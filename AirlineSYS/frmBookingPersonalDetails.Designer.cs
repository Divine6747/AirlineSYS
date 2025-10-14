﻿namespace AirlineSYS
{
    partial class frmBookingPersonalDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookingPersonalDetails));
            this.mnuCreateBooking = new System.Windows.Forms.MenuStrip();
            this.grpPersonalCreateBookingDetails = new System.Windows.Forms.GroupBox();
            this.dtpBookingDOB = new System.Windows.Forms.DateTimePicker();
            this.grpPaymentDetails = new System.Windows.Forms.GroupBox();
            this.txtPayBookingFlightPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBookingFlightPriceDetail = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBookingFlightPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBookingEircode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookingPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtForeName = new System.Windows.Forms.TextBox();
            this.txtBookingEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEndRouteDetails = new System.Windows.Forms.Label();
            this.btnFlightBookingConfirm = new System.Windows.Forms.Button();
            this.grpFlightData = new System.Windows.Forms.GroupBox();
            this.lblEstArrTime = new System.Windows.Forms.Label();
            this.lblEstArrTimeDetail = new System.Windows.Forms.Label();
            this.lblFlightSeatNumber = new System.Windows.Forms.Label();
            this.lblFlightSeatNumberDetail = new System.Windows.Forms.Label();
            this.lblPassengerIdDetail = new System.Windows.Forms.Label();
            this.lblBookingId = new System.Windows.Forms.Label();
            this.lblPassengerId = new System.Windows.Forms.Label();
            this.lblBookingRouteIDDetail = new System.Windows.Forms.Label();
            this.lblBookingRouteID = new System.Windows.Forms.Label();
            this.lblBookingIdDetail = new System.Windows.Forms.Label();
            this.lblNumBaggageDetail = new System.Windows.Forms.Label();
            this.lblNumBaggage = new System.Windows.Forms.Label();
            this.lblFlightTime = new System.Windows.Forms.Label();
            this.lblDeptAirport = new System.Windows.Forms.Label();
            this.lblDeptAirportDetail = new System.Windows.Forms.Label();
            this.lblFlightDate = new System.Windows.Forms.Label();
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.lblArrAirport = new System.Windows.Forms.Label();
            this.lblFlightTimedetail = new System.Windows.Forms.Label();
            this.lblFlightNumberDetail = new System.Windows.Forms.Label();
            this.lblArrAirportDetail = new System.Windows.Forms.Label();
            this.lblFlightDateDetails = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label12 = new System.Windows.Forms.Label();
            this.grpPersonalCreateBookingDetails.SuspendLayout();
            this.grpPaymentDetails.SuspendLayout();
            this.grpFlightData.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuCreateBooking
            // 
            this.mnuCreateBooking.BackColor = System.Drawing.Color.Plum;
            this.mnuCreateBooking.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mnuCreateBooking.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCreateBooking.Location = new System.Drawing.Point(0, 0);
            this.mnuCreateBooking.Name = "mnuCreateBooking";
            this.mnuCreateBooking.Padding = new System.Windows.Forms.Padding(0);
            this.mnuCreateBooking.Size = new System.Drawing.Size(1349, 24);
            this.mnuCreateBooking.TabIndex = 6;
            // 
            // grpPersonalCreateBookingDetails
            // 
            this.grpPersonalCreateBookingDetails.Controls.Add(this.dtpBookingDOB);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.grpPaymentDetails);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtBookingEircode);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label6);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtBookingPhone);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label5);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtForeName);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtBookingEmail);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label2);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label4);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.txtSurname);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label1);
            this.grpPersonalCreateBookingDetails.Controls.Add(this.label3);
            this.grpPersonalCreateBookingDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.grpPersonalCreateBookingDetails.Location = new System.Drawing.Point(77, 103);
            this.grpPersonalCreateBookingDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPersonalCreateBookingDetails.Name = "grpPersonalCreateBookingDetails";
            this.grpPersonalCreateBookingDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPersonalCreateBookingDetails.Size = new System.Drawing.Size(809, 508);
            this.grpPersonalCreateBookingDetails.TabIndex = 36;
            this.grpPersonalCreateBookingDetails.TabStop = false;
            this.grpPersonalCreateBookingDetails.Text = "Personal Details";
            // 
            // dtpBookingDOB
            // 
            this.dtpBookingDOB.CustomFormat = " dd-MMM-yy";
            this.dtpBookingDOB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpBookingDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingDOB.Location = new System.Drawing.Point(165, 138);
            this.dtpBookingDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBookingDOB.MinDate = new System.DateTime(1930, 2, 1, 0, 0, 0, 0);
            this.dtpBookingDOB.Name = "dtpBookingDOB";
            this.dtpBookingDOB.Size = new System.Drawing.Size(229, 32);
            this.dtpBookingDOB.TabIndex = 41;
            // 
            // grpPaymentDetails
            // 
            this.grpPaymentDetails.Controls.Add(this.txtPayBookingFlightPrice);
            this.grpPaymentDetails.Controls.Add(this.label11);
            this.grpPaymentDetails.Controls.Add(this.lblBookingFlightPriceDetail);
            this.grpPaymentDetails.Controls.Add(this.label9);
            this.grpPaymentDetails.Controls.Add(this.lblBookingFlightPrice);
            this.grpPaymentDetails.Controls.Add(this.label7);
            this.grpPaymentDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.grpPaymentDetails.Location = new System.Drawing.Point(192, 262);
            this.grpPaymentDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPaymentDetails.Name = "grpPaymentDetails";
            this.grpPaymentDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPaymentDetails.Size = new System.Drawing.Size(476, 210);
            this.grpPaymentDetails.TabIndex = 39;
            this.grpPaymentDetails.TabStop = false;
            this.grpPaymentDetails.Text = "Payment Details";
            // 
            // txtPayBookingFlightPrice
            // 
            this.txtPayBookingFlightPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayBookingFlightPrice.Location = new System.Drawing.Point(301, 140);
            this.txtPayBookingFlightPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPayBookingFlightPrice.Name = "txtPayBookingFlightPrice";
            this.txtPayBookingFlightPrice.Size = new System.Drawing.Size(84, 27);
            this.txtPayBookingFlightPrice.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.ForeColor = System.Drawing.Color.Plum;
            this.label11.Location = new System.Drawing.Point(268, 140);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 28);
            this.label11.TabIndex = 43;
            this.label11.Text = "€";
            // 
            // lblBookingFlightPriceDetail
            // 
            this.lblBookingFlightPriceDetail.AutoSize = true;
            this.lblBookingFlightPriceDetail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBookingFlightPriceDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblBookingFlightPriceDetail.Location = new System.Drawing.Point(268, 94);
            this.lblBookingFlightPriceDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingFlightPriceDetail.Name = "lblBookingFlightPriceDetail";
            this.lblBookingFlightPriceDetail.Size = new System.Drawing.Size(61, 28);
            this.lblBookingFlightPriceDetail.TabIndex = 42;
            this.lblBookingFlightPriceDetail.Text = "€ 000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(29, 140);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 28);
            this.label9.TabIndex = 41;
            this.label9.Text = "Please Pay Here";
            // 
            // lblBookingFlightPrice
            // 
            this.lblBookingFlightPrice.AutoSize = true;
            this.lblBookingFlightPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBookingFlightPrice.Location = new System.Drawing.Point(29, 94);
            this.lblBookingFlightPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingFlightPrice.Name = "lblBookingFlightPrice";
            this.lblBookingFlightPrice.Size = new System.Drawing.Size(187, 28);
            this.lblBookingFlightPrice.TabIndex = 40;
            this.lblBookingFlightPrice.Text = "Payment Due To Pay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label7.Location = new System.Drawing.Point(139, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 30);
            this.label7.TabIndex = 39;
            this.label7.Text = "PAYMENT SECTION";
            // 
            // txtBookingEircode
            // 
            this.txtBookingEircode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBookingEircode.Location = new System.Drawing.Point(539, 208);
            this.txtBookingEircode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookingEircode.Name = "txtBookingEircode";
            this.txtBookingEircode.Size = new System.Drawing.Size(229, 32);
            this.txtBookingEircode.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label6.Location = new System.Drawing.Point(423, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Eircode";
            // 
            // txtBookingPhone
            // 
            this.txtBookingPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBookingPhone.Location = new System.Drawing.Point(165, 206);
            this.txtBookingPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookingPhone.Name = "txtBookingPhone";
            this.txtBookingPhone.Size = new System.Drawing.Size(229, 32);
            this.txtBookingPhone.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.Location = new System.Drawing.Point(40, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Phone";
            // 
            // txtForeName
            // 
            this.txtForeName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtForeName.Location = new System.Drawing.Point(165, 71);
            this.txtForeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtForeName.Name = "txtForeName";
            this.txtForeName.Size = new System.Drawing.Size(229, 32);
            this.txtForeName.TabIndex = 21;
            // 
            // txtBookingEmail
            // 
            this.txtBookingEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBookingEmail.Location = new System.Drawing.Point(539, 140);
            this.txtBookingEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookingEmail.Name = "txtBookingEmail";
            this.txtBookingEmail.Size = new System.Drawing.Size(229, 32);
            this.txtBookingEmail.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(423, 78);
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
            this.label4.Location = new System.Drawing.Point(423, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Email";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSurname.Location = new System.Drawing.Point(539, 71);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(229, 32);
            this.txtSurname.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(40, 78);
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
            this.label3.Location = new System.Drawing.Point(40, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "DOB\r\n";
            // 
            // lblEndRouteDetails
            // 
            this.lblEndRouteDetails.AutoSize = true;
            this.lblEndRouteDetails.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.lblEndRouteDetails.Location = new System.Drawing.Point(321, 39);
            this.lblEndRouteDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndRouteDetails.Name = "lblEndRouteDetails";
            this.lblEndRouteDetails.Size = new System.Drawing.Size(405, 40);
            this.lblEndRouteDetails.TabIndex = 37;
            this.lblEndRouteDetails.Text = "BOOKING PERSONAL DETAILS";
            // 
            // btnFlightBookingConfirm
            // 
            this.btnFlightBookingConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnFlightBookingConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlightBookingConfirm.Location = new System.Drawing.Point(557, 651);
            this.btnFlightBookingConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFlightBookingConfirm.Name = "btnFlightBookingConfirm";
            this.btnFlightBookingConfirm.Size = new System.Drawing.Size(232, 47);
            this.btnFlightBookingConfirm.TabIndex = 38;
            this.btnFlightBookingConfirm.Text = "CONFIRM";
            this.btnFlightBookingConfirm.UseVisualStyleBackColor = false;
            this.btnFlightBookingConfirm.Click += new System.EventHandler(this.btnFlightBookingConfirm_Click);
            // 
            // grpFlightData
            // 
            this.grpFlightData.Controls.Add(this.lblEstArrTime);
            this.grpFlightData.Controls.Add(this.lblEstArrTimeDetail);
            this.grpFlightData.Controls.Add(this.lblFlightSeatNumber);
            this.grpFlightData.Controls.Add(this.lblFlightSeatNumberDetail);
            this.grpFlightData.Controls.Add(this.lblPassengerIdDetail);
            this.grpFlightData.Controls.Add(this.lblBookingId);
            this.grpFlightData.Controls.Add(this.lblPassengerId);
            this.grpFlightData.Controls.Add(this.lblBookingRouteIDDetail);
            this.grpFlightData.Controls.Add(this.lblBookingRouteID);
            this.grpFlightData.Controls.Add(this.lblBookingIdDetail);
            this.grpFlightData.Controls.Add(this.lblNumBaggageDetail);
            this.grpFlightData.Controls.Add(this.lblNumBaggage);
            this.grpFlightData.Controls.Add(this.lblFlightTime);
            this.grpFlightData.Controls.Add(this.lblDeptAirport);
            this.grpFlightData.Controls.Add(this.lblDeptAirportDetail);
            this.grpFlightData.Controls.Add(this.lblFlightDate);
            this.grpFlightData.Controls.Add(this.lblFlightNumber);
            this.grpFlightData.Controls.Add(this.lblArrAirport);
            this.grpFlightData.Controls.Add(this.lblFlightTimedetail);
            this.grpFlightData.Controls.Add(this.lblFlightNumberDetail);
            this.grpFlightData.Controls.Add(this.lblArrAirportDetail);
            this.grpFlightData.Controls.Add(this.lblFlightDateDetails);
            this.grpFlightData.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.grpFlightData.Location = new System.Drawing.Point(917, 113);
            this.grpFlightData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFlightData.Name = "grpFlightData";
            this.grpFlightData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFlightData.Size = new System.Drawing.Size(355, 564);
            this.grpFlightData.TabIndex = 39;
            this.grpFlightData.TabStop = false;
            this.grpFlightData.Text = "Flight Data";
            // 
            // lblEstArrTime
            // 
            this.lblEstArrTime.AutoSize = true;
            this.lblEstArrTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstArrTime.Location = new System.Drawing.Point(37, 410);
            this.lblEstArrTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstArrTime.Name = "lblEstArrTime";
            this.lblEstArrTime.Size = new System.Drawing.Size(146, 28);
            this.lblEstArrTime.TabIndex = 75;
            this.lblEstArrTime.Text = "Est Arrival Time";
            // 
            // lblEstArrTimeDetail
            // 
            this.lblEstArrTimeDetail.AutoSize = true;
            this.lblEstArrTimeDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstArrTimeDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblEstArrTimeDetail.Location = new System.Drawing.Point(213, 411);
            this.lblEstArrTimeDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstArrTimeDetail.Name = "lblEstArrTimeDetail";
            this.lblEstArrTimeDetail.Size = new System.Drawing.Size(95, 28);
            this.lblEstArrTimeDetail.TabIndex = 74;
            this.lblEstArrTimeDetail.Text = "Unknown";
            // 
            // lblFlightSeatNumber
            // 
            this.lblFlightSeatNumber.AutoSize = true;
            this.lblFlightSeatNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightSeatNumber.Location = new System.Drawing.Point(39, 498);
            this.lblFlightSeatNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightSeatNumber.Name = "lblFlightSeatNumber";
            this.lblFlightSeatNumber.Size = new System.Drawing.Size(127, 28);
            this.lblFlightSeatNumber.TabIndex = 73;
            this.lblFlightSeatNumber.Text = "Seat Number";
            // 
            // lblFlightSeatNumberDetail
            // 
            this.lblFlightSeatNumberDetail.AutoSize = true;
            this.lblFlightSeatNumberDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightSeatNumberDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblFlightSeatNumberDetail.Location = new System.Drawing.Point(213, 501);
            this.lblFlightSeatNumberDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightSeatNumberDetail.Name = "lblFlightSeatNumberDetail";
            this.lblFlightSeatNumberDetail.Size = new System.Drawing.Size(95, 28);
            this.lblFlightSeatNumberDetail.TabIndex = 72;
            this.lblFlightSeatNumberDetail.Text = "Unknown";
            // 
            // lblPassengerIdDetail
            // 
            this.lblPassengerIdDetail.AutoSize = true;
            this.lblPassengerIdDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerIdDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblPassengerIdDetail.Location = new System.Drawing.Point(213, 76);
            this.lblPassengerIdDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassengerIdDetail.Name = "lblPassengerIdDetail";
            this.lblPassengerIdDetail.Size = new System.Drawing.Size(95, 28);
            this.lblPassengerIdDetail.TabIndex = 68;
            this.lblPassengerIdDetail.Text = "Unknown";
            // 
            // lblBookingId
            // 
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingId.Location = new System.Drawing.Point(39, 31);
            this.lblBookingId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingId.Name = "lblBookingId";
            this.lblBookingId.Size = new System.Drawing.Size(109, 28);
            this.lblBookingId.TabIndex = 71;
            this.lblBookingId.Text = "Booking ID";
            // 
            // lblPassengerId
            // 
            this.lblPassengerId.AutoSize = true;
            this.lblPassengerId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerId.Location = new System.Drawing.Point(39, 79);
            this.lblPassengerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassengerId.Name = "lblPassengerId";
            this.lblPassengerId.Size = new System.Drawing.Size(122, 28);
            this.lblPassengerId.TabIndex = 69;
            this.lblPassengerId.Text = "Passenger ID";
            // 
            // lblBookingRouteIDDetail
            // 
            this.lblBookingRouteIDDetail.AutoSize = true;
            this.lblBookingRouteIDDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingRouteIDDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblBookingRouteIDDetail.Location = new System.Drawing.Point(213, 118);
            this.lblBookingRouteIDDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingRouteIDDetail.Name = "lblBookingRouteIDDetail";
            this.lblBookingRouteIDDetail.Size = new System.Drawing.Size(95, 28);
            this.lblBookingRouteIDDetail.TabIndex = 67;
            this.lblBookingRouteIDDetail.Text = "Unknown";
            // 
            // lblBookingRouteID
            // 
            this.lblBookingRouteID.AutoSize = true;
            this.lblBookingRouteID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingRouteID.Location = new System.Drawing.Point(37, 127);
            this.lblBookingRouteID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingRouteID.Name = "lblBookingRouteID";
            this.lblBookingRouteID.Size = new System.Drawing.Size(87, 28);
            this.lblBookingRouteID.TabIndex = 67;
            this.lblBookingRouteID.Text = "Route ID";
            // 
            // lblBookingIdDetail
            // 
            this.lblBookingIdDetail.AutoSize = true;
            this.lblBookingIdDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingIdDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblBookingIdDetail.Location = new System.Drawing.Point(213, 30);
            this.lblBookingIdDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingIdDetail.Name = "lblBookingIdDetail";
            this.lblBookingIdDetail.Size = new System.Drawing.Size(95, 28);
            this.lblBookingIdDetail.TabIndex = 70;
            this.lblBookingIdDetail.Text = "Unknown";
            // 
            // lblNumBaggageDetail
            // 
            this.lblNumBaggageDetail.AutoSize = true;
            this.lblNumBaggageDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBaggageDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblNumBaggageDetail.Location = new System.Drawing.Point(213, 454);
            this.lblNumBaggageDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumBaggageDetail.Name = "lblNumBaggageDetail";
            this.lblNumBaggageDetail.Size = new System.Drawing.Size(95, 28);
            this.lblNumBaggageDetail.TabIndex = 66;
            this.lblNumBaggageDetail.Text = "Unknown";
            // 
            // lblNumBaggage
            // 
            this.lblNumBaggage.AutoSize = true;
            this.lblNumBaggage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBaggage.Location = new System.Drawing.Point(37, 450);
            this.lblNumBaggage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumBaggage.Name = "lblNumBaggage";
            this.lblNumBaggage.Size = new System.Drawing.Size(121, 28);
            this.lblNumBaggage.TabIndex = 65;
            this.lblNumBaggage.Text = "No Baggage";
            // 
            // lblFlightTime
            // 
            this.lblFlightTime.AutoSize = true;
            this.lblFlightTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightTime.Location = new System.Drawing.Point(37, 367);
            this.lblFlightTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightTime.Name = "lblFlightTime";
            this.lblFlightTime.Size = new System.Drawing.Size(147, 28);
            this.lblFlightTime.TabIndex = 64;
            this.lblFlightTime.Text = "Departure Time";
            // 
            // lblDeptAirport
            // 
            this.lblDeptAirport.AutoSize = true;
            this.lblDeptAirport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptAirport.Location = new System.Drawing.Point(37, 175);
            this.lblDeptAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeptAirport.Name = "lblDeptAirport";
            this.lblDeptAirport.Size = new System.Drawing.Size(168, 28);
            this.lblDeptAirport.TabIndex = 61;
            this.lblDeptAirport.Text = "Departure Airport";
            // 
            // lblDeptAirportDetail
            // 
            this.lblDeptAirportDetail.AutoSize = true;
            this.lblDeptAirportDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptAirportDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblDeptAirportDetail.Location = new System.Drawing.Point(213, 167);
            this.lblDeptAirportDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeptAirportDetail.Name = "lblDeptAirportDetail";
            this.lblDeptAirportDetail.Size = new System.Drawing.Size(95, 28);
            this.lblDeptAirportDetail.TabIndex = 59;
            this.lblDeptAirportDetail.Text = "Unknown";
            // 
            // lblFlightDate
            // 
            this.lblFlightDate.AutoSize = true;
            this.lblFlightDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightDate.Location = new System.Drawing.Point(37, 319);
            this.lblFlightDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightDate.Name = "lblFlightDate";
            this.lblFlightDate.Size = new System.Drawing.Size(146, 28);
            this.lblFlightDate.TabIndex = 63;
            this.lblFlightDate.Text = "Departure Date";
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumber.Location = new System.Drawing.Point(37, 271);
            this.lblFlightNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(139, 28);
            this.lblFlightNumber.TabIndex = 56;
            this.lblFlightNumber.Text = "Flight Number";
            // 
            // lblArrAirport
            // 
            this.lblArrAirport.AutoSize = true;
            this.lblArrAirport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrAirport.Location = new System.Drawing.Point(37, 223);
            this.lblArrAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrAirport.Name = "lblArrAirport";
            this.lblArrAirport.Size = new System.Drawing.Size(137, 28);
            this.lblArrAirport.TabIndex = 62;
            this.lblArrAirport.Text = "Arrival Airport";
            // 
            // lblFlightTimedetail
            // 
            this.lblFlightTimedetail.AutoSize = true;
            this.lblFlightTimedetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightTimedetail.ForeColor = System.Drawing.Color.Plum;
            this.lblFlightTimedetail.Location = new System.Drawing.Point(213, 368);
            this.lblFlightTimedetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightTimedetail.Name = "lblFlightTimedetail";
            this.lblFlightTimedetail.Size = new System.Drawing.Size(95, 28);
            this.lblFlightTimedetail.TabIndex = 60;
            this.lblFlightTimedetail.Text = "Unknown";
            // 
            // lblFlightNumberDetail
            // 
            this.lblFlightNumberDetail.AutoSize = true;
            this.lblFlightNumberDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumberDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblFlightNumberDetail.Location = new System.Drawing.Point(213, 268);
            this.lblFlightNumberDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightNumberDetail.Name = "lblFlightNumberDetail";
            this.lblFlightNumberDetail.Size = new System.Drawing.Size(95, 28);
            this.lblFlightNumberDetail.TabIndex = 55;
            this.lblFlightNumberDetail.Text = "Unknown";
            // 
            // lblArrAirportDetail
            // 
            this.lblArrAirportDetail.AutoSize = true;
            this.lblArrAirportDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrAirportDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblArrAirportDetail.Location = new System.Drawing.Point(213, 218);
            this.lblArrAirportDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrAirportDetail.Name = "lblArrAirportDetail";
            this.lblArrAirportDetail.Size = new System.Drawing.Size(95, 28);
            this.lblArrAirportDetail.TabIndex = 58;
            this.lblArrAirportDetail.Text = "Unknown";
            // 
            // lblFlightDateDetails
            // 
            this.lblFlightDateDetails.AutoSize = true;
            this.lblFlightDateDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightDateDetails.ForeColor = System.Drawing.Color.Plum;
            this.lblFlightDateDetails.Location = new System.Drawing.Point(213, 318);
            this.lblFlightDateDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightDateDetails.Name = "lblFlightDateDetails";
            this.lblFlightDateDetails.Size = new System.Drawing.Size(95, 28);
            this.lblFlightDateDetails.TabIndex = 57;
            this.lblFlightDateDetails.Text = "Unknown";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label12.Location = new System.Drawing.Point(931, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(295, 37);
            this.label12.TabIndex = 40;
            this.label12.Text = "BOOKING FLIGHT DATA";
            // 
            // frmBookingPersonalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 714);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grpFlightData);
            this.Controls.Add(this.btnFlightBookingConfirm);
            this.Controls.Add(this.lblEndRouteDetails);
            this.Controls.Add(this.grpPersonalCreateBookingDetails);
            this.Controls.Add(this.mnuCreateBooking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBookingPersonalDetails";
            this.Text = "frmBookingPersonalDetails";
            this.Load += new System.EventHandler(this.frmBookingPersonalDetails_Load);
            this.grpPersonalCreateBookingDetails.ResumeLayout(false);
            this.grpPersonalCreateBookingDetails.PerformLayout();
            this.grpPaymentDetails.ResumeLayout(false);
            this.grpPaymentDetails.PerformLayout();
            this.grpFlightData.ResumeLayout(false);
            this.grpFlightData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuCreateBooking;
        private System.Windows.Forms.GroupBox grpPersonalCreateBookingDetails;
        private System.Windows.Forms.DateTimePicker dtpBookingDOB;
        private System.Windows.Forms.GroupBox grpPaymentDetails;
        private System.Windows.Forms.TextBox txtBookingEircode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookingPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtForeName;
        private System.Windows.Forms.TextBox txtBookingEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEndRouteDetails;
        private System.Windows.Forms.Button btnFlightBookingConfirm;
        private System.Windows.Forms.Label lblBookingFlightPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBookingFlightPriceDetail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpFlightData;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFlightTime;
        private System.Windows.Forms.Label lblFlightDate;
        private System.Windows.Forms.Label lblArrAirport;
        private System.Windows.Forms.Label lblDeptAirport;
        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.Label lblFlightTimedetail;
        private System.Windows.Forms.Label lblFlightNumberDetail;
        private System.Windows.Forms.Label lblFlightDateDetails;
        private System.Windows.Forms.Label lblDeptAirportDetail;
        private System.Windows.Forms.Label lblArrAirportDetail;
        private System.Windows.Forms.Label lblNumBaggageDetail;
        private System.Windows.Forms.Label lblNumBaggage;
        private System.Windows.Forms.Label lblBookingRouteIDDetail;
        private System.Windows.Forms.Label lblBookingRouteID;
        private System.Windows.Forms.Label lblPassengerIdDetail;
        private System.Windows.Forms.Label lblPassengerId;
        private System.Windows.Forms.TextBox txtPayBookingFlightPrice;
        private System.Windows.Forms.Label lblBookingIdDetail;
        private System.Windows.Forms.Label lblBookingId;
        private System.Windows.Forms.Label lblFlightSeatNumber;
        private System.Windows.Forms.Label lblFlightSeatNumberDetail;
        private System.Windows.Forms.Label lblEstArrTime;
        private System.Windows.Forms.Label lblEstArrTimeDetail;
    }
}