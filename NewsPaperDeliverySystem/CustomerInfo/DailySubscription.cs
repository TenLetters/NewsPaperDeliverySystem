using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPaperDeliverySystem.CustomerInfo
{
    class DailySubscription : Subscription
    {

        // passes the parameters to the super class
        public DailySubscription(String name, Double price) : base(name, price)
        {

        }

        //Purpose:
        //  Should this be delivered today?
        //  Will always return true since this is delivered daily
        public new Boolean deliverToday(DateTime date)
        {
            return true;
        }
    }
}
