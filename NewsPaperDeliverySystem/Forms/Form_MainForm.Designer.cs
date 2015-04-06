namespace NewsPaperDeliverySystem
{
    partial class Form1
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
            this.labelDate = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.labelTodaysDeliveries = new System.Windows.Forms.Label();
            this.groupBoxDeliveryServices = new System.Windows.Forms.GroupBox();
            this.groupBoxCustomerInformation = new System.Windows.Forms.GroupBox();
            this.buttonCreateDriverRoute = new System.Windows.Forms.Button();
            this.buttonViewPastDeliveryData = new System.Windows.Forms.Button();
            this.buttonAddNewCustomer = new System.Windows.Forms.Button();
            this.buttonModifyCustomer = new System.Windows.Forms.Button();
            this.buttonModifySubscriptions = new System.Windows.Forms.Button();
            this.groupBoxDeliveryServices.SuspendLayout();
            this.groupBoxCustomerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(671, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 76);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(236, 365);
            this.treeView1.TabIndex = 1;
            // 
            // labelTodaysDeliveries
            // 
            this.labelTodaysDeliveries.AutoSize = true;
            this.labelTodaysDeliveries.Location = new System.Drawing.Point(79, 60);
            this.labelTodaysDeliveries.Name = "labelTodaysDeliveries";
            this.labelTodaysDeliveries.Size = new System.Drawing.Size(93, 13);
            this.labelTodaysDeliveries.TabIndex = 2;
            this.labelTodaysDeliveries.Text = "Today\'s Deliveries";
            // 
            // groupBoxDeliveryServices
            // 
            this.groupBoxDeliveryServices.Controls.Add(this.buttonViewPastDeliveryData);
            this.groupBoxDeliveryServices.Controls.Add(this.buttonCreateDriverRoute);
            this.groupBoxDeliveryServices.Location = new System.Drawing.Point(423, 60);
            this.groupBoxDeliveryServices.Name = "groupBoxDeliveryServices";
            this.groupBoxDeliveryServices.Size = new System.Drawing.Size(216, 151);
            this.groupBoxDeliveryServices.TabIndex = 3;
            this.groupBoxDeliveryServices.TabStop = false;
            this.groupBoxDeliveryServices.Text = "Delivery Services";
            // 
            // groupBoxCustomerInformation
            // 
            this.groupBoxCustomerInformation.Controls.Add(this.buttonModifySubscriptions);
            this.groupBoxCustomerInformation.Controls.Add(this.buttonModifyCustomer);
            this.groupBoxCustomerInformation.Controls.Add(this.buttonAddNewCustomer);
            this.groupBoxCustomerInformation.Location = new System.Drawing.Point(423, 232);
            this.groupBoxCustomerInformation.Name = "groupBoxCustomerInformation";
            this.groupBoxCustomerInformation.Size = new System.Drawing.Size(216, 161);
            this.groupBoxCustomerInformation.TabIndex = 4;
            this.groupBoxCustomerInformation.TabStop = false;
            this.groupBoxCustomerInformation.Text = "Customer Information";
            // 
            // buttonCreateDriverRoute
            // 
            this.buttonCreateDriverRoute.Location = new System.Drawing.Point(45, 42);
            this.buttonCreateDriverRoute.Name = "buttonCreateDriverRoute";
            this.buttonCreateDriverRoute.Size = new System.Drawing.Size(121, 23);
            this.buttonCreateDriverRoute.TabIndex = 0;
            this.buttonCreateDriverRoute.Text = "Create Driver Route";
            this.buttonCreateDriverRoute.UseVisualStyleBackColor = true;
            // 
            // buttonViewPastDeliveryData
            // 
            this.buttonViewPastDeliveryData.Location = new System.Drawing.Point(45, 87);
            this.buttonViewPastDeliveryData.Name = "buttonViewPastDeliveryData";
            this.buttonViewPastDeliveryData.Size = new System.Drawing.Size(121, 23);
            this.buttonViewPastDeliveryData.TabIndex = 1;
            this.buttonViewPastDeliveryData.Text = "View Past Delivery Data";
            this.buttonViewPastDeliveryData.UseVisualStyleBackColor = true;
            // 
            // buttonAddNewCustomer
            // 
            this.buttonAddNewCustomer.Location = new System.Drawing.Point(45, 20);
            this.buttonAddNewCustomer.Name = "buttonAddNewCustomer";
            this.buttonAddNewCustomer.Size = new System.Drawing.Size(121, 23);
            this.buttonAddNewCustomer.TabIndex = 0;
            this.buttonAddNewCustomer.Text = "Add New Customer";
            this.buttonAddNewCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonModifyCustomer
            // 
            this.buttonModifyCustomer.Location = new System.Drawing.Point(45, 62);
            this.buttonModifyCustomer.Name = "buttonModifyCustomer";
            this.buttonModifyCustomer.Size = new System.Drawing.Size(121, 23);
            this.buttonModifyCustomer.TabIndex = 1;
            this.buttonModifyCustomer.Text = "Modify Customer";
            this.buttonModifyCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonModifySubscriptions
            // 
            this.buttonModifySubscriptions.Location = new System.Drawing.Point(45, 103);
            this.buttonModifySubscriptions.Name = "buttonModifySubscriptions";
            this.buttonModifySubscriptions.Size = new System.Drawing.Size(121, 23);
            this.buttonModifySubscriptions.TabIndex = 2;
            this.buttonModifySubscriptions.Text = "Modify Subscriptions";
            this.buttonModifySubscriptions.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 453);
            this.Controls.Add(this.groupBoxCustomerInformation);
            this.Controls.Add(this.groupBoxDeliveryServices);
            this.Controls.Add(this.labelTodaysDeliveries);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.labelDate);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "News Paper Delivery System";
            this.groupBoxDeliveryServices.ResumeLayout(false);
            this.groupBoxCustomerInformation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label labelTodaysDeliveries;
        private System.Windows.Forms.GroupBox groupBoxDeliveryServices;
        private System.Windows.Forms.Button buttonViewPastDeliveryData;
        private System.Windows.Forms.Button buttonCreateDriverRoute;
        private System.Windows.Forms.GroupBox groupBoxCustomerInformation;
        private System.Windows.Forms.Button buttonModifySubscriptions;
        private System.Windows.Forms.Button buttonModifyCustomer;
        private System.Windows.Forms.Button buttonAddNewCustomer;
    }
}

