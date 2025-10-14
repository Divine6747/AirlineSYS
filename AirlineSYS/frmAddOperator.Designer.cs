﻿namespace AirlineSYS
{
    partial class frmAddOperator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOperator));
            this.mnuAddOperator = new System.Windows.Forms.MenuStrip();
            this.btnOperatorConfirm = new System.Windows.Forms.Button();
            this.grpOperatorDetails = new System.Windows.Forms.GroupBox();
            this.grpAirportAddress = new System.Windows.Forms.GroupBox();
            this.txtOperatorCountry = new System.Windows.Forms.TextBox();
            this.lblOperatorCountry = new System.Windows.Forms.Label();
            this.lblOperatorCity = new System.Windows.Forms.Label();
            this.txtOperatorCity = new System.Windows.Forms.TextBox();
            this.txtOperatorName = new System.Windows.Forms.TextBox();
            this.lblOperatorName = new System.Windows.Forms.Label();
            this.txtOperatorCode = new System.Windows.Forms.TextBox();
            this.lblOperatorCode = new System.Windows.Forms.Label();
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.munBack = new System.Windows.Forms.Label();
            this.grpOperatorDetails.SuspendLayout();
            this.grpAirportAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAddOperator
            // 
            this.mnuAddOperator.BackColor = System.Drawing.Color.Plum;
            this.mnuAddOperator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAddOperator.Location = new System.Drawing.Point(0, 0);
            this.mnuAddOperator.Name = "mnuAddOperator";
            this.mnuAddOperator.Padding = new System.Windows.Forms.Padding(0);
            this.mnuAddOperator.Size = new System.Drawing.Size(1067, 24);
            this.mnuAddOperator.TabIndex = 4;
            // 
            // btnOperatorConfirm
            // 
            this.btnOperatorConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnOperatorConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperatorConfirm.Location = new System.Drawing.Point(414, 406);
            this.btnOperatorConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnOperatorConfirm.Name = "btnOperatorConfirm";
            this.btnOperatorConfirm.Size = new System.Drawing.Size(232, 47);
            this.btnOperatorConfirm.TabIndex = 13;
            this.btnOperatorConfirm.Text = "CONFIRM";
            this.btnOperatorConfirm.UseVisualStyleBackColor = false;
            this.btnOperatorConfirm.Click += new System.EventHandler(this.btnOperatorConfirm_Click);
            // 
            // grpOperatorDetails
            // 
            this.grpOperatorDetails.Controls.Add(this.grpAirportAddress);
            this.grpOperatorDetails.Controls.Add(this.txtOperatorName);
            this.grpOperatorDetails.Controls.Add(this.lblOperatorName);
            this.grpOperatorDetails.Controls.Add(this.txtOperatorCode);
            this.grpOperatorDetails.Controls.Add(this.lblOperatorCode);
            this.grpOperatorDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperatorDetails.Location = new System.Drawing.Point(35, 97);
            this.grpOperatorDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpOperatorDetails.Name = "grpOperatorDetails";
            this.grpOperatorDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpOperatorDetails.Size = new System.Drawing.Size(999, 288);
            this.grpOperatorDetails.TabIndex = 12;
            this.grpOperatorDetails.TabStop = false;
            this.grpOperatorDetails.Text = "Operator Details";
            // 
            // grpAirportAddress
            // 
            this.grpAirportAddress.Controls.Add(this.txtOperatorCountry);
            this.grpAirportAddress.Controls.Add(this.lblOperatorCountry);
            this.grpAirportAddress.Controls.Add(this.lblOperatorCity);
            this.grpAirportAddress.Controls.Add(this.txtOperatorCity);
            this.grpAirportAddress.Location = new System.Drawing.Point(73, 118);
            this.grpAirportAddress.Margin = new System.Windows.Forms.Padding(4);
            this.grpAirportAddress.Name = "grpAirportAddress";
            this.grpAirportAddress.Padding = new System.Windows.Forms.Padding(4);
            this.grpAirportAddress.Size = new System.Drawing.Size(856, 118);
            this.grpAirportAddress.TabIndex = 11;
            this.grpAirportAddress.TabStop = false;
            this.grpAirportAddress.Text = "Address";
            // 
            // txtOperatorCountry
            // 
            this.txtOperatorCountry.Location = new System.Drawing.Point(582, 44);
            this.txtOperatorCountry.Margin = new System.Windows.Forms.Padding(4);
            this.txtOperatorCountry.Name = "txtOperatorCountry";
            this.txtOperatorCountry.Size = new System.Drawing.Size(229, 34);
            this.txtOperatorCountry.TabIndex = 14;
            // 
            // lblOperatorCountry
            // 
            this.lblOperatorCountry.AutoSize = true;
            this.lblOperatorCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorCountry.Location = new System.Drawing.Point(454, 49);
            this.lblOperatorCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperatorCountry.Name = "lblOperatorCountry";
            this.lblOperatorCountry.Size = new System.Drawing.Size(82, 28);
            this.lblOperatorCountry.TabIndex = 13;
            this.lblOperatorCountry.Text = "Country";
            // 
            // lblOperatorCity
            // 
            this.lblOperatorCity.AutoSize = true;
            this.lblOperatorCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorCity.Location = new System.Drawing.Point(46, 44);
            this.lblOperatorCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperatorCity.Name = "lblOperatorCity";
            this.lblOperatorCity.Size = new System.Drawing.Size(46, 28);
            this.lblOperatorCity.TabIndex = 13;
            this.lblOperatorCity.Text = "City";
            // 
            // txtOperatorCity
            // 
            this.txtOperatorCity.Location = new System.Drawing.Point(154, 40);
            this.txtOperatorCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtOperatorCity.Name = "txtOperatorCity";
            this.txtOperatorCity.Size = new System.Drawing.Size(229, 34);
            this.txtOperatorCity.TabIndex = 14;
            // 
            // txtOperatorName
            // 
            this.txtOperatorName.Location = new System.Drawing.Point(655, 53);
            this.txtOperatorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtOperatorName.Name = "txtOperatorName";
            this.txtOperatorName.Size = new System.Drawing.Size(229, 34);
            this.txtOperatorName.TabIndex = 10;
            // 
            // lblOperatorName
            // 
            this.lblOperatorName.AutoSize = true;
            this.lblOperatorName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorName.Location = new System.Drawing.Point(547, 57);
            this.lblOperatorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperatorName.Name = "lblOperatorName";
            this.lblOperatorName.Size = new System.Drawing.Size(64, 28);
            this.lblOperatorName.TabIndex = 9;
            this.lblOperatorName.Text = "Name";
            // 
            // txtOperatorCode
            // 
            this.txtOperatorCode.Location = new System.Drawing.Point(227, 48);
            this.txtOperatorCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtOperatorCode.Name = "txtOperatorCode";
            this.txtOperatorCode.Size = new System.Drawing.Size(229, 34);
            this.txtOperatorCode.TabIndex = 8;
            // 
            // lblOperatorCode
            // 
            this.lblOperatorCode.AutoSize = true;
            this.lblOperatorCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorCode.Location = new System.Drawing.Point(68, 53);
            this.lblOperatorCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperatorCode.Name = "lblOperatorCode";
            this.lblOperatorCode.Size = new System.Drawing.Size(143, 28);
            this.lblOperatorCode.TabIndex = 7;
            this.lblOperatorCode.Text = "Operator Code";
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(35, 34);
            this.lblAddAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(180, 37);
            this.lblAddAirport.TabIndex = 11;
            this.lblAddAirport.Text = "Add Operator";
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(985, -1);
            this.munBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(13, 2, 13, 2);
            this.munBack.Size = new System.Drawing.Size(77, 29);
            this.munBack.TabIndex = 5;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // frmAddOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 477);
            this.Controls.Add(this.btnOperatorConfirm);
            this.Controls.Add(this.grpOperatorDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuAddOperator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddOperator";
            this.Text = "Add Operator";
            this.grpOperatorDetails.ResumeLayout(false);
            this.grpOperatorDetails.PerformLayout();
            this.grpAirportAddress.ResumeLayout(false);
            this.grpAirportAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuAddOperator;
        private System.Windows.Forms.Button btnOperatorConfirm;
        private System.Windows.Forms.GroupBox grpOperatorDetails;
        private System.Windows.Forms.GroupBox grpAirportAddress;
        private System.Windows.Forms.TextBox txtOperatorCountry;
        private System.Windows.Forms.Label lblOperatorCountry;
        private System.Windows.Forms.Label lblOperatorCity;
        private System.Windows.Forms.TextBox txtOperatorCity;
        private System.Windows.Forms.TextBox txtOperatorName;
        private System.Windows.Forms.Label lblOperatorName;
        private System.Windows.Forms.TextBox txtOperatorCode;
        private System.Windows.Forms.Label lblOperatorCode;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.Label munBack;
    }
}