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
            customerList = customers;
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
            return null;
        }
    }

}
