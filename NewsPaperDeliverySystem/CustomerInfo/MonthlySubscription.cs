using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPaperDeliverSystem.CustomerInfo
{
    class MonthlySubscription : Subscription
    {
        //Purpose:
        //  Should this be delivered today?
        //  Will return true if this is the day it is delivered on, false otherwise
        public Boolean deliverToday(DateTime date)
        {
            // set up a date time to find the first friday
            DateTime firstFriday = new DateTime(date.Year, date.Month, 1);

            // loop through the days until the temporary date is set to friday
            while (firstFriday.DayOfWeek != DayOfWeek.Friday)
                firstFriday = firstFriday.AddDays(1);

            // check if today is the first friday
            if (date.Day == firstFriday.Day)
            {
                return true;
            }

            return false;
        }
    }
}
