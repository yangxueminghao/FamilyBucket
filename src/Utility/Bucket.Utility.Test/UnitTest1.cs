using System;
using Xunit;
using System.IO;

namespace Bucket.Utility.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestExcel()
        {
            var result=ExcelHelper.ReadFromExcelFile(@"C:\Users\EDZ\Desktop\��TOC��NFV���ڣ�����ַǨ�ƣ�Gn��ַ��ʡ���-20211221(1)(1)(1).xlsx");
            ExcelHelper.WriteToExcel(@"C:\Users\EDZ\Documents\WeChat Files\wxid_y65p5ljamjxh22\FileStorage\File\2021-12\��TOC��NFV���ڣ�����ַǨ�ƣ�Gn��ַ��ʡ���-20211221(16����)(3).xlsx", result);
            Assert.Equal(1,1);

        }
        [Fact]
        public void TestRegex()
        {
            //ReadFromExcelFile(@"H:\�༶�ļ���15�����\15��������̰�����.xls");
            var result = RegexHelper.ReplaceChinese("hsadjfhh�����,weqrweqwer�༶�ļ�teryrteyrt");
            Assert.NotNull(result);
        }
        
    }
}
