using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bucket.Event.KafkaClient.Models
{
    public class MessageBase
    {
        public MessageBase()
        {
            CreateTime = DateTimeOffset.Now;
            MsgNo = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// 业务类型
        /// </summary>
        public int BusType { get; set; }
        /// <summary>
        /// 生成时间
        /// </summary>
        public DateTimeOffset CreateTime { get; set; }
        /// <summary>
        /// 消息编号
        /// </summary>
        public string MsgNo { get; set; }
        /// <summary>
        /// 客户端名称
        /// </summary>
        public string ClientName { get; set; }

    }
}
