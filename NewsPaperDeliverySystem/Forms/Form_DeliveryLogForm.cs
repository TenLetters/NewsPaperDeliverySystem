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

        }

        // Purpose:
        //  loads the data corresponding to the date selected by the user
        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            // get the date the user chose
            DateTime dateSelected = this.monthCalendar.SelectionStart;

            // update the tree with the proper date
            displayTree(dateSelected);
        }

        // Purpose:
        //  Updates the tree with the data corresponding to the given date
        //  leaves the tree blank if the date could not be found
        private void displayTree(DateTime dateSelected)
        {
            // format the date as a string
            String date = dateSelected.ToString("MM/dd/yy");

            // get a reference to an ioModule to read/write data
            NewsPaperDeliverySystem.IOModule.IOModule ioModule = new IOModule.IOModule();

            ioModule.
        }
    }
}
