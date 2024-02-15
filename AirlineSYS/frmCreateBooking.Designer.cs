namespace AirlineSYS
{
    partial class frmCreateBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateBooking));
            this.munBack = new System.Windows.Forms.Label();
            this.mnuCreateBooking = new System.Windows.Forms.MenuStrip();
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.lblAirportCode = new System.Windows.Forms.Label();
            this.lblAirportName = new System.Windows.Forms.Label();
            this.lblAirportPhone = new System.Windows.Forms.Label();
            this.lblAirportEmail = new System.Windows.Forms.Label();
            this.grpPersonalCreateBookingDetails = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.grpPaymentDetails = new System.Windows.Forms.GroupBox();
            this.dtpExpireEndsCreateBooking = new System.Windows.Forms.DateTimePicker();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumBaggage = new System.Windows.Forms.TextBox();
            this.grpCreateBookingDetails = new System.Windows.Forms.GroupBox();
            this.cboArrAirportBooking = new System.Windows.Forms.ComboBox();
            this.cboDeptAirportBooking = new System.Windows.Forms.ComboBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDeptDate = new System.Windows.Forms.DateTimePicker();
            this.btnAirportConfirm = new System.Windows.Forms.Button();
            this.grpPersonalCreateBookingDetails.SuspendLayout();
            this.grpPaymentDetails.SuspendLayout();
            this.grpCreateBookingDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(741, 2);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.munBack.Size = new System.Drawing.Size(60, 20);
            this.munBack.TabIndex = 5;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // mnuCreateBooking
            // 
            this.mnuCreateBooking.BackColor = System.Drawing.Color.Plum;
            this.mnuCreateBooking.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCreateBooking.Location = new System.Drawing.Point(0, 0);
            this.mnuCreateBooking.Name = "mnuCreateBooking";
            this.mnuCreateBooking.Padding = new System.Windows.Forms.Padding(0);
            this.mnuCreateBooking.Size = new System.Drawing.Size(800, 24);
            this.mnuCreateBooking.TabIndex = 4;
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(25, 28);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(154, 30);
            this.lblAddAirport.TabIndex = 14;
            this.lblAddAirport.Text = "Create Booking";
            // 
            // lblAirportCode
            // 
            this.lblAirportCode.AutoSize = true;
            this.lblAirportCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportCode.Location = new System.Drawing.Point(28, 40);
            this.lblAirportCode.Name = "lblAirportCode";
            this.lblAirportCode.Size = new System.Drawing.Size(120, 18);
            this.lblAirportCode.TabIndex = 7;
            this.lblAirportCode.Text = "Departure Airport";
            // 
            // lblAirportName
            // 
            this.lblAirportName.AutoSize = true;
            this.lblAirportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportName.Location = new System.Drawing.Point(411, 40);
            this.lblAirportName.Name = "lblAirportName";
            this.lblAirportName.Size = new System.Drawing.Size(95, 18);
            this.lblAirportName.TabIndex = 9;
            this.lblAirportName.Text = "Arrival Airport";
            // 
            // lblAirportPhone
            // 
            this.lblAirportPhone.AutoSize = true;
            this.lblAirportPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportPhone.Location = new System.Drawing.Point(27, 97);
            this.lblAirportPhone.Name = "lblAirportPhone";
            this.lblAirportPhone.Size = new System.Drawing.Size(108, 18);
            this.lblAirportPhone.TabIndex = 29;
            this.lblAirportPhone.Text = "Departure Date";
            // 
            // lblAirportEmail
            // 
            this.lblAirportEmail.AutoSize = true;
            this.lblAirportEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportEmail.Location = new System.Drawing.Point(410, 100);
            this.lblAirportEmail.Name = "lblAirportEmail";
            this.lblAirportEmail.Size = new System.Drawing.Size(87, 18);
            this.lblAirportEmail.TabIndex = 31;
            this.lblAirportEmail.Text = "Return Date";
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
            this.grpPersonalCreateBookingDetails.Location = new System.Drawing.Point(28, 197);
            this.grpPersonalCreateBookingDetails.Name = "grpPersonalCreateBookingDetails";
            this.grpPersonalCreateBookingDetails.Size = new System.Drawing.Size(692, 413);
            this.grpPersonalCreateBookingDetails.TabIndex = 35;
            this.grpPersonalCreateBookingDetails.TabStop = false;
            this.grpPersonalCreateBookingDetails.Text = "Personal Details";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(146, 109);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(173, 29);
            this.dtpDOB.TabIndex = 41;
            // 
            // grpPaymentDetails
            // 
            this.grpPaymentDetails.Controls.Add(this.dtpExpireEndsCreateBooking);
            this.grpPaymentDetails.Controls.Add(this.txtCardName);
            this.grpPaymentDetails.Controls.Add(this.txtCVC);
            this.grpPaymentDetails.Controls.Add(this.label11);
            this.grpPaymentDetails.Controls.Add(this.label12);
            this.grpPaymentDetails.Controls.Add(this.txtCardNumber);
            this.grpPaymentDetails.Controls.Add(this.label13);
            this.grpPaymentDetails.Controls.Add(this.label14);
            this.grpPaymentDetails.Location = new System.Drawing.Point(40, 211);
            this.grpPaymentDetails.Name = "grpPaymentDetails";
            this.grpPaymentDetails.Size = new System.Drawing.Size(625, 171);
            this.grpPaymentDetails.TabIndex = 39;
            this.grpPaymentDetails.TabStop = false;
            this.grpPaymentDetails.Text = "Payment Details";
            // 
            // dtpExpireEndsCreateBooking
            // 
            this.dtpExpireEndsCreateBooking.CustomFormat = "MM/yy";
            this.dtpExpireEndsCreateBooking.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpExpireEndsCreateBooking.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpireEndsCreateBooking.Location = new System.Drawing.Point(248, 119);
            this.dtpExpireEndsCreateBooking.Margin = new System.Windows.Forms.Padding(2);
            this.dtpExpireEndsCreateBooking.Name = "dtpExpireEndsCreateBooking";
            this.dtpExpireEndsCreateBooking.Size = new System.Drawing.Size(74, 29);
            this.dtpExpireEndsCreateBooking.TabIndex = 41;
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(113, 51);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(173, 29);
            this.txtCardName.TabIndex = 21;
            // 
            // txtCVC
            // 
            this.txtCVC.Location = new System.Drawing.Point(426, 119);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(50, 29);
            this.txtCVC.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(336, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Card Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(372, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "CVC";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(440, 57);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(173, 29);
            this.txtCardNumber.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 18);
            this.label13.TabIndex = 32;
            this.label13.Text = "Card Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(136, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "Expires Ends";
            // 
            // txtCreateBookingEircode
            // 
            this.txtCreateBookingEircode.Location = new System.Drawing.Point(479, 161);
            this.txtCreateBookingEircode.Name = "txtCreateBookingEircode";
            this.txtCreateBookingEircode.Size = new System.Drawing.Size(173, 29);
            this.txtCreateBookingEircode.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Eircode";
            // 
            // txtCreateBooingPhone
            // 
            this.txtCreateBooingPhone.Location = new System.Drawing.Point(146, 160);
            this.txtCreateBooingPhone.Name = "txtCreateBooingPhone";
            this.txtCreateBooingPhone.Size = new System.Drawing.Size(173, 29);
            this.txtCreateBooingPhone.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Phone";
            // 
            // txtForeName
            // 
            this.txtForeName.Location = new System.Drawing.Point(146, 50);
            this.txtForeName.Name = "txtForeName";
            this.txtForeName.Size = new System.Drawing.Size(173, 29);
            this.txtForeName.TabIndex = 21;
            // 
            // txtCreateBookingEmail
            // 
            this.txtCreateBookingEmail.Location = new System.Drawing.Point(479, 109);
            this.txtCreateBookingEmail.Name = "txtCreateBookingEmail";
            this.txtCreateBookingEmail.Size = new System.Drawing.Size(173, 29);
            this.txtCreateBookingEmail.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Email";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(479, 50);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(173, 29);
            this.txtSurname.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Forename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "DOB\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Number of Baggage";
            // 
            // txtNumBaggage
            // 
            this.txtNumBaggage.Location = new System.Drawing.Point(193, 147);
            this.txtNumBaggage.Name = "txtNumBaggage";
            this.txtNumBaggage.Size = new System.Drawing.Size(173, 29);
            this.txtNumBaggage.TabIndex = 38;
            // 
            // grpCreateBookingDetails
            // 
            this.grpCreateBookingDetails.Controls.Add(this.cboArrAirportBooking);
            this.grpCreateBookingDetails.Controls.Add(this.cboDeptAirportBooking);
            this.grpCreateBookingDetails.Controls.Add(this.dtpReturnDate);
            this.grpCreateBookingDetails.Controls.Add(this.dtpDeptDate);
            this.grpCreateBookingDetails.Controls.Add(this.txtNumBaggage);
            this.grpCreateBookingDetails.Controls.Add(this.label7);
            this.grpCreateBookingDetails.Controls.Add(this.grpPersonalCreateBookingDetails);
            this.grpCreateBookingDetails.Controls.Add(this.lblAirportEmail);
            this.grpCreateBookingDetails.Controls.Add(this.lblAirportPhone);
            this.grpCreateBookingDetails.Controls.Add(this.lblAirportName);
            this.grpCreateBookingDetails.Controls.Add(this.lblAirportCode);
            this.grpCreateBookingDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCreateBookingDetails.Location = new System.Drawing.Point(26, 69);
            this.grpCreateBookingDetails.Name = "grpCreateBookingDetails";
            this.grpCreateBookingDetails.Size = new System.Drawing.Size(749, 637);
            this.grpCreateBookingDetails.TabIndex = 15;
            this.grpCreateBookingDetails.TabStop = false;
            this.grpCreateBookingDetails.Text = "Create Booking Details";
            // 
            // cboArrAirportBooking
            // 
            this.cboArrAirportBooking.FormattingEnabled = true;
            this.cboArrAirportBooking.Items.AddRange(new object[] {
            "JFK - New York",
            "LAX - Los Angeles",
            "ORD - Chicago",
            "DFW Dallas",
            "SNN - Shannon",
            "PVG - Shanghai"});
            this.cboArrAirportBooking.Location = new System.Drawing.Point(550, 35);
            this.cboArrAirportBooking.Name = "cboArrAirportBooking";
            this.cboArrAirportBooking.Size = new System.Drawing.Size(171, 29);
            this.cboArrAirportBooking.TabIndex = 43;
            // 
            // cboDeptAirportBooking
            // 
            this.cboDeptAirportBooking.FormattingEnabled = true;
            this.cboDeptAirportBooking.Items.AddRange(new object[] {
            "JFK - New York",
            "LAX - Los Angeles",
            "ORD - Chicago",
            "DFW Dallas",
            "SNN - Shannon",
            "PVG - Shanghai"});
            this.cboDeptAirportBooking.Location = new System.Drawing.Point(192, 35);
            this.cboDeptAirportBooking.Name = "cboDeptAirportBooking";
            this.cboDeptAirportBooking.Size = new System.Drawing.Size(175, 29);
            this.cboDeptAirportBooking.TabIndex = 42;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CustomFormat = "        dd-mm-yyyy";
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnDate.Location = new System.Drawing.Point(550, 93);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(173, 29);
            this.dtpReturnDate.TabIndex = 41;
            // 
            // dtpDeptDate
            // 
            this.dtpDeptDate.CustomFormat = "        dd-mmyyyy";
            this.dtpDeptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeptDate.Location = new System.Drawing.Point(192, 93);
            this.dtpDeptDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDeptDate.Name = "dtpDeptDate";
            this.dtpDeptDate.Size = new System.Drawing.Size(173, 29);
            this.dtpDeptDate.TabIndex = 40;
            // 
            // btnAirportConfirm
            // 
            this.btnAirportConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnAirportConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirportConfirm.Location = new System.Drawing.Point(321, 713);
            this.btnAirportConfirm.Name = "btnAirportConfirm";
            this.btnAirportConfirm.Size = new System.Drawing.Size(174, 38);
            this.btnAirportConfirm.TabIndex = 16;
            this.btnAirportConfirm.Text = "CONFIRM";
            this.btnAirportConfirm.UseVisualStyleBackColor = false;
            this.btnAirportConfirm.Click += new System.EventHandler(this.btnAirportConfirm_Click);
            // 
            // frmCreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 760);
            this.Controls.Add(this.btnAirportConfirm);
            this.Controls.Add(this.grpCreateBookingDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuCreateBooking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateBooking";
            this.Text = "Create Booking";
            this.grpPersonalCreateBookingDetails.ResumeLayout(false);
            this.grpPersonalCreateBookingDetails.PerformLayout();
            this.grpPaymentDetails.ResumeLayout(false);
            this.grpPaymentDetails.PerformLayout();
            this.grpCreateBookingDetails.ResumeLayout(false);
            this.grpCreateBookingDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuCreateBooking;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.Label lblAirportCode;
        private System.Windows.Forms.Label lblAirportName;
        private System.Windows.Forms.Label lblAirportPhone;
        private System.Windows.Forms.Label lblAirportEmail;
        private System.Windows.Forms.GroupBox grpPersonalCreateBookingDetails;
        private System.Windows.Forms.GroupBox grpPaymentDetails;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumBaggage;
        private System.Windows.Forms.GroupBox grpCreateBookingDetails;
        private System.Windows.Forms.Button btnAirportConfirm;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.DateTimePicker dtpExpireEndsCreateBooking;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpDeptDate;
        private System.Windows.Forms.ComboBox cboArrAirportBooking;
        private System.Windows.Forms.ComboBox cboDeptAirportBooking;
    }
}