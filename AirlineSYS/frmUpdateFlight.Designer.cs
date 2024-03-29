namespace AirlineSYS
{
    partial class frmUpdateFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateFlight));
            this.munBack = new System.Windows.Forms.Label();
            this.mnuUpdateFlight = new System.Windows.Forms.MenuStrip();
            this.btnAirportConfirm = new System.Windows.Forms.Button();
            this.grpUpdateFlightDetails = new System.Windows.Forms.GroupBox();
            this.cboOperatorCodeFlight = new System.Windows.Forms.ComboBox();
            this.cboDeptTime = new System.Windows.Forms.ComboBox();
            this.dtpDeptFlight = new System.Windows.Forms.DateTimePicker();
            this.cboArrAirportFlight = new System.Windows.Forms.ComboBox();
            this.txtTicketPriceFlight = new System.Windows.Forms.TextBox();
            this.cboDeptAirportFlight = new System.Windows.Forms.ComboBox();
            this.txtNumFlightSeats = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOperatorCode = new System.Windows.Forms.Label();
            this.lblAirportEmail = new System.Windows.Forms.Label();
            this.lblAirportPhone = new System.Windows.Forms.Label();
            this.lblAirportName = new System.Windows.Forms.Label();
            this.lblAirportCode = new System.Windows.Forms.Label();
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.txtUpdateFlightNumber = new System.Windows.Forms.TextBox();
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.btnFlightSearch = new System.Windows.Forms.Button();
            this.grpUpdateFlightDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(987, 1);
            this.munBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.munBack.Size = new System.Drawing.Size(77, 25);
            this.munBack.TabIndex = 7;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // mnuUpdateFlight
            // 
            this.mnuUpdateFlight.BackColor = System.Drawing.Color.Plum;
            this.mnuUpdateFlight.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuUpdateFlight.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateFlight.Name = "mnuUpdateFlight";
            this.mnuUpdateFlight.Padding = new System.Windows.Forms.Padding(0);
            this.mnuUpdateFlight.Size = new System.Drawing.Size(1067, 24);
            this.mnuUpdateFlight.TabIndex = 6;
            // 
            // btnAirportConfirm
            // 
            this.btnAirportConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnAirportConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirportConfirm.Location = new System.Drawing.Point(417, 492);
            this.btnAirportConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAirportConfirm.Name = "btnAirportConfirm";
            this.btnAirportConfirm.Size = new System.Drawing.Size(232, 47);
            this.btnAirportConfirm.TabIndex = 16;
            this.btnAirportConfirm.Text = "CONFIRM";
            this.btnAirportConfirm.UseVisualStyleBackColor = false;
            this.btnAirportConfirm.Click += new System.EventHandler(this.btnAirportConfirm_Click);
            // 
            // grpUpdateFlightDetails
            // 
            this.grpUpdateFlightDetails.Controls.Add(this.cboOperatorCodeFlight);
            this.grpUpdateFlightDetails.Controls.Add(this.cboDeptTime);
            this.grpUpdateFlightDetails.Controls.Add(this.dtpDeptFlight);
            this.grpUpdateFlightDetails.Controls.Add(this.cboArrAirportFlight);
            this.grpUpdateFlightDetails.Controls.Add(this.txtTicketPriceFlight);
            this.grpUpdateFlightDetails.Controls.Add(this.cboDeptAirportFlight);
            this.grpUpdateFlightDetails.Controls.Add(this.txtNumFlightSeats);
            this.grpUpdateFlightDetails.Controls.Add(this.label3);
            this.grpUpdateFlightDetails.Controls.Add(this.label2);
            this.grpUpdateFlightDetails.Controls.Add(this.lblOperatorCode);
            this.grpUpdateFlightDetails.Controls.Add(this.lblAirportEmail);
            this.grpUpdateFlightDetails.Controls.Add(this.lblAirportPhone);
            this.grpUpdateFlightDetails.Controls.Add(this.lblAirportName);
            this.grpUpdateFlightDetails.Controls.Add(this.lblAirportCode);
            this.grpUpdateFlightDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateFlightDetails.Location = new System.Drawing.Point(35, 140);
            this.grpUpdateFlightDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpUpdateFlightDetails.Name = "grpUpdateFlightDetails";
            this.grpUpdateFlightDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpUpdateFlightDetails.Size = new System.Drawing.Size(999, 322);
            this.grpUpdateFlightDetails.TabIndex = 15;
            this.grpUpdateFlightDetails.TabStop = false;
            this.grpUpdateFlightDetails.Text = "Update Flight Details";
            this.grpUpdateFlightDetails.Visible = false;
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
            this.cboOperatorCodeFlight.Location = new System.Drawing.Point(227, 121);
            this.cboOperatorCodeFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboOperatorCodeFlight.Name = "cboOperatorCodeFlight";
            this.cboOperatorCodeFlight.Size = new System.Drawing.Size(244, 36);
            this.cboOperatorCodeFlight.TabIndex = 38;
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
            this.cboDeptTime.Location = new System.Drawing.Point(713, 183);
            this.cboDeptTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDeptTime.Name = "cboDeptTime";
            this.cboDeptTime.Size = new System.Drawing.Size(244, 36);
            this.cboDeptTime.TabIndex = 37;
            // 
            // dtpDeptFlight
            // 
            this.dtpDeptFlight.CustomFormat = "dd-MM-yyyy";
            this.dtpDeptFlight.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeptFlight.Location = new System.Drawing.Point(227, 192);
            this.dtpDeptFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDeptFlight.Name = "dtpDeptFlight";
            this.dtpDeptFlight.Size = new System.Drawing.Size(244, 34);
            this.dtpDeptFlight.TabIndex = 36;
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
            this.cboArrAirportFlight.Location = new System.Drawing.Point(713, 53);
            this.cboArrAirportFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboArrAirportFlight.Name = "cboArrAirportFlight";
            this.cboArrAirportFlight.Size = new System.Drawing.Size(244, 36);
            this.cboArrAirportFlight.TabIndex = 33;
            // 
            // txtTicketPriceFlight
            // 
            this.txtTicketPriceFlight.Location = new System.Drawing.Point(227, 261);
            this.txtTicketPriceFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTicketPriceFlight.Name = "txtTicketPriceFlight";
            this.txtTicketPriceFlight.Size = new System.Drawing.Size(244, 34);
            this.txtTicketPriceFlight.TabIndex = 35;
            // 
            // cboDeptAirportFlight
            // 
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
            this.cboDeptAirportFlight.Location = new System.Drawing.Point(227, 50);
            this.cboDeptAirportFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDeptAirportFlight.Name = "cboDeptAirportFlight";
            this.cboDeptAirportFlight.Size = new System.Drawing.Size(244, 36);
            this.cboDeptAirportFlight.TabIndex = 32;
            // 
            // txtNumFlightSeats
            // 
            this.txtNumFlightSeats.Location = new System.Drawing.Point(713, 119);
            this.txtNumFlightSeats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumFlightSeats.Name = "txtNumFlightSeats";
            this.txtNumFlightSeats.Size = new System.Drawing.Size(244, 34);
            this.txtNumFlightSeats.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ticket Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Number of Seats";
            // 
            // lblOperatorCode
            // 
            this.lblOperatorCode.AutoSize = true;
            this.lblOperatorCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorCode.Location = new System.Drawing.Point(41, 123);
            this.lblOperatorCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperatorCode.Name = "lblOperatorCode";
            this.lblOperatorCode.Size = new System.Drawing.Size(143, 28);
            this.lblOperatorCode.TabIndex = 20;
            this.lblOperatorCode.Text = "Operator Code";
            // 
            // lblAirportEmail
            // 
            this.lblAirportEmail.AutoSize = true;
            this.lblAirportEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportEmail.Location = new System.Drawing.Point(540, 187);
            this.lblAirportEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportEmail.Name = "lblAirportEmail";
            this.lblAirportEmail.Size = new System.Drawing.Size(141, 24);
            this.lblAirportEmail.TabIndex = 19;
            this.lblAirportEmail.Text = "Departure Time";
            // 
            // lblAirportPhone
            // 
            this.lblAirportPhone.AutoSize = true;
            this.lblAirportPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportPhone.Location = new System.Drawing.Point(41, 196);
            this.lblAirportPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportPhone.Name = "lblAirportPhone";
            this.lblAirportPhone.Size = new System.Drawing.Size(136, 24);
            this.lblAirportPhone.TabIndex = 17;
            this.lblAirportPhone.Text = "Departure Date";
            // 
            // lblAirportName
            // 
            this.lblAirportName.AutoSize = true;
            this.lblAirportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportName.Location = new System.Drawing.Point(540, 57);
            this.lblAirportName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportName.Name = "lblAirportName";
            this.lblAirportName.Size = new System.Drawing.Size(122, 24);
            this.lblAirportName.TabIndex = 9;
            this.lblAirportName.Text = "Arrival Airport";
            // 
            // lblAirportCode
            // 
            this.lblAirportCode.AutoSize = true;
            this.lblAirportCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportCode.Location = new System.Drawing.Point(41, 54);
            this.lblAirportCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportCode.Name = "lblAirportCode";
            this.lblAirportCode.Size = new System.Drawing.Size(153, 24);
            this.lblAirportCode.TabIndex = 7;
            this.lblAirportCode.Text = "Departure Airport";
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(33, 34);
            this.lblAddAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(179, 37);
            this.lblAddAirport.TabIndex = 14;
            this.lblAddAirport.Text = "Update Flight";
            // 
            // txtUpdateFlightNumber
            // 
            this.txtUpdateFlightNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateFlightNumber.Location = new System.Drawing.Point(387, 75);
            this.txtUpdateFlightNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdateFlightNumber.Name = "txtUpdateFlightNumber";
            this.txtUpdateFlightNumber.Size = new System.Drawing.Size(229, 34);
            this.txtUpdateFlightNumber.TabIndex = 23;
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumber.Location = new System.Drawing.Point(227, 78);
            this.lblFlightNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(139, 28);
            this.lblFlightNumber.TabIndex = 22;
            this.lblFlightNumber.Text = "Flight Number";
            // 
            // btnFlightSearch
            // 
            this.btnFlightSearch.BackColor = System.Drawing.Color.Plum;
            this.btnFlightSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnFlightSearch.Location = new System.Drawing.Point(672, 75);
            this.btnFlightSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFlightSearch.Name = "btnFlightSearch";
            this.btnFlightSearch.Size = new System.Drawing.Size(168, 34);
            this.btnFlightSearch.TabIndex = 24;
            this.btnFlightSearch.Text = "SEARCH";
            this.btnFlightSearch.UseVisualStyleBackColor = false;
            this.btnFlightSearch.Click += new System.EventHandler(this.btnFlightSearch_Click);
            // 
            // frmUpdateFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnFlightSearch);
            this.Controls.Add(this.txtUpdateFlightNumber);
            this.Controls.Add(this.lblFlightNumber);
            this.Controls.Add(this.btnAirportConfirm);
            this.Controls.Add(this.grpUpdateFlightDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuUpdateFlight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUpdateFlight";
            this.Text = "Update Flight";
            this.Load += new System.EventHandler(this.frmUpdateFlight_Load);
            this.grpUpdateFlightDetails.ResumeLayout(false);
            this.grpUpdateFlightDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuUpdateFlight;
        private System.Windows.Forms.Button btnAirportConfirm;
        private System.Windows.Forms.GroupBox grpUpdateFlightDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOperatorCode;
        private System.Windows.Forms.Label lblAirportEmail;
        private System.Windows.Forms.Label lblAirportPhone;
        private System.Windows.Forms.Label lblAirportName;
        private System.Windows.Forms.Label lblAirportCode;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.TextBox txtUpdateFlightNumber;
        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.Button btnFlightSearch;
        private System.Windows.Forms.ComboBox cboOperatorCodeFlight;
        private System.Windows.Forms.ComboBox cboDeptTime;
        private System.Windows.Forms.DateTimePicker dtpDeptFlight;
        private System.Windows.Forms.ComboBox cboArrAirportFlight;
        private System.Windows.Forms.TextBox txtTicketPriceFlight;
        private System.Windows.Forms.ComboBox cboDeptAirportFlight;
        private System.Windows.Forms.TextBox txtNumFlightSeats;
    }
}