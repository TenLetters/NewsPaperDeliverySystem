using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPaperDeliverySystem.CustomerInfo
{
    class WeeklySubsciption : Subscription
    {

        // passes the parameters to the super class
        public WeeklySubsciption(String name, Double price) : base(name, price)
        {
        }
        
        // returns an empty WeeklySubscription
        public WeeklySubsciption() : base()
        {
        }

        //Purpose:
        //  Should this be delivered today?
        //  Will return true if this is the day it is delivered on, false otherwise
        public new Boolean deliverToday(DateTime date)
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

    }
}
