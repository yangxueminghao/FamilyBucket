using Bucket.DapperContext.Dapper;
using FamilyBucket.Aop.Client.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace FamilyBucket.Aop.Client.Service
{
    public class StudentService : IStudentService
    {
        //private readonly IDapperDbRepository<Student> _dapperDbRepository;
        private readonly IDbConnection _DbConnection;

        public StudentService(IDbConnection DbConnection)//IDapperDbRepository<Student> dapperDbRepository,
        {
            //_dapperDbRepository = dapperDbRepository;
            _DbConnection = DbConnection;
        }
        public Student Get(long id)
        {
            return _DbConnection.Get<Student>(id);
        }
    }
}
