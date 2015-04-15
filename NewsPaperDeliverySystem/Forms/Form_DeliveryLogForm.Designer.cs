namespace NewsPaperDeliverySystem.Forms
{
    partial class Form_DeliveryLogForm
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.listViewDeliveriesOn = new System.Windows.Forms.ListView();
            this.labelDeliveriesOn = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.columnHeaderAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItemDelivered = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(79, 236);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // listViewDeliveriesOn
            // 
            this.listViewDeliveriesOn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAddress,
            this.columnHeaderItemDelivered});
            this.listViewDeliveriesOn.GridLines = true;
            this.listViewDeliveriesOn.Location = new System.Drawing.Point(435, 68);
            this.listViewDeliveriesOn.Name = "listViewDeliveriesOn";
            this.listViewDeliveriesOn.Size = new System.Drawing.Size(665, 520);
            this.listViewDeliveriesOn.TabIndex = 1;
            this.listViewDeliveriesOn.UseCompatibleStateImageBehavior = false;
            this.listViewDeliveriesOn.View = System.Windows.Forms.View.Details;
            // 
            // labelDeliveriesOn
            // 
            this.labelDeliveriesOn.AutoSize = true;
            this.labelDeliveriesOn.Location = new System.Drawing.Point(732, 52);
            this.labelDeliveriesOn.Name = "labelDeliveriesOn";
            this.labelDeliveriesOn.Size = new System.Drawing.Size(73, 13);
            this.labelDeliveriesOn.TabIndex = 2;
            this.labelDeliveriesOn.Text = "Deliveries On:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(1025, 694);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // columnHeaderAddress
            // 
            this.columnHeaderAddress.Text = "Address";
            this.columnHeaderAddress.Width = 296;
            // 
            // columnHeaderItemDelivered
            // 
            this.columnHeaderItemDelivered.Text = "Item Delivered";
            this.columnHeaderItemDelivered.Width = 333;
            // 
            // Form_DeliveryLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 729);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelDeliveriesOn);
            this.Controls.Add(this.listViewDeliveriesOn);
            this.Controls.Add(this.monthCalendar);
            this.Name = "Form_DeliveryLogForm";
            this.Text = "Delivery History Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ListView listViewDeliveriesOn;
        private System.Windows.Forms.Label labelDeliveriesOn;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderItemDelivered;
    }
}