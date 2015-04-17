namespace NewsPaperDeliverySystem.Forms
{
    partial class Form_AddCustomerForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.listViewSubscriptions = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeliveryPeriod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSubscriptions = new System.Windows.Forms.Label();
            this.buttonAddSubscription = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxCustomerInformation = new System.Windows.Forms.GroupBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.groupBoxAddSubscriptions = new System.Windows.Forms.GroupBox();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.textBoxSubscriptionName = new System.Windows.Forms.TextBox();
            this.textBoxSubscriptionPrice = new System.Windows.Forms.TextBox();
            this.labelSubscriptionPeriod = new System.Windows.Forms.Label();
            this.labelSubscriptionPrice = new System.Windows.Forms.Label();
            this.labelSubscriptionName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.groupBoxCustomerInformation.SuspendLayout();
            this.groupBoxAddSubscriptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(128, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(129, 58);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(35, 13);
            this.labelStreet.TabIndex = 1;
            this.labelStreet.Text = "Street";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(169, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(169, 55);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(200, 20);
            this.textBoxStreet.TabIndex = 3;
            // 
            // listViewSubscriptions
            // 
            this.listViewSubscriptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderCost,
            this.columnHeaderDeliveryPeriod});
            this.listViewSubscriptions.GridLines = true;
            this.listViewSubscriptions.Location = new System.Drawing.Point(12, 258);
            this.listViewSubscriptions.Name = "listViewSubscriptions";
            this.listViewSubscriptions.Size = new System.Drawing.Size(693, 298);
            this.listViewSubscriptions.TabIndex = 4;
            this.listViewSubscriptions.UseCompatibleStateImageBehavior = false;
            this.listViewSubscriptions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 119;
            // 
            // columnHeaderCost
            // 
            this.columnHeaderCost.Text = "Cost";
            this.columnHeaderCost.Width = 85;
            // 
            // columnHeaderDeliveryPeriod
            // 
            this.columnHeaderDeliveryPeriod.Text = "Delivery Period";
            this.columnHeaderDeliveryPeriod.Width = 138;
            // 
            // labelSubscriptions
            // 
            this.labelSubscriptions.AutoSize = true;
            this.labelSubscriptions.Location = new System.Drawing.Point(368, 242);
            this.labelSubscriptions.Name = "labelSubscriptions";
            this.labelSubscriptions.Size = new System.Drawing.Size(70, 13);
            this.labelSubscriptions.TabIndex = 5;
            this.labelSubscriptions.Text = "Subscriptions";
            // 
            // buttonAddSubscription
            // 
            this.buttonAddSubscription.Location = new System.Drawing.Point(210, 146);
            this.buttonAddSubscription.Name = "buttonAddSubscription";
            this.buttonAddSubscription.Size = new System.Drawing.Size(96, 23);
            this.buttonAddSubscription.TabIndex = 8;
            this.buttonAddSubscription.Text = "Add Subscription";
            this.buttonAddSubscription.UseVisualStyleBackColor = true;
            this.buttonAddSubscription.Click += new System.EventHandler(this.buttonAddSubscription_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(742, 522);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBoxCustomerInformation
            // 
            this.groupBoxCustomerInformation.Controls.Add(this.comboBoxState);
            this.groupBoxCustomerInformation.Controls.Add(this.textBoxCity);
            this.groupBoxCustomerInformation.Controls.Add(this.textBoxZip);
            this.groupBoxCustomerInformation.Controls.Add(this.labelState);
            this.groupBoxCustomerInformation.Controls.Add(this.labelCity);
            this.groupBoxCustomerInformation.Controls.Add(this.labelZip);
            this.groupBoxCustomerInformation.Controls.Add(this.textBoxName);
            this.groupBoxCustomerInformation.Controls.Add(this.labelName);
            this.groupBoxCustomerInformation.Controls.Add(this.textBoxStreet);
            this.groupBoxCustomerInformation.Controls.Add(this.labelStreet);
            this.groupBoxCustomerInformation.Location = new System.Drawing.Point(12, 24);
            this.groupBoxCustomerInformation.Name = "groupBoxCustomerInformation";
            this.groupBoxCustomerInformation.Size = new System.Drawing.Size(508, 175);
            this.groupBoxCustomerInformation.TabIndex = 10;
            this.groupBoxCustomerInformation.TabStop = false;
            this.groupBoxCustomerInformation.Text = "Customer Information";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(169, 120);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(200, 20);
            this.textBoxCity.TabIndex = 8;
            // 
            // textBoxZip
            // 
            this.textBoxZip.Location = new System.Drawing.Point(169, 88);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(200, 20);
            this.textBoxZip.TabIndex = 7;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(129, 151);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(32, 13);
            this.labelState.TabIndex = 6;
            this.labelState.Text = "State";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(128, 123);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "City";
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(113, 91);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(50, 13);
            this.labelZip.TabIndex = 4;
            this.labelZip.Text = "Zip Code";
            // 
            // groupBoxAddSubscriptions
            // 
            this.groupBoxAddSubscriptions.Controls.Add(this.comboBoxPeriod);
            this.groupBoxAddSubscriptions.Controls.Add(this.textBoxSubscriptionName);
            this.groupBoxAddSubscriptions.Controls.Add(this.textBoxSubscriptionPrice);
            this.groupBoxAddSubscriptions.Controls.Add(this.labelSubscriptionPeriod);
            this.groupBoxAddSubscriptions.Controls.Add(this.labelSubscriptionPrice);
            this.groupBoxAddSubscriptions.Controls.Add(this.labelSubscriptionName);
            this.groupBoxAddSubscriptions.Controls.Add(this.buttonAddSubscription);
            this.groupBoxAddSubscriptions.Location = new System.Drawing.Point(595, 24);
            this.groupBoxAddSubscriptions.Name = "groupBoxAddSubscriptions";
            this.groupBoxAddSubscriptions.Size = new System.Drawing.Size(312, 175);
            this.groupBoxAddSubscriptions.TabIndex = 11;
            this.groupBoxAddSubscriptions.TabStop = false;
            this.groupBoxAddSubscriptions.Text = "Add Subscriptions";
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Location = new System.Drawing.Point(114, 87);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(161, 21);
            this.comboBoxPeriod.TabIndex = 15;
            // 
            // textBoxSubscriptionName
            // 
            this.textBoxSubscriptionName.Location = new System.Drawing.Point(114, 20);
            this.textBoxSubscriptionName.Name = "textBoxSubscriptionName";
            this.textBoxSubscriptionName.Size = new System.Drawing.Size(161, 20);
            this.textBoxSubscriptionName.TabIndex = 14;
            // 
            // textBoxSubscriptionPrice
            // 
            this.textBoxSubscriptionPrice.Location = new System.Drawing.Point(114, 55);
            this.textBoxSubscriptionPrice.Name = "textBoxSubscriptionPrice";
            this.textBoxSubscriptionPrice.Size = new System.Drawing.Size(161, 20);
            this.textBoxSubscriptionPrice.TabIndex = 13;
            // 
            // labelSubscriptionPeriod
            // 
            this.labelSubscriptionPeriod.AutoSize = true;
            this.labelSubscriptionPeriod.Location = new System.Drawing.Point(59, 96);
            this.labelSubscriptionPeriod.Name = "labelSubscriptionPeriod";
            this.labelSubscriptionPeriod.Size = new System.Drawing.Size(37, 13);
            this.labelSubscriptionPeriod.TabIndex = 11;
            this.labelSubscriptionPeriod.Text = "Period";
            // 
            // labelSubscriptionPrice
            // 
            this.labelSubscriptionPrice.AutoSize = true;
            this.labelSubscriptionPrice.Location = new System.Drawing.Point(59, 58);
            this.labelSubscriptionPrice.Name = "labelSubscriptionPrice";
            this.labelSubscriptionPrice.Size = new System.Drawing.Size(31, 13);
            this.labelSubscriptionPrice.TabIndex = 10;
            this.labelSubscriptionPrice.Text = "Price";
            // 
            // labelSubscriptionName
            // 
            this.labelSubscriptionName.AutoSize = true;
            this.labelSubscriptionName.Location = new System.Drawing.Point(55, 23);
            this.labelSubscriptionName.Name = "labelSubscriptionName";
            this.labelSubscriptionName.Size = new System.Drawing.Size(35, 13);
            this.labelSubscriptionName.TabIndex = 9;
            this.labelSubscriptionName.Text = "Name";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(832, 522);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(168, 146);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(201, 21);
            this.comboBoxState.TabIndex = 9;
            // 
            // Form_AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 568);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxAddSubscriptions);
            this.Controls.Add(this.groupBoxCustomerInformation);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelSubscriptions);
            this.Controls.Add(this.listViewSubscriptions);
            this.Name = "Form_AddCustomerForm";
            this.Text = "Add Customer";
            this.groupBoxCustomerInformation.ResumeLayout(false);
            this.groupBoxCustomerInformation.PerformLayout();
            this.groupBoxAddSubscriptions.ResumeLayout(false);
            this.groupBoxAddSubscriptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.ListView listViewSubscriptions;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderCost;
        private System.Windows.Forms.ColumnHeader columnHeaderDeliveryPeriod;
        private System.Windows.Forms.Label labelSubscriptions;
        private System.Windows.Forms.Button buttonAddSubscription;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxCustomerInformation;
        private System.Windows.Forms.GroupBox groupBoxAddSubscriptions;
        private System.Windows.Forms.TextBox textBoxSubscriptionName;
        private System.Windows.Forms.TextBox textBoxSubscriptionPrice;
        private System.Windows.Forms.Label labelSubscriptionPeriod;
        private System.Windows.Forms.Label labelSubscriptionPrice;
        private System.Windows.Forms.Label labelSubscriptionName;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.ComboBox comboBoxState;
    }
}