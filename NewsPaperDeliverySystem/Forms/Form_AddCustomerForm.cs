using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NewsPaperDeliverySystem.CustomerInfo;

namespace NewsPaperDeliverySystem.Forms
{
    public partial class Form_AddCustomerForm : Form
    {
        private Customer customer;
        private int nextID;

        // loads the form
        public Form_AddCustomerForm()
        {
            InitializeComponent();
            // add our combo box choices for the subscription periods
            this.comboBoxPeriod.Items.Add("Daily");
            this.comboBoxPeriod.Items.Add("Weekly");
            this.comboBoxPeriod.Items.Add("Monthly");
            // add our combo box choices for the stats
            loadStateComboBox();
        }

        // Purpose:
        //  loads all of the stats into the stateComboBox
        private void loadStateComboBox()
        {
            this.comboBoxState.Items.Add("Alabama");
            this.comboBoxState.Items.Add("Alaska");
            this.comboBoxState.Items.Add("Arizona");
            this.comboBoxState.Items.Add("Arkansas");
            this.comboBoxState.Items.Add("California");
            this.comboBoxState.Items.Add("Colorado");
            this.comboBoxState.Items.Add("Connecticut");
            this.comboBoxState.Items.Add("Delaware");
            this.comboBoxState.Items.Add("Florida");
            this.comboBoxState.Items.Add("Georgia");
            this.comboBoxState.Items.Add("Hawaii");
            this.comboBoxState.Items.Add("Iadaho");
            this.comboBoxState.Items.Add("Illinois");
            this.comboBoxState.Items.Add("Indiana");
            this.comboBoxState.Items.Add("Iowa");
            this.comboBoxState.Items.Add("Kansas");
            this.comboBoxState.Items.Add("Kentucky");
            this.comboBoxState.Items.Add("Louisiana");
            this.comboBoxState.Items.Add("Maine");
            this.comboBoxState.Items.Add("Maryland");
            this.comboBoxState.Items.Add("Massachusetts");
            this.comboBoxState.Items.Add("Michigan");
            this.comboBoxState.Items.Add("Minnesota");
            this.comboBoxState.Items.Add("Mississippi");
            this.comboBoxState.Items.Add("Missouri");
            this.comboBoxState.Items.Add("Montana");
            this.comboBoxState.Items.Add("Nebraska");
            this.comboBoxState.Items.Add("Nevada");
            this.comboBoxState.Items.Add("New Hampshire");
            this.comboBoxState.Items.Add("New Jersey");
            this.comboBoxState.Items.Add("New Mexico");
            this.comboBoxState.Items.Add("New York");
            this.comboBoxState.Items.Add("North Carolina");
            this.comboBoxState.Items.Add("North Dakota");
            this.comboBoxState.Items.Add("Ohio");
            this.comboBoxState.Items.Add("Oklahoma");
            this.comboBoxState.Items.Add("Oregon");
            this.comboBoxState.Items.Add("Pennsylvania");
            this.comboBoxState.Items.Add("Rhode Island");
            this.comboBoxState.Items.Add("South Carolina");
            this.comboBoxState.Items.Add("South Dakota");
            this.comboBoxState.Items.Add("Tennessee");
            this.comboBoxState.Items.Add("Texas");
            this.comboBoxState.Items.Add("Utah");
            this.comboBoxState.Items.Add("Vermont");
            this.comboBoxState.Items.Add("Virginia");
            this.comboBoxState.Items.Add("Washington");
            this.comboBoxState.Items.Add("West Virginia");
            this.comboBoxState.Items.Add("Wisconsin");
            this.comboBoxState.Items.Add("Wyoming");
        }

        // Purpose:
        //  sets the id so we know which one to assign the next customer
        public void setID(int id)
        {
            this.nextID = id;
        }

        // Purpose:
        // creates subscription objects based on those listed in the list view
        public List<Subscription> getSubscriptions()
        {
            // save our list of subscriptions
            List<Subscription> result = new List<Subscription>();

            foreach (ListViewItem lvi in this.listViewSubscriptions.Items)
            {
                // add the subscription to the list

                // check for which period the subscription should be delivered on
                if(lvi.SubItems[2].Text.Equals("Daily"))
                {
                    result.Add(new DailySubscription(lvi.SubItems[0].Text, Double.Parse(lvi.SubItems[1].Text)));
                }
                else if(lvi.SubItems[2].Text.Equals("Weekly"))
                {
                    result.Add(new WeeklySubscription(lvi.SubItems[0].Text, Double.Parse(lvi.SubItems[1].Text)));
                }
                else
                {
                    result.Add(new MonthlySubscription(lvi.SubItems[0].Text, Double.Parse(lvi.SubItems[1].Text)));
                }
            }

            return result;
        }

        // Purpose:
        //  returns the customer object stored
        public Customer getCustomer()
        {
            return customer;
        }

        // Purpose:
        // sets this dialogue to ok and hides the form
        // creates a new customer based on the fields filled in by the user
        private void buttonOK_Click(object sender, EventArgs e)
        {
            // verify that the user entered all of the required information
            if(this.textBoxName.Text.Equals(""))
            {
                MessageBox.Show("Please enter a name", "Data Error");
                return;
            }
            if (this.textBoxStreet.Text.Equals(""))
            {
                MessageBox.Show("Please enter a street", "Data Error");
                return;
            }
            if (this.textBoxZip.Text.Equals(""))
            {
                MessageBox.Show("Please enter a zip code", "Data Error");
                return;
            }
            if (this.textBoxCity.Text.Equals(""))
            {
                MessageBox.Show("Please enter a city", "Data Error");
                return;
            }
            if (this.comboBoxState.Text.Equals(""))
            {
                MessageBox.Show("Please enter a state", "Data Error");
                return;
            }


            // create a customer based on our fields the user has entered
            customer = new CustomerInfo.Customer(
                                        this.textBoxName.Text,
                                        new Address(
                                            this.textBoxStreet.Text,
                                            this.textBoxZip.Text,
                                            this.textBoxCity.Text,
                                            this.comboBoxState.Text),
                                        getSubscriptions(),
                                        nextID,
                                        new DateTime(),
                                        new DateTime());

            this.Hide();
            this.DialogResult = DialogResult.OK;
        }

        // Purpose:
        // sets this dialogue to cancel and hides the form
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.DialogResult = DialogResult.Cancel;
        }

        // Purpose:
        // adds the fields entered by the user into the list view of 
        private void buttonAddSubscription_Click(object sender, EventArgs e)
        {
            try
            {
                String price = this.textBoxSubscriptionPrice.Text;

                // verify that the user entered a proper value for price
                Double.Parse(price);

                // format the price string for the user if they did not add cents 
                if (!price.Contains("."))
                {
                    price += ".00";
                }
                
                // create a list view item with the fields of the subscription entered
                ListViewItem lvi = new ListViewItem(this.textBoxSubscriptionName.Text);
                lvi.SubItems.Add(price);
                lvi.SubItems.Add(this.comboBoxPeriod.Text);

                // add the list view item to the list view
                this.listViewSubscriptions.Items.Add(lvi);

                // clear out the text boxes for the user
                this.textBoxSubscriptionName.Clear();
                this.textBoxSubscriptionPrice.Clear();
            }
            catch (Exception ex)
            {
                // show a message if an exception was raised by trying to parse a double
                MessageBox.Show("Price must be a numerical value", "User Error");
            }

        }
    }
}
