using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Bucket.DapperContext.Dapper
{
    public class DapperDbRepository<T> : IDapperDbRepository<T> where T:class
    {
        private readonly IDbConnection _dbConnection;
        public DapperDbRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public long Insert(T entity)
        {
            return _dbConnection.Insert(entity);
        }
        public T Get(long id)
        {
            return _dbConnection.Get<T>(id);
        }

    }
}
