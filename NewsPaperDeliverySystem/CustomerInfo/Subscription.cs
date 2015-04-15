using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPaperDeliverySystem.CustomerInfo
{
        class Subscription
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
        public Boolean deliverToday(DateTime date)
        {
            return true;
        }
        
        // Purpose:
        // convert to subscription into a writeable string
        // name##price
        public String getSubcriptionWrieFormat()
        {
            String result = "Subscription##";
            result += this.name;
            result += "##";
            result += this.price.ToString();

            return result;
        }

        // Purpose:
        //  Fills this subscription from a string read in
        public void fillFromFileString(String line)
        {
            string[] splitLine = line.Split(new string[] { "##" }, StringSplitOptions.None);

            this.name = splitLine[1];
            this.price = double.Parse(splitLine[2]);
        }
    }
}
