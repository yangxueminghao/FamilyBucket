using System;
using Xunit;
using System.IO;
using Spire.OCR;

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
        [Fact]
        public void TestOcr()
        {
            //ReadFromExcelFile(@"H:\�༶�ļ���15�����\15��������̰�����.xls");
            OcrScanner scanner = new OcrScanner();
            //var isSuc=scanner.Scan(@"D:\��ʱ�ļ�\΢��ͼƬ_20220331173157.jpg"); 
            var isSuc = scanner.Scan(@"D:\��ʱ�ļ�\1648721535(1).png");
            var result=scanner.Text.ToString().Replace("Evaluation Warning : The version can be used only for evaluation purpose...","");
            Assert.NotNull(result);
        }

    }
}
