using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewsPaperDeliverySystem.CustomerInfo;
using System.Windows.Forms;
using System.IO;

namespace NewsPaperDeliverySystem.IOModule
{
    class IOModule
    {
        private string customerDataFilePath = "Data\\";
        private string customerFileName = "Customer Data.txt";

        // default constructor for an IOModule object
        public IOModule()
        {
        }

        // Purpose:
        //  reads the text file with the customer data
        //  creates customer objects from the strings read in
        //  saves the customers to a list and returns it
        public List<Customer> loadCustomers()
        {
            String line;
            try
            {
                // read the customer file
                using(StreamReader reader = new StreamReader(customerDataFilePath + customerFileName))
                {
                    List<Customer> customers = new List<Customer>();
                    Customer currentCustomer = new Customer();

                    // read through the whole file
                    while((line = reader.ReadLine()) != null)
                    {
                        if(line.Equals("Begin Customer"))
                        {
                            // start a new customer
                            currentCustomer = new Customer();
                            // read the next line
                            line = reader.ReadLine();
                            // fill the customer from the line read
                            currentCustomer.fillFromFileString(line);
                        }
                        else if(line.Equals("Subsriptions"))
                        {
                            // read the next line
                            line = reader.ReadLine();

                            // loop through all subscriptions
                            while(line.StartsWith("Subscription"))
                            {
                                Subscription subscription = new Subscription();
                                // fill the subscrption with the proper information and typing
                                subscription = subscription.fillFromFileString(line);
                                // store the subscription into the current customer
                                currentCustomer.addSubscription(subscription);
                            }
                        }
                        else if(line.Equals("Back Log"))
                        {
                            // read the next line
                            line = reader.ReadLine();
                            // loop through all items in the back log
                            while(line.StartsWith("Back Log"))
                            {
                                Subscription subscription = new Subscription();
                                subscription.fillFromFileString(line);
                                // store the subscription into the back log of the customer
                                currentCustomer.addToBackLog(subscription);
                            }
                        }
                        else if(line.Equals("End Customer"))
                        {
                            // save the customer as is to the list
                            customers.Add(currentCustomer);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load customer data", "File not found exception");
            }
            return null;
        }

        
        // Purpose:
        //  write out all of the customer information into a text file
        //  located in the default location
        public void writeCustomer(List<Customer> customers)
        {
            try
            {
                // store the lines to be written
                List<String> lines = new List<String>();

                // loop through all of the customers
                foreach(Customer customer in customers)
                {
                    lines.AddRange(customer.getCustomerWriteFormat());
                }

                // try writing the info to the file
                System.IO.File.WriteAllLines(customerDataFilePath + customerFileName, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing customer data", "Error");
            }
        }

    }
}
