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
    public class DapperDbRepository<T> : IDapperDbRepository<T> where T : class
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
        public bool Update(T entity)
        {
            return _dbConnection.Update(entity);
        }
        public T Get(long id)
        {
            return _dbConnection.Get<T>(id);
        }
        public bool Delete(T entity)
        {
            return _dbConnection.Delete(entity);
        }
        public int Execute(string cmdStr, IDictionary<string, object> prams)
        {
            return _dbConnection.Execute(cmdStr, prams);
        }
        public TOut ExecuteScalar<TOut>(string cmdStr, IDictionary<string, object> prams)
        {
            return _dbConnection.ExecuteScalar<TOut>(cmdStr, prams);
        }
        public IEnumerable<T> Query(string cmdStr, IDictionary<string, object> prams)
        {
            //if (_dbConnection.State == ConnectionState.Closed)
            //{
            //    _dbConnection.Open();
            //}
            using (_dbConnection)
            {
               
                return _dbConnection.Query<T>(cmdStr, prams);
            }
            
        }

    }
}
