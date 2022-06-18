using System;
using System.IO;
using System.Drawing;
using Bucket.ImgVerifyCode;
using System.Drawing.Imaging;
using RRQMSocket;

namespace FamilyBucket.Images.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var path = @"C:\Users\EDZ\Desktop\images";
            //Image imagebase = Image.FromFile(@$"{path}\base.png");
            //Image imagemed = Image.FromFile(@$"{path}\med.png");
            //Image imageorg = Image.FromFile(@$"{path}\org.png");
            //Image imagesmp = Image.FromFile(@$"{path}\smp.png");
            //var bitmapRet1 = ImageHelper.UniteImage(imagebase, 10, 20, ImageHelper.CutEllipse(imageorg, new Rectangle(0, 0, imageorg.Width, imageorg.Height), new Size(50, 50)));
            //bitmapRet1.Save(@$"{path}\bitmapRet01.png", ImageFormat.Jpeg);
            //bitmapRet1 = ImageHelper.DrawText(bitmapRet1, 50, 60, "中国人", "宋体", 20, Color.Red);
            //bitmapRet1.Save(@$"{path}\bitmapRet02.png", ImageFormat.Jpeg);
            //var bitmapRet2 = ImageHelper.UniteImage(bitmapRet1, 80, 100, imagemed);
            //bitmapRet2.Save(@$"{path}\bitmapRet2.png", ImageFormat.Jpeg);
            //var bitmapRet3 = ImageHelper.UniteImage(bitmapRet2, 80, 200, imagesmp);
            //bitmapRet3.Save(@$"{path}\bitmapRet3.png", ImageFormat.Jpeg);
            //var a = 1;

            TcpService service = new TcpService();
            service.Connecting += (client, e) => { };//有客户端正在连接
            service.Connected += (client, e) => { };//有客户端连接
            service.Disconnected += (client, e) => { };//有客户端断开连接
            service.Received += (client, byteBlock, requestInfo) =>
            {
                //从客户端收到信息
                string mes = byteBlock.ToString();
                System.Console.WriteLine($"已从{client.ID}接收到信息：{mes}");

                client.Send(mes);//将收到的信息直接返回给发送方

                //client.Send("id",mes);//将收到的信息返回给特定ID的客户端

                var clients = service.GetClients();
                foreach (var targetClient in clients)//将收到的信息返回给在线的所有客户端。
                {
                    if (targetClient.ID != client.ID)
                    {
                        targetClient.Send(mes);
                    }
                }
            };

            service.Setup(new RRQMConfig()//载入配置     
                .SetListenIPHosts(new IPHost[] { new IPHost("127.0.0.1:7789"), new IPHost(7790) })//同时监听两个地址
                .SetMaxCount(10000)
                .SetThreadCount(100))
                .Setup(1706)
                .Start();//启动
            System.Console.Read();
        }
    }
}
