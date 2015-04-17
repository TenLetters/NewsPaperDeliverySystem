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
    public partial class Form_EditCustomerForm : Form
    {
        private Data data;
        private Customer customerEditing;
        private DateTime start;
        private DateTime end;

        // Purpose:
        //  creates an object of type Form_EditCustomerForm
        public Form_EditCustomerForm(Data data)
        {
            InitializeComponent();
            // save the customer list
            this.data = data;
            // add our combo box item choices for subscriptions
            this.comboBoxPeriod.Items.Add("Daily");
            this.comboBoxPeriod.Items.Add("Weekly");
            this.comboBoxPeriod.Items.Add("Monthly");
            // add our options to the state combo box
            loadStateComboBox();
            // initialize the start and end dates
            start = new DateTime();
            end = new DateTime();
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
        //  Adds the text fields from the subscription group box into the list view of subscriptions
        private void buttonAddSubscription_Click(object sender, EventArgs e)
        {
            try
            {
                // save the data into a new list view item
                ListViewItem lvi = new ListViewItem(this.textBoxSubscriptionName.Text);

                // check to make sure the user entered a double
                String price = this.textBoxSubscriptionPrice.Text;
                Double.Parse(price);

                // format the price string if needed
                if (!price.Contains("."))
                {
                    // if the user did not enter a decimal for the cents, add it
                    price += ".00";
                }

                //  add the remaining items to the list view item
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
                // if the number entered for price was not a double, tell the user
                MessageBox.Show("Value for subscription price must be a number", "User Input Error");
            }



        }

        // Purpose:
        // Searches through all customers to find those with the matching address
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // clear the list view of previous search results
            this.listViewMatchingAddress.Items.Clear();

            // store a list view item to be used to display the matches
            ListViewItem lvi;

            // loop through all customers
            foreach (Customer customer in data.getCustomerList())
            {
                // if any part of the search string is found within an address, display it
                if (customer.getAddress().getStreet().Contains(this.textBoxSearchAddress.Text))
                {
                    // add the customer to the list view item
                    lvi = new ListViewItem(customer.getName());
                    lvi.SubItems.Add(customer.getAddress().getStreet());
                    // add the id but do not display it
                    lvi.SubItems.Add(customer.getID().ToString());

                    // display the item on the list view
                    this.listViewMatchingAddress.Items.Add(lvi);
                }
            }
        }

        // Purpose:
        //  fires when a user checks an item
        //  unchecks any other items and loads the corresponding customer into the other text fields
        private void listViewMatchingAddress_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // uncheck other checked items
            this.listViewMatchingAddress.ItemChecked -= this.listViewMatchingAddress_ItemChecked;
            foreach (var item in this.listViewMatchingAddress.CheckedItems)
            {
                // check if the item is the item we just checked
                if (e.Item != item)
                {
                    // if not, uncheck it
                    ((ListViewItem)item).Checked = false;
                }
            }
            this.listViewMatchingAddress.ItemChecked += this.listViewMatchingAddress_ItemChecked;

            // check if any items are checked for saftey
            if (this.listViewMatchingAddress.CheckedItems.Count > 0)
            {
                // load the data from the checked item
                // our item has to be the first one because we removed all others 
                ListViewItem lvi = this.listViewMatchingAddress.CheckedItems[0];

                // get a reference to the proper customer object whos id is in the list view item
                customerEditing = data.getCustomerByID(int.Parse(lvi.SubItems[2].Text));

                // load the text fields with his/her data
                this.textBoxName.Text = customerEditing.getName();
                this.textBoxAddress.Text = customerEditing.getAddress().getStreet();
                this.textBoxZip.Text = customerEditing.getAddress().getZipCode();
                this.textBoxCity.Text = customerEditing.getAddress().getCity();
                this.comboBoxState.Text = customerEditing.getAddress().getState();

                // check if the customer is on vacation currently
                if (DateTime.Now < customerEditing.getVacationStart() && DateTime.Now > customerEditing.getVacationEnd())
                {
                    this.textBoxVacationStatus.Text = "True";
                }
                else
                {
                    this.textBoxVacationStatus.Text = "False";
                }

                // load the subscriptions into the list view
                loadSubscriptions(customerEditing);
            }
        }

        // Purpose:
        // loads the subscription information from a customer into the list view
        private void loadSubscriptions(Customer customer)
        {
            // clear the old loaded data
            this.listViewSubscriptions.Items.Clear();

            ListViewItem lvi;

            // loop through all subscriptions
            foreach (Subscription subscription in customer.getSubscriptions())
            {
                lvi = new ListViewItem(subscription.getName());
                lvi.SubItems.Add(subscription.getPrice().ToString());
                lvi.SubItems.Add(subscription.getPeriod());

                // add the lvi to the list view
                this.listViewSubscriptions.Items.Add(lvi);
            }
        }

        // Purpose:
        // loads the range of dates from the calander that the user selects using the mouse
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            // get the start end end points that the user selected
            start = this.monthCalendar1.SelectionRange.Start;
            end = this.monthCalendar1.SelectionRange.End;

            // display them in the text box
            this.textBoxVacationStartDate.Text = start.ToString("MMMM dd, yyyy");
            this.textBoxVacationEndDate.Text = end.ToString("MMMM dd, yyyy");
        }

        // Purpose:
        // loads the range of dates from the calander that the user selects using the keyboard
        private void monthCalendar1_KeyUp(object sender, KeyEventArgs e)
        {
            // get the start end end points that the user selected
            start = this.monthCalendar1.SelectionRange.Start;
            end = this.monthCalendar1.SelectionRange.End;

            // display them in the text box
            this.textBoxVacationStartDate.Text = start.ToString("MMMM dd, yyyy");
            this.textBoxVacationEndDate.Text = end.ToString("MMMM dd, yyyy");
        }

        // Purpose:
        // edits the customer with all of the data the user has entered
        private void buttonOK_Click(object sender, EventArgs e)
        {
            // set the dialogResult to OK
            this.DialogResult = DialogResult.OK;

            // set the fields of the customer to those currently in the text box
            customerEditing.setName(this.textBoxName.Text);
            customerEditing.setAddress( 
                    new Address(    this.textBoxAddress.Text,
                                    this.textBoxZip.Text,
                                    this.textBoxCity.Text,
                                    this.comboBoxState.Text));
            customerEditing.clearSubscriptions();
            customerEditing.addSubscriptions(getSubscriptions());
            customerEditing.setVacationStart(start);
            customerEditing.setVacationEnd(end);

        }

        // Purpose:
        //  wraps all of the list view items into subscriptions
        //  returns the list of all subscriptions
        private List<Subscription> getSubscriptions()
        {
            List<Subscription> subscriptions = new List<Subscription>();
            Subscription subscription;

            // loop through all list view items in the list view
            foreach (ListViewItem lvi in this.listViewSubscriptions.Items)
            {
                // create the proper type of subscription based on the period
                if(lvi.SubItems[2].Text.Equals("Daily"))
                {
                    subscription = new DailySubscription(lvi.SubItems[0].Text, double.Parse(lvi.SubItems[1].Text));
                }
                else if(lvi.SubItems[2].Text.Equals("Weekly"))
                {
                    subscription = new WeeklySubscription(lvi.SubItems[0].Text, double.Parse(lvi.SubItems[1].Text));
                }
                else
                {
                    subscription = new MonthlySubscription(lvi.SubItems[0].Text, double.Parse(lvi.SubItems[1].Text));
                }

                // add the item to the list
                subscriptions.Add(subscription);
            }

            // return the list of subscriptions
            return subscriptions;
        }

        // Purpose:
        // set the dialog result of this form to cancel so none of the data is update
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // Purpose:
        //  removes all checked list view items from the list view
        private void buttonRemoveSubscription_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in this.listViewSubscriptions.CheckedItems)
            {
                this.listViewSubscriptions.Items.Remove(lvi);
            }
        }
    }
}
