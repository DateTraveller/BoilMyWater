using log4net;
using log4net.Config;
using log4net.Repository;
using System;
using System.IO;

namespace BoilMyWater
{
    public class Program
    {
        static void Main(string[] args)
        {
            //InitLog4Net();
            //MethodFortheFirst();

        }

        private static void InitLog4Net()
        {
            ILoggerRepository repository = LogManager.CreateRepository("NETCoreRepository");
            var logCfg = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config");
            XmlConfigurator.ConfigureAndWatch(repository, logCfg);
            var logger = LogManager.GetLogger(typeof(Program));

            logger.Info("消息");
            logger.Warn("警告");
            logger.Error("异常");
            logger.Fatal("错误");

            Console.ReadLine();
        }

        private static void MethodFortheFirst()
        {
            UnitConverter uc = new UnitConverter(10);
            Console.WriteLine(uc.Convert(2));
        }

    }
    public class UnitConverter
    {
        int ratio;// Field 字段
        public UnitConverter(int unitRatio)//Constructor 构造函数
        {
            ratio = unitRatio;
        }
        public int Convert(int unit)// Method 方法
        {
            return unit * ratio;
        }
    }
}
