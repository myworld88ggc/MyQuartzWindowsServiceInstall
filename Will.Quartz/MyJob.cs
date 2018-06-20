using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Common.Logging;
using Quartz;

namespace Will.Quartz
{
    public class MyJob : IJob
    {
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public void Execute(IJobExecutionContext context)
        {

            Console.WriteLine("Job Executed");
            logger.Info("Info Msg");
            logger.Error("Error Msg");

        }
    }
}
