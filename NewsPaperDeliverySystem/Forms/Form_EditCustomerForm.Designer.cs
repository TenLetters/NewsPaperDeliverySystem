namespace NewsPaperDeliverySystem.Forms
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.textBoxVacationStatus = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelVacationStatus = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxSubscriptions = new System.Windows.Forms.GroupBox();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.textBoxSubscriptionPrice = new System.Windows.Forms.TextBox();
            this.textBoxSubscriptionName = new System.Windows.Forms.TextBox();
            this.labelSubscriptionPrice = new System.Windows.Forms.Label();
            this.labelSubscriptionName = new System.Windows.Forms.Label();
            this.buttonAddSubscription = new System.Windows.Forms.Button();
            this.listViewMatchingAddress = new System.Windows.Forms.ListView();
            this.columnHeaderCustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMatchingAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewSubscriptions = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPeriod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelCustomerSubscriptions = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxVacations = new System.Windows.Forms.GroupBox();
            this.labelVacationEndDate = new System.Windows.Forms.Label();
            this.labelVacationStartDate = new System.Windows.Forms.Label();
            this.textBoxVacationEndDate = new System.Windows.Forms.TextBox();
            this.textBoxVacationStartDate = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearchForAnAddress = new System.Windows.Forms.Label();
            this.textBoxSearchAddress = new System.Windows.Forms.TextBox();
            this.groupBoxFindCustomer = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRemoveSubscription = new System.Windows.Forms.Button();
            this.groupBoxCustomerInformation.SuspendLayout();
            this.groupBoxSubscriptions.SuspendLayout();
            this.groupBoxVacations.SuspendLayout();
            this.groupBoxFindCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCustomerInformation
            // 
            this.groupBoxCustomerInformation.Controls.Add(this.label3);
            this.groupBoxCustomerInformation.Controls.Add(this.comboBoxState);
            this.groupBoxCustomerInformation.Controls.Add(this.label2);
            this.groupBoxCustomerInformation.Controls.Add(this.textBoxCity);
            this.groupBoxCustomerInformation.Controls.Add(this.label1);
            this.groupBoxCustomerInformation.Controls.Add(this.textBoxZip);
            this.groupBoxCustomerInformation.Controls.Add(this.textBoxVacationStatus);
            this.groupBoxCustomerInformation.Controls.Add(this.textBoxAddress);
            this.groupBoxCustomerInformation.Controls.Add(this.labelVacationStatus);
            this.groupBoxCustomerInformation.Controls.Add(this.labelAddress);
            this.groupBoxCustomerInformation.Controls.Add(this.labelName);
            this.groupBoxCustomerInformation.Controls.Add(this.textBoxName);
            this.groupBoxCustomerInformation.Location = new System.Drawing.Point(647, 12);
            this.groupBoxCustomerInformation.Name = "groupBoxCustomerInformation";
            this.groupBoxCustomerInformation.Size = new System.Drawing.Size(228, 208);
            this.groupBoxCustomerInformation.TabIndex = 0;
            this.groupBoxCustomerInformation.TabStop = false;
            this.groupBoxCustomerInformation.Text = "Customer Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "State";
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(100, 143);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(100, 21);
            this.comboBoxState.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "City";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(100, 117);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Zip Code";
            // 
            // textBoxZip
            // 
            this.textBoxZip.Location = new System.Drawing.Point(100, 81);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(100, 20);
            this.textBoxZip.TabIndex = 6;
            // 
            // textBoxVacationStatus
            // 
            this.textBoxVacationStatus.Location = new System.Drawing.Point(100, 176);
            this.textBoxVacationStatus.Name = "textBoxVacationStatus";
            this.textBoxVacationStatus.ReadOnly = true;
            this.textBoxVacationStatus.Size = new System.Drawing.Size(100, 20);
            this.textBoxVacationStatus.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(100, 47);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 4;
            // 
            // labelVacationStatus
            // 
            this.labelVacationStatus.AutoSize = true;
            this.labelVacationStatus.Location = new System.Drawing.Point(23, 179);
            this.labelVacationStatus.Name = "labelVacationStatus";
            this.labelVacationStatus.Size = new System.Drawing.Size(66, 13);
            this.labelVacationStatus.TabIndex = 3;
            this.labelVacationStatus.Text = "On Vacation";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(44, 50);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(47, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(100, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // groupBoxSubscriptions
            // 
            this.groupBoxSubscriptions.Controls.Add(this.comboBoxPeriod);
            this.groupBoxSubscriptions.Controls.Add(this.labelPeriod);
            this.groupBoxSubscriptions.Controls.Add(this.textBoxSubscriptionPrice);
            this.groupBoxSubscriptions.Controls.Add(this.textBoxSubscriptionName);
            this.groupBoxSubscriptions.Controls.Add(this.labelSubscriptionPrice);
            this.groupBoxSubscriptions.Controls.Add(this.labelSubscriptionName);
            this.groupBoxSubscriptions.Controls.Add(this.buttonAddSubscription);
            this.groupBoxSubscriptions.Location = new System.Drawing.Point(891, 63);
            this.groupBoxSubscriptions.Name = "groupBoxSubscriptions";
            this.groupBoxSubscriptions.Size = new System.Drawing.Size(300, 157);
            this.groupBoxSubscriptions.TabIndex = 1;
            this.groupBoxSubscriptions.TabStop = false;
            this.groupBoxSubscriptions.Text = "Subscriptions";
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Location = new System.Drawing.Point(65, 110);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(127, 21);
            this.comboBoxPeriod.TabIndex = 8;
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
            // textBoxSubscriptionPrice
            // 
            this.textBoxSubscriptionPrice.Location = new System.Drawing.Point(65, 77);
            this.textBoxSubscriptionPrice.Name = "textBoxSubscriptionPrice";
            this.textBoxSubscriptionPrice.Size = new System.Drawing.Size(127, 20);
            this.textBoxSubscriptionPrice.TabIndex = 6;
            // 
            // textBoxSubscriptionName
            // 
            this.textBoxSubscriptionName.Location = new System.Drawing.Point(65, 38);
            this.textBoxSubscriptionName.Name = "textBoxSubscriptionName";
            this.textBoxSubscriptionName.Size = new System.Drawing.Size(127, 20);
            this.textBoxSubscriptionName.TabIndex = 5;
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
            // labelSubscriptionName
            // 
            this.labelSubscriptionName.AutoSize = true;
            this.labelSubscriptionName.Location = new System.Drawing.Point(24, 41);
            this.labelSubscriptionName.Name = "labelSubscriptionName";
            this.labelSubscriptionName.Size = new System.Drawing.Size(35, 13);
            this.labelSubscriptionName.TabIndex = 3;
            this.labelSubscriptionName.Text = "Name";
            // 
            // buttonAddSubscription
            // 
            this.buttonAddSubscription.Location = new System.Drawing.Point(198, 128);
            this.buttonAddSubscription.Name = "buttonAddSubscription";
            this.buttonAddSubscription.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSubscription.TabIndex = 1;
            this.buttonAddSubscription.Text = "Add";
            this.buttonAddSubscription.UseVisualStyleBackColor = true;
            this.buttonAddSubscription.Click += new System.EventHandler(this.buttonAddSubscription_Click);
            // 
            // listViewMatchingAddress
            // 
            this.listViewMatchingAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listViewMatchingAddress.CheckBoxes = true;
            this.listViewMatchingAddress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCustomerName,
            this.columnHeaderMatchingAddress});
            this.listViewMatchingAddress.FullRowSelect = true;
            this.listViewMatchingAddress.GridLines = true;
            this.listViewMatchingAddress.Location = new System.Drawing.Point(6, 58);
            this.listViewMatchingAddress.Name = "listViewMatchingAddress";
            this.listViewMatchingAddress.Size = new System.Drawing.Size(526, 170);
            this.listViewMatchingAddress.TabIndex = 3;
            this.listViewMatchingAddress.UseCompatibleStateImageBehavior = false;
            this.listViewMatchingAddress.View = System.Windows.Forms.View.Details;
            this.listViewMatchingAddress.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewMatchingAddress_ItemChecked);
            // 
            // columnHeaderCustomerName
            // 
            this.columnHeaderCustomerName.Text = "Customer Name";
            this.columnHeaderCustomerName.Width = 192;
            // 
            // columnHeaderMatchingAddress
            // 
            this.columnHeaderMatchingAddress.Text = "Matching Address";
            this.columnHeaderMatchingAddress.Width = 188;
            // 
            // listViewSubscriptions
            // 
            this.listViewSubscriptions.CheckBoxes = true;
            this.listViewSubscriptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderPrice,
            this.columnHeaderPeriod});
            this.listViewSubscriptions.GridLines = true;
            this.listViewSubscriptions.Location = new System.Drawing.Point(12, 265);
            this.listViewSubscriptions.Name = "listViewSubscriptions";
            this.listViewSubscriptions.Size = new System.Drawing.Size(654, 326);
            this.listViewSubscriptions.TabIndex = 2;
            this.listViewSubscriptions.UseCompatibleStateImageBehavior = false;
            this.listViewSubscriptions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 119;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 139;
            // 
            // columnHeaderPeriod
            // 
            this.columnHeaderPeriod.Text = "Period";
            this.columnHeaderPeriod.Width = 153;
            // 
            // labelCustomerSubscriptions
            // 
            this.labelCustomerSubscriptions.AutoSize = true;
            this.labelCustomerSubscriptions.Location = new System.Drawing.Point(251, 249);
            this.labelCustomerSubscriptions.Name = "labelCustomerSubscriptions";
            this.labelCustomerSubscriptions.Size = new System.Drawing.Size(117, 13);
            this.labelCustomerSubscriptions.TabIndex = 3;
            this.labelCustomerSubscriptions.Text = "Customer Subscriptions";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(903, 547);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(133, 44);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBoxVacations
            // 
            this.groupBoxVacations.Controls.Add(this.labelVacationEndDate);
            this.groupBoxVacations.Controls.Add(this.labelVacationStartDate);
            this.groupBoxVacations.Controls.Add(this.textBoxVacationEndDate);
            this.groupBoxVacations.Controls.Add(this.textBoxVacationStartDate);
            this.groupBoxVacations.Controls.Add(this.monthCalendar1);
            this.groupBoxVacations.Location = new System.Drawing.Point(684, 237);
            this.groupBoxVacations.Name = "groupBoxVacations";
            this.groupBoxVacations.Size = new System.Drawing.Size(507, 304);
            this.groupBoxVacations.TabIndex = 5;
            this.groupBoxVacations.TabStop = false;
            this.groupBoxVacations.Text = "Vacations";
            // 
            // labelVacationEndDate
            // 
            this.labelVacationEndDate.AutoSize = true;
            this.labelVacationEndDate.Location = new System.Drawing.Point(94, 254);
            this.labelVacationEndDate.Name = "labelVacationEndDate";
            this.labelVacationEndDate.Size = new System.Drawing.Size(97, 13);
            this.labelVacationEndDate.TabIndex = 8;
            this.labelVacationEndDate.Text = "Vacation End Date";
            // 
            // labelVacationStartDate
            // 
            this.labelVacationStartDate.AutoSize = true;
            this.labelVacationStartDate.Location = new System.Drawing.Point(91, 205);
            this.labelVacationStartDate.Name = "labelVacationStartDate";
            this.labelVacationStartDate.Size = new System.Drawing.Size(100, 13);
            this.labelVacationStartDate.TabIndex = 7;
            this.labelVacationStartDate.Text = "Vacation Start Date";
            // 
            // textBoxVacationEndDate
            // 
            this.textBoxVacationEndDate.Location = new System.Drawing.Point(207, 251);
            this.textBoxVacationEndDate.Name = "textBoxVacationEndDate";
            this.textBoxVacationEndDate.ReadOnly = true;
            this.textBoxVacationEndDate.Size = new System.Drawing.Size(171, 20);
            this.textBoxVacationEndDate.TabIndex = 6;
            // 
            // textBoxVacationStartDate
            // 
            this.textBoxVacationStartDate.Location = new System.Drawing.Point(207, 202);
            this.textBoxVacationStartDate.Name = "textBoxVacationStartDate";
            this.textBoxVacationStartDate.ReadOnly = true;
            this.textBoxVacationStartDate.Size = new System.Drawing.Size(171, 20);
            this.textBoxVacationStartDate.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(125, 28);
            this.monthCalendar1.MaxSelectionCount = 100;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.monthCalendar1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.monthCalendar1_KeyUp);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(538, 205);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearchForAnAddress
            // 
            this.labelSearchForAnAddress.AutoSize = true;
            this.labelSearchForAnAddress.Location = new System.Drawing.Point(76, 16);
            this.labelSearchForAnAddress.Name = "labelSearchForAnAddress";
            this.labelSearchForAnAddress.Size = new System.Drawing.Size(116, 13);
            this.labelSearchForAnAddress.TabIndex = 1;
            this.labelSearchForAnAddress.Text = "Search For An Address";
            // 
            // textBoxSearchAddress
            // 
            this.textBoxSearchAddress.Location = new System.Drawing.Point(59, 32);
            this.textBoxSearchAddress.Name = "textBoxSearchAddress";
            this.textBoxSearchAddress.Size = new System.Drawing.Size(152, 20);
            this.textBoxSearchAddress.TabIndex = 0;
            // 
            // groupBoxFindCustomer
            // 
            this.groupBoxFindCustomer.Controls.Add(this.textBoxSearchAddress);
            this.groupBoxFindCustomer.Controls.Add(this.buttonSearch);
            this.groupBoxFindCustomer.Controls.Add(this.listViewMatchingAddress);
            this.groupBoxFindCustomer.Controls.Add(this.labelSearchForAnAddress);
            this.groupBoxFindCustomer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFindCustomer.Name = "groupBoxFindCustomer";
            this.groupBoxFindCustomer.Size = new System.Drawing.Size(619, 234);
            this.groupBoxFindCustomer.TabIndex = 6;
            this.groupBoxFindCustomer.TabStop = false;
            this.groupBoxFindCustomer.Text = "Find Customer To Edit";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(1058, 547);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 44);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRemoveSubscription
            // 
            this.buttonRemoveSubscription.Location = new System.Drawing.Point(534, 523);
            this.buttonRemoveSubscription.Name = "buttonRemoveSubscription";
            this.buttonRemoveSubscription.Size = new System.Drawing.Size(123, 58);
            this.buttonRemoveSubscription.TabIndex = 8;
            this.buttonRemoveSubscription.Text = "Remove Checked Subscriptions";
            this.buttonRemoveSubscription.UseVisualStyleBackColor = true;
            this.buttonRemoveSubscription.Click += new System.EventHandler(this.buttonRemoveSubscription_Click);
            // 
            // Form_EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 603);
            this.Controls.Add(this.buttonRemoveSubscription);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxFindCustomer);
            this.Controls.Add(this.groupBoxVacations);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelCustomerSubscriptions);
            this.Controls.Add(this.listViewSubscriptions);
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
            this.groupBoxFindCustomer.ResumeLayout(false);
            this.groupBoxFindCustomer.PerformLayout();
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
        private System.Windows.Forms.ListView listViewSubscriptions;
        private System.Windows.Forms.Label labelCustomerSubscriptions;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxVacations;
        private System.Windows.Forms.Label labelVacationEndDate;
        private System.Windows.Forms.Label labelVacationStartDate;
        private System.Windows.Forms.TextBox textBoxVacationEndDate;
        private System.Windows.Forms.TextBox textBoxVacationStartDate;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListView listViewMatchingAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderMatchingAddress;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearchForAnAddress;
        private System.Windows.Forms.TextBox textBoxSearchAddress;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.TextBox textBoxSubscriptionPrice;
        private System.Windows.Forms.TextBox textBoxSubscriptionName;
        private System.Windows.Forms.Label labelSubscriptionPrice;
        private System.Windows.Forms.Label labelSubscriptionName;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderPeriod;
        private System.Windows.Forms.GroupBox groupBoxFindCustomer;
        private System.Windows.Forms.ColumnHeader columnHeaderCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRemoveSubscription;
    }
}