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
            foreach (Customer customer in data.getTodaysDeliveries())
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

        // writes the customer data into a file
        private void buttonSaveCustomerInformation_Click(object sender, EventArgs e)
        {
            this.IOModule.writeCustomer(data.getCustomerList());
        }

        // opens up the AddCustomerForm
        // adds a new customer object to data if the user clicks ok
        private void buttonAddNewCustomer_Click(object sender, EventArgs e)
        {
            NewsPaperDeliverySystem.Forms.Form_AddCustomerForm addCustomerForm = new Forms.Form_AddCustomerForm();
            addCustomerForm.ShowDialog();

            // the user clicked OK
            if (addCustomerForm.DialogResult == DialogResult.OK)
            {
                // add the created customer to our data
                data.addCustomer(addCustomerForm.getCustomer());
                // reload our tree data incase something changes
                // clear the old data first
                this.treeViewTodaysDeliveries.Nodes.Clear();
                loadDataIntoTree();
            }
            // the user clicked cancel
            else if (addCustomerForm.DialogResult == DialogResult.Cancel)
            {
                // do nothing
            }

        }

        // opens up the edit customer form
        // modifies a customer object in data if the user clicks ok
        private void buttonModifyCustomer_Click(object sender, EventArgs e)
        {
            // open up a new edit customer form
            NewsPaperDeliverySystem.Forms.Form_EditCustomerForm editCustomerForm = new Forms.Form_EditCustomerForm(data);
            editCustomerForm.ShowDialog();

            // check if the user clicked OK
            if (editCustomerForm.DialogResult == DialogResult.OK)
            {
                // reload our tree data incase something changed
                this.treeViewTodaysDeliveries.Nodes.Clear();
                loadDataIntoTree();
            }
            else if (editCustomerForm.DialogResult == DialogResult.Cancel)
            {
                // do nothing
            }

        }

        // Purpose: 
        //  opens up the form to view the past deliveries made during the software's use
        private void buttonViewPastDeliveryData_Click(object sender, EventArgs e)
        {

        }
    }
}
