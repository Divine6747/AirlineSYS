﻿namespace AirlineSYS
{
    partial class frmUpdateBooking
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
            this.munBack = new System.Windows.Forms.Label();
            this.mnuUpdateBooking = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(740, 1);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.munBack.Size = new System.Drawing.Size(60, 20);
            this.munBack.TabIndex = 7;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // mnuUpdateBooking
            // 
            this.mnuUpdateBooking.BackColor = System.Drawing.Color.Plum;
            this.mnuUpdateBooking.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateBooking.Name = "mnuUpdateBooking";
            this.mnuUpdateBooking.Padding = new System.Windows.Forms.Padding(0);
            this.mnuUpdateBooking.Size = new System.Drawing.Size(800, 24);
            this.mnuUpdateBooking.TabIndex = 6;
            this.mnuUpdateBooking.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuUpdateBooking_ItemClicked);
            // 
            // frmUpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuUpdateBooking);
            this.Name = "frmUpdateBooking";
            this.Text = "Update Booking";
            this.Load += new System.EventHandler(this.frmUpdateBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuUpdateBooking;
    }
}