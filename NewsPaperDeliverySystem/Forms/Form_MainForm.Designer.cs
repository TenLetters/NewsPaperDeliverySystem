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
            this.treeViewTodaysDeliveries = new System.Windows.Forms.TreeView();
            this.labelTodaysDeliveries = new System.Windows.Forms.Label();
            this.groupBoxDeliveryServices = new System.Windows.Forms.GroupBox();
            this.buttonViewPastDeliveryData = new System.Windows.Forms.Button();
            this.buttonCreateDriverRoute = new System.Windows.Forms.Button();
            this.groupBoxCustomerInformation = new System.Windows.Forms.GroupBox();
            this.buttonSaveCustomerInformation = new System.Windows.Forms.Button();
            this.buttonModifyCustomer = new System.Windows.Forms.Button();
            this.buttonAddNewCustomer = new System.Windows.Forms.Button();
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
            // treeViewTodaysDeliveries
            // 
            this.treeViewTodaysDeliveries.Location = new System.Drawing.Point(12, 76);
            this.treeViewTodaysDeliveries.Name = "treeViewTodaysDeliveries";
            this.treeViewTodaysDeliveries.Size = new System.Drawing.Size(236, 365);
            this.treeViewTodaysDeliveries.TabIndex = 1;
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
            // buttonViewPastDeliveryData
            // 
            this.buttonViewPastDeliveryData.Location = new System.Drawing.Point(27, 87);
            this.buttonViewPastDeliveryData.Name = "buttonViewPastDeliveryData";
            this.buttonViewPastDeliveryData.Size = new System.Drawing.Size(156, 23);
            this.buttonViewPastDeliveryData.TabIndex = 1;
            this.buttonViewPastDeliveryData.Text = "View Past Delivery Data";
            this.buttonViewPastDeliveryData.UseVisualStyleBackColor = true;
            this.buttonViewPastDeliveryData.Click += new System.EventHandler(this.buttonViewPastDeliveryData_Click);
            // 
            // buttonCreateDriverRoute
            // 
            this.buttonCreateDriverRoute.Location = new System.Drawing.Point(27, 42);
            this.buttonCreateDriverRoute.Name = "buttonCreateDriverRoute";
            this.buttonCreateDriverRoute.Size = new System.Drawing.Size(156, 23);
            this.buttonCreateDriverRoute.TabIndex = 0;
            this.buttonCreateDriverRoute.Text = "Create Driver Route";
            this.buttonCreateDriverRoute.UseVisualStyleBackColor = true;
            // 
            // groupBoxCustomerInformation
            // 
            this.groupBoxCustomerInformation.Controls.Add(this.buttonSaveCustomerInformation);
            this.groupBoxCustomerInformation.Controls.Add(this.buttonModifyCustomer);
            this.groupBoxCustomerInformation.Controls.Add(this.buttonAddNewCustomer);
            this.groupBoxCustomerInformation.Location = new System.Drawing.Point(423, 232);
            this.groupBoxCustomerInformation.Name = "groupBoxCustomerInformation";
            this.groupBoxCustomerInformation.Size = new System.Drawing.Size(216, 156);
            this.groupBoxCustomerInformation.TabIndex = 4;
            this.groupBoxCustomerInformation.TabStop = false;
            this.groupBoxCustomerInformation.Text = "Customer Information";
            // 
            // buttonSaveCustomerInformation
            // 
            this.buttonSaveCustomerInformation.Location = new System.Drawing.Point(27, 110);
            this.buttonSaveCustomerInformation.Name = "buttonSaveCustomerInformation";
            this.buttonSaveCustomerInformation.Size = new System.Drawing.Size(156, 23);
            this.buttonSaveCustomerInformation.TabIndex = 3;
            this.buttonSaveCustomerInformation.Text = "Save Customer Information";
            this.buttonSaveCustomerInformation.UseVisualStyleBackColor = true;
            this.buttonSaveCustomerInformation.Click += new System.EventHandler(this.buttonSaveCustomerInformation_Click);
            // 
            // buttonModifyCustomer
            // 
            this.buttonModifyCustomer.Location = new System.Drawing.Point(27, 63);
            this.buttonModifyCustomer.Name = "buttonModifyCustomer";
            this.buttonModifyCustomer.Size = new System.Drawing.Size(156, 23);
            this.buttonModifyCustomer.TabIndex = 1;
            this.buttonModifyCustomer.Text = "Modify Customer";
            this.buttonModifyCustomer.UseVisualStyleBackColor = true;
            this.buttonModifyCustomer.Click += new System.EventHandler(this.buttonModifyCustomer_Click);
            // 
            // buttonAddNewCustomer
            // 
            this.buttonAddNewCustomer.Location = new System.Drawing.Point(27, 19);
            this.buttonAddNewCustomer.Name = "buttonAddNewCustomer";
            this.buttonAddNewCustomer.Size = new System.Drawing.Size(156, 23);
            this.buttonAddNewCustomer.TabIndex = 0;
            this.buttonAddNewCustomer.Text = "Add New Customer";
            this.buttonAddNewCustomer.UseVisualStyleBackColor = true;
            this.buttonAddNewCustomer.Click += new System.EventHandler(this.buttonAddNewCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 453);
            this.Controls.Add(this.groupBoxCustomerInformation);
            this.Controls.Add(this.groupBoxDeliveryServices);
            this.Controls.Add(this.labelTodaysDeliveries);
            this.Controls.Add(this.treeViewTodaysDeliveries);
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
        private System.Windows.Forms.TreeView treeViewTodaysDeliveries;
        private System.Windows.Forms.Label labelTodaysDeliveries;
        private System.Windows.Forms.GroupBox groupBoxDeliveryServices;
        private System.Windows.Forms.Button buttonViewPastDeliveryData;
        private System.Windows.Forms.Button buttonCreateDriverRoute;
        private System.Windows.Forms.GroupBox groupBoxCustomerInformation;
        private System.Windows.Forms.Button buttonModifyCustomer;
        private System.Windows.Forms.Button buttonAddNewCustomer;
        private System.Windows.Forms.Button buttonSaveCustomerInformation;
    }
}

