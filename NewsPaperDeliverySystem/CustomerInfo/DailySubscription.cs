using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPaperDeliverSystem.CustomerInfo
{
    class DailySubscription : Subscription
    {
        //Purpose:
        //  Should this be delivered today?
        //  Will always return true since this is delivered daily
        public Boolean deliverToday(DateTime date)
        {
            return true;
        }
    }
}
