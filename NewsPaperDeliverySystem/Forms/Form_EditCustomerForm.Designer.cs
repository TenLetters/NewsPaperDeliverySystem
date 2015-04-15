﻿namespace NewsPaperDeliverySystem.Forms
{
    partial class Form_EditCustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCustomerInformation = new System.Windows.Forms.GroupBox();
            this.textBoxVacationStatus = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelVacationStatus = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxSubscriptions = new System.Windows.Forms.GroupBox();
            this.buttonAddSubscription = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelCustomerSubscriptions = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxVacations = new System.Windows.Forms.GroupBox();
            this.labelVacationEndDate = new System.Windows.Forms.Label();
            this.labelVacationStartDate = new System.Windows.Forms.Label();
            this.textBoxVacationEndDate = new System.Windows.Forms.TextBox();
            this.textBoxVacationStartDate = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeaderMatchingAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearchForAnAddress = new System.Windows.Forms.Label();
            this.textBoxSearchAddress = new System.Windows.Forms.TextBox();
            this.labelSubscriptionName = new System.Windows.Forms.Label();
            this.labelSubscriptionPrice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.groupBoxCustomerInformation.SuspendLayout();
            this.groupBoxSubscriptions.SuspendLayout();
            this.groupBoxVacations.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCustomerInformation
            // 
            this.groupBoxCustomerInformation.Controls.Add(this.textBoxVacationStatus);
            this.groupBoxCustomerInformation.Controls.Add(this.textBoxAddress);
            this.groupBoxCustomerInformation.Controls.Add(this.labelVacationStatus);
            this.groupBoxCustomerInformation.Controls.Add(this.labelAddress);
            this.groupBoxCustomerInformation.Controls.Add(this.labelName);
            this.groupBoxCustomerInformation.Controls.Add(this.textBoxName);
            this.groupBoxCustomerInformation.Location = new System.Drawing.Point(75, 63);
            this.groupBoxCustomerInformation.Name = "groupBoxCustomerInformation";
            this.groupBoxCustomerInformation.Size = new System.Drawing.Size(228, 157);
            this.groupBoxCustomerInformation.TabIndex = 0;
            this.groupBoxCustomerInformation.TabStop = false;
            this.groupBoxCustomerInformation.Text = "Customer Information";
            // 
            // textBoxVacationStatus
            // 
            this.textBoxVacationStatus.Location = new System.Drawing.Point(100, 107);
            this.textBoxVacationStatus.Name = "textBoxVacationStatus";
            this.textBoxVacationStatus.Size = new System.Drawing.Size(100, 20);
            this.textBoxVacationStatus.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(100, 74);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 4;
            // 
            // labelVacationStatus
            // 
            this.labelVacationStatus.AutoSize = true;
            this.labelVacationStatus.Location = new System.Drawing.Point(28, 110);
            this.labelVacationStatus.Name = "labelVacationStatus";
            this.labelVacationStatus.Size = new System.Drawing.Size(66, 13);
            this.labelVacationStatus.TabIndex = 3;
            this.labelVacationStatus.Text = "On Vacation";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(35, 77);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(45, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.Name_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(100, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // groupBoxSubscriptions
            // 
            this.groupBoxSubscriptions.Controls.Add(this.comboBoxPeriod);
            this.groupBoxSubscriptions.Controls.Add(this.labelPeriod);
            this.groupBoxSubscriptions.Controls.Add(this.textBox2);
            this.groupBoxSubscriptions.Controls.Add(this.textBox1);
            this.groupBoxSubscriptions.Controls.Add(this.labelSubscriptionPrice);
            this.groupBoxSubscriptions.Controls.Add(this.labelSubscriptionName);
            this.groupBoxSubscriptions.Controls.Add(this.buttonAddSubscription);
            this.groupBoxSubscriptions.Location = new System.Drawing.Point(330, 63);
            this.groupBoxSubscriptions.Name = "groupBoxSubscriptions";
            this.groupBoxSubscriptions.Size = new System.Drawing.Size(297, 157);
            this.groupBoxSubscriptions.TabIndex = 1;
            this.groupBoxSubscriptions.TabStop = false;
            this.groupBoxSubscriptions.Text = "Subscriptions";
            // 
            // buttonAddSubscription
            // 
            this.buttonAddSubscription.Location = new System.Drawing.Point(216, 128);
            this.buttonAddSubscription.Name = "buttonAddSubscription";
            this.buttonAddSubscription.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSubscription.TabIndex = 1;
            this.buttonAddSubscription.Text = "Add";
            this.buttonAddSubscription.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(75, 265);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(591, 276);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // labelCustomerSubscriptions
            // 
            this.labelCustomerSubscriptions.AutoSize = true;
            this.labelCustomerSubscriptions.Location = new System.Drawing.Point(306, 237);
            this.labelCustomerSubscriptions.Name = "labelCustomerSubscriptions";
            this.labelCustomerSubscriptions.Size = new System.Drawing.Size(117, 13);
            this.labelCustomerSubscriptions.TabIndex = 3;
            this.labelCustomerSubscriptions.Text = "Customer Subscriptions";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(1058, 547);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(133, 44);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // groupBoxVacations
            // 
            this.groupBoxVacations.Controls.Add(this.labelVacationEndDate);
            this.groupBoxVacations.Controls.Add(this.labelVacationStartDate);
            this.groupBoxVacations.Controls.Add(this.textBoxVacationEndDate);
            this.groupBoxVacations.Controls.Add(this.textBoxVacationStartDate);
            this.groupBoxVacations.Controls.Add(this.monthCalendar1);
            this.groupBoxVacations.Controls.Add(this.listView2);
            this.groupBoxVacations.Controls.Add(this.buttonSearch);
            this.groupBoxVacations.Controls.Add(this.labelSearchForAnAddress);
            this.groupBoxVacations.Controls.Add(this.textBoxSearchAddress);
            this.groupBoxVacations.Location = new System.Drawing.Point(673, 63);
            this.groupBoxVacations.Name = "groupBoxVacations";
            this.groupBoxVacations.Size = new System.Drawing.Size(518, 478);
            this.groupBoxVacations.TabIndex = 5;
            this.groupBoxVacations.TabStop = false;
            this.groupBoxVacations.Text = "Vacations";
            // 
            // labelVacationEndDate
            // 
            this.labelVacationEndDate.AutoSize = true;
            this.labelVacationEndDate.Location = new System.Drawing.Point(224, 345);
            this.labelVacationEndDate.Name = "labelVacationEndDate";
            this.labelVacationEndDate.Size = new System.Drawing.Size(97, 13);
            this.labelVacationEndDate.TabIndex = 8;
            this.labelVacationEndDate.Text = "Vacation End Date";
            // 
            // labelVacationStartDate
            // 
            this.labelVacationStartDate.AutoSize = true;
            this.labelVacationStartDate.Location = new System.Drawing.Point(221, 287);
            this.labelVacationStartDate.Name = "labelVacationStartDate";
            this.labelVacationStartDate.Size = new System.Drawing.Size(100, 13);
            this.labelVacationStartDate.TabIndex = 7;
            this.labelVacationStartDate.Text = "Vacation Start Date";
            // 
            // textBoxVacationEndDate
            // 
            this.textBoxVacationEndDate.Location = new System.Drawing.Point(327, 342);
            this.textBoxVacationEndDate.Name = "textBoxVacationEndDate";
            this.textBoxVacationEndDate.Size = new System.Drawing.Size(171, 20);
            this.textBoxVacationEndDate.TabIndex = 6;
            // 
            // textBoxVacationStartDate
            // 
            this.textBoxVacationStartDate.Location = new System.Drawing.Point(327, 284);
            this.textBoxVacationStartDate.Name = "textBoxVacationStartDate";
            this.textBoxVacationStartDate.Size = new System.Drawing.Size(171, 20);
            this.textBoxVacationStartDate.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(246, 67);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMatchingAddress});
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(6, 110);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(195, 362);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeaderMatchingAddress
            // 
            this.columnHeaderMatchingAddress.Text = "Matching Address";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(54, 67);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // labelSearchForAnAddress
            // 
            this.labelSearchForAnAddress.AutoSize = true;
            this.labelSearchForAnAddress.Location = new System.Drawing.Point(35, 16);
            this.labelSearchForAnAddress.Name = "labelSearchForAnAddress";
            this.labelSearchForAnAddress.Size = new System.Drawing.Size(116, 13);
            this.labelSearchForAnAddress.TabIndex = 1;
            this.labelSearchForAnAddress.Text = "Search For An Address";
            // 
            // textBoxSearchAddress
            // 
            this.textBoxSearchAddress.Location = new System.Drawing.Point(20, 41);
            this.textBoxSearchAddress.Name = "textBoxSearchAddress";
            this.textBoxSearchAddress.Size = new System.Drawing.Size(152, 20);
            this.textBoxSearchAddress.TabIndex = 0;
            // 
            // labelSubscriptionName
            // 
            this.labelSubscriptionName.AutoSize = true;
            this.labelSubscriptionName.Location = new System.Drawing.Point(24, 41);
            this.labelSubscriptionName.Name = "labelSubscriptionName";
            this.labelSubscriptionName.Size = new System.Drawing.Size(35, 13);
            this.labelSubscriptionName.TabIndex = 3;
            this.labelSubscriptionName.Text = "Name";
            // 
            // labelSubscriptionPrice
            // 
            this.labelSubscriptionPrice.AutoSize = true;
            this.labelSubscriptionPrice.Location = new System.Drawing.Point(28, 84);
            this.labelSubscriptionPrice.Name = "labelSubscriptionPrice";
            this.labelSubscriptionPrice.Size = new System.Drawing.Size(31, 13);
            this.labelSubscriptionPrice.TabIndex = 4;
            this.labelSubscriptionPrice.Text = "Price";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 6;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(23, 113);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(37, 13);
            this.labelPeriod.TabIndex = 7;
            this.labelPeriod.Text = "Period";
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Location = new System.Drawing.Point(65, 110);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(127, 21);
            this.comboBoxPeriod.TabIndex = 8;
            // 
            // Form_EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 603);
            this.Controls.Add(this.groupBoxVacations);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelCustomerSubscriptions);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBoxSubscriptions);
            this.Controls.Add(this.groupBoxCustomerInformation);
            this.Name = "Form_EditCustomerForm";
            this.Text = "Edit Customer";
            this.groupBoxCustomerInformation.ResumeLayout(false);
            this.groupBoxCustomerInformation.PerformLayout();
            this.groupBoxSubscriptions.ResumeLayout(false);
            this.groupBoxSubscriptions.PerformLayout();
            this.groupBoxVacations.ResumeLayout(false);
            this.groupBoxVacations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCustomerInformation;
        private System.Windows.Forms.TextBox textBoxVacationStatus;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelVacationStatus;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxSubscriptions;
        private System.Windows.Forms.Button buttonAddSubscription;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelCustomerSubscriptions;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxVacations;
        private System.Windows.Forms.Label labelVacationEndDate;
        private System.Windows.Forms.Label labelVacationStartDate;
        private System.Windows.Forms.TextBox textBoxVacationEndDate;
        private System.Windows.Forms.TextBox textBoxVacationStartDate;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeaderMatchingAddress;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearchForAnAddress;
        private System.Windows.Forms.TextBox textBoxSearchAddress;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelSubscriptionPrice;
        private System.Windows.Forms.Label labelSubscriptionName;
    }
}