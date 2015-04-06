using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewsPaperDeliverySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // test
            InitializeComponent();
            this.labelDate.Text = DateTime.Now.ToString("M/d/yyyy");
        }
    }
}
