using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Bucket.Utility.Test
{
    class RegexHelper
    {
        public static string ReplaceChinese(string text, string patten= @"[\u4e00-\u9fa5]+",char ch=',') 
        {
            List<string> list = new List<string>();
            foreach (Match machetext in Regex.Matches(text, patten))
            {
                list.Add(machetext.Value);
            }
            return string.Join(ch, list);
        }

    }
}