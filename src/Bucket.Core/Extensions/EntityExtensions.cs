using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Bucket.Extensions
{
    public static class EntityExtensions
    {
        /// <summary>
        /// 将字典数据转化为指定类型对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dic"></param>
        /// <returns></returns>
        public static T ToEntity<T>(this IDictionary<string,object> dic)
        {
            T entity = Activator.CreateInstance<T>();
            var prps = typeof(T).GetProperties().ToList();
            prps.ForEach(p=> {
                if (dic.ContainsKey(p.Name))
                {
                    p.SetValue(entity,Convert.ChangeType(dic[p.Name],p.PropertyType));
                }
            });
            return entity;
        }
        /// <summary>
        /// 将指定类型对象转化为字典数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static IDictionary<string, object> ToDic<T>(this T entity)
        {
            IDictionary<string, object> dic = new Dictionary<string, object>();
            var prps = typeof(T).GetProperties().ToList();
            prps.ForEach(a => dic.Add(a.Name, a.GetValue(entity, null)));
            return dic;
        }
    }
}
