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
            this.lbFlightlBookingPrice = new System.Windows.Forms.Label();
            this.cboDeptimeDetail = new System.Windows.Forms.ComboBox();
            this.lblFlightNumberDetail = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dptUpdateBookingDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.lbFlightlBookingPriceDetail = new System.Windows.Forms.Label();
            this.cboUpdateArrAirportDetail = new System.Windows.Forms.ComboBox();
            this.grpPersonalCreateBookingDetails = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.grpPaymentDetails = new System.Windows.Forms.GroupBox();
            this.txtCreateBookingEircode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreateBooingPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtForeName = new System.Windows.Forms.TextBox();
            this.txtCreateBookingEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.cboUpdateDeptAirportDetail = new System.Windows.Forms.ComboBox();
            this.lblArrAirport = new System.Windows.Forms.Label();
            this.lblDeptAirport = new System.Windows.Forms.Label();
            this.lblDepartDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.nudNumBaggage = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateBookingIDSearch = new System.Windows.Forms.Button();
            this.lblSeatNum = new System.Windows.Forms.Label();
            this.lblSeatNumDetail = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblBookingid = new System.Windows.Forms.Label();
            this.lblbok = new System.Windows.Forms.Label();
            this.lblPassengerid = new System.Windows.Forms.Label();
            this.passenger = new System.Windows.Forms.Label();
            this.lblrouteid = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grpUpdateCreateBookingDetails.SuspendLayout();
            this.grpPersonalCreateBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumBaggage)).BeginInit();
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
            // mnuUpdateBooking
            // 
            this.mnuUpdateBooking.BackColor = System.Drawing.Color.Plum;
            this.mnuUpdateBooking.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuUpdateBooking.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateBooking.Name = "mnuUpdateBooking";
            this.mnuUpdateBooking.Padding = new System.Windows.Forms.Padding(0);
            this.mnuUpdateBooking.Size = new System.Drawing.Size(1924, 24);
            this.mnuUpdateBooking.TabIndex = 6;
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(33, 34);
            this.lblAddAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(210, 37);
            this.lblAddAirport.TabIndex = 17;
            this.lblAddAirport.Text = "Update Booking";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingID.Location = new System.Drawing.Point(392, 82);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(229, 34);
            this.txtBookingID.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(232, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 28);
            this.label9.TabIndex = 24;
            this.label9.Text = "Booking ID";
            // 
            // btnUpadateBookingConfirm
            // 
            this.btnUpadateBookingConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnUpadateBookingConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpadateBookingConfirm.Location = new System.Drawing.Point(428, 926);
            this.btnUpadateBookingConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpadateBookingConfirm.Name = "btnUpadateBookingConfirm";
            this.btnUpadateBookingConfirm.Size = new System.Drawing.Size(232, 47);
            this.btnUpadateBookingConfirm.TabIndex = 27;
            this.btnUpadateBookingConfirm.Text = "CONFIRM";
            this.btnUpadateBookingConfirm.UseVisualStyleBackColor = false;
            this.btnUpadateBookingConfirm.Click += new System.EventHandler(this.btnUpadateBookingConfirm_Click);
            // 
            // grpUpdateCreateBookingDetails
            // 
            this.grpUpdateCreateBookingDetails.Controls.Add(this.lbFlightlBookingPrice);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.cboDeptimeDetail);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.lblFlightNumberDetail);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.label13);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.dptUpdateBookingDate);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.label14);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.lbFlightlBookingPriceDetail);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.cboUpdateArrAirportDetail);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.grpPersonalCreateBookingDetails);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.lblFlightNumber);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.cboUpdateDeptAirportDetail);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.lblArrAirport);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.lblDeptAirport);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.lblDepartDate);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.label7);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.lblDepartureTime);
            this.grpUpdateCreateBookingDetails.Controls.Add(this.nudNumBaggage);
            this.grpUpdateCreateBookingDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateCreateBookingDetails.Location = new System.Drawing.Point(35, 183);
            this.grpUpdateCreateBookingDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpUpdateCreateBookingDetails.Name = "grpUpdateCreateBookingDetails";
            this.grpUpdateCreateBookingDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpUpdateCreateBookingDetails.Size = new System.Drawing.Size(999, 734);
            this.grpUpdateCreateBookingDetails.TabIndex = 26;
            this.grpUpdateCreateBookingDetails.TabStop = false;
            this.grpUpdateCreateBookingDetails.Text = "Update Booking Details";
            // 
            // lbFlightlBookingPrice
            // 
            this.lbFlightlBookingPrice.AutoSize = true;
            this.lbFlightlBookingPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlightlBookingPrice.Location = new System.Drawing.Point(558, 294);
            this.lbFlightlBookingPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFlightlBookingPrice.Name = "lbFlightlBookingPrice";
            this.lbFlightlBookingPrice.Size = new System.Drawing.Size(55, 28);
            this.lbFlightlBookingPrice.TabIndex = 60;
            this.lbFlightlBookingPrice.Text = "price";
            // 
            // cboDeptimeDetail
            // 
            this.cboDeptimeDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptimeDetail.FormattingEnabled = true;
            this.cboDeptimeDetail.Location = new System.Drawing.Point(774, 171);
            this.cboDeptimeDetail.Name = "cboDeptimeDetail";
            this.cboDeptimeDetail.Size = new System.Drawing.Size(145, 36);
            this.cboDeptimeDetail.TabIndex = 67;
            // 
            // lblFlightNumberDetail
            // 
            this.lblFlightNumberDetail.AutoSize = true;
            this.lblFlightNumberDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumberDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblFlightNumberDetail.Location = new System.Drawing.Point(770, 237);
            this.lblFlightNumberDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightNumberDetail.Name = "lblFlightNumberDetail";
            this.lblFlightNumberDetail.Size = new System.Drawing.Size(95, 28);
            this.lblFlightNumberDetail.TabIndex = 47;
            this.lblFlightNumberDetail.Text = "Unknown";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(388, -30);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 28);
            this.label13.TabIndex = 54;
            this.label13.Text = "Flight Number";
            // 
            // dptUpdateBookingDate
            // 
            this.dptUpdateBookingDate.CustomFormat = "dd-MM-yy";
            this.dptUpdateBookingDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptUpdateBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptUpdateBookingDate.Location = new System.Drawing.Point(293, 171);
            this.dptUpdateBookingDate.Name = "dptUpdateBookingDate";
            this.dptUpdateBookingDate.Size = new System.Drawing.Size(145, 34);
            this.dptUpdateBookingDate.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Plum;
            this.label14.Location = new System.Drawing.Point(540, -30);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 28);
            this.label14.TabIndex = 53;
            this.label14.Text = "Unknown";
            // 
            // lbFlightlBookingPriceDetail
            // 
            this.lbFlightlBookingPriceDetail.AutoSize = true;
            this.lbFlightlBookingPriceDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlightlBookingPriceDetail.ForeColor = System.Drawing.Color.Plum;
            this.lbFlightlBookingPriceDetail.Location = new System.Drawing.Point(761, 294);
            this.lbFlightlBookingPriceDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFlightlBookingPriceDetail.Name = "lbFlightlBookingPriceDetail";
            this.lbFlightlBookingPriceDetail.Size = new System.Drawing.Size(95, 28);
            this.lbFlightlBookingPriceDetail.TabIndex = 59;
            this.lbFlightlBookingPriceDetail.Text = "Unknown";
            // 
            // cboUpdateArrAirportDetail
            // 
            this.cboUpdateArrAirportDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUpdateArrAirportDetail.FormattingEnabled = true;
            this.cboUpdateArrAirportDetail.Location = new System.Drawing.Point(774, 92);
            this.cboUpdateArrAirportDetail.Name = "cboUpdateArrAirportDetail";
            this.cboUpdateArrAirportDetail.Size = new System.Drawing.Size(145, 36);
            this.cboUpdateArrAirportDetail.TabIndex = 65;
            // 
            // grpPersonalCreateBookingDetails
            // 
            this.grpPersonalCreateBookingDetails.Controls.Add(this.dtpDOB);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.grpPaymentDetails);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtCreateBookingEircode);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label6);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtCreateBooingPhone);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label5);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtForeName);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtCreateBookingEmail);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label2);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label4);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtSurname);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label1);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label3);
            this.grpPersonalCreateBookingDetails.Location = new System.Drawing.Point(38, 332);
            this.grpPersonalCreateBookingDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpPersonalCreateBookingDetails.Name = "grpPersonalCreateBookingDetails";
            this.grpPersonalCreateBookingDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpPersonalCreateBookingDetails.Size = new System.Drawing.Size(923, 430);
            this.grpPersonalCreateBookingDetails.TabIndex = 35;
            this.grpPersonalCreateBookingDetails.TabStop = false;
            this.grpPersonalCreateBookingDetails.Text = "Update Personal Details";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd-MM-yy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(196, 151);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(229, 34);
            this.dtpDOB.TabIndex = 41;
            // 
            // grpPaymentDetails
            // 
            this.grpPaymentDetails.Location = new System.Drawing.Point(60, 284);
            this.grpPaymentDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpPaymentDetails.Name = "grpPaymentDetails";
            this.grpPaymentDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpPaymentDetails.Size = new System.Drawing.Size(833, 94);
            this.grpPaymentDetails.TabIndex = 39;
            this.grpPaymentDetails.TabStop = false;
            this.grpPaymentDetails.Text = "Payment Details";
            // 
            // txtCreateBookingEircode
            // 
            this.txtCreateBookingEircode.Location = new System.Drawing.Point(640, 215);
            this.txtCreateBookingEircode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreateBookingEircode.Name = "txtCreateBookingEircode";
            this.txtCreateBookingEircode.Size = new System.Drawing.Size(229, 34);
            this.txtCreateBookingEircode.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(503, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Eircode";
            // 
            // txtCreateBooingPhone
            // 
            this.txtCreateBooingPhone.Location = new System.Drawing.Point(196, 214);
            this.txtCreateBooingPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreateBooingPhone.Name = "txtCreateBooingPhone";
            this.txtCreateBooingPhone.Size = new System.Drawing.Size(229, 34);
            this.txtCreateBooingPhone.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Phone";
            // 
            // txtForeName
            // 
            this.txtForeName.Location = new System.Drawing.Point(196, 79);
            this.txtForeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtForeName.Name = "txtForeName";
            this.txtForeName.Size = new System.Drawing.Size(229, 34);
            this.txtForeName.TabIndex = 21;
            // 
            // txtCreateBookingEmail
            // 
            this.txtCreateBookingEmail.Location = new System.Drawing.Point(640, 151);
            this.txtCreateBookingEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreateBookingEmail.Name = "txtCreateBookingEmail";
            this.txtCreateBookingEmail.Size = new System.Drawing.Size(229, 34);
            this.txtCreateBookingEmail.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Email";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(640, 79);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(229, 34);
            this.txtSurname.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Forename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "DOB\r\n";
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumber.Location = new System.Drawing.Point(558, 237);
            this.lblFlightNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(139, 28);
            this.lblFlightNumber.TabIndex = 48;
            this.lblFlightNumber.Text = "Flight Number";
            // 
            // cboUpdateDeptAirportDetail
            // 
            this.cboUpdateDeptAirportDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUpdateDeptAirportDetail.FormattingEnabled = true;
            this.cboUpdateDeptAirportDetail.Location = new System.Drawing.Point(293, 83);
            this.cboUpdateDeptAirportDetail.Name = "cboUpdateDeptAirportDetail";
            this.cboUpdateDeptAirportDetail.Size = new System.Drawing.Size(145, 36);
            this.cboUpdateDeptAirportDetail.TabIndex = 64;
            // 
            // lblArrAirport
            // 
            this.lblArrAirport.AutoSize = true;
            this.lblArrAirport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrAirport.Location = new System.Drawing.Point(558, 85);
            this.lblArrAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrAirport.Name = "lblArrAirport";
            this.lblArrAirport.Size = new System.Drawing.Size(137, 28);
            this.lblArrAirport.TabIndex = 60;
            this.lblArrAirport.Text = "Arrival Airport";
            // 
            // lblDeptAirport
            // 
            this.lblDeptAirport.AutoSize = true;
            this.lblDeptAirport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptAirport.Location = new System.Drawing.Point(79, 83);
            this.lblDeptAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeptAirport.Name = "lblDeptAirport";
            this.lblDeptAirport.Size = new System.Drawing.Size(168, 28);
            this.lblDeptAirport.TabIndex = 62;
            this.lblDeptAirport.Text = "Departure Airport";
            // 
            // lblDepartDate
            // 
            this.lblDepartDate.AutoSize = true;
            this.lblDepartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartDate.Location = new System.Drawing.Point(79, 169);
            this.lblDepartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartDate.Name = "lblDepartDate";
            this.lblDepartDate.Size = new System.Drawing.Size(146, 28);
            this.lblDepartDate.TabIndex = 52;
            this.lblDepartDate.Text = "Departure Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 39;
            this.label7.Text = "No. Baggage";
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureTime.Location = new System.Drawing.Point(558, 171);
            this.lblDepartureTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(147, 28);
            this.lblDepartureTime.TabIndex = 50;
            this.lblDepartureTime.Text = "Departure Time";
            // 
            // nudNumBaggage
            // 
            this.nudNumBaggage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumBaggage.Location = new System.Drawing.Point(293, 257);
            this.nudNumBaggage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudNumBaggage.Name = "nudNumBaggage";
            this.nudNumBaggage.Size = new System.Drawing.Size(45, 34);
            this.nudNumBaggage.TabIndex = 56;
            // 
            // btnUpdateBookingIDSearch
            // 
            this.btnUpdateBookingIDSearch.BackColor = System.Drawing.Color.Plum;
            this.btnUpdateBookingIDSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnUpdateBookingIDSearch.Location = new System.Drawing.Point(668, 82);
            this.btnUpdateBookingIDSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateBookingIDSearch.Name = "btnUpdateBookingIDSearch";
            this.btnUpdateBookingIDSearch.Size = new System.Drawing.Size(168, 34);
            this.btnUpdateBookingIDSearch.TabIndex = 28;
            this.btnUpdateBookingIDSearch.Text = "SEARCH";
            this.btnUpdateBookingIDSearch.UseVisualStyleBackColor = false;
            this.btnUpdateBookingIDSearch.Click += new System.EventHandler(this.btnUpdateBookingIDSearch_Click);
            // 
            // lblSeatNum
            // 
            this.lblSeatNum.AutoSize = true;
            this.lblSeatNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatNum.Location = new System.Drawing.Point(593, 151);
            this.lblSeatNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeatNum.Name = "lblSeatNum";
            this.lblSeatNum.Size = new System.Drawing.Size(127, 28);
            this.lblSeatNum.TabIndex = 58;
            this.lblSeatNum.Text = "Seat Number";
            // 
            // lblSeatNumDetail
            // 
            this.lblSeatNumDetail.AutoSize = true;
            this.lblSeatNumDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatNumDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblSeatNumDetail.Location = new System.Drawing.Point(728, 151);
            this.lblSeatNumDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeatNumDetail.Name = "lblSeatNumDetail";
            this.lblSeatNumDetail.Size = new System.Drawing.Size(95, 28);
            this.lblSeatNumDetail.TabIndex = 57;
            this.lblSeatNumDetail.Text = "Unknown";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1116, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(296, 194);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retrieved Booking Details";
            // 
            // lblBookingid
            // 
            this.lblBookingid.AutoSize = true;
            this.lblBookingid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingid.ForeColor = System.Drawing.Color.Plum;
            this.lblBookingid.Location = new System.Drawing.Point(446, 142);
            this.lblBookingid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingid.Name = "lblBookingid";
            this.lblBookingid.Size = new System.Drawing.Size(95, 28);
            this.lblBookingid.TabIndex = 64;
            this.lblBookingid.Text = "Unknown";
            // 
            // lblbok
            // 
            this.lblbok.AutoSize = true;
            this.lblbok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbok.Location = new System.Drawing.Point(311, 142);
            this.lblbok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbok.Name = "lblbok";
            this.lblbok.Size = new System.Drawing.Size(86, 28);
            this.lblbok.TabIndex = 65;
            this.lblbok.Text = "booking";
            // 
            // lblPassengerid
            // 
            this.lblPassengerid.AutoSize = true;
            this.lblPassengerid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerid.ForeColor = System.Drawing.Color.Plum;
            this.lblPassengerid.Location = new System.Drawing.Point(974, 142);
            this.lblPassengerid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassengerid.Name = "lblPassengerid";
            this.lblPassengerid.Size = new System.Drawing.Size(95, 28);
            this.lblPassengerid.TabIndex = 66;
            this.lblPassengerid.Text = "Unknown";
            // 
            // passenger
            // 
            this.passenger.AutoSize = true;
            this.passenger.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passenger.Location = new System.Drawing.Point(839, 151);
            this.passenger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passenger.Name = "passenger";
            this.passenger.Size = new System.Drawing.Size(100, 28);
            this.passenger.TabIndex = 67;
            this.passenger.Text = "passenger";
            // 
            // lblrouteid
            // 
            this.lblrouteid.AutoSize = true;
            this.lblrouteid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrouteid.ForeColor = System.Drawing.Color.Plum;
            this.lblrouteid.Location = new System.Drawing.Point(187, 142);
            this.lblrouteid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrouteid.Name = "lblrouteid";
            this.lblrouteid.Size = new System.Drawing.Size(95, 28);
            this.lblrouteid.TabIndex = 68;
            this.lblrouteid.Text = "Unknown";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 142);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 28);
            this.label10.TabIndex = 69;
            this.label10.Text = "Route";
            // 
            // frmUpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1002);
            this.Controls.Add(this.lblrouteid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPassengerid);
            this.Controls.Add(this.passenger);
            this.Controls.Add(this.lblBookingid);
            this.Controls.Add(this.lblbok);
            this.Controls.Add(this.lblSeatNumDetail);
            this.Controls.Add(this.lblSeatNum);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUpdateBooking";
            this.Text = "Update Booking";
            this.Load += new System.EventHandler(this.frmUpdateBooking_Load);
            this.grpUpdateCreateBookingDetails.ResumeLayout(false);
            this.grpUpdateCreateBookingDetails.PerformLayout();
            this.grpPersonalCreateBookingDetails.ResumeLayout(false);
            this.grpPersonalCreateBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumBaggage)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.GroupBox grpPaymentDetails;
        private System.Windows.Forms.TextBox txtCreateBookingEircode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCreateBooingPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtForeName;
        private System.Windows.Forms.TextBox txtCreateBookingEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateBookingIDSearch;
        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.Label lblFlightNumberDetail;
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
        private System.Windows.Forms.Label lblBookingid;
        private System.Windows.Forms.Label lblbok;
        private System.Windows.Forms.Label lblPassengerid;
        private System.Windows.Forms.Label passenger;
        private System.Windows.Forms.Label lblrouteid;
        private System.Windows.Forms.Label label10;
    }
}