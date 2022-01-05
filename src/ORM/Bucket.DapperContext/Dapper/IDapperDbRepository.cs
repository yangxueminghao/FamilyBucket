using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucket.DapperContext.Dapper
{
   public interface IDapperDbRepository<T> where T : class
    {
        long Insert(T entity);
        T Get(long id);
        bool Update(T entity);
        bool Delete(T entity);
        int Execute(string cmdStr, IDictionary<string, object> prams);
        TOut ExecuteScalar<TOut>(string cmdStr, IDictionary<string, object> prams);
        IEnumerable<T> Query(string cmdStr, IDictionary<string, object> prams);
    }
}
