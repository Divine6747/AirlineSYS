namespace AirlineSYS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateBooking));
            this.munBack = new System.Windows.Forms.Label();
            this.mnuUpdateBooking = new System.Windows.Forms.MenuStrip();
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpadateBookingConfirm = new System.Windows.Forms.Button();
            this.grpUpdateCreateBookingDetails = new System.Windows.Forms.GroupBox();
            this.cboDeptimeDetail = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dptUpdateBookingDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.cboUpdateArrAirportDetail = new System.Windows.Forms.ComboBox();
            this.grpPersonalCreateBookingDetails = new System.Windows.Forms.GroupBox();
            this.dtpDOBUpdate = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateEircode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateBooingPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdateForeName = new System.Windows.Forms.TextBox();
            this.txtUpdateBookingEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboUpdateDeptAirportDetail = new System.Windows.Forms.ComboBox();
            this.lblArrAirport = new System.Windows.Forms.Label();
            this.lblDeptAirport = new System.Windows.Forms.Label();
            this.lblDepartDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.nudNumBaggage = new System.Windows.Forms.NumericUpDown();
            this.lbFlightlBookingPrice = new System.Windows.Forms.Label();
            this.lblUpdateFlightNumberDetail = new System.Windows.Forms.Label();
            this.lbFlightlBookingPriceDetail = new System.Windows.Forms.Label();
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.btnUpdateBookingIDSearch = new System.Windows.Forms.Button();
            this.lblSeatNum = new System.Windows.Forms.Label();
            this.lblSeatNumDetail = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUpdateBookingRouteID = new System.Windows.Forms.Label();
            this.lblUpdateBookingID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblbok = new System.Windows.Forms.Label();
            this.lblUpdatePassengerID = new System.Windows.Forms.Label();
            this.passenger = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpUpdateCreateBookingDetails.SuspendLayout();
            this.grpPersonalCreateBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumBaggage)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.mnuUpdateBooking.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuUpdateBooking.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateBooking.Name = "mnuUpdateBooking";
            this.mnuUpdateBooking.Padding = new System.Windows.Forms.Padding(0);
            this.mnuUpdateBooking.Size = new System.Drawing.Size(1112, 24);
            this.mnuUpdateBooking.TabIndex = 6;
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(25, 28);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(161, 30);
            this.lblAddAirport.TabIndex = 17;
            this.lblAddAirport.Text = "Update Booking";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingID.Location = new System.Drawing.Point(294, 67);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(173, 29);
            this.txtBookingID.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(174, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Booking ID";
            // 
            // btnUpadateBookingConfirm
            // 
            this.btnUpadateBookingConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnUpadateBookingConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpadateBookingConfirm.Location = new System.Drawing.Point(326, 616);
            this.btnUpadateBookingConfirm.Name = "btnUpadateBookingConfirm";
            this.btnUpadateBookingConfirm.Size = new System.Drawing.Size(174, 38);
            this.btnUpadateBookingConfirm.TabIndex = 27;
            this.btnUpadateBookingConfirm.Text = "CONFIRM";
            this.btnUpadateBookingConfirm.UseVisualStyleBackColor = false;
            this.btnUpadateBookingConfirm.Click += new System.EventHandler(this.btnUpadateBookingConfirm_Click);
            // 
            // grpUpdateCreateBookingDetails
            // 
            this.grpUpdateCreateBookingDetails.Controls.Add(this.cboDeptimeDetail);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.label13);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.dptUpdateBookingDate);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.label14);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.cboUpdateArrAirportDetail);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.grpPersonalCreateBookingDetails);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.cboUpdateDeptAirportDetail);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.lblArrAirport);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.lblDeptAirport);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.lblDepartDate);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.label7);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.lblDepartureTime);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.nudNumBaggage);
            this.grpUpdateCreateBookingDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateCreateBookingDetails.Location = new System.Drawing.Point(30, 111);
            this.grpUpdateCreateBookingDetails.Name = "grpUpdateCreateBookingDetails";
            this.grpUpdateCreateBookingDetails.Size = new System.Drawing.Size(749, 492);
            this.grpUpdateCreateBookingDetails.TabIndex = 26;
            this.grpUpdateCreateBookingDetails.TabStop = false;
            this.grpUpdateCreateBookingDetails.Text = "Update Booking Details";
            // 
            // cboDeptimeDetail
            // 
            this.cboDeptimeDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptimeDetail.FormattingEnabled = true;
            this.cboDeptimeDetail.Location = new System.Drawing.Point(577, 110);
            this.cboDeptimeDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDeptimeDetail.Name = "cboDeptimeDetail";
            this.cboDeptimeDetail.Size = new System.Drawing.Size(110, 29);
            this.cboDeptimeDetail.TabIndex = 67;
            this.cboDeptimeDetail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboDeptimeDetail_MouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(291, -24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 21);
            this.label13.TabIndex = 54;
            this.label13.Text = "Flight Number";
            // 
            // dptUpdateBookingDate
            // 
            this.dptUpdateBookingDate.CustomFormat = "dd-MM-yy";
            this.dptUpdateBookingDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptUpdateBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptUpdateBookingDate.Location = new System.Drawing.Point(216, 110);
            this.dptUpdateBookingDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dptUpdateBookingDate.Name = "dptUpdateBookingDate";
            this.dptUpdateBookingDate.Size = new System.Drawing.Size(110, 29);
            this.dptUpdateBookingDate.TabIndex = 66;
            this.dptUpdateBookingDate.ValueChanged += new System.EventHandler(this.dptUpdateBookingDate_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Plum;
            this.label14.Location = new System.Drawing.Point(405, -24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 21);
            this.label14.TabIndex = 53;
            this.label14.Text = "Unknown";
            // 
            // cboUpdateArrAirportDetail
            // 
            this.cboUpdateArrAirportDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUpdateArrAirportDetail.FormattingEnabled = true;
            this.cboUpdateArrAirportDetail.Location = new System.Drawing.Point(577, 46);
            this.cboUpdateArrAirportDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboUpdateArrAirportDetail.Name = "cboUpdateArrAirportDetail";
            this.cboUpdateArrAirportDetail.Size = new System.Drawing.Size(110, 29);
            this.cboUpdateArrAirportDetail.TabIndex = 65;
            this.cboUpdateArrAirportDetail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboUpdateArrAirportDetail_MouseClick);
            // 
            // grpPersonalCreateBookingDetails
            // 
            this.grpPersonalCreateBookingDetails.Controls.Add(this.dtpDOBUpdate);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtUpdateEircode);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label6);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtUpdateBooingPhone);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label5);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtUpdateForeName);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtUpdateBookingEmail);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label2);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label4);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtUpdateSurname);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label1);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label3);
            this.grpPersonalCreateBookingDetails.Location = new System.Drawing.Point(28, 225);
            this.grpPersonalCreateBookingDetails.Name = "grpPersonalCreateBookingDetails";
            this.grpPersonalCreateBookingDetails.Size = new System.Drawing.Size(692, 227);
            this.grpPersonalCreateBookingDetails.TabIndex = 35;
            this.grpPersonalCreateBookingDetails.TabStop = false;
            this.grpPersonalCreateBookingDetails.Text = "Update Personal Details";
            // 
            // dtpDOBUpdate
            // 
            this.dtpDOBUpdate.CustomFormat = "dd-MM-yy";
            this.dtpDOBUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOBUpdate.Location = new System.Drawing.Point(147, 110);
            this.dtpDOBUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDOBUpdate.Name = "dtpDOBUpdate";
            this.dtpDOBUpdate.Size = new System.Drawing.Size(173, 29);
            this.dtpDOBUpdate.TabIndex = 41;
            // 
            // txtUpdateEircode
            // 
            this.txtUpdateEircode.Location = new System.Drawing.Point(480, 162);
            this.txtUpdateEircode.Name = "txtUpdateEircode";
            this.txtUpdateEircode.Size = new System.Drawing.Size(173, 29);
            this.txtUpdateEircode.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Eircode";
            // 
            // txtUpdateBooingPhone
            // 
            this.txtUpdateBooingPhone.Location = new System.Drawing.Point(147, 162);
            this.txtUpdateBooingPhone.Name = "txtUpdateBooingPhone";
            this.txtUpdateBooingPhone.Size = new System.Drawing.Size(173, 29);
            this.txtUpdateBooingPhone.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Phone";
            // 
            // txtUpdateForeName
            // 
            this.txtUpdateForeName.Location = new System.Drawing.Point(147, 52);
            this.txtUpdateForeName.Name = "txtUpdateForeName";
            this.txtUpdateForeName.Size = new System.Drawing.Size(173, 29);
            this.txtUpdateForeName.TabIndex = 21;
            // 
            // txtUpdateBookingEmail
            // 
            this.txtUpdateBookingEmail.Location = new System.Drawing.Point(480, 110);
            this.txtUpdateBookingEmail.Name = "txtUpdateBookingEmail";
            this.txtUpdateBookingEmail.Size = new System.Drawing.Size(173, 29);
            this.txtUpdateBookingEmail.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Email";
            // 
            // txtUpdateSurname
            // 
            this.txtUpdateSurname.Location = new System.Drawing.Point(480, 52);
            this.txtUpdateSurname.Name = "txtUpdateSurname";
            this.txtUpdateSurname.Size = new System.Drawing.Size(173, 29);
            this.txtUpdateSurname.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Forename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "DOB\r\n";
            // 
            // cboUpdateDeptAirportDetail
            // 
            this.cboUpdateDeptAirportDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUpdateDeptAirportDetail.FormattingEnabled = true;
            this.cboUpdateDeptAirportDetail.Location = new System.Drawing.Point(216, 52);
            this.cboUpdateDeptAirportDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboUpdateDeptAirportDetail.Name = "cboUpdateDeptAirportDetail";
            this.cboUpdateDeptAirportDetail.Size = new System.Drawing.Size(110, 29);
            this.cboUpdateDeptAirportDetail.TabIndex = 64;
            this.cboUpdateDeptAirportDetail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboUpdateDeptAirportDetail_MouseClick);
            // 
            // lblArrAirport
            // 
            this.lblArrAirport.AutoSize = true;
            this.lblArrAirport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrAirport.Location = new System.Drawing.Point(415, 41);
            this.lblArrAirport.Name = "lblArrAirport";
            this.lblArrAirport.Size = new System.Drawing.Size(109, 21);
            this.lblArrAirport.TabIndex = 60;
            this.lblArrAirport.Text = "Arrival Airport";
            // 
            // lblDeptAirport
            // 
            this.lblDeptAirport.AutoSize = true;
            this.lblDeptAirport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptAirport.Location = new System.Drawing.Point(56, 39);
            this.lblDeptAirport.Name = "lblDeptAirport";
            this.lblDeptAirport.Size = new System.Drawing.Size(133, 21);
            this.lblDeptAirport.TabIndex = 62;
            this.lblDeptAirport.Text = "Departure Airport";
            // 
            // lblDepartDate
            // 
            this.lblDepartDate.AutoSize = true;
            this.lblDepartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartDate.Location = new System.Drawing.Point(56, 102);
            this.lblDepartDate.Name = "lblDepartDate";
            this.lblDepartDate.Size = new System.Drawing.Size(116, 21);
            this.lblDepartDate.TabIndex = 52;
            this.lblDepartDate.Text = "Departure Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "No. Baggage";
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureTime.Location = new System.Drawing.Point(415, 110);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(118, 21);
            this.lblDepartureTime.TabIndex = 50;
            this.lblDepartureTime.Text = "Departure Time";
            // 
            // nudNumBaggage
            // 
            this.nudNumBaggage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumBaggage.Location = new System.Drawing.Point(216, 167);
            this.nudNumBaggage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudNumBaggage.Name = "nudNumBaggage";
            this.nudNumBaggage.Size = new System.Drawing.Size(34, 29);
            this.nudNumBaggage.TabIndex = 56;
            // 
            // lbFlightlBookingPrice
            // 
            this.lbFlightlBookingPrice.AutoSize = true;
            this.lbFlightlBookingPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlightlBookingPrice.Location = new System.Drawing.Point(14, 236);
            this.lbFlightlBookingPrice.Name = "lbFlightlBookingPrice";
            this.lbFlightlBookingPrice.Size = new System.Drawing.Size(44, 21);
            this.lbFlightlBookingPrice.TabIndex = 60;
            this.lbFlightlBookingPrice.Text = "Price";
            // 
            // lblUpdateFlightNumberDetail
            // 
            this.lblUpdateFlightNumberDetail.AutoSize = true;
            this.lblUpdateFlightNumberDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateFlightNumberDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblUpdateFlightNumberDetail.Location = new System.Drawing.Point(124, 115);
            this.lblUpdateFlightNumberDetail.Name = "lblUpdateFlightNumberDetail";
            this.lblUpdateFlightNumberDetail.Size = new System.Drawing.Size(77, 21);
            this.lblUpdateFlightNumberDetail.TabIndex = 47;
            this.lblUpdateFlightNumberDetail.Text = "Unknown";
            // 
            // lbFlightlBookingPriceDetail
            // 
            this.lbFlightlBookingPriceDetail.AutoSize = true;
            this.lbFlightlBookingPriceDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlightlBookingPriceDetail.ForeColor = System.Drawing.Color.Plum;
            this.lbFlightlBookingPriceDetail.Location = new System.Drawing.Point(124, 236);
            this.lbFlightlBookingPriceDetail.Name = "lbFlightlBookingPriceDetail";
            this.lbFlightlBookingPriceDetail.Size = new System.Drawing.Size(77, 21);
            this.lbFlightlBookingPriceDetail.TabIndex = 59;
            this.lbFlightlBookingPriceDetail.Text = "Unknown";
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumber.Location = new System.Drawing.Point(14, 115);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(111, 21);
            this.lblFlightNumber.TabIndex = 48;
            this.lblFlightNumber.Text = "Flight Number";
            // 
            // btnUpdateBookingIDSearch
            // 
            this.btnUpdateBookingIDSearch.BackColor = System.Drawing.Color.Plum;
            this.btnUpdateBookingIDSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnUpdateBookingIDSearch.Location = new System.Drawing.Point(501, 67);
            this.btnUpdateBookingIDSearch.Name = "btnUpdateBookingIDSearch";
            this.btnUpdateBookingIDSearch.Size = new System.Drawing.Size(126, 28);
            this.btnUpdateBookingIDSearch.TabIndex = 28;
            this.btnUpdateBookingIDSearch.Text = "SEARCH";
            this.btnUpdateBookingIDSearch.UseVisualStyleBackColor = false;
            this.btnUpdateBookingIDSearch.Click += new System.EventHandler(this.btnUpdateBookingIDSearch_Click);
            // 
            // lblSeatNum
            // 
            this.lblSeatNum.AutoSize = true;
            this.lblSeatNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatNum.Location = new System.Drawing.Point(14, 196);
            this.lblSeatNum.Name = "lblSeatNum";
            this.lblSeatNum.Size = new System.Drawing.Size(102, 21);
            this.lblSeatNum.TabIndex = 58;
            this.lblSeatNum.Text = "Seat Number";
            // 
            // lblSeatNumDetail
            // 
            this.lblSeatNumDetail.AutoSize = true;
            this.lblSeatNumDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatNumDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblSeatNumDetail.Location = new System.Drawing.Point(124, 196);
            this.lblSeatNumDetail.Name = "lblSeatNumDetail";
            this.lblSeatNumDetail.Size = new System.Drawing.Size(77, 21);
            this.lblSeatNumDetail.TabIndex = 57;
            this.lblSeatNumDetail.Text = "Unknown";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbFlightlBookingPrice);
            this.groupBox1.Controls.Add(this.lblSeatNumDetail);
            this.groupBox1.Controls.Add(this.lblSeatNum);
            this.groupBox1.Controls.Add(this.lblUpdateBookingRouteID);
            this.groupBox1.Controls.Add(this.lbFlightlBookingPriceDetail);
            this.groupBox1.Controls.Add(this.lblUpdateBookingID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblbok);
            this.groupBox1.Controls.Add(this.lblUpdateFlightNumberDetail);
            this.groupBox1.Controls.Add(this.lblUpdatePassengerID);
            this.groupBox1.Controls.Add(this.passenger);
            this.groupBox1.Controls.Add(this.lblFlightNumber);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(837, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 293);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retrieved Booking Details";
            // 
            // lblUpdateBookingRouteID
            // 
            this.lblUpdateBookingRouteID.AutoSize = true;
            this.lblUpdateBookingRouteID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateBookingRouteID.ForeColor = System.Drawing.Color.Plum;
            this.lblUpdateBookingRouteID.Location = new System.Drawing.Point(124, 155);
            this.lblUpdateBookingRouteID.Name = "lblUpdateBookingRouteID";
            this.lblUpdateBookingRouteID.Size = new System.Drawing.Size(77, 21);
            this.lblUpdateBookingRouteID.TabIndex = 68;
            this.lblUpdateBookingRouteID.Text = "Unknown";
            // 
            // lblUpdateBookingID
            // 
            this.lblUpdateBookingID.AutoSize = true;
            this.lblUpdateBookingID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateBookingID.ForeColor = System.Drawing.Color.Plum;
            this.lblUpdateBookingID.Location = new System.Drawing.Point(124, 33);
            this.lblUpdateBookingID.Name = "lblUpdateBookingID";
            this.lblUpdateBookingID.Size = new System.Drawing.Size(77, 21);
            this.lblUpdateBookingID.TabIndex = 64;
            this.lblUpdateBookingID.Text = "Unknown";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 21);
            this.label10.TabIndex = 69;
            this.label10.Text = "Route";
            // 
            // lblbok
            // 
            this.lblbok.AutoSize = true;
            this.lblbok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbok.Location = new System.Drawing.Point(14, 33);
            this.lblbok.Name = "lblbok";
            this.lblbok.Size = new System.Drawing.Size(91, 21);
            this.lblbok.TabIndex = 65;
            this.lblbok.Text = "BookiongID";
            // 
            // lblUpdatePassengerID
            // 
            this.lblUpdatePassengerID.AutoSize = true;
            this.lblUpdatePassengerID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePassengerID.ForeColor = System.Drawing.Color.Plum;
            this.lblUpdatePassengerID.Location = new System.Drawing.Point(124, 74);
            this.lblUpdatePassengerID.Name = "lblUpdatePassengerID";
            this.lblUpdatePassengerID.Size = new System.Drawing.Size(77, 21);
            this.lblUpdatePassengerID.TabIndex = 66;
            this.lblUpdatePassengerID.Text = "Unknown";
            // 
            // passenger
            // 
            this.passenger.AutoSize = true;
            this.passenger.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passenger.Location = new System.Drawing.Point(14, 74);
            this.passenger.Name = "passenger";
            this.passenger.Size = new System.Drawing.Size(95, 21);
            this.passenger.TabIndex = 67;
            this.passenger.Text = "PassengerID";
            // 
            // frmUpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 684);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdateBookingIDSearch);
            this.Controls.Add(this.btnUpadateBookingConfirm);
            this.Controls.Add(this.grpUpdateCreateBookingDetails);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuUpdateBooking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateBooking";
            this.Text = "Update Booking";
            this.grpUpdateCreateBookingDetails.ResumeLayout(false);
            this.grpUpdateCreateBookingDetails.PerformLayout();
            this.grpPersonalCreateBookingDetails.ResumeLayout(false);
            this.grpPersonalCreateBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumBaggage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuUpdateBooking;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpadateBookingConfirm;
        private System.Windows.Forms.GroupBox grpUpdateCreateBookingDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpPersonalCreateBookingDetails;
        private System.Windows.Forms.DateTimePicker dtpDOBUpdate;
        private System.Windows.Forms.TextBox txtUpdateEircode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdateBooingPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpdateForeName;
        private System.Windows.Forms.TextBox txtUpdateBookingEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpdateSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateBookingIDSearch;
        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.Label lblUpdateFlightNumberDetail;
        public System.Windows.Forms.NumericUpDown nudNumBaggage;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblDepartDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSeatNum;
        private System.Windows.Forms.Label lblSeatNumDetail;
        private System.Windows.Forms.Label lblArrAirport;
        private System.Windows.Forms.Label lbFlightlBookingPriceDetail;
        private System.Windows.Forms.Label lblDeptAirport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboUpdateDeptAirportDetail;
        private System.Windows.Forms.ComboBox cboUpdateArrAirportDetail;
        private System.Windows.Forms.DateTimePicker dptUpdateBookingDate;
        private System.Windows.Forms.ComboBox cboDeptimeDetail;
        private System.Windows.Forms.Label lbFlightlBookingPrice;
        private System.Windows.Forms.Label lblUpdateBookingID;
        private System.Windows.Forms.Label lblbok;
        private System.Windows.Forms.Label lblUpdatePassengerID;
        private System.Windows.Forms.Label passenger;
        private System.Windows.Forms.Label lblUpdateBookingRouteID;
        private System.Windows.Forms.Label label10;
    }
}