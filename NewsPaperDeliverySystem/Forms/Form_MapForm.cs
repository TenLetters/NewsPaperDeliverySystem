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
    public partial class Form_MapForm : Form
    {
        public Form_MapForm(List<Customer> customers)
        {
            InitializeComponent();
            // load the map with the customer data
            loadMap(customers);
        }

        // Purpose:
        //  Goes through the list of customers and adds their addresses to the google map search
        //  then displays the result on screen
        private void loadMap(List<Customer> customers)
        {
            StringBuilder queryAddress = new StringBuilder();
            queryAddress.Append("https://www.google.com/maps/dir/");

            // loop through all customers with deliveires today
            for (int i = 0; i < customers.Count; i++)
            {
                queryAddress.Append(customers[i].getAddress().getMapString());
                // only add the backslash if we are not on the last customer
                if (i < customers.Count - 1)
                {
                    queryAddress.Append("/");
                }
            }

            //https://www.google.com/maps/dir/112+Tiffany+Ln,+Egg+Harbor+Township,+NJ+08234,+USA/300+Rowan+Blvd,+Glassboro,+NJ+08028/First+St+NE,+Washington,+DC
            //this.webKitBrowser.Navigate("https://www.google.com/maps/dir/112+Tiffany+Ln,+Egg+Harbor+Township,+NJ+08234,+USA/300+Rowan+Blvd,+Glassboro,+NJ+08028/First+St+NE,+Washington,+DC");
            this.webKitBrowser.Navigate(queryAddress.ToString());
        }
    }
}
