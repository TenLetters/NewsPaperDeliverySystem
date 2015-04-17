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
        private string fileExtension = ".txt";

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
            List<Customer> customers = new List<Customer>();
            try
            {
                // read the customer file
                using(StreamReader reader = new StreamReader(customerDataFilePath + customerFileName))
                {
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
                        if(line.Equals("Subscriptions"))
                        {
                            // read the next line
                            line = reader.ReadLine();

                            // loop through all subscriptions
                            while(line.StartsWith("Subscription"))
                            {
                                // parse the line
                                string[] splitLine = line.Split(new string[] { "##" }, StringSplitOptions.None);

                                Subscription subscription;

                                // check which type of subscription we are reading
                                // fill the subscrption with the proper information and typing
                                if (splitLine[3].Equals("Daily"))
                                {
                                    subscription = new DailySubscription().fillFromFileString(line);
                                }
                                else if (splitLine[3].Equals("Weekly"))
                                {
                                    subscription = new WeeklySubscription().fillFromFileString(line);
                                }
                                else
                                {
                                    subscription = new MonthlySubscription().fillFromFileString(line);
                                }

                                // store the subscription into the current customer
                                currentCustomer.addSubscription(subscription);

                                // advance to the next line
                                line = reader.ReadLine();
                            }
                        }
                        if(line.Equals("Back Log"))
                        {
                            // read the next line
                            line = reader.ReadLine();
                            // loop through all items in the back log
                            while(line.StartsWith("Back Log"))
                            {
                                // parse the line
                                string[] splitLine = line.Split(new string[] { "##" }, StringSplitOptions.None);

                                Subscription subscription;

                                // check which type of subscription we are reading
                                // fill the subscrption with the proper information and typing
                                if (splitLine[3].Equals("Daily"))
                                {
                                    subscription = new DailySubscription().fillFromFileString(line);
                                }
                                else if (splitLine[3].Equals("Weekly"))
                                {
                                    subscription = new WeeklySubscription().fillFromFileString(line);
                                }
                                else
                                {
                                    subscription = new MonthlySubscription().fillFromFileString(line);
                                }

                                // store the subscription into the back log of the customer
                                currentCustomer.addToBackLog(subscription);
                            }
                        }
                        if(line.Equals("End Customer"))
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

            // return the list we made
            return customers;
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

                MessageBox.Show("Customer data saved to " + Directory.GetCurrentDirectory().ToString() + "\\" + customerDataFilePath + customerFileName, "Save Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing customer data", "Error");
            }
        }

        // Purpose:
        //  writes out all of the delivery log information into a text file
        //  located in the default location
        public void writeDeliveryLog(List<Customer> customers)
        {
            try
            {
                // get today's date
                DateTime today = DateTime.Now;
                // format the date as a string
                String date = today.ToString("MM-dd-yy");

                // store the lines to be written
                List<String> lines = new List<String>();

                // loop through all of the customers
                foreach (Customer customer in customers)
                {
                    //  loop through each subscription for each customer
                    foreach (Subscription subscription in customer.getSubscriptions())
                    {
                        // add the customer address and the subscription delivered to that address
                        lines.Add(customer.getAddress().getStreet() + "##" + subscription.getName());
                    }
                }

               // try writing the info to the file
                System.IO.File.WriteAllLines(customerDataFilePath + date + fileExtension, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing delivery data", "Error");
            }
        }

        // Purpose:
        //  reads the text file with the delivery log data which
        //  corresponds to the given date string and returns all of the data
        //  if the file cannot be found, return an empty list
        public List<String> loadDeliveryLog(String date)
        {
            List<String> result = new List<String>();

            try
            {
                // get the name of the file the data would be in if it exists
                string filename = date + fileExtension;

                // read the file
                String[] lines = File.ReadAllLines(customerDataFilePath + date + fileExtension);

                // add the array of lines to the array list
                result.AddRange(lines);

                // return the list of lines read
                return result;
            }
            catch (Exception ex)
            {
                // Return a List with one string
                // which states that there is no saved data for the given date
                result.Add("There is no saved data for: " + date);
                return result;
            }
        }
    }
}
