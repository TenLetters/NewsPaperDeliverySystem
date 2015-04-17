using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPaperDeliverySystem.CustomerInfo
{
    class WeeklySubscription : Subscription
    {

        // passes the parameters to the super class
        public WeeklySubscription(String name, Double price) : base(name, price)
        {
        }
        
        // returns an empty WeeklySubscription
        public WeeklySubscription() : base()
        {
        }

        //Purpose:
        //  Should this be delivered today?
        //  Will return true if this is the day it is delivered on, false otherwise
        public override Boolean deliverToday(DateTime date)
        {
            if(date.DayOfWeek == DayOfWeek.Friday)
            {
                return true;
            }
            return false;
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
            result += "Weekly";

            return result;
        }

        // Purpose:
        // return the period of this subscription
        public override String getPeriod()
        {
            return "Weekly";
        }
    }
}
