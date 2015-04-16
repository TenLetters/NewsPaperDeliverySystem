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
            this.labelDeliveriesOn = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.labelSelectADate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(79, 236);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // labelDeliveriesOn
            // 
            this.labelDeliveriesOn.AutoSize = true;
            this.labelDeliveriesOn.Location = new System.Drawing.Point(685, 67);
            this.labelDeliveriesOn.Name = "labelDeliveriesOn";
            this.labelDeliveriesOn.Size = new System.Drawing.Size(73, 13);
            this.labelDeliveriesOn.TabIndex = 2;
            this.labelDeliveriesOn.Text = "Deliveries On:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(1025, 669);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(353, 83);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(747, 563);
            this.treeView1.TabIndex = 4;
            // 
            // labelSelectADate
            // 
            this.labelSelectADate.AutoSize = true;
            this.labelSelectADate.Location = new System.Drawing.Point(156, 214);
            this.labelSelectADate.Name = "labelSelectADate";
            this.labelSelectADate.Size = new System.Drawing.Size(70, 13);
            this.labelSelectADate.TabIndex = 5;
            this.labelSelectADate.Text = "Select a date";
            // 
            // Form_DeliveryLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 704);
            this.Controls.Add(this.labelSelectADate);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelDeliveriesOn);
            this.Controls.Add(this.monthCalendar);
            this.Name = "Form_DeliveryLogForm";
            this.Text = "Delivery History Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label labelDeliveriesOn;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label labelSelectADate;
    }
}