//Written By: Josh Levine, Anand Patel, Alex Ciaramella
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPaperDeliverSystem.CustomerInfo
{
    class Customer
    {
        //customer fields
        String name;
        Address address;
        List<Subscription> subscriptions;
        int id;
        DateTime vacationStart;
        DateTime vacationEnd;

        //default constructor
        public Customer()
        {
            name = "None";
            address = new Address();
            subscriptions = new List<Subscription>();
            id = 000;
            vacationStart = new DateTime();
            vacationEnd = new DateTime();
        }

        //Purpose:
        //  constructor of the class takes ...
        public Customer(String name, Address address, List<Subscription> subscriptions, int id, DateTime vacationStart, DateTime vacationEnd)
        {
            this.name = name;
            this.address = address;
            this.subscriptions = subscriptions;
            this.id = id;
            this.vacationStart = vacationStart;
            this.vacationEnd = vacationEnd;
        }

        //Purpose:
        //  returns the customer name
        public String getName()
        {
            return name;
        }

        //Purpose:
        //  sets the customers name to the param name
        public void setName(String name)
        {
            this.name = name;
        }

        //Purpose:
        //  retuns the address object associated with this customer
        public Address getAddress()
        {
            return address;
        }

        //Purpose:
        //  sets the customers address to the param address
        public void setAddress(Address address)
        {
            this.address = address;
        }

        //Purpose:
        //  returns the customers subscriptions, as a list
        public List<Subscription> getSubscriptions()
        {
            return subscriptions;
        }

        //Purpose:
        //  adds a subscription to the customers list of subscription
        //  returns true if the subscription is added false otherwise    
        public Boolean addSubscription(Subscription subscription) 
        {
            if (!this.subscriptions.Contains(subscription))
            {
                this.subscriptions.Add(subscription);
                return true;
            }
            return false;            
        }

        //Purpose:
        //  adds a list of subscriptions to the end of the customers subscriptions list
        //  returns true if it adds all the items.
        public Boolean addSubscriptions(List<Subscription> subscriptions)
        {
            foreach (Subscription item in subscriptions)
            {
                addSubscription(item);
            }
            return true;
        }

        //Purpose:
        // removes the specified items from the list
        public Boolean removeSubscriptions(List<Subscription> subscriptionsToBeRemoved)
        {
            foreach (Subscription item in subscriptionsToBeRemoved)
            {
                removeSubscription(item);
            }

            return true;
        }

        //Purpose:
        //  removes the specified item from the list of subscriptions
        public Boolean removeSubscription(Subscription subscriptionToBeRemoved)
        {
            return this.subscriptions.Remove(subscriptionToBeRemoved);
        }

        //Purpose;
        //  returns the customer ID
        public int getID()
        {
            return id;
        }

        //Purpose;
        //  returns the start date of the customer vacation
        public DateTime getVacationStart()
        {
            return vacationStart;
        }

        //Purpose:
        //  sets the start date of the customers vacaton
        public void setVacationStart(DateTime vacationStart)
        {
            this.vacationStart = vacationStart;
        }

        //Purpose;
        //  returns the end date of the customers vacation
        public DateTime getVacationEnd()
        {
            return vacationEnd;
        }

        //Purpose:
        //  sets the end date of the customer vacation
        public void setVacationEnd(DateTime vacationEnd)
        {
            this.vacationEnd = vacationEnd;
        }

    }
}
