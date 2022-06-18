using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucket.Utility.Test
{
   public class P_CodeImage
    {
        /// <summary>
        /// 底图文件路径
        /// </summary>
        public string BaseImagePath { get; set; }

        /// <summary>
        /// Logo文件路径
        /// </summary>
        public string LogoImagePath { get; set; }
        /// <summary>
        /// WxCode文件路径
        /// </summary>
        public string WxCodeImagePath { get; set; }
        /// <summary>
        /// 主图文件路径
        /// </summary>
        public string MainImagePath { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 短内容
        /// </summary>
        public string ShortContent { get; set; }
        /// <summary>
        /// 原价
        /// </summary>
        public decimal OrginalPrice { get; set; }
        /// <summary>
        /// 活动价
        /// </summary>
        public decimal ActPrice { get; set; }
        /// <summary>
        /// 底部文本
        /// </summary>
        public string BottomContent { get; set; }
    }
}
