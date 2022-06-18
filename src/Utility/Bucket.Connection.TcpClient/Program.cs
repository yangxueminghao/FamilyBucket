using System;
using RRQMCore.ByteManager;
using RRQMCore.Log;
using RRQMSocket;
using System.Threading;


namespace Bucket.Connection.TcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RRQMSocket.TcpClient m_tcpClient = new RRQMSocket.TcpClient();
            //声明配置
            RRQMConfig config = new RRQMConfig();
            config.SetRemoteIPHost(new IPHost("127.0.0.1:1706"))
                .UsePlugin()
                .SetBufferLength(1024 * 10)
                .SetSingletonLogger(new LoggerGroup(new EasyLogger(p=>{ }), new FileLogger()));

            //载入配置
            m_tcpClient.Setup(config);
            m_tcpClient.Connect();
            m_tcpClient.Logger.Message("成功连接");
            Console.WriteLine("Hello World!");
            while (true)
            {
                m_tcpClient.Send("asdjfksdajgk");
                Thread.Sleep(1000);



            }
            Console.Read();
        }
    }
}
