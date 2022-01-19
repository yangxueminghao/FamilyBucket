// ***********************************************************************
// Assembly         : OpenAuth.Mvc
// Author           : yubaolee
// Created          : 10-26-2015
//
// Last Modified By : yubaolee
// Last Modified On : 10-26-2015
// ***********************************************************************
// <copyright file="AutofacExt.cs" company="www.cnblogs.com/yubaolee">
//     Copyright (c) www.cnblogs.com/yubaolee. All rights reserved.
// </copyright>
// <summary>IOC扩展</summary>
// ***********************************************************************

using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using Bucket.DapperContext.Dapper;
using FamilyBucket.Aop.Client.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using IContainer = Autofac.IContainer;

namespace FamilyBucket.Aop.Client.Util
{
    public static class AutofacExt
    {
        private static IContainer _container;

        public static void InitAutofac(ContainerBuilder builder, IConfiguration configuration)
        {

            builder.RegisterType<ConnectionAvaliableInterceptor>();
            //注入授权
            builder.RegisterType<StudentService>().As<IStudentService>();
            
            builder.RegisterType<MySqlConnection>().As<IDbConnection>().WithParameter("connectionString", configuration.GetSection("DapperDbConfig").Get<DapperOption>().ConStrs[0])
                .InterceptedBy(typeof(ConnectionAvaliableInterceptor))
                .EnableInterfaceInterceptors();

        }



    }
}