﻿namespace AirlineSYS
{
    partial class frmScheduleFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleFlight));
            this.munBack = new System.Windows.Forms.Label();
            this.mnuScheduleFlight = new System.Windows.Forms.MenuStrip();
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.lblAirportCode = new System.Windows.Forms.Label();
            this.lblAirportName = new System.Windows.Forms.Label();
            this.lblAirportPhone = new System.Windows.Forms.Label();
            this.lblAirportEmail = new System.Windows.Forms.Label();
            this.lblOperatorCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumFlightSeats = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTicketPriceFlight = new System.Windows.Forms.TextBox();
            this.grpAirportDetails = new System.Windows.Forms.GroupBox();
            this.cboOperatorCodeFlight = new System.Windows.Forms.ComboBox();
            this.cboDeptTime = new System.Windows.Forms.ComboBox();
            this.dtpDeptFlight = new System.Windows.Forms.DateTimePicker();
            this.cboArrAirportFlight = new System.Windows.Forms.ComboBox();
            this.cboDeptAirportFlight = new System.Windows.Forms.ComboBox();
            this.btnAirportConfirm = new System.Windows.Forms.Button();
            this.grpAirportDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(740, 2);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.munBack.Size = new System.Drawing.Size(60, 20);
            this.munBack.TabIndex = 5;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // mnuScheduleFlight
            // 
            this.mnuScheduleFlight.BackColor = System.Drawing.Color.Plum;
            this.mnuScheduleFlight.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuScheduleFlight.Location = new System.Drawing.Point(0, 0);
            this.mnuScheduleFlight.Name = "mnuScheduleFlight";
            this.mnuScheduleFlight.Padding = new System.Windows.Forms.Padding(0);
            this.mnuScheduleFlight.Size = new System.Drawing.Size(800, 24);
            this.mnuScheduleFlight.TabIndex = 4;
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(25, 28);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(154, 30);
            this.lblAddAirport.TabIndex = 11;
            this.lblAddAirport.Text = "Schedule Flight";
            // 
            // lblAirportCode
            // 
            this.lblAirportCode.AutoSize = true;
            this.lblAirportCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportCode.Location = new System.Drawing.Point(26, 44);
            this.lblAirportCode.Name = "lblAirportCode";
            this.lblAirportCode.Size = new System.Drawing.Size(120, 18);
            this.lblAirportCode.TabIndex = 7;
            this.lblAirportCode.Text = "Departure Airport";
            // 
            // lblAirportName
            // 
            this.lblAirportName.AutoSize = true;
            this.lblAirportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportName.Location = new System.Drawing.Point(411, 46);
            this.lblAirportName.Name = "lblAirportName";
            this.lblAirportName.Size = new System.Drawing.Size(95, 18);
            this.lblAirportName.TabIndex = 9;
            this.lblAirportName.Text = "Arrival Airport";
            // 
            // lblAirportPhone
            // 
            this.lblAirportPhone.AutoSize = true;
            this.lblAirportPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportPhone.Location = new System.Drawing.Point(26, 159);
            this.lblAirportPhone.Name = "lblAirportPhone";
            this.lblAirportPhone.Size = new System.Drawing.Size(108, 18);
            this.lblAirportPhone.TabIndex = 17;
            this.lblAirportPhone.Text = "Departure Date";
            // 
            // lblAirportEmail
            // 
            this.lblAirportEmail.AutoSize = true;
            this.lblAirportEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportEmail.Location = new System.Drawing.Point(411, 152);
            this.lblAirportEmail.Name = "lblAirportEmail";
            this.lblAirportEmail.Size = new System.Drawing.Size(110, 18);
            this.lblAirportEmail.TabIndex = 19;
            this.lblAirportEmail.Text = "Departure Time";
            // 
            // lblOperatorCode
            // 
            this.lblOperatorCode.AutoSize = true;
            this.lblOperatorCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorCode.Location = new System.Drawing.Point(26, 101);
            this.lblOperatorCode.Name = "lblOperatorCode";
            this.lblOperatorCode.Size = new System.Drawing.Size(113, 21);
            this.lblOperatorCode.TabIndex = 20;
            this.lblOperatorCode.Text = "Operator Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Number of Seats";
            // 
            // txtNumFlightSeats
            // 
            this.txtNumFlightSeats.Location = new System.Drawing.Point(548, 95);
            this.txtNumFlightSeats.Name = "txtNumFlightSeats";
            this.txtNumFlightSeats.Size = new System.Drawing.Size(184, 29);
            this.txtNumFlightSeats.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ticket Price";
            // 
            // txtTicketPriceFlight
            // 
            this.txtTicketPriceFlight.Location = new System.Drawing.Point(182, 212);
            this.txtTicketPriceFlight.Name = "txtTicketPriceFlight";
            this.txtTicketPriceFlight.Size = new System.Drawing.Size(184, 29);
            this.txtTicketPriceFlight.TabIndex = 27;
            // 
            // grpAirportDetails
            // 
            this.grpAirportDetails.Controls.Add(this.cboOperatorCodeFlight);
            this.grpAirportDetails.Controls.Add(this.cboDeptTime);
            this.grpAirportDetails.Controls.Add(this.dtpDeptFlight);
            this.grpAirportDetails.Controls.Add(this.cboArrAirportFlight);
            this.grpAirportDetails.Controls.Add(this.txtTicketPriceFlight);
            this.grpAirportDetails.Controls.Add(this.cboDeptAirportFlight);
            this.grpAirportDetails.Controls.Add(this.label3);
            this.grpAirportDetails.Controls.Add(this.txtNumFlightSeats);
            this.grpAirportDetails.Controls.Add(this.label2);
            this.grpAirportDetails.Controls.Add(this.lblOperatorCode);
            this.grpAirportDetails.Controls.Add(this.lblAirportEmail);
            this.grpAirportDetails.Controls.Add(this.lblAirportPhone);
            this.grpAirportDetails.Controls.Add(this.lblAirportName);
            this.grpAirportDetails.Controls.Add(this.lblAirportCode);
            this.grpAirportDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAirportDetails.Location = new System.Drawing.Point(26, 81);
            this.grpAirportDetails.Name = "grpAirportDetails";
            this.grpAirportDetails.Size = new System.Drawing.Size(749, 313);
            this.grpAirportDetails.TabIndex = 12;
            this.grpAirportDetails.TabStop = false;
            this.grpAirportDetails.Text = "Schedule Flight Details";
            // 
            // cboOperatorCodeFlight
            // 
            this.cboOperatorCodeFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperatorCodeFlight.FormattingEnabled = true;
            this.cboOperatorCodeFlight.Items.AddRange(new object[] {
            "AA - American Airlines",
            "DL - Delta Air Lines",
            "EK - Emirates",
            "LH -  Lufthansa",
            "BA -  British Airways",
            "AC - Air Canada",
            "QF - Qantas",
            "SQ -  Singapore Airlines",
            "CX - Cathay Pacific",
            "WN - Southwest Airlines",
            "AF - Air France",
            "JL - Japan Airlines",
            "TK: - Turkish Airlines",
            "UA - United Airlines",
            "FR - Ryanair"});
            this.cboOperatorCodeFlight.Location = new System.Drawing.Point(182, 98);
            this.cboOperatorCodeFlight.Name = "cboOperatorCodeFlight";
            this.cboOperatorCodeFlight.Size = new System.Drawing.Size(184, 29);
            this.cboOperatorCodeFlight.TabIndex = 31;
            // 
            // cboDeptTime
            // 
            this.cboDeptTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptTime.FormattingEnabled = true;
            this.cboDeptTime.Items.AddRange(new object[] {
            "18:00 PM",
            "06:00 AM",
            "19:00 PM",
            "07:00 AM",
            "20:00 PM",
            "08:00 AM",
            "21:00 PM",
            "09:00 AM",
            "22:00 PM",
            "10:00 AM",
            "23:00 PM",
            "11:00 AM",
            "00:00 AM",
            "12:00 PM"});
            this.cboDeptTime.Location = new System.Drawing.Point(548, 147);
            this.cboDeptTime.Name = "cboDeptTime";
            this.cboDeptTime.Size = new System.Drawing.Size(184, 29);
            this.cboDeptTime.TabIndex = 30;
            // 
            // dtpDeptFlight
            // 
            this.dtpDeptFlight.CustomFormat = "dd-MM-yyyy";
            this.dtpDeptFlight.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeptFlight.Location = new System.Drawing.Point(182, 155);
            this.dtpDeptFlight.Name = "dtpDeptFlight";
            this.dtpDeptFlight.Size = new System.Drawing.Size(184, 29);
            this.dtpDeptFlight.TabIndex = 29;
            // 
            // cboArrAirportFlight
            // 
            this.cboArrAirportFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArrAirportFlight.FormattingEnabled = true;
            this.cboArrAirportFlight.Items.AddRange(new object[] {
            "JFK",
            "CDG",
            "DXB",
            "PEK",
            "NRT",
            "YYZ",
            "FRA",
            "HKG",
            "ICN",
            "MIA",
            "CGK",
            "SNN",
            "DUB",
            "SHA",
            "FCO",
            "BGY"});
            this.cboArrAirportFlight.Location = new System.Drawing.Point(548, 41);
            this.cboArrAirportFlight.Name = "cboArrAirportFlight";
            this.cboArrAirportFlight.Size = new System.Drawing.Size(184, 29);
            this.cboArrAirportFlight.TabIndex = 20;
            // 
            // cboDeptAirportFlight
            // 
            this.cboDeptAirportFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptAirportFlight.FormattingEnabled = true;
            this.cboDeptAirportFlight.Items.AddRange(new object[] {
            "JFK",
            "CDG",
            "DXB",
            "PEK",
            "NRT",
            "YYZ",
            "FRA",
            "HKG",
            "ICN",
            "MIA",
            "CGK",
            "SNN",
            "DUB",
            "SHA",
            "FCO",
            "BGY"});
            this.cboDeptAirportFlight.Location = new System.Drawing.Point(182, 39);
            this.cboDeptAirportFlight.Name = "cboDeptAirportFlight";
            this.cboDeptAirportFlight.Size = new System.Drawing.Size(184, 29);
            this.cboDeptAirportFlight.TabIndex = 19;
            // 
            // btnAirportConfirm
            // 
            this.btnAirportConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnAirportConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirportConfirm.Location = new System.Drawing.Point(310, 400);
            this.btnAirportConfirm.Name = "btnAirportConfirm";
            this.btnAirportConfirm.Size = new System.Drawing.Size(174, 38);
            this.btnAirportConfirm.TabIndex = 13;
            this.btnAirportConfirm.Text = "CONFIRM";
            this.btnAirportConfirm.UseVisualStyleBackColor = false;
            this.btnAirportConfirm.Click += new System.EventHandler(this.btnAirportConfirm_Click);
            // 
            // frmScheduleFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAirportConfirm);
            this.Controls.Add(this.grpAirportDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuScheduleFlight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmScheduleFlight";
            this.Text = "Schedule Flight";
            this.Load += new System.EventHandler(this.frmScheduleFlight_Load);
            this.grpAirportDetails.ResumeLayout(false);
            this.grpAirportDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuScheduleFlight;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.Label lblAirportCode;
        private System.Windows.Forms.Label lblAirportName;
        private System.Windows.Forms.Label lblAirportPhone;
        private System.Windows.Forms.Label lblAirportEmail;
        private System.Windows.Forms.Label lblOperatorCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumFlightSeats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTicketPriceFlight;
        private System.Windows.Forms.GroupBox grpAirportDetails;
        private System.Windows.Forms.Button btnAirportConfirm;
        private System.Windows.Forms.ComboBox cboArrAirportFlight;
        private System.Windows.Forms.ComboBox cboDeptAirportFlight;
        private System.Windows.Forms.DateTimePicker dtpDeptFlight;
        private System.Windows.Forms.ComboBox cboDeptTime;
        private System.Windows.Forms.ComboBox cboOperatorCodeFlight;
    }
}