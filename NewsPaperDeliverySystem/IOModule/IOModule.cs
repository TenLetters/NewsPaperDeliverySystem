using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewsPaperDeliverySystem.CustomerInfo;
using System.Windows.Forms;

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

        // reads the text file with the customer data
        // creates customer objects from the strings read in
        // saves the customers to a list and returns it
        public List<Customer> loadCustomers()
        {
            try
            {
                // read the customer file
                string[] lines = System.IO.File.ReadAllLines(customerDataFilePath + customerFileName);

                // parse the data
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load customer data", "File not found exception");
            }
            return null;
        }

    }
}
