﻿using Bucket.DapperContext.Dapper;
using Castle.DynamicProxy;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Reflection;
using System.Threading.Tasks;

namespace FamilyBucket.Aop
{
    public class ConnectionAvaliableInterceptor : BaseInterceptor
    {
        private readonly DapperOption _dapperOption;
        public ConnectionAvaliableInterceptor(IOptionsMonitor<DapperOption> optionsMonitor)
        {
            _dapperOption = optionsMonitor.CurrentValue;
        }
        public override void Intercept(IInvocation invocation)
        {
            int count = 0;
            try
            {
                //在被拦截的方法执行完毕后 继续执行当前方法，注意是被拦截的是异步的
                invocation.Proceed();


                // 异步获取异常，先执行
                if (IsAsyncMethod(invocation.Method))
                {
                    var result = invocation.ReturnValue;
                    if (result is Task)
                    {
                        Task.WaitAll(result as Task);
                    }
                }

            }
            catch (MySqlException e)
            {
                if (invocation.TargetType.IsAssignableTo(typeof(IDbConnection)))
                {
                    var target = invocation.InvocationTarget as IDbConnection;
                    count++;
                    target.ConnectionString = _dapperOption.ConStrs[new Random().Next(count, _dapperOption.ConStrs.Length)];
                    if (count< _dapperOption.ConStrs.Length)
                    {
                        invocation.Proceed();
                    }
                    
                }

            }
        }

    }
}
