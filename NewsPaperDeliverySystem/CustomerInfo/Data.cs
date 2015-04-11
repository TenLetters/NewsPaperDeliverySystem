using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPaperDeliverSystem.CustomerInfo
{
    class Data
    {
        List<Customer> customerList;

        public Data()
        {
            customerList = new List<Customer>();
        }

        public List<Customer> getCustomerList()
        {
            return customerList;
        }

        public Customer getCustomerByID(int ID)
        {
            foreach (Customer customer in customerList)
            {
                if (customer.getID() == ID)
                    return customer;
            }
            return new Customer();
        }
    }

}
