using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPaperDeliverySystem.CustomerInfo
{
        public abstract class Subscription
    {
        String name;
        Double price;

        // default constructor for a subscription
        public Subscription(String name, Double price)
        {
            this.name  = name;
            this.price = price;
        }

        // create a blank subscription
        public Subscription()
        {

        }

        //Purpose:
        //  gets the name of this subscirption
        //  returns the String name
        public String getName()
        {
            return this.name;
        }

        //Purpose:
        //  sets the name of the subscirption to the parameter name
        //  returns true
        public Boolean setName(String name)
        {
            this.name = name;
            return true;
        }

        //Purpose:
        //  returns the price of this subscription  
        public Double getPrice()
        {
            return this.price;
        }

        //Purpose:
        //  set the price of a subscription
        //  return true
        public Boolean setPrice(Double price)
        {
            this.price = price;
            return true;
        }

        //Purpose:
        //  Should this be delivered today?
        //  Will return true if this is the day it is delivered on, false otherwise
        public abstract Boolean deliverToday(DateTime date);
        
        // Purpose:
        // convert to subscription into a writeable string
        // name##price
        public abstract String getSubcriptionWriteFormat();

        // Purpose:
        // return the period of this subscription
        public abstract String getPeriod();

        // Purpose:
        //  Fills this subscription from a string read in
        public Subscription fillFromFileString(String line)
        {
            string[] splitLine = line.Split(new string[] { "##" }, StringSplitOptions.None);

            // check if the subscription is daily
            if (splitLine[3].Equals("Daily"))
            {
                return new DailySubscription(splitLine[1], double.Parse(splitLine[2]));
            }
            // check if the subscription is monthly
            else if (splitLine[3].Equals("Monthly"))
            {
                return new MonthlySubscription(splitLine[1], double.Parse(splitLine[2]));
            }
            // otherwise it must be weekly
            else
            {
                return new WeeklySubscription(splitLine[1], double.Parse(splitLine[2]));
            }
        }
    }
}
