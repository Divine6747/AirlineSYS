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
            this.btnUpdateFlightConfirm = new System.Windows.Forms.Button();
            this.grpUpdateFlightDetails = new System.Windows.Forms.GroupBox();
            this.cboUpdateOperatorCodeFlight = new System.Windows.Forms.ComboBox();
            this.cboUpdateDeptAirportFlight = new System.Windows.Forms.ComboBox();
            this.cboUpdateArrAirportFlight = new System.Windows.Forms.ComboBox();
            this.cboUpdateDeptTime = new System.Windows.Forms.ComboBox();
            this.dtpUpdateDeptFlight = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateNumFlightSeats = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOperatorCode = new System.Windows.Forms.Label();
            this.lblAirportEmail = new System.Windows.Forms.Label();
            this.lblAirportPhone = new System.Windows.Forms.Label();
            this.lblAirportName = new System.Windows.Forms.Label();
            this.lblAirportCode = new System.Windows.Forms.Label();
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.lblUpdateFlightList = new System.Windows.Forms.Label();
            this.btnUpdateFlightSearch = new System.Windows.Forms.Button();
            this.cboUpdateFlight = new System.Windows.Forms.ComboBox();
            this.lblEndRouteDetails = new System.Windows.Forms.Label();
            this.grpViewUpdateFlightDetails = new System.Windows.Forms.GroupBox();
            this.lblUpdateFlightEstArrTimeDetail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUpdateFlightRouteIdDetails = new System.Windows.Forms.Label();
            this.lblUpdateFlightRouteDurationDetail = new System.Windows.Forms.Label();
            this.lblRouteId = new System.Windows.Forms.Label();
            this.lblUpdateFlightNumberDetail = new System.Windows.Forms.Label();
            this.lblRouteDuration = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDateReview = new System.Windows.Forms.Label();
            this.grpUpdateFlightDetails.SuspendLayout();
            this.grpViewUpdateFlightDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(808, -1);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.munBack.Size = new System.Drawing.Size(60, 20);
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
            this.mnuUpdateFlight.Size = new System.Drawing.Size(866, 24);
            this.mnuUpdateFlight.TabIndex = 6;
            // 
            // btnUpdateFlightConfirm
            // 
            this.btnUpdateFlightConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnUpdateFlightConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFlightConfirm.Location = new System.Drawing.Point(346, 480);
            this.btnUpdateFlightConfirm.Name = "btnUpdateFlightConfirm";
            this.btnUpdateFlightConfirm.Size = new System.Drawing.Size(174, 38);
            this.btnUpdateFlightConfirm.TabIndex = 13;
            this.btnUpdateFlightConfirm.Text = "CONFIRM";
            this.btnUpdateFlightConfirm.UseVisualStyleBackColor = false;
            this.btnUpdateFlightConfirm.Click += new System.EventHandler(this.btnUpdateFlightConfirm_Click);
            // 
            // grpUpdateFlightDetails
            // 
            this.grpUpdateFlightDetails.Controls.Add(this.cboUpdateOperatorCodeFlight);
            this.grpUpdateFlightDetails.Controls.Add(this.cboUpdateDeptAirportFlight);
            this.grpUpdateFlightDetails.Controls.Add(this.cboUpdateArrAirportFlight);
            this.grpUpdateFlightDetails.Controls.Add(this.cboUpdateDeptTime);
            this.grpUpdateFlightDetails.Controls.Add(this.dtpUpdateDeptFlight);
            this.grpUpdateFlightDetails.Controls.Add(this.txtUpdateNumFlightSeats);
            this.grpUpdateFlightDetails.Controls.Add(this.label2);
            this.grpUpdateFlightDetails.Controls.Add(this.lblOperatorCode);
            this.grpUpdateFlightDetails.Controls.Add(this.lblAirportEmail);
            this.grpUpdateFlightDetails.Controls.Add(this.lblAirportPhone);
            this.grpUpdateFlightDetails.Controls.Add(this.lblAirportName);
            this.grpUpdateFlightDetails.Controls.Add(this.lblAirportCode);
            this.grpUpdateFlightDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateFlightDetails.Location = new System.Drawing.Point(58, 245);
            this.grpUpdateFlightDetails.Name = "grpUpdateFlightDetails";
            this.grpUpdateFlightDetails.Size = new System.Drawing.Size(749, 217);
            this.grpUpdateFlightDetails.TabIndex = 15;
            this.grpUpdateFlightDetails.TabStop = false;
            this.grpUpdateFlightDetails.Text = "Update Flight Details";
            this.grpUpdateFlightDetails.Visible = false;
            // 
            // cboUpdateOperatorCodeFlight
            // 
            this.cboUpdateOperatorCodeFlight.FormattingEnabled = true;
            this.cboUpdateOperatorCodeFlight.Location = new System.Drawing.Point(168, 158);
            this.cboUpdateOperatorCodeFlight.Margin = new System.Windows.Forms.Padding(2);
            this.cboUpdateOperatorCodeFlight.Name = "cboUpdateOperatorCodeFlight";
            this.cboUpdateOperatorCodeFlight.Size = new System.Drawing.Size(120, 29);
            this.cboUpdateOperatorCodeFlight.TabIndex = 41;
            this.cboUpdateOperatorCodeFlight.SelectedIndexChanged += new System.EventHandler(this.cboUpdateOperatorCodeFlight_SelectedIndexChanged_1);
            // 
            // cboUpdateDeptAirportFlight
            // 
            this.cboUpdateDeptAirportFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboUpdateDeptAirportFlight.FormattingEnabled = true;
            this.cboUpdateDeptAirportFlight.Location = new System.Drawing.Point(168, 46);
            this.cboUpdateDeptAirportFlight.Name = "cboUpdateDeptAirportFlight";
            this.cboUpdateDeptAirportFlight.Size = new System.Drawing.Size(120, 26);
            this.cboUpdateDeptAirportFlight.TabIndex = 40;
            this.cboUpdateDeptAirportFlight.SelectedIndexChanged += new System.EventHandler(this.cboUpdateDeptAirportFlight_SelectedIndexChanged);
            this.cboUpdateDeptAirportFlight.TextChanged += new System.EventHandler(this.cboUpdateDeptAirportFlight_TextChanged);
            // 
            // cboUpdateArrAirportFlight
            // 
            this.cboUpdateArrAirportFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboUpdateArrAirportFlight.FormattingEnabled = true;
            this.cboUpdateArrAirportFlight.Location = new System.Drawing.Point(535, 41);
            this.cboUpdateArrAirportFlight.Name = "cboUpdateArrAirportFlight";
            this.cboUpdateArrAirportFlight.Size = new System.Drawing.Size(120, 26);
            this.cboUpdateArrAirportFlight.TabIndex = 39;
            this.cboUpdateArrAirportFlight.SelectedIndexChanged += new System.EventHandler(this.cboUpdateArrAirportFlight_SelectedIndexChanged);
            this.cboUpdateArrAirportFlight.TextChanged += new System.EventHandler(this.cboUpdateArrAirportFlight_TextChanged);
            // 
            // cboUpdateDeptTime
            // 
            this.cboUpdateDeptTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboUpdateDeptTime.FormattingEnabled = true;
            this.cboUpdateDeptTime.Location = new System.Drawing.Point(535, 149);
            this.cboUpdateDeptTime.Name = "cboUpdateDeptTime";
            this.cboUpdateDeptTime.Size = new System.Drawing.Size(120, 26);
            this.cboUpdateDeptTime.TabIndex = 37;
            this.cboUpdateDeptTime.SelectedIndexChanged += new System.EventHandler(this.cboUpdateDeptTime_SelectedIndexChanged);
            // 
            // dtpUpdateDeptFlight
            // 
            this.dtpUpdateDeptFlight.CustomFormat = " dd-MM-yyyy";
            this.dtpUpdateDeptFlight.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dtpUpdateDeptFlight.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpdateDeptFlight.Location = new System.Drawing.Point(168, 104);
            this.dtpUpdateDeptFlight.MinDate = new System.DateTime(2000, 2, 1, 0, 0, 0, 0);
            this.dtpUpdateDeptFlight.Name = "dtpUpdateDeptFlight";
            this.dtpUpdateDeptFlight.Size = new System.Drawing.Size(120, 27);
            this.dtpUpdateDeptFlight.TabIndex = 36;
            this.dtpUpdateDeptFlight.ValueChanged += new System.EventHandler(this.dtpUpdateDeptFlight_ValueChanged);
            // 
            // txtUpdateNumFlightSeats
            // 
            this.txtUpdateNumFlightSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtUpdateNumFlightSeats.Location = new System.Drawing.Point(535, 96);
            this.txtUpdateNumFlightSeats.Name = "txtUpdateNumFlightSeats";
            this.txtUpdateNumFlightSeats.Size = new System.Drawing.Size(120, 24);
            this.txtUpdateNumFlightSeats.TabIndex = 34;
            this.txtUpdateNumFlightSeats.TextChanged += new System.EventHandler(this.txtUpdateNumFlightSeats_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Number of Seats";
            // 
            // lblOperatorCode
            // 
            this.lblOperatorCode.AutoSize = true;
            this.lblOperatorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblOperatorCode.Location = new System.Drawing.Point(28, 164);
            this.lblOperatorCode.Name = "lblOperatorCode";
            this.lblOperatorCode.Size = new System.Drawing.Size(107, 18);
            this.lblOperatorCode.TabIndex = 20;
            this.lblOperatorCode.Text = "Operator Code";
            // 
            // lblAirportEmail
            // 
            this.lblAirportEmail.AutoSize = true;
            this.lblAirportEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportEmail.Location = new System.Drawing.Point(405, 152);
            this.lblAirportEmail.Name = "lblAirportEmail";
            this.lblAirportEmail.Size = new System.Drawing.Size(110, 18);
            this.lblAirportEmail.TabIndex = 19;
            this.lblAirportEmail.Text = "Departure Time";
            // 
            // lblAirportPhone
            // 
            this.lblAirportPhone.AutoSize = true;
            this.lblAirportPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportPhone.Location = new System.Drawing.Point(28, 104);
            this.lblAirportPhone.Name = "lblAirportPhone";
            this.lblAirportPhone.Size = new System.Drawing.Size(108, 18);
            this.lblAirportPhone.TabIndex = 17;
            this.lblAirportPhone.Text = "Departure Date";
            // 
            // lblAirportName
            // 
            this.lblAirportName.AutoSize = true;
            this.lblAirportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportName.Location = new System.Drawing.Point(405, 46);
            this.lblAirportName.Name = "lblAirportName";
            this.lblAirportName.Size = new System.Drawing.Size(95, 18);
            this.lblAirportName.TabIndex = 9;
            this.lblAirportName.Text = "Arrival Airport";
            // 
            // lblAirportCode
            // 
            this.lblAirportCode.AutoSize = true;
            this.lblAirportCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirportCode.Location = new System.Drawing.Point(31, 44);
            this.lblAirportCode.Name = "lblAirportCode";
            this.lblAirportCode.Size = new System.Drawing.Size(120, 18);
            this.lblAirportCode.TabIndex = 7;
            this.lblAirportCode.Text = "Departure Airport";
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(25, 28);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(137, 30);
            this.lblAddAirport.TabIndex = 14;
            this.lblAddAirport.Text = "Update Flight";
            // 
            // lblUpdateFlightList
            // 
            this.lblUpdateFlightList.AutoSize = true;
            this.lblUpdateFlightList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUpdateFlightList.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.lblUpdateFlightList.Location = new System.Drawing.Point(256, 58);
            this.lblUpdateFlightList.Name = "lblUpdateFlightList";
            this.lblUpdateFlightList.Size = new System.Drawing.Size(116, 23);
            this.lblUpdateFlightList.TabIndex = 22;
            this.lblUpdateFlightList.Text = "Lists of Flights";
            // 
            // btnUpdateFlightSearch
            // 
            this.btnUpdateFlightSearch.BackColor = System.Drawing.Color.Plum;
            this.btnUpdateFlightSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnUpdateFlightSearch.Location = new System.Drawing.Point(503, 61);
            this.btnUpdateFlightSearch.Name = "btnUpdateFlightSearch";
            this.btnUpdateFlightSearch.Size = new System.Drawing.Size(106, 26);
            this.btnUpdateFlightSearch.TabIndex = 24;
            this.btnUpdateFlightSearch.Text = "SEARCH";
            this.btnUpdateFlightSearch.UseVisualStyleBackColor = false;
            this.btnUpdateFlightSearch.Click += new System.EventHandler(this.btnFlightSearch_Click);
            // 
            // cboUpdateFlight
            // 
            this.cboUpdateFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboUpdateFlight.FormattingEnabled = true;
            this.cboUpdateFlight.Location = new System.Drawing.Point(376, 59);
            this.cboUpdateFlight.Name = "cboUpdateFlight";
            this.cboUpdateFlight.Size = new System.Drawing.Size(108, 26);
            this.cboUpdateFlight.TabIndex = 25;
            // 
            // lblEndRouteDetails
            // 
            this.lblEndRouteDetails.AutoSize = true;
            this.lblEndRouteDetails.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.lblEndRouteDetails.Location = new System.Drawing.Point(269, 246);
            this.lblEndRouteDetails.Name = "lblEndRouteDetails";
            this.lblEndRouteDetails.Size = new System.Drawing.Size(342, 31);
            this.lblEndRouteDetails.TabIndex = 39;
            this.lblEndRouteDetails.Text = "NO FLIGHT HAS BEEN SELECTED";
            // 
            // grpViewUpdateFlightDetails
            // 
            this.grpViewUpdateFlightDetails.Controls.Add(this.lblUpdateFlightEstArrTimeDetail);
            this.grpViewUpdateFlightDetails.Controls.Add(this.label1);
            this.grpViewUpdateFlightDetails.Controls.Add(this.lblUpdateFlightRouteIdDetails);
            this.grpViewUpdateFlightDetails.Controls.Add(this.lblUpdateFlightRouteDurationDetail);
            this.grpViewUpdateFlightDetails.Controls.Add(this.lblRouteId);
            this.grpViewUpdateFlightDetails.Controls.Add(this.lblUpdateFlightNumberDetail);
            this.grpViewUpdateFlightDetails.Controls.Add(this.lblRouteDuration);
            this.grpViewUpdateFlightDetails.Controls.Add(this.label4);
            this.grpViewUpdateFlightDetails.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpViewUpdateFlightDetails.Location = new System.Drawing.Point(58, 110);
            this.grpViewUpdateFlightDetails.Name = "grpViewUpdateFlightDetails";
            this.grpViewUpdateFlightDetails.Size = new System.Drawing.Size(572, 121);
            this.grpViewUpdateFlightDetails.TabIndex = 40;
            this.grpViewUpdateFlightDetails.TabStop = false;
            this.grpViewUpdateFlightDetails.Text = "View Extra Details";
            // 
            // lblUpdateFlightEstArrTimeDetail
            // 
            this.lblUpdateFlightEstArrTimeDetail.AutoSize = true;
            this.lblUpdateFlightEstArrTimeDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateFlightEstArrTimeDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblUpdateFlightEstArrTimeDetail.Location = new System.Drawing.Point(389, 79);
            this.lblUpdateFlightEstArrTimeDetail.Name = "lblUpdateFlightEstArrTimeDetail";
            this.lblUpdateFlightEstArrTimeDetail.Size = new System.Drawing.Size(116, 18);
            this.lblUpdateFlightEstArrTimeDetail.TabIndex = 22;
            this.lblUpdateFlightEstArrTimeDetail.Text = "Did Not Retrieve";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Estimated Arrival Time:";
            // 
            // lblUpdateFlightRouteIdDetails
            // 
            this.lblUpdateFlightRouteIdDetails.AutoSize = true;
            this.lblUpdateFlightRouteIdDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateFlightRouteIdDetails.ForeColor = System.Drawing.Color.Plum;
            this.lblUpdateFlightRouteIdDetails.Location = new System.Drawing.Point(301, 42);
            this.lblUpdateFlightRouteIdDetails.Name = "lblUpdateFlightRouteIdDetails";
            this.lblUpdateFlightRouteIdDetails.Size = new System.Drawing.Size(138, 18);
            this.lblUpdateFlightRouteIdDetails.TabIndex = 17;
            this.lblUpdateFlightRouteIdDetails.Text = "No Route Retrieved";
            // 
            // lblUpdateFlightRouteDurationDetail
            // 
            this.lblUpdateFlightRouteDurationDetail.AutoSize = true;
            this.lblUpdateFlightRouteDurationDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateFlightRouteDurationDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblUpdateFlightRouteDurationDetail.Location = new System.Drawing.Point(83, 79);
            this.lblUpdateFlightRouteDurationDetail.Name = "lblUpdateFlightRouteDurationDetail";
            this.lblUpdateFlightRouteDurationDetail.Size = new System.Drawing.Size(116, 18);
            this.lblUpdateFlightRouteDurationDetail.TabIndex = 19;
            this.lblUpdateFlightRouteDurationDetail.Text = "Did Not Retrieve";
            // 
            // lblRouteId
            // 
            this.lblRouteId.AutoSize = true;
            this.lblRouteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteId.Location = new System.Drawing.Point(232, 42);
            this.lblRouteId.Name = "lblRouteId";
            this.lblRouteId.Size = new System.Drawing.Size(70, 18);
            this.lblRouteId.TabIndex = 16;
            this.lblRouteId.Text = "Route ID:";
            // 
            // lblUpdateFlightNumberDetail
            // 
            this.lblUpdateFlightNumberDetail.AutoSize = true;
            this.lblUpdateFlightNumberDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateFlightNumberDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblUpdateFlightNumberDetail.Location = new System.Drawing.Point(120, 42);
            this.lblUpdateFlightNumberDetail.Name = "lblUpdateFlightNumberDetail";
            this.lblUpdateFlightNumberDetail.Size = new System.Drawing.Size(64, 18);
            this.lblUpdateFlightNumberDetail.TabIndex = 15;
            this.lblUpdateFlightNumberDetail.Text = "N/A0000";
            // 
            // lblRouteDuration
            // 
            this.lblRouteDuration.AutoSize = true;
            this.lblRouteDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteDuration.Location = new System.Drawing.Point(16, 79);
            this.lblRouteDuration.Name = "lblRouteDuration";
            this.lblRouteDuration.Size = new System.Drawing.Size(68, 18);
            this.lblRouteDuration.TabIndex = 18;
            this.lblRouteDuration.Text = "Duration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Flight Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(636, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 30);
            this.label3.TabIndex = 42;
            this.label3.Text = "Reviewing Data";
            // 
            // lblDateReview
            // 
            this.lblDateReview.AutoSize = true;
            this.lblDateReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReview.ForeColor = System.Drawing.Color.Plum;
            this.lblDateReview.Location = new System.Drawing.Point(638, 67);
            this.lblDateReview.Name = "lblDateReview";
            this.lblDateReview.Size = new System.Drawing.Size(154, 18);
            this.lblDateReview.TabIndex = 41;
            this.lblDateReview.Text = "NO DATA GIVEN YET";
            // 
            // frmUpdateFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 529);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDateReview);
            this.Controls.Add(this.grpViewUpdateFlightDetails);
            this.Controls.Add(this.grpUpdateFlightDetails);
            this.Controls.Add(this.cboUpdateFlight);
            this.Controls.Add(this.btnUpdateFlightSearch);
            this.Controls.Add(this.lblUpdateFlightList);
            this.Controls.Add(this.btnUpdateFlightConfirm);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuUpdateFlight);
            this.Controls.Add(this.lblEndRouteDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateFlight";
            this.Text = "Update Flight";
            this.Load += new System.EventHandler(this.frmUpdateFlight_Load);
            this.grpUpdateFlightDetails.ResumeLayout(false);
            this.grpUpdateFlightDetails.PerformLayout();
            this.grpViewUpdateFlightDetails.ResumeLayout(false);
            this.grpViewUpdateFlightDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuUpdateFlight;
        private System.Windows.Forms.Button btnUpdateFlightConfirm;
        private System.Windows.Forms.GroupBox grpUpdateFlightDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOperatorCode;
        private System.Windows.Forms.Label lblAirportEmail;
        private System.Windows.Forms.Label lblAirportPhone;
        private System.Windows.Forms.Label lblAirportName;
        private System.Windows.Forms.Label lblAirportCode;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.Label lblUpdateFlightList;
        private System.Windows.Forms.Button btnUpdateFlightSearch;
        private System.Windows.Forms.ComboBox cboUpdateDeptTime;
        private System.Windows.Forms.DateTimePicker dtpUpdateDeptFlight;
        private System.Windows.Forms.TextBox txtUpdateNumFlightSeats;
        private System.Windows.Forms.ComboBox cboUpdateFlight;
        private System.Windows.Forms.Label lblEndRouteDetails;
        private System.Windows.Forms.GroupBox grpViewUpdateFlightDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUpdateFlightRouteIdDetails;
        private System.Windows.Forms.Label lblUpdateFlightRouteDurationDetail;
        private System.Windows.Forms.Label lblRouteId;
        private System.Windows.Forms.Label lblUpdateFlightNumberDetail;
        private System.Windows.Forms.Label lblRouteDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboUpdateDeptAirportFlight;
        private System.Windows.Forms.ComboBox cboUpdateArrAirportFlight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDateReview;
        private System.Windows.Forms.Label lblUpdateFlightEstArrTimeDetail;
        private System.Windows.Forms.ComboBox cboUpdateOperatorCodeFlight;
    }
}