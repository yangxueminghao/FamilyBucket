using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Bucket.ImgVerifyCode
{
    public static class ImageExtension
    {
        public static Image UniteImage(this Image img1, int x, int y, Image img2)
        {
            Image img = new Bitmap(img1);
            using (Graphics g = Graphics.FromImage(img))
            {
                g.DrawImage(img2, x, y, img2.Width, img2.Height);
            }
            img1.Dispose();
            img2.Dispose();
            return img;
        }
        public static Image DrawText(this Image imgSrc, int x, int y, string text, string fontfamily, int fontSize, Color color, FontStyle fontStyle = FontStyle.Regular)
        {
            using (Graphics g = Graphics.FromImage(imgSrc))
            {
                g.DrawImage(imgSrc, 0, 0, imgSrc.Width, imgSrc.Height);
                using (Font f = new Font(fontfamily, fontSize, fontStyle, GraphicsUnit.Pixel))
                {
                    using (Brush b = new SolidBrush(color))
                    {
                        g.DrawString(text, f, b, x, y);
                    }
                }
            }
            return imgSrc;
        }
        public static Image DrawRectangleText(this Image imgSrc, RectangleF layoutRectangle, string text, string fontfamily, int fontSize, Color color, FontStyle fontStyle = FontStyle.Regular)
        {
            using (Graphics g = Graphics.FromImage(imgSrc))
            {
                g.DrawImage(imgSrc, 0, 0, imgSrc.Width, imgSrc.Height);
                using (Font f = new Font(fontfamily, fontSize, fontStyle, GraphicsUnit.Pixel))
                {
                    using (Brush b = new SolidBrush(color))
                    {
                        g.DrawString(text, f, b, layoutRectangle);
                    }
                }
            }
            return imgSrc;
        }
        /// <summary>
        /// 按比例缩小图片，自动计算宽度
        /// </summary>
        /// <param name="imgSrc">源图</param>        
        /// <param name="width">缩小至宽度</param>
        /// <param name="height">缩小至高度</param>
        public static Image DrawLine(this Image imgSrc, Point x, Point y, Color color)
        {
            using (Graphics g = Graphics.FromImage(imgSrc))
            {
                g.DrawImage(imgSrc, 0, 0, imgSrc.Width, imgSrc.Height);
                using (Pen pen = new Pen(color))
                {
                    g.DrawLine(pen, x, y);
                }
            }
            return imgSrc;
        }
        public static Image Resize(this Image imgSrc, int width, int height)
        {
            var objpic = new Bitmap(imgSrc);
            Bitmap imgDest = new Bitmap(objpic, width, height);
            imgSrc.Dispose();
            objpic.Dispose();
            return imgDest;
        }
        public static Image CutEllipse(this Image img, Rectangle rec, Size size)
        {
            Bitmap bitmap = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                using (TextureBrush br = new TextureBrush(img, System.Drawing.Drawing2D.WrapMode.Clamp, rec))
                {
                    br.ScaleTransform(bitmap.Width / (float)rec.Width, bitmap.Height / (float)rec.Height);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.FillEllipse(br, new Rectangle(Point.Empty, size));
                }
            }
            img.Dispose();
            return bitmap;
        }
        public static Image Resize2(this Image imgSrc, int width, int height)
        {
            Bitmap dest = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(dest))
            {
                g.DrawImage(imgSrc, 0, 0, width, height);

            }
            imgSrc.Dispose();
            return dest;
        }
    }
}
