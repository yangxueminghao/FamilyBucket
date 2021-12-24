using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket.MongoDbContext.Mongo
{
   public class MongoDbConnectOption: MongoClientSettings
    {
        /// <summary>
        /// 数据库名称
        /// </summary>
        public string DbName { set; get; }

        /// <summary>
        /// 主机名
        /// </summary>
        public string Host { set; get; }

        /// <summary>
        /// 端口
        /// </summary>
        public int Port { set; get; }

    }
}
