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
            this.btnSearchDest = new System.Windows.Forms.Button();
            this.cboArrAirportBooking = new System.Windows.Forms.ComboBox();
            this.cboDeptAirportBooking = new System.Windows.Forms.ComboBox();
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
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.munBack.Location = new System.Drawing.Point(988, 2);
            this.munBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.munBack.Size = new System.Drawing.Size(77, 25);
            this.munBack.TabIndex = 5;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // mnuCreateBooking
            // 
            this.mnuCreateBooking.BackColor = System.Drawing.Color.Plum;
            this.mnuCreateBooking.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mnuCreateBooking.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCreateBooking.Location = new System.Drawing.Point(0, 0);
            this.mnuCreateBooking.Name = "mnuCreateBooking";
            this.mnuCreateBooking.Padding = new System.Windows.Forms.Padding(0);
            this.mnuCreateBooking.Size = new System.Drawing.Size(1067, 24);
            this.mnuCreateBooking.TabIndex = 4;
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAddAirport.Location = new System.Drawing.Point(33, 34);
            this.lblAddAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(141, 25);
            this.lblAddAirport.TabIndex = 14;
            this.lblAddAirport.Text = "Create Booking";
            // 
            // lblAirportCode
            // 
            this.lblAirportCode.AutoSize = true;
            this.lblAirportCode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAirportCode.Location = new System.Drawing.Point(33, 49);
            this.lblAirportCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportCode.Name = "lblAirportCode";
            this.lblAirportCode.Size = new System.Drawing.Size(216, 25);
            this.lblAirportCode.TabIndex = 7;
            this.lblAirportCode.Text = "Select Departure Airport";
            // 
            // lblAirportName
            // 
            this.lblAirportName.AutoSize = true;
            this.lblAirportName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAirportName.Location = new System.Drawing.Point(446, 50);
            this.lblAirportName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportName.Name = "lblAirportName";
            this.lblAirportName.Size = new System.Drawing.Size(186, 25);
            this.lblAirportName.TabIndex = 9;
            this.lblAirportName.Text = "Select Arrival Airport";
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
            this.grpPersonalCreateBookingDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.grpPersonalCreateBookingDetails.Location = new System.Drawing.Point(37, 242);
            this.grpPersonalCreateBookingDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpPersonalCreateBookingDetails.Name = "grpPersonalCreateBookingDetails";
            this.grpPersonalCreateBookingDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpPersonalCreateBookingDetails.Size = new System.Drawing.Size(923, 508);
            this.grpPersonalCreateBookingDetails.TabIndex = 35;
            this.grpPersonalCreateBookingDetails.TabStop = false;
            this.grpPersonalCreateBookingDetails.Text = "Personal Details";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpDOB.Location = new System.Drawing.Point(195, 134);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(229, 32);
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
            this.grpPaymentDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.grpPaymentDetails.Location = new System.Drawing.Point(53, 260);
            this.grpPaymentDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpPaymentDetails.Name = "grpPaymentDetails";
            this.grpPaymentDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpPaymentDetails.Size = new System.Drawing.Size(833, 210);
            this.grpPaymentDetails.TabIndex = 39;
            this.grpPaymentDetails.TabStop = false;
            this.grpPaymentDetails.Text = "Payment Details";
            // 
            // dtpExpireEndsCreateBooking
            // 
            this.dtpExpireEndsCreateBooking.CustomFormat = "MM/yy";
            this.dtpExpireEndsCreateBooking.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpExpireEndsCreateBooking.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpExpireEndsCreateBooking.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpireEndsCreateBooking.Location = new System.Drawing.Point(331, 146);
            this.dtpExpireEndsCreateBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpExpireEndsCreateBooking.Name = "dtpExpireEndsCreateBooking";
            this.dtpExpireEndsCreateBooking.Size = new System.Drawing.Size(97, 32);
            this.dtpExpireEndsCreateBooking.TabIndex = 41;
            // 
            // txtCardName
            // 
            this.txtCardName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCardName.Location = new System.Drawing.Point(151, 63);
            this.txtCardName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(229, 32);
            this.txtCardName.TabIndex = 21;
            // 
            // txtCVC
            // 
            this.txtCVC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCVC.Location = new System.Drawing.Point(568, 146);
            this.txtCVC.Margin = new System.Windows.Forms.Padding(4);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(65, 32);
            this.txtCVC.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label11.Location = new System.Drawing.Point(448, 74);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Card Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label12.Location = new System.Drawing.Point(496, 151);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 25);
            this.label12.TabIndex = 33;
            this.label12.Text = "CVC";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCardNumber.Location = new System.Drawing.Point(587, 70);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(229, 32);
            this.txtCardNumber.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label13.Location = new System.Drawing.Point(28, 70);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Card Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label14.Location = new System.Drawing.Point(181, 151);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "Expires Ends";
            // 
            // txtCreateBookingEircode
            // 
            this.txtCreateBookingEircode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCreateBookingEircode.Location = new System.Drawing.Point(639, 198);
            this.txtCreateBookingEircode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreateBookingEircode.Name = "txtCreateBookingEircode";
            this.txtCreateBookingEircode.Size = new System.Drawing.Size(229, 32);
            this.txtCreateBookingEircode.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label6.Location = new System.Drawing.Point(501, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Eircode";
            // 
            // txtCreateBooingPhone
            // 
            this.txtCreateBooingPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCreateBooingPhone.Location = new System.Drawing.Point(195, 197);
            this.txtCreateBooingPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreateBooingPhone.Name = "txtCreateBooingPhone";
            this.txtCreateBooingPhone.Size = new System.Drawing.Size(229, 32);
            this.txtCreateBooingPhone.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.Location = new System.Drawing.Point(55, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Phone";
            // 
            // txtForeName
            // 
            this.txtForeName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtForeName.Location = new System.Drawing.Point(195, 62);
            this.txtForeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtForeName.Name = "txtForeName";
            this.txtForeName.Size = new System.Drawing.Size(229, 32);
            this.txtForeName.TabIndex = 21;
            // 
            // txtCreateBookingEmail
            // 
            this.txtCreateBookingEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCreateBookingEmail.Location = new System.Drawing.Point(639, 134);
            this.txtCreateBookingEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreateBookingEmail.Name = "txtCreateBookingEmail";
            this.txtCreateBookingEmail.Size = new System.Drawing.Size(229, 32);
            this.txtCreateBookingEmail.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(501, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(501, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Email";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSurname.Location = new System.Drawing.Point(639, 62);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(229, 32);
            this.txtSurname.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(55, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Forename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(55, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "DOB\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label7.Location = new System.Drawing.Point(36, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "Number of Baggage";
            // 
            // txtNumBaggage
            // 
            this.txtNumBaggage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNumBaggage.Location = new System.Drawing.Point(257, 181);
            this.txtNumBaggage.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumBaggage.Name = "txtNumBaggage";
            this.txtNumBaggage.Size = new System.Drawing.Size(229, 32);
            this.txtNumBaggage.TabIndex = 38;
            // 
            // grpCreateBookingDetails
            // 
            this.grpCreateBookingDetails.Controls.Add(this.btnSearchDest);
            this.grpCreateBookingDetails.Controls.Add(this.cboArrAirportBooking);
            this.grpCreateBookingDetails.Controls.Add(this.cboDeptAirportBooking);
            this.grpCreateBookingDetails.Controls.Add(this.txtNumBaggage);
            this.grpCreateBookingDetails.Controls.Add(this.label7);
            this.grpCreateBookingDetails.Controls.Add(this.grpPersonalCreateBookingDetails);
            this.grpCreateBookingDetails.Controls.Add(this.lblAirportName);
            this.grpCreateBookingDetails.Controls.Add(this.lblAirportCode);
            this.grpCreateBookingDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.grpCreateBookingDetails.Location = new System.Drawing.Point(35, 85);
            this.grpCreateBookingDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpCreateBookingDetails.Name = "grpCreateBookingDetails";
            this.grpCreateBookingDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpCreateBookingDetails.Size = new System.Drawing.Size(999, 784);
            this.grpCreateBookingDetails.TabIndex = 15;
            this.grpCreateBookingDetails.TabStop = false;
            this.grpCreateBookingDetails.Text = "Create Booking Details";
            // 
            // btnSearchDest
            // 
            this.btnSearchDest.BackColor = System.Drawing.Color.Plum;
            this.btnSearchDest.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSearchDest.Location = new System.Drawing.Point(828, 42);
            this.btnSearchDest.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchDest.Name = "btnSearchDest";
            this.btnSearchDest.Size = new System.Drawing.Size(150, 32);
            this.btnSearchDest.TabIndex = 44;
            this.btnSearchDest.Text = "SEARCH";
            this.btnSearchDest.UseVisualStyleBackColor = false;
            this.btnSearchDest.Click += new System.EventHandler(this.btnUpdateFlightSearch_Click);
            // 
            // cboArrAirportBooking
            // 
            this.cboArrAirportBooking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArrAirportBooking.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboArrAirportBooking.FormattingEnabled = true;
            this.cboArrAirportBooking.Location = new System.Drawing.Point(651, 38);
            this.cboArrAirportBooking.Margin = new System.Windows.Forms.Padding(4);
            this.cboArrAirportBooking.Name = "cboArrAirportBooking";
            this.cboArrAirportBooking.Size = new System.Drawing.Size(151, 33);
            this.cboArrAirportBooking.TabIndex = 43;
            // 
            // cboDeptAirportBooking
            // 
            this.cboDeptAirportBooking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptAirportBooking.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboDeptAirportBooking.FormattingEnabled = true;
            this.cboDeptAirportBooking.Location = new System.Drawing.Point(269, 43);
            this.cboDeptAirportBooking.Margin = new System.Windows.Forms.Padding(4);
            this.cboDeptAirportBooking.Name = "cboDeptAirportBooking";
            this.cboDeptAirportBooking.Size = new System.Drawing.Size(151, 33);
            this.cboDeptAirportBooking.TabIndex = 42;
            // 
            // btnAirportConfirm
            // 
            this.btnAirportConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnAirportConfirm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAirportConfirm.Location = new System.Drawing.Point(428, 878);
            this.btnAirportConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnAirportConfirm.Name = "btnAirportConfirm";
            this.btnAirportConfirm.Size = new System.Drawing.Size(232, 47);
            this.btnAirportConfirm.TabIndex = 16;
            this.btnAirportConfirm.Text = "CONFIRM";
            this.btnAirportConfirm.UseVisualStyleBackColor = false;
            this.btnAirportConfirm.Click += new System.EventHandler(this.btnAirportConfirm_Click);
            // 
            // frmCreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 935);
            this.Controls.Add(this.btnAirportConfirm);
            this.Controls.Add(this.grpCreateBookingDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuCreateBooking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCreateBooking";
            this.Text = "Create Booking";
            this.Load += new System.EventHandler(this.frmCreateBooking_Load);
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
        private System.Windows.Forms.ComboBox cboArrAirportBooking;
        private System.Windows.Forms.ComboBox cboDeptAirportBooking;
        private System.Windows.Forms.Button btnSearchDest;
    }
}