namespace AirlineSYS
{
    partial class frmCancelBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelBooking));
            this.munBack = new System.Windows.Forms.Label();
            this.mnuCancelBooking = new System.Windows.Forms.MenuStrip();
            this.btnAirportConfirm = new System.Windows.Forms.Button();
            this.grpAirportDetails = new System.Windows.Forms.GroupBox();
            this.cboCancelDeptimeDetail = new System.Windows.Forms.ComboBox();
            this.dptCancelBookingDate = new System.Windows.Forms.DateTimePicker();
            this.cboCancelArrAirportDetail = new System.Windows.Forms.ComboBox();
            this.grpPersonalCreateBookingDetails = new System.Windows.Forms.GroupBox();
            this.dtpDOBUpdate = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateEircode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateBooingPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCancelForeName = new System.Windows.Forms.TextBox();
            this.txtUpdateBookingEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCancelDeptAirportDetail = new System.Windows.Forms.ComboBox();
            this.lblArrAirport = new System.Windows.Forms.Label();
            this.lblDeptAirport = new System.Windows.Forms.Label();
            this.lblDepartDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.nudCancelNumBaggage = new System.Windows.Forms.NumericUpDown();
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.btnCancelBookingIDSearch = new System.Windows.Forms.Button();
            this.txtCancelBookingID = new System.Windows.Forms.TextBox();
            this.lblCancelSearchBookingID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCancelSeatNumDetail = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCancelBookingRouteID = new System.Windows.Forms.Label();
            this.lbCancelFlightBookingPrice = new System.Windows.Forms.Label();
            this.lblCancelBookingID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCancelFlightNumber = new System.Windows.Forms.Label();
            this.lblCancelPassengerID = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpAirportDetails.SuspendLayout();
            this.grpPersonalCreateBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCancelNumBaggage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(740, -1);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.munBack.Size = new System.Drawing.Size(60, 20);
            this.munBack.TabIndex = 5;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // mnuCancelBooking
            // 
            this.mnuCancelBooking.BackColor = System.Drawing.Color.Plum;
            this.mnuCancelBooking.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCancelBooking.Location = new System.Drawing.Point(0, 0);
            this.mnuCancelBooking.Name = "mnuCancelBooking";
            this.mnuCancelBooking.Padding = new System.Windows.Forms.Padding(0);
            this.mnuCancelBooking.Size = new System.Drawing.Size(1095, 24);
            this.mnuCancelBooking.TabIndex = 4;
            // 
            // btnAirportConfirm
            // 
            this.btnAirportConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnAirportConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirportConfirm.Location = new System.Drawing.Point(313, 594);
            this.btnAirportConfirm.Name = "btnAirportConfirm";
            this.btnAirportConfirm.Size = new System.Drawing.Size(174, 38);
            this.btnAirportConfirm.TabIndex = 28;
            this.btnAirportConfirm.Text = "CONFIRM";
            this.btnAirportConfirm.UseVisualStyleBackColor = false;
            this.btnAirportConfirm.Click += new System.EventHandler(this.btnAirportConfirm_Click);
            // 
            // grpAirportDetails
            // 
            this.grpAirportDetails.Controls.Add(this.cboCancelDeptimeDetail);
            this.grpAirportDetails.Controls.Add(this.dptCancelBookingDate);
            this.grpAirportDetails.Controls.Add(this.cboCancelArrAirportDetail);
            this.grpAirportDetails.Controls.Add(this.grpPersonalCreateBookingDetails);
            this.grpAirportDetails.Controls.Add(this.cboCancelDeptAirportDetail);
            this.grpAirportDetails.Controls.Add(this.lblArrAirport);
            this.grpAirportDetails.Controls.Add(this.lblDeptAirport);
            this.grpAirportDetails.Controls.Add(this.lblDepartDate);
            this.grpAirportDetails.Controls.Add(this.label7);
            this.grpAirportDetails.Controls.Add(this.lblDepartureTime);
            this.grpAirportDetails.Controls.Add(this.nudCancelNumBaggage);
            this.grpAirportDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAirportDetails.Location = new System.Drawing.Point(26, 102);
            this.grpAirportDetails.Name = "grpAirportDetails";
            this.grpAirportDetails.Size = new System.Drawing.Size(749, 467);
            this.grpAirportDetails.TabIndex = 27;
            this.grpAirportDetails.TabStop = false;
            this.grpAirportDetails.Text = "Cancel Booking Details";
            // 
            // cboCancelDeptimeDetail
            // 
            this.cboCancelDeptimeDetail.Enabled = false;
            this.cboCancelDeptimeDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCancelDeptimeDetail.FormattingEnabled = true;
            this.cboCancelDeptimeDetail.Location = new System.Drawing.Point(578, 104);
            this.cboCancelDeptimeDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCancelDeptimeDetail.Name = "cboCancelDeptimeDetail";
            this.cboCancelDeptimeDetail.Size = new System.Drawing.Size(110, 29);
            this.cboCancelDeptimeDetail.TabIndex = 78;
            // 
            // dptCancelBookingDate
            // 
            this.dptCancelBookingDate.CustomFormat = "dd-MM-yy";
            this.dptCancelBookingDate.Enabled = false;
            this.dptCancelBookingDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptCancelBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptCancelBookingDate.Location = new System.Drawing.Point(217, 104);
            this.dptCancelBookingDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dptCancelBookingDate.Name = "dptCancelBookingDate";
            this.dptCancelBookingDate.Size = new System.Drawing.Size(110, 29);
            this.dptCancelBookingDate.TabIndex = 77;
            // 
            // cboCancelArrAirportDetail
            // 
            this.cboCancelArrAirportDetail.Enabled = false;
            this.cboCancelArrAirportDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCancelArrAirportDetail.FormattingEnabled = true;
            this.cboCancelArrAirportDetail.Location = new System.Drawing.Point(578, 41);
            this.cboCancelArrAirportDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCancelArrAirportDetail.Name = "cboCancelArrAirportDetail";
            this.cboCancelArrAirportDetail.Size = new System.Drawing.Size(110, 29);
            this.cboCancelArrAirportDetail.TabIndex = 76;
            // 
            // grpPersonalCreateBookingDetails
            // 
            this.grpPersonalCreateBookingDetails.Controls.Add(this.dtpDOBUpdate);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtUpdateEircode);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label6);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtUpdateBooingPhone);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label5);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtCancelForeName);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtUpdateBookingEmail);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label2);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label4);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtUpdateSurname);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label1);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label3);
            this.grpPersonalCreateBookingDetails.Location = new System.Drawing.Point(28, 219);
            this.grpPersonalCreateBookingDetails.Name = "grpPersonalCreateBookingDetails";
            this.grpPersonalCreateBookingDetails.Size = new System.Drawing.Size(692, 227);
            this.grpPersonalCreateBookingDetails.TabIndex = 68;
            this.grpPersonalCreateBookingDetails.TabStop = false;
            this.grpPersonalCreateBookingDetails.Text = "Cancel Personal Details";
            // 
            // dtpDOBUpdate
            // 
            this.dtpDOBUpdate.CustomFormat = "dd-MM-yy";
            this.dtpDOBUpdate.Enabled = false;
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
            this.txtUpdateEircode.ReadOnly = true;
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
            this.txtUpdateBooingPhone.ReadOnly = true;
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
            // txtCancelForeName
            // 
            this.txtCancelForeName.Location = new System.Drawing.Point(147, 52);
            this.txtCancelForeName.Name = "txtCancelForeName";
            this.txtCancelForeName.ReadOnly = true;
            this.txtCancelForeName.Size = new System.Drawing.Size(173, 29);
            this.txtCancelForeName.TabIndex = 21;
            // 
            // txtUpdateBookingEmail
            // 
            this.txtUpdateBookingEmail.Location = new System.Drawing.Point(480, 110);
            this.txtUpdateBookingEmail.Name = "txtUpdateBookingEmail";
            this.txtUpdateBookingEmail.ReadOnly = true;
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
            this.txtUpdateSurname.ReadOnly = true;
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
            // cboCancelDeptAirportDetail
            // 
            this.cboCancelDeptAirportDetail.Enabled = false;
            this.cboCancelDeptAirportDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCancelDeptAirportDetail.FormattingEnabled = true;
            this.cboCancelDeptAirportDetail.Location = new System.Drawing.Point(217, 46);
            this.cboCancelDeptAirportDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCancelDeptAirportDetail.Name = "cboCancelDeptAirportDetail";
            this.cboCancelDeptAirportDetail.Size = new System.Drawing.Size(110, 29);
            this.cboCancelDeptAirportDetail.TabIndex = 75;
            this.cboCancelDeptAirportDetail.BackColorChanged += new System.EventHandler(this.btnCancelBookingIDSearch_Click);
            // 
            // lblArrAirport
            // 
            this.lblArrAirport.AutoSize = true;
            this.lblArrAirport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrAirport.Location = new System.Drawing.Point(416, 35);
            this.lblArrAirport.Name = "lblArrAirport";
            this.lblArrAirport.Size = new System.Drawing.Size(109, 21);
            this.lblArrAirport.TabIndex = 73;
            this.lblArrAirport.Text = "Arrival Airport";
            // 
            // lblDeptAirport
            // 
            this.lblDeptAirport.AutoSize = true;
            this.lblDeptAirport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptAirport.Location = new System.Drawing.Point(57, 33);
            this.lblDeptAirport.Name = "lblDeptAirport";
            this.lblDeptAirport.Size = new System.Drawing.Size(133, 21);
            this.lblDeptAirport.TabIndex = 74;
            this.lblDeptAirport.Text = "Departure Airport";
            // 
            // lblDepartDate
            // 
            this.lblDepartDate.AutoSize = true;
            this.lblDepartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartDate.Location = new System.Drawing.Point(57, 97);
            this.lblDepartDate.Name = "lblDepartDate";
            this.lblDepartDate.Size = new System.Drawing.Size(116, 21);
            this.lblDepartDate.TabIndex = 71;
            this.lblDepartDate.Text = "Departure Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 69;
            this.label7.Text = "No. Baggage";
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureTime.Location = new System.Drawing.Point(416, 104);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(118, 21);
            this.lblDepartureTime.TabIndex = 70;
            this.lblDepartureTime.Text = "Departure Time";
            // 
            // nudCancelNumBaggage
            // 
            this.nudCancelNumBaggage.Enabled = false;
            this.nudCancelNumBaggage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCancelNumBaggage.Location = new System.Drawing.Point(217, 162);
            this.nudCancelNumBaggage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudCancelNumBaggage.Name = "nudCancelNumBaggage";
            this.nudCancelNumBaggage.Size = new System.Drawing.Size(34, 29);
            this.nudCancelNumBaggage.TabIndex = 72;
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(25, 28);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(156, 30);
            this.lblAddAirport.TabIndex = 26;
            this.lblAddAirport.Text = "Cancel Booking";
            // 
            // btnCancelBookingIDSearch
            // 
            this.btnCancelBookingIDSearch.BackColor = System.Drawing.Color.Plum;
            this.btnCancelBookingIDSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancelBookingIDSearch.Location = new System.Drawing.Point(500, 68);
            this.btnCancelBookingIDSearch.Name = "btnCancelBookingIDSearch";
            this.btnCancelBookingIDSearch.Size = new System.Drawing.Size(126, 28);
            this.btnCancelBookingIDSearch.TabIndex = 31;
            this.btnCancelBookingIDSearch.Text = "SEARCH";
            this.btnCancelBookingIDSearch.UseVisualStyleBackColor = false;
            this.btnCancelBookingIDSearch.Click += new System.EventHandler(this.btnCancelBookingIDSearch_Click);
            // 
            // txtCancelBookingID
            // 
            this.txtCancelBookingID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelBookingID.Location = new System.Drawing.Point(293, 68);
            this.txtCancelBookingID.Name = "txtCancelBookingID";
            this.txtCancelBookingID.Size = new System.Drawing.Size(173, 29);
            this.txtCancelBookingID.TabIndex = 30;
            // 
            // lblCancelSearchBookingID
            // 
            this.lblCancelSearchBookingID.AutoSize = true;
            this.lblCancelSearchBookingID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelSearchBookingID.Location = new System.Drawing.Point(173, 72);
            this.lblCancelSearchBookingID.Name = "lblCancelSearchBookingID";
            this.lblCancelSearchBookingID.Size = new System.Drawing.Size(86, 21);
            this.lblCancelSearchBookingID.TabIndex = 29;
            this.lblCancelSearchBookingID.Text = "Booking ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 21);
            this.label8.TabIndex = 60;
            this.label8.Text = "Price";
            // 
            // lblCancelSeatNumDetail
            // 
            this.lblCancelSeatNumDetail.AutoSize = true;
            this.lblCancelSeatNumDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelSeatNumDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblCancelSeatNumDetail.Location = new System.Drawing.Point(124, 196);
            this.lblCancelSeatNumDetail.Name = "lblCancelSeatNumDetail";
            this.lblCancelSeatNumDetail.Size = new System.Drawing.Size(77, 21);
            this.lblCancelSeatNumDetail.TabIndex = 57;
            this.lblCancelSeatNumDetail.Text = "Unknown";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 21);
            this.label10.TabIndex = 58;
            this.label10.Text = "Seat Number";
            // 
            // lblCancelBookingRouteID
            // 
            this.lblCancelBookingRouteID.AutoSize = true;
            this.lblCancelBookingRouteID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelBookingRouteID.ForeColor = System.Drawing.Color.Plum;
            this.lblCancelBookingRouteID.Location = new System.Drawing.Point(124, 155);
            this.lblCancelBookingRouteID.Name = "lblCancelBookingRouteID";
            this.lblCancelBookingRouteID.Size = new System.Drawing.Size(77, 21);
            this.lblCancelBookingRouteID.TabIndex = 68;
            this.lblCancelBookingRouteID.Text = "Unknown";
            // 
            // lbCancelFlightBookingPrice
            // 
            this.lbCancelFlightBookingPrice.AutoSize = true;
            this.lbCancelFlightBookingPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancelFlightBookingPrice.ForeColor = System.Drawing.Color.Plum;
            this.lbCancelFlightBookingPrice.Location = new System.Drawing.Point(124, 236);
            this.lbCancelFlightBookingPrice.Name = "lbCancelFlightBookingPrice";
            this.lbCancelFlightBookingPrice.Size = new System.Drawing.Size(77, 21);
            this.lbCancelFlightBookingPrice.TabIndex = 59;
            this.lbCancelFlightBookingPrice.Text = "Unknown";
            // 
            // lblCancelBookingID
            // 
            this.lblCancelBookingID.AutoSize = true;
            this.lblCancelBookingID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelBookingID.ForeColor = System.Drawing.Color.Plum;
            this.lblCancelBookingID.Location = new System.Drawing.Point(124, 33);
            this.lblCancelBookingID.Name = "lblCancelBookingID";
            this.lblCancelBookingID.Size = new System.Drawing.Size(77, 21);
            this.lblCancelBookingID.TabIndex = 64;
            this.lblCancelBookingID.Text = "Unknown";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 21);
            this.label14.TabIndex = 69;
            this.label14.Text = "Route";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 21);
            this.label15.TabIndex = 65;
            this.label15.Text = "BookiongID";
            // 
            // lblCancelFlightNumber
            // 
            this.lblCancelFlightNumber.AutoSize = true;
            this.lblCancelFlightNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelFlightNumber.ForeColor = System.Drawing.Color.Plum;
            this.lblCancelFlightNumber.Location = new System.Drawing.Point(124, 115);
            this.lblCancelFlightNumber.Name = "lblCancelFlightNumber";
            this.lblCancelFlightNumber.Size = new System.Drawing.Size(77, 21);
            this.lblCancelFlightNumber.TabIndex = 47;
            this.lblCancelFlightNumber.Text = "Unknown";
            // 
            // lblCancelPassengerID
            // 
            this.lblCancelPassengerID.AutoSize = true;
            this.lblCancelPassengerID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelPassengerID.ForeColor = System.Drawing.Color.Plum;
            this.lblCancelPassengerID.Location = new System.Drawing.Point(124, 74);
            this.lblCancelPassengerID.Name = "lblCancelPassengerID";
            this.lblCancelPassengerID.Size = new System.Drawing.Size(77, 21);
            this.lblCancelPassengerID.TabIndex = 66;
            this.lblCancelPassengerID.Text = "Unknown";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 21);
            this.label18.TabIndex = 67;
            this.label18.Text = "PassengerID";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 115);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 21);
            this.label19.TabIndex = 48;
            this.label19.Text = "Flight Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblCancelSeatNumDetail);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblCancelBookingRouteID);
            this.groupBox1.Controls.Add(this.lbCancelFlightBookingPrice);
            this.groupBox1.Controls.Add(this.lblCancelBookingID);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblCancelFlightNumber);
            this.groupBox1.Controls.Add(this.lblCancelPassengerID);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(814, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 293);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cancel Retrieved Booking Details";
            // 
            // frmCancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 671);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelBookingIDSearch);
            this.Controls.Add(this.txtCancelBookingID);
            this.Controls.Add(this.lblCancelSearchBookingID);
            this.Controls.Add(this.btnAirportConfirm);
            this.Controls.Add(this.grpAirportDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuCancelBooking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCancelBooking";
            this.Text = "Cancel Booking";
            this.Load += new System.EventHandler(this.frmCancelBooking_Load);
            this.grpAirportDetails.ResumeLayout(false);
            this.grpAirportDetails.PerformLayout();
            this.grpPersonalCreateBookingDetails.ResumeLayout(false);
            this.grpPersonalCreateBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCancelNumBaggage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuCancelBooking;
        private System.Windows.Forms.Button btnAirportConfirm;
        private System.Windows.Forms.GroupBox grpAirportDetails;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.ComboBox cboCancelDeptimeDetail;
        private System.Windows.Forms.DateTimePicker dptCancelBookingDate;
        private System.Windows.Forms.ComboBox cboCancelArrAirportDetail;
        private System.Windows.Forms.GroupBox grpPersonalCreateBookingDetails;
        private System.Windows.Forms.DateTimePicker dtpDOBUpdate;
        private System.Windows.Forms.TextBox txtUpdateEircode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdateBooingPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCancelForeName;
        private System.Windows.Forms.TextBox txtUpdateBookingEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpdateSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCancelDeptAirportDetail;
        private System.Windows.Forms.Label lblArrAirport;
        private System.Windows.Forms.Label lblDeptAirport;
        private System.Windows.Forms.Label lblDepartDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDepartureTime;
        public System.Windows.Forms.NumericUpDown nudCancelNumBaggage;
        private System.Windows.Forms.Button btnCancelBookingIDSearch;
        private System.Windows.Forms.TextBox txtCancelBookingID;
        private System.Windows.Forms.Label lblCancelSearchBookingID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCancelSeatNumDetail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCancelBookingRouteID;
        private System.Windows.Forms.Label lbCancelFlightBookingPrice;
        private System.Windows.Forms.Label lblCancelBookingID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCancelFlightNumber;
        private System.Windows.Forms.Label lblCancelPassengerID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}