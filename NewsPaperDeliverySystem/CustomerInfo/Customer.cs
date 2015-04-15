//Written By: Josh Levine, Anand Patel, Alex Ciaramella
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPaperDeliverySystem.CustomerInfo
{
    public class Customer
    {
        //customer fields
        String name;
        Address address;
        List<Subscription> subscriptions;
        List<Subscription> backlog;
        int id;
        DateTime vacationStart;
        DateTime vacationEnd;

        //default constructor
        public Customer()
        {
            name = "None";
            address = new Address();
            subscriptions = new List<Subscription>();
            backlog = new List<Subscription>();
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
            this.backlog = new List<Subscription>();
            this.id = id;
            this.vacationStart = vacationStart;
            this.vacationEnd = vacationEnd;
        }

        // Purpose:
        //  copies the fields from the first customer then replaces the list of subscriptions with the given list
        public Customer(Customer customer, List<Subscription> subscriptions)
        {
            // check if customer is on vacation
            if (DateTime.Now > customer.vacationStart && DateTime.Now < customer.vacationEnd)
            {
                // copy fields
                this.name = customer.name;
                this.address = customer.address;
                this.id = customer.id;
                this.backlog = new List<Subscription>();
                // copy subscriptions from given list
                this.subscriptions = subscriptions;
            }
            // if customer is on vacation, add items to backlog
            else
            {
                this.backlog.AddRange(customer.getSubscriptions());
            }
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

        // Purpose:
        // Returns a copy of this customer object with only the subscriptions that need to be deliviered today
        public Customer getTodaysDeliveries()
        {
            List<Subscription> result = new List<Subscription>();

            // loop through each subscription
            foreach(Subscription subscription in subscriptions)
            {
                // if the subscription needs to be delivered today
                if(subscription.deliverToday(DateTime.Now))
                {
                    result.Add(subscription);
                }
            }

            // return a new customer with only the subscriptions that need to be delivered today 
            Customer resultingCustomer = new Customer(this, subscriptions);

            // if our customer has no subscriptions, they must be on vacation so add their backlog to ours
            if(resultingCustomer.getSubscriptions().Count == 0)
            {
                this.backlog.AddRange(resultingCustomer.getBackLog());
            }
            // return the customer
            return resultingCustomer;
        }

        // Purpose:
        //  Returns the back log
        public List<Subscription> getBackLog()
        {
            return this.backlog;
        }

        // Purpose:
        //  creates a string with the proper format to be written out
        // name##address##id##VacationStart##VacationEnd##
        public List<String> getCustomerWriteFormat()
        {
            // set up a variable to store out final list of strings to write out
            List<String> listResult = new List<String>();
            // set up a variable to store our string
            String result = "";
            // set up a delimeter
            String delimeter = "##";

            // save the class data
            result += this.name;
            result += delimeter;
            result += this.address.toString();
            result += delimeter;
            result += id.ToString();
            result += delimeter;
            result += this.vacationStart.ToBinary().ToString();
            result += delimeter;
            result += this.vacationEnd.ToBinary().ToString();

            // say we are starting a new customer object
            listResult.Add("Begin Customer");
            // add the name, address, id, and vacation information
            listResult.Add(result);

            // save all of the subscriptions
            listResult.Add("Subscriptions");
            foreach(Subscription subscription in subscriptions)
            {
                listResult.Add(subscription.getSubcriptionWriteFormat());
            }

            // save all of the subscriptions in the back log
            listResult.Add("Back Log");
            foreach(Subscription subscription in backlog)
            {
                listResult.Add(subscription.getSubcriptionWriteFormat());
            }

            // say we are done with this customer
            listResult.Add("End Customer");

            // return the writeable info
            return listResult;
        }

        // Purpose:
        //  Add an item to this customers back log
        public Boolean addToBackLog(Subscription subscription)
        {
            this.backlog.Add(subscription);
            return true;
        }

        // Purpose:
        // Parses a string and fill up the attributes in this class
        public void fillFromFileString(String line)
        {
            string[] splitLine = line.Split(new string[] { "##" }, StringSplitOptions.None);

            this.name = splitLine[0];
            // split up the address line
            string[] addressLine = splitLine[1].Split(',');
            this.address = new Address(addressLine[0], addressLine[1], addressLine[2], addressLine[3]);
            this.id = int.Parse(splitLine[2]);
            this.vacationStart = DateTime.FromBinary(long.Parse(splitLine[3]));
            this.vacationEnd = DateTime.FromBinary(long.Parse(splitLine[4]));
        }
    }
}
