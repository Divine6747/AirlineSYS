namespace AirlineSYS
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
            this.grpScheduleFlightDetails = new System.Windows.Forms.GroupBox();
            this.cboOperatorCodeFlight = new System.Windows.Forms.ComboBox();
            this.cboDeptTime = new System.Windows.Forms.ComboBox();
            this.dtpDeptFlight = new System.Windows.Forms.DateTimePicker();
            this.cboArrAirportFlight = new System.Windows.Forms.ComboBox();
            this.cboDeptAirportFlight = new System.Windows.Forms.ComboBox();
            this.btnFlightConfirm = new System.Windows.Forms.Button();
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.lblFlightNumberDetail = new System.Windows.Forms.Label();
            this.lblRouteIdDetails = new System.Windows.Forms.Label();
            this.lblRouteId = new System.Windows.Forms.Label();
            this.lblRouteDurationDetail = new System.Windows.Forms.Label();
            this.lblRouteDuration = new System.Windows.Forms.Label();
            this.lblEstArrTimeDetail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDateReview = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpScheduleFlightDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.munBack.Location = new System.Drawing.Point(1078, -1);
            this.munBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.munBack.Size = new System.Drawing.Size(77, 25);
            this.munBack.TabIndex = 7;
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
            this.mnuScheduleFlight.Size = new System.Drawing.Size(1155, 24);
            this.mnuScheduleFlight.TabIndex = 6;
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(33, 34);
            this.lblAddAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(198, 37);
            this.lblAddAirport.TabIndex = 11;
            this.lblAddAirport.Text = "Schedule Flight";
            // 
            // lblAirportCode
            // 
            this.lblAirportCode.AutoSize = true;
            this.lblAirportCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportCode.Location = new System.Drawing.Point(73, 54);
            this.lblAirportCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportCode.Name = "lblAirportCode";
            this.lblAirportCode.Size = new System.Drawing.Size(153, 24);
            this.lblAirportCode.TabIndex = 7;
            this.lblAirportCode.Text = "Departure Airport";
            // 
            // lblAirportName
            // 
            this.lblAirportName.AutoSize = true;
            this.lblAirportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportName.Location = new System.Drawing.Point(555, 57);
            this.lblAirportName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportName.Name = "lblAirportName";
            this.lblAirportName.Size = new System.Drawing.Size(122, 24);
            this.lblAirportName.TabIndex = 9;
            this.lblAirportName.Text = "Arrival Airport";
            // 
            // lblAirportPhone
            // 
            this.lblAirportPhone.AutoSize = true;
            this.lblAirportPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportPhone.Location = new System.Drawing.Point(73, 132);
            this.lblAirportPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportPhone.Name = "lblAirportPhone";
            this.lblAirportPhone.Size = new System.Drawing.Size(136, 24);
            this.lblAirportPhone.TabIndex = 17;
            this.lblAirportPhone.Text = "Departure Date";
            // 
            // lblAirportEmail
            // 
            this.lblAirportEmail.AutoSize = true;
            this.lblAirportEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportEmail.Location = new System.Drawing.Point(555, 132);
            this.lblAirportEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportEmail.Name = "lblAirportEmail";
            this.lblAirportEmail.Size = new System.Drawing.Size(141, 24);
            this.lblAirportEmail.TabIndex = 19;
            this.lblAirportEmail.Text = "Departure Time";
            // 
            // lblOperatorCode
            // 
            this.lblOperatorCode.AutoSize = true;
            this.lblOperatorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblOperatorCode.Location = new System.Drawing.Point(73, 210);
            this.lblOperatorCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperatorCode.Name = "lblOperatorCode";
            this.lblOperatorCode.Size = new System.Drawing.Size(135, 24);
            this.lblOperatorCode.TabIndex = 20;
            this.lblOperatorCode.Text = "Operator Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Number of Seats";
            // 
            // txtNumFlightSeats
            // 
            this.txtNumFlightSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNumFlightSeats.Location = new System.Drawing.Point(737, 202);
            this.txtNumFlightSeats.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumFlightSeats.Name = "txtNumFlightSeats";
            this.txtNumFlightSeats.Size = new System.Drawing.Size(159, 29);
            this.txtNumFlightSeats.TabIndex = 25;
            // 
            // grpScheduleFlightDetails
            // 
            this.grpScheduleFlightDetails.Controls.Add(this.cboOperatorCodeFlight);
            this.grpScheduleFlightDetails.Controls.Add(this.cboDeptTime);
            this.grpScheduleFlightDetails.Controls.Add(this.dtpDeptFlight);
            this.grpScheduleFlightDetails.Controls.Add(this.cboArrAirportFlight);
            this.grpScheduleFlightDetails.Controls.Add(this.cboDeptAirportFlight);
            this.grpScheduleFlightDetails.Controls.Add(this.txtNumFlightSeats);
            this.grpScheduleFlightDetails.Controls.Add(this.label2);
            this.grpScheduleFlightDetails.Controls.Add(this.lblOperatorCode);
            this.grpScheduleFlightDetails.Controls.Add(this.lblAirportEmail);
            this.grpScheduleFlightDetails.Controls.Add(this.lblAirportPhone);
            this.grpScheduleFlightDetails.Controls.Add(this.lblAirportName);
            this.grpScheduleFlightDetails.Controls.Add(this.lblAirportCode);
            this.grpScheduleFlightDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpScheduleFlightDetails.Location = new System.Drawing.Point(77, 293);
            this.grpScheduleFlightDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpScheduleFlightDetails.Name = "grpScheduleFlightDetails";
            this.grpScheduleFlightDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpScheduleFlightDetails.Size = new System.Drawing.Size(999, 267);
            this.grpScheduleFlightDetails.TabIndex = 15;
            this.grpScheduleFlightDetails.TabStop = false;
            this.grpScheduleFlightDetails.Text = "Schedule Flight Details";
            // 
            // cboOperatorCodeFlight
            // 
            this.cboOperatorCodeFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperatorCodeFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
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
            this.cboOperatorCodeFlight.Location = new System.Drawing.Point(281, 205);
            this.cboOperatorCodeFlight.Margin = new System.Windows.Forms.Padding(4);
            this.cboOperatorCodeFlight.Name = "cboOperatorCodeFlight";
            this.cboOperatorCodeFlight.Size = new System.Drawing.Size(159, 32);
            this.cboOperatorCodeFlight.TabIndex = 31;
            this.cboOperatorCodeFlight.SelectedIndexChanged += new System.EventHandler(this.cboOperatorCodeFlight_SelectedIndexChanged);
            // 
            // cboDeptTime
            // 
            this.cboDeptTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
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
            this.cboDeptTime.Location = new System.Drawing.Point(737, 126);
            this.cboDeptTime.Margin = new System.Windows.Forms.Padding(4);
            this.cboDeptTime.Name = "cboDeptTime";
            this.cboDeptTime.Size = new System.Drawing.Size(159, 32);
            this.cboDeptTime.TabIndex = 30;
            this.cboDeptTime.SelectedIndexChanged += new System.EventHandler(this.cboDeptTime_SelectedIndexChanged);
            // 
            // dtpDeptFlight
            // 
            this.dtpDeptFlight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDeptFlight.CustomFormat = " dd-MMM-yy";
            this.dtpDeptFlight.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtpDeptFlight.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeptFlight.Location = new System.Drawing.Point(281, 128);
            this.dtpDeptFlight.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDeptFlight.MinDate = new System.DateTime(2000, 2, 1, 0, 0, 0, 0);
            this.dtpDeptFlight.Name = "dtpDeptFlight";
            this.dtpDeptFlight.Size = new System.Drawing.Size(159, 32);
            this.dtpDeptFlight.TabIndex = 29;
            // 
            // cboArrAirportFlight
            // 
            this.cboArrAirportFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArrAirportFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboArrAirportFlight.FormattingEnabled = true;
            this.cboArrAirportFlight.Location = new System.Drawing.Point(737, 50);
            this.cboArrAirportFlight.Margin = new System.Windows.Forms.Padding(4);
            this.cboArrAirportFlight.Name = "cboArrAirportFlight";
            this.cboArrAirportFlight.Size = new System.Drawing.Size(159, 32);
            this.cboArrAirportFlight.TabIndex = 20;
            this.cboArrAirportFlight.SelectedIndexChanged += new System.EventHandler(this.cboArrAirportFlight_SelectedIndexChanged);
            // 
            // cboDeptAirportFlight
            // 
            this.cboDeptAirportFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptAirportFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboDeptAirportFlight.FormattingEnabled = true;
            this.cboDeptAirportFlight.Location = new System.Drawing.Point(281, 48);
            this.cboDeptAirportFlight.Margin = new System.Windows.Forms.Padding(4);
            this.cboDeptAirportFlight.Name = "cboDeptAirportFlight";
            this.cboDeptAirportFlight.Size = new System.Drawing.Size(159, 32);
            this.cboDeptAirportFlight.TabIndex = 19;
            this.cboDeptAirportFlight.SelectedIndexChanged += new System.EventHandler(this.cboDeptAirportFlight_SelectedIndexChanged);
            // 
            // btnFlightConfirm
            // 
            this.btnFlightConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnFlightConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlightConfirm.Location = new System.Drawing.Point(461, 587);
            this.btnFlightConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnFlightConfirm.Name = "btnFlightConfirm";
            this.btnFlightConfirm.Size = new System.Drawing.Size(232, 47);
            this.btnFlightConfirm.TabIndex = 13;
            this.btnFlightConfirm.Text = "CONFIRM";
            this.btnFlightConfirm.UseVisualStyleBackColor = false;
            this.btnFlightConfirm.Click += new System.EventHandler(this.btnFlightConfirm_Click);
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumber.Location = new System.Drawing.Point(22, 52);
            this.lblFlightNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(135, 24);
            this.lblFlightNumber.TabIndex = 14;
            this.lblFlightNumber.Text = "Flight Number:";
            // 
            // lblFlightNumberDetail
            // 
            this.lblFlightNumberDetail.AutoSize = true;
            this.lblFlightNumberDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumberDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblFlightNumberDetail.Location = new System.Drawing.Point(160, 52);
            this.lblFlightNumberDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightNumberDetail.Name = "lblFlightNumberDetail";
            this.lblFlightNumberDetail.Size = new System.Drawing.Size(82, 24);
            this.lblFlightNumberDetail.TabIndex = 15;
            this.lblFlightNumberDetail.Text = "N/A0000";
            // 
            // lblRouteIdDetails
            // 
            this.lblRouteIdDetails.AutoSize = true;
            this.lblRouteIdDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteIdDetails.ForeColor = System.Drawing.Color.Plum;
            this.lblRouteIdDetails.Location = new System.Drawing.Point(401, 52);
            this.lblRouteIdDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRouteIdDetails.Name = "lblRouteIdDetails";
            this.lblRouteIdDetails.Size = new System.Drawing.Size(175, 24);
            this.lblRouteIdDetails.TabIndex = 17;
            this.lblRouteIdDetails.Text = "No Route Retrieved";
            // 
            // lblRouteId
            // 
            this.lblRouteId.AutoSize = true;
            this.lblRouteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteId.Location = new System.Drawing.Point(310, 52);
            this.lblRouteId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRouteId.Name = "lblRouteId";
            this.lblRouteId.Size = new System.Drawing.Size(87, 24);
            this.lblRouteId.TabIndex = 16;
            this.lblRouteId.Text = "Route ID:";
            // 
            // lblRouteDurationDetail
            // 
            this.lblRouteDurationDetail.AutoSize = true;
            this.lblRouteDurationDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteDurationDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblRouteDurationDetail.Location = new System.Drawing.Point(111, 97);
            this.lblRouteDurationDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRouteDurationDetail.Name = "lblRouteDurationDetail";
            this.lblRouteDurationDetail.Size = new System.Drawing.Size(173, 24);
            this.lblRouteDurationDetail.TabIndex = 19;
            this.lblRouteDurationDetail.Text = "Does Not Retrieved";
            // 
            // lblRouteDuration
            // 
            this.lblRouteDuration.AutoSize = true;
            this.lblRouteDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteDuration.Location = new System.Drawing.Point(22, 97);
            this.lblRouteDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRouteDuration.Name = "lblRouteDuration";
            this.lblRouteDuration.Size = new System.Drawing.Size(85, 24);
            this.lblRouteDuration.TabIndex = 18;
            this.lblRouteDuration.Text = "Duration:";
            // 
            // lblEstArrTimeDetail
            // 
            this.lblEstArrTimeDetail.AutoSize = true;
            this.lblEstArrTimeDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstArrTimeDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblEstArrTimeDetail.Location = new System.Drawing.Point(518, 97);
            this.lblEstArrTimeDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstArrTimeDetail.Name = "lblEstArrTimeDetail";
            this.lblEstArrTimeDetail.Size = new System.Drawing.Size(195, 24);
            this.lblEstArrTimeDetail.TabIndex = 20;
            this.lblEstArrTimeDetail.Text = "No Duration Retrieved";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Estimated Arrival Time:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblRouteIdDetails);
            this.groupBox1.Controls.Add(this.lblRouteDurationDetail);
            this.groupBox1.Controls.Add(this.lblRouteId);
            this.groupBox1.Controls.Add(this.lblEstArrTimeDetail);
            this.groupBox1.Controls.Add(this.lblFlightNumberDetail);
            this.groupBox1.Controls.Add(this.lblRouteDuration);
            this.groupBox1.Controls.Add(this.lblFlightNumber);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(77, 117);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(762, 149);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Extra Details";
            // 
            // lblDateReview
            // 
            this.lblDateReview.AutoSize = true;
            this.lblDateReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReview.ForeColor = System.Drawing.Color.Plum;
            this.lblDateReview.Location = new System.Drawing.Point(880, 85);
            this.lblDateReview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateReview.Name = "lblDateReview";
            this.lblDateReview.Size = new System.Drawing.Size(200, 24);
            this.lblDateReview.TabIndex = 22;
            this.lblDateReview.Text = "NO DATA GIVEN YET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(877, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 41);
            this.label3.TabIndex = 23;
            this.label3.Text = "REVIEWING DATA";
            // 
            // frmScheduleFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 650);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDateReview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFlightConfirm);
            this.Controls.Add(this.grpScheduleFlightDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuScheduleFlight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmScheduleFlight";
            this.Text = "Schedule Flight";
            this.Load += new System.EventHandler(this.frmScheduleFlight_Load);
            this.grpScheduleFlightDetails.ResumeLayout(false);
            this.grpScheduleFlightDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpScheduleFlightDetails;
        private System.Windows.Forms.Button btnFlightConfirm;
        private System.Windows.Forms.ComboBox cboArrAirportFlight;
        private System.Windows.Forms.ComboBox cboDeptAirportFlight;
        private System.Windows.Forms.DateTimePicker dtpDeptFlight;
        private System.Windows.Forms.ComboBox cboDeptTime;
        private System.Windows.Forms.ComboBox cboOperatorCodeFlight;
        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.Label lblFlightNumberDetail;
        private System.Windows.Forms.Label lblRouteIdDetails;
        private System.Windows.Forms.Label lblRouteId;
        private System.Windows.Forms.Label lblRouteDurationDetail;
        private System.Windows.Forms.Label lblRouteDuration;
        private System.Windows.Forms.Label lblEstArrTimeDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDateReview;
        private System.Windows.Forms.Label label3;
    }
}