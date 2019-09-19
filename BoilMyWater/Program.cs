using System;
using System.IO;
using log4net;
using log4net.Config;
using log4net.Repository;

namespace BoilMyWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            Nullable<int> a1 = null;
            Console.WriteLine("Hello World!");
            Console.WriteLine(a.GetValueOrDefault());

            InitLog4Net();
            var logger = LogManager.GetLogger(typeof(Program));

            logger.Info("消息");
            logger.Warn("警告");
            logger.Error("异常");
            logger.Fatal("错误");

            Console.ReadLine();

        }

        private static void InitLog4Net()
        {
            ILoggerRepository repository = LogManager.CreateRepository("NETCoreRepository");
            var logCfg = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config");
            XmlConfigurator.ConfigureAndWatch(repository,logCfg);
        }
    }
}
