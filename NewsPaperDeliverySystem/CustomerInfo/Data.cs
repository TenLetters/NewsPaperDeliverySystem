using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPaperDeliverySystem.CustomerInfo
{
    public class Data
    {
        List<Customer> customerList;
        private int highestID = 0;

        // default consctructor for a Data object
        public Data(List<Customer> customers)
        {
            // if we are passed no customers, create a new empty list instead
            if (customers != null)
            {
                highestID = checkID(customers);
                customerList = customers;
            }
            else
            {
                customerList = new List<Customer>();
            }
        }

        // Purpose:
        //  returns the highest id number found in the list of customers
        private int checkID(List<Customer> customers)
        {
            int highest = 0;

            // loop through each customer, checking their id number
            foreach (Customer customer in customers)
            {
                // if theirs is higher than the max, change the max to it
                if (customer.getID() > highestID)
                {
                    highest = customer.getID();
                }
            }

            return highest;

        }

        // Purpose:
        //  adds a customer to the list
        public void addCustomer(Customer customer)
        {
            // increment highest id for the new customer
            highestID += 1;
            // add the proper id to this new customer
            customer.setID(highestID);
            // add the customer to the list of customers
            this.customerList.Add(customer);
        }

        // returns the list of customers
        public List<Customer> getCustomerList()
        {
            return customerList;
        }

        // returns the customer with a matching ID from the list of customers
        public Customer getCustomerByID(int ID)
        {
            foreach (Customer customer in customerList)
            {
                if (customer.getID() == ID)
                    return customer;
            }
            return new Customer();
        }

        // returns the list of customers who have deliveries today
        public List<Customer> getTodaysDeliveries()
        {
            List<Customer> result = new List<Customer>();

            // loop through all of the customers
            foreach(Customer customer in customerList)
            {
                // check if the customer has atleast one delivery for today
                if(customer.getTodaysDeliveries().getSubscriptions().Count > 0)
                {
                    result.Add(customer);
                }
            }

            return result;
        }
    }

}
