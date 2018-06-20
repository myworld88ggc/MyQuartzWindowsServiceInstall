using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Common.Logging;
using Quartz;
using Quartz.Impl;


namespace Will.Test
{
    class Program
    {
        private static IScheduler scheduler;
        static void Main(string[] args)
        {
            //ILog logger = LogManager.GetLogger(typeof(Program));
            //logger.Info("Info Msg");
            //logger.Error("Error Msg");

            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();
             scheduler = schedulerFactory.GetScheduler();
            scheduler.Start();
            Console.WriteLine("QuartZ Job Start");
            Thread.Sleep(60*1000);
        }
    }
}
