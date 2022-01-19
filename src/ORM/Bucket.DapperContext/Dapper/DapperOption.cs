using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucket.DapperContext.Dapper
{
   public class DapperOption
    {
        public DbTypeEnum DbType { get; set; }
        public string[] ConStrs { get; set; }
    }
    public enum DbTypeEnum
    {
        MsSql,
        Mysql,
        Sqlite
    }
}
