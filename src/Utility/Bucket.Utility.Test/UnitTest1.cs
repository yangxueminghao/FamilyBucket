using System;
using Xunit;
using System.IO;
using Spire.OCR;
using System.Drawing;
using Bucket.ImgVerifyCode;
using System.Drawing.Imaging;
using System.Text.Encodings;
using System.Text;
using System.Collections.Generic;

namespace Bucket.Utility.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestExcel()
        {
            var result = ExcelHelper.ReadFromExcelFile(@"C:\Users\EDZ\Desktop\【TOC】NFV三期（含地址迁移）Gn地址分省情况-20211221(1)(1)(1).xlsx");
            ExcelHelper.WriteToExcel(@"C:\Users\EDZ\Documents\WeChat Files\wxid_y65p5ljamjxh22\FileStorage\File\2021-12\【TOC】NFV三期（含地址迁移）Gn地址分省情况-20211221(16进制)(3).xlsx", result);
            Assert.Equal(1, 1);

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
            //var isSuc=scanner.Scan(@"D:\临时文件\微信图片_20220331173157.jpg"); 
            var isSuc = scanner.Scan(@"D:\临时文件\1648721535(1).png");
            var result = scanner.Text.ToString().Replace("Evaluation Warning : The version can be used only for evaluation purpose...", "");
            Assert.NotNull(result);
        }
        [Fact]
        public void TestImageHelper()
        {
            var path = @"C:\Users\EDZ\Desktop\images";
            Image imagebase = Image.FromFile(@$"{path}\base.png");

            Image imagemed = Image.FromFile(@$"{path}\1.png");
            Image imageorg = Image.FromFile(@$"{path}\1.png");
            Image imagesmp = Image.FromFile(@$"{path}\1.png");
            var bitmapRet1 = imagebase.UniteImage(30, 27, imageorg.CutEllipse(new Rectangle(0, 0, imageorg.Width, imageorg.Height), new Size(48, 48)));
            bitmapRet1.Save(@$"{path}\bitmapRet01.png", ImageFormat.Png);
            bitmapRet1 = bitmapRet1.DrawText(86, 37, "标哥健康大药房", "苹方-简", 20, Color.White);
            bitmapRet1.Save(@$"{path}\bitmapRet02.png", ImageFormat.Png);
            var bitmapRet2 = bitmapRet1.UniteImage(45, 123, imagemed.Resize(285, 285)); //0XFF0000
            bitmapRet2 = bitmapRet2.DrawText(99, 408, "活动价 ￥", "苹方-简", 20, Color.FromArgb(255, 0, 0));
            bitmapRet2 = bitmapRet2.DrawText(192, 400, "489.00", "苹方-简", 30, Color.FromArgb(255, 0, 0));
            bitmapRet2.Save(@$"{path}\bitmapRet21.png", ImageFormat.Png);
            bitmapRet2 = bitmapRet2.DrawText(171, 452, "￥689.00", "苹方-简", 20, Color.FromArgb(102, 102, 102));
            bitmapRet2 = bitmapRet2.DrawLine(new Point(171, 463), new Point(240 + 20, 463), Color.FromArgb(102, 102, 102));
            bitmapRet2.Save(@$"{path}\bitmapRet22.png", ImageFormat.Png);
            bitmapRet2 = bitmapRet2.DrawRectangleText(new RectangleF(44, 491, 196, 44), "贝儿(Bubs)婴幼儿有机草饲牛奶粉3段", "苹方-简", 16, Color.FromArgb(51, 51, 51), FontStyle.Bold);
            bitmapRet2.Save(@$"{path}\bitmapRet23.png", ImageFormat.Png);
            bitmapRet2 = bitmapRet2.DrawText(44, 543, "立即扫码参与吧", "苹方-简", 16, Color.FromArgb(51, 51, 51));
            bitmapRet2.Save(@$"{path}\bitmapRet2.png", ImageFormat.Png);
            var bitmapRet3 = bitmapRet2.UniteImage(261, 491, imagesmp.Resize(71, 69));
            bitmapRet3.Save(@$"{path}\bitmapRet3.png", ImageFormat.Png);
            Assert.True(1 == 1);

        }
        [Fact]
        public void TestImageHelper2()
        {
            var path = @"C:\Users\EDZ\Desktop\images";
            //Image imagebase = Image.FromFile(@$"{path}\base2x.png");
            Image imagebase = Image.FromFile(@$"{path}\base2x.png");

            Image imagemed = Image.FromFile(@$"{path}\1.png");
            Image imageorg = Image.FromFile(@$"{path}\1.png");
            Image imagesmp = Image.FromFile(@$"{path}\o=19537&a=20&m=38.jpg");
            Image imageyh = Image.FromFile(@$"{path}\icon_youhui@2x.png");
            Image imagemb = Image.FromFile(@$"{path}\icon_manbingguanli@2x.png");
            Image imagejk = Image.FromFile(@$"{path}\icon_jiankangzice@2x.png");
            var bitmapRet1 = imagebase.UniteImage(30 * 2, 27 * 2, imageorg.CutEllipse(new Rectangle(0, 0, imageorg.Width, imageorg.Height), new Size(48 * 2, 48 * 2)));
            bitmapRet1.Save(@$"{path}\bitmapRet01.png", ImageFormat.Png);
            bitmapRet1 = bitmapRet1.DrawText(86 * 2, 37 * 2, "标哥健康大药房", "苹方-简", 20 * 2, Color.White);

            bitmapRet1 = bitmapRet1.UniteImage(86 * 2, 60 * 2, imageyh.Resize(16 * 2, 16 * 2));
            bitmapRet1 = bitmapRet1.DrawText(104 * 2, 60 * 2, "特价优惠", "苹方-简", 14 * 2, Color.White);
            bitmapRet1 = bitmapRet1.UniteImage(175 * 2, 60 * 2, imagemb.Resize(16 * 2, 16 * 2));
            bitmapRet1 = bitmapRet1.DrawText(193 * 2, 60 * 2, "慢病管理", "苹方-简", 14 * 2, Color.White);
            bitmapRet1 = bitmapRet1.UniteImage(264 * 2, 60 * 2, imagejk.Resize(16 * 2, 16 * 2));
            bitmapRet1 = bitmapRet1.DrawText(282 * 2, 60 * 2, "健康自测", "苹方-简", 14 * 2, Color.White);

            bitmapRet1.Save(@$"{path}\bitmapRet02.png", ImageFormat.Png);
            var bitmapRet2 = bitmapRet1.UniteImage(45 * 2, 123 * 2, imagemed.Resize(285 * 2, 285 * 2)); //0XFF0000
            //bitmapRet2 = bitmapRet2.DrawText(99 * 2, 408 * 2, "活动价 ￥", "苹方-简", 20 * 2, Color.FromArgb(255, 0, 0));
            //bitmapRet2 = bitmapRet2.DrawText(192 * 2, 400 * 2, "489.00", "苹方-简", 30 * 2, Color.FromArgb(255, 0, 0));

            bitmapRet2 = bitmapRet2.DrawRectangleText(new RectangleF(45 * 2, 418 * 2, 285 * 2, 28 * 2), "贝儿(Bubs)婴幼儿有机草饲牛奶粉3段", "苹方-简", 16 * 2, Color.FromArgb(51, 51, 51), FontStyle.Bold);

            bitmapRet2.Save(@$"{path}\bitmapRet21.png", ImageFormat.Png);
            //bitmapRet2 = bitmapRet2.DrawText(171 * 2, 452 * 2, "￥689.00", "苹方-简", 20 * 2, Color.FromArgb(102, 102, 102));
            //bitmapRet2 = bitmapRet2.DrawLine(new Point(171 * 2, 463 * 2), new Point((240 + 20) * 2, 463 * 2), Color.FromArgb(102, 102, 102));
            bitmapRet2.Save(@$"{path}\bitmapRet22.png", ImageFormat.Png);

            //bitmapRet2 = bitmapRet2.DrawRectangleText(new RectangleF(44 * 2, 491 * 2, 196 * 2, 44 * 2), "贝儿(Bubs)婴幼儿有机草饲牛奶粉3段", "苹方-简", 16 * 2, Color.FromArgb(51, 51, 51), FontStyle.Bold);
            bitmapRet2.Save(@$"{path}\bitmapRet23.png", ImageFormat.Png);
            bitmapRet2 = bitmapRet2.DrawText(44 * 2, 543 * 2, "立即扫码参与吧", "苹方-简", 16 * 2, Color.FromArgb(51, 51, 51));
            bitmapRet2.Save(@$"{path}\bitmapRet2.png", ImageFormat.Png);
            //var bitmapRet3 = bitmapRet2.UniteImage((261 - 30) * 2, (491 - 15) * 2, imagesmp.Resize2((71 + 40) * 2, (71 + 40) * 2));
            var bitmapRet3 = bitmapRet2.UniteImage((261) * 2, (491) * 2, imagesmp.Resize2((71) * 2, (71) * 2));
            bitmapRet3.Save(@$"{path}\bitmapRet3.png", ImageFormat.Png);
            Assert.True(1 == 1);

        }

        [Fact]
        public void TestImageHelper4()
        {
            var path = @"C:\Users\EDZ\Desktop\images";
            //Image imagebase = Image.FromFile(@$"{path}\base2x.png");
            Image imagebase = Image.FromFile(@$"{path}\base2@2x.png");

            Image imagemed = Image.FromFile(@$"{path}\1.png");
            Image imageorg = Image.FromFile(@$"{path}\1.png");
            Image imagesmp = Image.FromFile(@$"{path}\o=19537&a=20&m=38.jpg");

            var bitmapRet1 = imagebase.UniteImage(30 * 2, 27 * 2, imageorg.CutEllipse(new Rectangle(0, 0, imageorg.Width, imageorg.Height), new Size(48 * 2, 48 * 2)));
            bitmapRet1.Save(@$"{path}\bitmapRet01.png", ImageFormat.Png);
            bitmapRet1 = bitmapRet1.DrawText(86 * 2, 37 * 2, "标哥健康\n大金色/白色/粉色药房", "苹方-简", 20 * 2, Color.White);

            bitmapRet1.Save(@$"{path}\bitmapRet02.png", ImageFormat.Png);
            var bitmapRet2 = bitmapRet1.UniteImage(45 * 2, 123 * 2, imagemed.Resize(285 * 2, 285 * 2)); //0XFF0000
            //bitmapRet2 = bitmapRet2.DrawText(99 * 2, 408 * 2, "活动价 ￥", "苹方-简", 20 * 2, Color.FromArgb(255, 0, 0));
            //bitmapRet2 = bitmapRet2.DrawText(192 * 2, 400 * 2, "489.00", "苹方-简", 30 * 2, Color.FromArgb(255, 0, 0));

            bitmapRet2 = bitmapRet2.DrawRectangleText(new RectangleF(45 * 2, 418 * 2, 285 * 2, (28 * 2) * 2), "贝儿(Bubs)婴幼儿有机草饲牛奶粉3段", "苹方-简", 20 * 2, Color.FromArgb(51, 51, 51), FontStyle.Bold);

            bitmapRet2.Save(@$"{path}\bitmapRet21.png", ImageFormat.Png);



            bitmapRet2 = bitmapRet2.DrawText(103 * 2, (471 + 5) * 2, "¥ 489.00", "苹方-简", 20 * 2, Color.FromArgb(255, 0, 0));

            bitmapRet2 = bitmapRet2.DrawText(197 * 2, (int)((478.5 + 5) * 2), "¥ 689.00", "苹方-简", 12 * 2, Color.FromArgb(153, 153, 153), FontStyle.Strikeout);
            //bitmapRet2 = bitmapRet2.DrawLine(new Point(171 * 2, 463 * 2), new Point((240 + 20) * 2, 463 * 2), Color.FromArgb(102, 102, 102));


            bitmapRet2.Save(@$"{path}\bitmapRet22.png", ImageFormat.Png);

            //bitmapRet2 = bitmapRet2.DrawRectangleText(new RectangleF(44 * 2, 491 * 2, 196 * 2, 44 * 2), "贝儿(Bubs)婴幼儿有机草饲牛奶粉3段", "苹方-简", 16 * 2, Color.FromArgb(51, 51, 51), FontStyle.Bold);
            bitmapRet2.Save(@$"{path}\bitmapRet23.png", ImageFormat.Png);
            //bitmapRet2 = bitmapRet2.DrawText(44 * 2, 543 * 2, "立即扫码参与吧", "苹方-简", 16 * 2, Color.FromArgb(51, 51, 51));
            bitmapRet2.Save(@$"{path}\bitmapRet2.png", ImageFormat.Png);
            //var bitmapRet3 = bitmapRet2.UniteImage((261 - 30) * 2, (491 - 15) * 2, imagesmp.Resize2((71 + 40) * 2, (71 + 40) * 2));
            var bitmapRet3 = bitmapRet2.UniteImage((261) * 2, (491) * 2, imagesmp.Resize2((71) * 2, (71) * 2));
            bitmapRet3.Save(@$"{path}\bitmapRet3.png", ImageFormat.Png);
            Assert.True(1 == 1);

        }
        [Fact]
        public void TestImageHelper3()
        {
            var path = @"C:\Users\EDZ\Desktop\images";
            Image imagebase = Image.FromFile(@$"{path}\base2x.png");


            Image imagesmp = Image.FromFile(@$"{path}\o=19537&a=20&m=38.jpg");
            var bitmap = imagesmp.Resize2(71 * 2, 71 * 2);
            bitmap.Save(@$"{path}\bitmapRet31.png", ImageFormat.Png);

            Assert.True(1 == 1);

        }
        [Fact]
        public void TestBit()
        {
            var str = "AAAAAAAAAABCC";
            var bytes = Encoding.ASCII.GetBytes(str);
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            foreach (var byt in bytes)
            {
                var bin = Convert.ToString(byt, 2).PadLeft(8, '0').Trim();
                sb.Append(bin);
            }
            var result = sb.ToString();
            List<bool> isSign = new List<bool>();
            for (int i = 0; i < bytes.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    bool isTrue = bytes[i] / (Convert.ToInt16(Math.Pow(2, 7))) == 1;
                    bytes[i] = (byte)(bytes[i] << (byte)1);

                    isSign.Add(isTrue);
                    sb2.Append(isTrue ? 1 : 0);
                }


            }
            var ret2 = sb2.ToString();
            Assert.True(ret2 == result);

        }
        [Fact]
        public void TestImage()
        {
            //var orginalPicturePath = "Common/202204/2204111227407955457.jpg";
            //var PicturePath = "";
            //if (!string.IsNullOrWhiteSpace(orginalPicturePath))
            //{
            //    var index = orginalPicturePath.LastIndexOf('/');
            //    PicturePath = orginalPicturePath.Substring(0, index) + "/Thumbnail" + orginalPicturePath.Substring(index);
            //    Assert.True(1 == 1);
            //}

            var path = @"C:\Users\EDZ\Desktop\images";
            Image imagebase = Image.FromFile(@$"{path}\base2x.png");
            var str = ("\n &c=3&d=4&f/空气\n氧吧-南山奖产品(桌面机) 金色/白色/粉色（请在订单页备注颜色）dhsg-kjhfd.png").Replace(@"/", "").Replace(@"\", "").Replace('\n', 'a');
            var title = (@$"{path}\{str}");


            imagebase.Save(title, ImageFormat.Png);


        }
        [Fact]
        public void TestCopy()
        {
            var students = new List<Student>();
            var stu1 = new Student { Id = 3, Name = "fdskjfjas;j" };
            students.Add(stu1);
            students.Add(new Student { Id = 5, Name = "weryhbdh" });
            //Student stud2 = stu1.Clone() as Student;
            //stud2.Name = "dsfgjdflkjgsd";
            var stus = students.Copy() as List<Student>;
            var stus2 = students;
            //foreach (var stu in stus)
            //{
            //    stu.Name = "bnzcxm,va";
            //}

            var isTrue=ReferenceEquals(stus, students);
            isTrue = Equals(stus, students);
            isTrue = stus == students;
            isTrue = stus.Equals(students);

            isTrue = ReferenceEquals(stus2, students);
            isTrue = Equals(stus2, students);
            isTrue = stus2 == students;
            isTrue = stus2.Equals(students);

            //Assert.True(ReferenceEquals(stus, students));
            //Assert.True(Equals(stus, students));
            //Assert.True(stus == students);
            //Assert.True(stus.Equals(students));


        }

        [Fact]
        public void TestImaf()
        {

            var str = "{\"baseImagePath\":\"hfgd\",\"logoImagePath\":\"\\\\10.12.110.24\\Resource\\Common / 202205 / 2205301750382601812.jpg\",\"wxCodeImagePath\":\"\\\\10.12.110.24\\Resource\\AppletQRCode / 5 / OrgCode / o = 19845 & a = 1384 & m = 3056 & c = 888692 & d = 13.jpg\",\"mainImagePath\":\"\\\\10.12.110.24\\Resource\\Common / 202206 / 2206061145106474648.jpg\",\"title\":\"新起点健康旗舰店\",\"content\":\"空气氧吧 - 南\n山奖产品(桌\n面机) 金色 / 白色 / 粉色（请在订单页备注颜色）\",\"shortContent\":\"森态空气系列分销 & c = 888692 & d = 13_空气氧吧 - 南\n山奖产品(桌\n面机)_1384\",\"orginalPrice\":5999.00,\"actPrice\":5999.00,\"bottomContent\":null}";
            bool istrue;
            GenerateCodeImageV2(Newtonsoft.Json.JsonConvert.DeserializeObject<P_CodeImage>(str),out istrue);
        }

        /// <summary>
        /// 生成活动商品推广码图片V2
        /// </summary>
        /// <param name="CodeImage"></param>
        /// <returns></returns>
        public string GenerateCodeImageV2(P_CodeImage CodeImage, out bool isStoreToDb, bool isCompres = false)
        {
            isStoreToDb = true;
            Image bitmapRet;
            var fileName = $"{ CodeImage.Title?.Replace(@"/", "").Replace(@"\", "")}_{ CodeImage.ShortContent?.Replace(@"/", "").Replace(@"\", "")}.png";
            try
            {
                var path = @"C:\Users\EDZ\Desktop\images";
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                Image imagebase = Image.FromFile(CodeImage.BaseImagePath);

                bitmapRet = imagebase.DrawText(86 * 2, 37 * 2, CodeImage.Title, "苹方-简", 20 * 2, Color.White)
                                           .DrawText(103 * 2, (471 + 5) * 2, $"¥ {CodeImage.ActPrice.ToString("0.00")}", "苹方-简", 20 * 2, Color.FromArgb(255, 0, 0))
                                           .DrawText(197 * 2, (int)((478.5 + 5) * 2), $"¥ {CodeImage.OrginalPrice.ToString("0.00")}", "苹方-简", 12 * 2, Color.FromArgb(153, 153, 153), FontStyle.Strikeout)
                                           .DrawRectangleText(new RectangleF(45 * 2, 418 * 2, 285 * 2, (28 * 2) * 2), CodeImage.Content, "苹方-简", 16 * 2, Color.FromArgb(51, 51, 51), FontStyle.Bold);

                if (File.Exists(CodeImage.LogoImagePath))
                {
                    Image imageorg = Image.FromFile(CodeImage.LogoImagePath);
                    bitmapRet = bitmapRet.UniteImage(30 * 2, 27 * 2, imageorg.CutEllipse(new Rectangle(0, 0, imageorg.Width, imageorg.Height), new Size(48 * 2, 48 * 2)));
                    imageorg.Dispose();
                }
                else
                {
                    isStoreToDb = false;
                }
                if (File.Exists(CodeImage.WxCodeImagePath))
                {
                    Image imagesmp = Image.FromFile(CodeImage.WxCodeImagePath);
                    bitmapRet = bitmapRet.UniteImage(261 * 2, 491 * 2, imagesmp.Resize(71 * 2, 71 * 2));
                    imagesmp.Dispose();
                }
                else
                {
                    isStoreToDb = false;
                }
                if (File.Exists(CodeImage.MainImagePath))
                {
                    Image imagemed = Image.FromFile(CodeImage.MainImagePath);
                    bitmapRet = bitmapRet.UniteImage(45 * 2, 123 * 2, imagemed.Resize(285 * 2, 285 * 2));
                    imagemed.Dispose();
                }
                else
                {
                    isStoreToDb = false;
                }


                if (isCompres)
                {
                    bitmapRet.Save(Path.Combine(path, fileName), ImageFormat.Jpeg);
                    //ThumbnailHandler.GetPicThumbnail(Path.Combine(path, fileName), Path.Combine(path, ThumbnailHandler.ThumbnailName, fileName), 50);
                }
                else
                {
                    bitmapRet.Save(Path.Combine(path, fileName), ImageFormat.Png);
                }
                bitmapRet.Dispose();
                
            }
            catch (Exception e)
            {
               
                throw;
            }
            
            return "";

        }

    }

    public class Student//:ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public object Clone()
        //{
        //    return this.MemberwiseClone();
        //}
    }
}
