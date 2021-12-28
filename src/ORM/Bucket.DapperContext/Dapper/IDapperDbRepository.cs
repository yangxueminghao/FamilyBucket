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
    }
}
