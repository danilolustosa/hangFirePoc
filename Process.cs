using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangFirePOC
{
    public static class Process
    {
        public static void RecurringJobs()
        {
            var division = new Division();
            RecurringJob.AddOrUpdate(() => division.DivisionRandom(), Cron.Minutely());
        }
    }
}
