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

    }
}
