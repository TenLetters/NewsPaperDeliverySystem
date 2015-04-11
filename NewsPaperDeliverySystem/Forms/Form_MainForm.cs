using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NewsPaperDeliverySystem.CustomerInfo;
using NewsPaperDeliverySystem.IOModule;

namespace NewsPaperDeliverySystem
{
    public partial class Form1 : Form
    {
        private Data data; // the customer data
        private IOModule.IOModule IOModule; // used to write/read from the saved text files which contain customer information

        public Form1()
        {
            // test
            InitializeComponent();
            this.labelDate.Text = DateTime.Now.ToString("M/d/yyyy");
            IOModule = new IOModule.IOModule();
            // load the customers saved in text files into memory
            data = new Data(IOModule.loadCustomers());
            loadDataIntoTree();
        }

        // loads the customers who have deliveries today into the tree view
        private void loadDataIntoTree()
        {
            // get a list of all customers with deliveries today
            List<Customer> customers = data.getTodaysDeliveries();

            // declare a variable to store the temporary nodes in
            TreeNode tempNode;

            // create a new node for each customer
            foreach (Customer customer in customers)
            {
                // set the text at the head of the node as the customer's name
                tempNode = new TreeNode(customer.getName());

                // set child nodes for each subscription the customer is to be delivered today
                foreach (Subscription subscription in customer.getSubscriptions())
                {
                    tempNode.Nodes.Add(subscription.getName());
                }

                this.treeViewTodaysDeliveries.Nodes.Add(tempNode);
            }
        }
    }
}
