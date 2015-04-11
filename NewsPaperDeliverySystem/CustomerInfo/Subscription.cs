using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPaperDeliverSystem.CustomerInfo
{
    abstract class Subscription
    {
        String name;
        Double price;

        public Subscription(String name, Double price)
        {
            this.name  = name;
            this.price = price;
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
        
    }
}
