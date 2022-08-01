using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Bucket.Utility.Test.Model
{
    public class SqlServerDataTool : BaseDataTool
    {
        public override string Process()
        {
            Random random = new Random();
            string text = $"sghfsdjkgh_{random.Next(1,100)}";
            JsonConvert.SerializeObject(text);
            return text;
        }
    }
}
