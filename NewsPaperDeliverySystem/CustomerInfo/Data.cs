using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPaperDeliverySystem.CustomerInfo
{
    class Data
    {
        List<Customer> customerList;

        // default consctructor for a Data object
        public Data(List<Customer> customers)
        {
            // if we are passed no customers, create a new empty list instead
            if (customers != null)
            {
                customerList = customers;
            }
            else
            {
                customerList = new List<Customer>();
            }
        }

        // Purpose:
        //  adds a customer to the list
        public void addCustomer(Customer customer)
        {
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
