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
            var result=ExcelHelper.ReadFromExcelFile(@"C:\Users\EDZ\Desktop\【TOC】NFV三期（含地址迁移）Gn地址分省情况-20211221(1)(1)(1).xlsx");
            ExcelHelper.WriteToExcel(@"C:\Users\EDZ\Documents\WeChat Files\wxid_y65p5ljamjxh22\FileStorage\File\2021-12\【TOC】NFV三期（含地址迁移）Gn地址分省情况-20211221(16进制)(3).xlsx", result);
            Assert.Equal(1,1);

        }
        [Fact]
        public void TestRegex()
        {
            //ReadFromExcelFile(@"H:\班级文件（15软件）\15级软件工程班名单.xls");
            var result = RegexHelper.ReplaceChinese("hsadjfhh软件工,weqrweqwer班级文件teryrteyrt");
            Assert.NotNull(result);
        }
        [Fact]
        public void TestOcr()
        {
            //ReadFromExcelFile(@"H:\班级文件（15软件）\15级软件工程班名单.xls");
            OcrScanner scanner = new OcrScanner();
            var isSuc=scanner.Scan(@"D:\临时文件\微信图片_20220331173157.jpg");
            var result=scanner.Text.ToString();
            Assert.NotNull(result);
        }

    }
}
