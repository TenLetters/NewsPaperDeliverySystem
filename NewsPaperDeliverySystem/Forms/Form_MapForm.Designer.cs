﻿namespace NewsPaperDeliverySystem.Forms
{
    partial class Form_MapForm
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
            this.webKitBrowser = new WebKit.WebKitBrowser();
            this.SuspendLayout();
            // 
            // webKitBrowser
            // 
            this.webKitBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.webKitBrowser.BackColor = System.Drawing.Color.White;
            this.webKitBrowser.Location = new System.Drawing.Point(0, 4);
            this.webKitBrowser.Name = "webKitBrowser";
            this.webKitBrowser.Size = new System.Drawing.Size(969, 668);
            this.webKitBrowser.TabIndex = 0;
            this.webKitBrowser.Url = null;
            // 
            // Form_MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 684);
            this.Controls.Add(this.webKitBrowser);
            this.Name = "Form_MapForm";
            this.Text = "Map";
            this.ResumeLayout(false);

        }

        #endregion

        private WebKit.WebKitBrowser webKitBrowser;

    }
}