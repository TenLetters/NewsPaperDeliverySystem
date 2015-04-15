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
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelSubscriptions = new System.Windows.Forms.Label();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeliveryPeriod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelAddSubscription = new System.Windows.Forms.Label();
            this.comboBoxAddSubscription = new System.Windows.Forms.ComboBox();
            this.buttonAddSubscription = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(89, 76);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(89, 120);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderCost,
            this.columnHeaderDeliveryPeriod});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 258);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(508, 298);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // labelSubscriptions
            // 
            this.labelSubscriptions.AutoSize = true;
            this.labelSubscriptions.Location = new System.Drawing.Point(218, 242);
            this.labelSubscriptions.Name = "labelSubscriptions";
            this.labelSubscriptions.Size = new System.Drawing.Size(70, 13);
            this.labelSubscriptions.TabIndex = 5;
            this.labelSubscriptions.Text = "Subscriptions";
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            // 
            // columnHeaderCost
            // 
            this.columnHeaderCost.Text = "Cost";
            // 
            // columnHeaderDeliveryPeriod
            // 
            this.columnHeaderDeliveryPeriod.Text = "Delivery Period";
            // 
            // labelAddSubscription
            // 
            this.labelAddSubscription.AutoSize = true;
            this.labelAddSubscription.Location = new System.Drawing.Point(695, 258);
            this.labelAddSubscription.Name = "labelAddSubscription";
            this.labelAddSubscription.Size = new System.Drawing.Size(87, 13);
            this.labelAddSubscription.TabIndex = 6;
            this.labelAddSubscription.Text = "Add Subscription";
            // 
            // comboBoxAddSubscription
            // 
            this.comboBoxAddSubscription.FormattingEnabled = true;
            this.comboBoxAddSubscription.Location = new System.Drawing.Point(689, 293);
            this.comboBoxAddSubscription.Name = "comboBoxAddSubscription";
            this.comboBoxAddSubscription.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAddSubscription.TabIndex = 7;
            // 
            // buttonAddSubscription
            // 
            this.buttonAddSubscription.Location = new System.Drawing.Point(698, 320);
            this.buttonAddSubscription.Name = "buttonAddSubscription";
            this.buttonAddSubscription.Size = new System.Drawing.Size(96, 23);
            this.buttonAddSubscription.TabIndex = 8;
            this.buttonAddSubscription.Text = "Add Subscription";
            this.buttonAddSubscription.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(832, 533);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // Form_AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 568);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonAddSubscription);
            this.Controls.Add(this.comboBoxAddSubscription);
            this.Controls.Add(this.labelAddSubscription);
            this.Controls.Add(this.labelSubscriptions);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Name = "Form_AddCustomerForm";
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderCost;
        private System.Windows.Forms.ColumnHeader columnHeaderDeliveryPeriod;
        private System.Windows.Forms.Label labelSubscriptions;
        private System.Windows.Forms.Label labelAddSubscription;
        private System.Windows.Forms.ComboBox comboBoxAddSubscription;
        private System.Windows.Forms.Button buttonAddSubscription;
        private System.Windows.Forms.Button buttonOK;
    }
}