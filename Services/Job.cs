using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuartzScheduler.Services
{
    public class Job : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            //do your task here
            //just a simple print for demo purpose
            System.Diagnostics.Debug.WriteLine("Hello There!!");
        }
    }
}