using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPaperDeliverSystem.CustomerInfo
{
    class WeeklySubsciption : Subscription
    {
        //Purpose:
        //  Should this be delivered today?
        //  Will return true if this is the day it is delivered on, false otherwise
        public Boolean deliverToday(DateTime date)
        {
            if(date.DayOfWeek == DayOfWeek.Friday)
            {
                return true;
            }
            return false;
        }

    }
}
