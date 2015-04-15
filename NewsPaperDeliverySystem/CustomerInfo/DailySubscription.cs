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

        // returns an empty DailySubscription
        public DailySubscription() : base()
        {
        }

        //Purpose:
        //  Should this be delivered today?
        //  Will always return true since this is delivered daily
        public new Boolean deliverToday(DateTime date)
        {
            return true;
        }

        // Purpose:
        // convert to subscription into a writeable string
        // name##price##period
        public override String getSubcriptionWriteFormat()
        {
            String result = "Subscription##";
            result += base.getName();
            result += "##";
            result += base.getPrice().ToString();
            result += "##";
            result += "Daily";

            return result;
        }
    }
}
