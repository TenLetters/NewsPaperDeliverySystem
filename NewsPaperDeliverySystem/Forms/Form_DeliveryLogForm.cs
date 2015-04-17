using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewsPaperDeliverySystem.Forms
{
    public partial class Form_DeliveryLogForm : Form
    {
        public Form_DeliveryLogForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        // Purpose:
        //  loads the data corresponding to the date selected by the user
        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            // get the date the user chose
            DateTime dateSelected = this.monthCalendar.SelectionStart;

            // update the list viewwith the proper date
            displayData(dateSelected);
        }

        // Purpose:
        //  Updates the list view with the data corresponding to the given date
        //  leaves the list view blank if the date could not be found
        private void displayData(DateTime dateSelected)
        {

            // clear any old data out
            this.listViewDeliveriesOn.Items.Clear();

            // format the date as a string
            String date = dateSelected.ToString("MM-dd-yy");

            // get a reference to an ioModule to read/write data
            NewsPaperDeliverySystem.IOModule.IOModule ioModule = new IOModule.IOModule();

            // read in the data from the date
            List<String> results = ioModule.loadDeliveryLog(date);

            ListViewItem lvi;

            // check if any data was read in
            if (results.Count == 1)
            {
                // no data was read in
                lvi = new ListViewItem(results[0]);

                // add our item to the list view
                this.listViewDeliveriesOn.Items.Add(lvi);

            }
            else
            {
                // loop through all strings in result
                foreach (String line in results)
                {
                    // parse the line
                    string[] splitLine = line.Split(new string[] { "##" }, StringSplitOptions.None);

                    // add the data to a list view item
                    lvi = new ListViewItem(splitLine[0]);
                    lvi.SubItems.Add(splitLine[1]);

                    // add the list view item to the list view
                    this.listViewDeliveriesOn.Items.Add(lvi);
                }
            }

        }
    }
}
