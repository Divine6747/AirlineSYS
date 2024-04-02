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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUpdateFlightRouteIdDetails = new System.Windows.Forms.Label();
            this.lblUpdateFlightRouteDurationDetail = new System.Windows.Forms.Label();
            this.lblRouteId = new System.Windows.Forms.Label();
            this.lblUpdateFlightEstArrTimeDetail = new System.Windows.Forms.Label();
            this.lblUpdateFlightNumberDetail = new System.Windows.Forms.Label();
            this.lblRouteDuration = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboUpdateArrAirportFlight = new System.Windows.Forms.ComboBox();
            this.cboUpdateDeptAirportFlight = new System.Windows.Forms.ComboBox();
            this.grpUpdateFlightDetails.SuspendLayout();
            this.grpViewUpdateFlightDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(1078, -1);
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
            this.mnuUpdateFlight.Size = new System.Drawing.Size(1155, 24);
            this.mnuUpdateFlight.TabIndex = 6;
            // 
            // btnUpdateFlightConfirm
            // 
            this.btnUpdateFlightConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnUpdateFlightConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFlightConfirm.Location = new System.Drawing.Point(451, 591);
            this.btnUpdateFlightConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateFlightConfirm.Name = "btnUpdateFlightConfirm";
            this.btnUpdateFlightConfirm.Size = new System.Drawing.Size(232, 47);
            this.btnUpdateFlightConfirm.TabIndex = 13;
            this.btnUpdateFlightConfirm.Text = "CONFIRM";
            this.btnUpdateFlightConfirm.UseVisualStyleBackColor = false;
            this.btnUpdateFlightConfirm.Click += new System.EventHandler(this.btnAirportConfirm_Click);
            // 
            // grpUpdateFlightDetails
            // 
            this.grpUpdateFlightDetails.Controls.Add(this.cboUpdateDeptAirportFlight);
            this.grpUpdateFlightDetails.Controls.Add(this.cboUpdateArrAirportFlight);
            this.grpUpdateFlightDetails.Controls.Add(this.cboUpdateOperatorCodeFlight);
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
            this.grpUpdateFlightDetails.Location = new System.Drawing.Point(77, 301);
            this.grpUpdateFlightDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpUpdateFlightDetails.Name = "grpUpdateFlightDetails";
            this.grpUpdateFlightDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpUpdateFlightDetails.Size = new System.Drawing.Size(999, 267);
            this.grpUpdateFlightDetails.TabIndex = 15;
            this.grpUpdateFlightDetails.TabStop = false;
            this.grpUpdateFlightDetails.Text = "Update Flight Details";
            this.grpUpdateFlightDetails.Visible = false;
            // 
            // cboUpdateOperatorCodeFlight
            // 
            this.cboUpdateOperatorCodeFlight.FormattingEnabled = true;
            this.cboUpdateOperatorCodeFlight.Location = new System.Drawing.Point(227, 121);
            this.cboUpdateOperatorCodeFlight.Margin = new System.Windows.Forms.Padding(4);
            this.cboUpdateOperatorCodeFlight.Name = "cboUpdateOperatorCodeFlight";
            this.cboUpdateOperatorCodeFlight.Size = new System.Drawing.Size(159, 36);
            this.cboUpdateOperatorCodeFlight.TabIndex = 38;
            // 
            // cboUpdateDeptTime
            // 
            this.cboUpdateDeptTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateDeptTime.FormattingEnabled = true;
            this.cboUpdateDeptTime.Items.AddRange(new object[] {
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
            this.cboUpdateDeptTime.Location = new System.Drawing.Point(713, 183);
            this.cboUpdateDeptTime.Margin = new System.Windows.Forms.Padding(4);
            this.cboUpdateDeptTime.Name = "cboUpdateDeptTime";
            this.cboUpdateDeptTime.Size = new System.Drawing.Size(159, 36);
            this.cboUpdateDeptTime.TabIndex = 37;
            // 
            // dtpUpdateDeptFlight
            // 
            this.dtpUpdateDeptFlight.CustomFormat = " dd-MM-yyyy";
            this.dtpUpdateDeptFlight.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpdateDeptFlight.Location = new System.Drawing.Point(227, 192);
            this.dtpUpdateDeptFlight.Margin = new System.Windows.Forms.Padding(4);
            this.dtpUpdateDeptFlight.Name = "dtpUpdateDeptFlight";
            this.dtpUpdateDeptFlight.Size = new System.Drawing.Size(159, 34);
            this.dtpUpdateDeptFlight.TabIndex = 36;
            // 
            // txtUpdateNumFlightSeats
            // 
            this.txtUpdateNumFlightSeats.Location = new System.Drawing.Point(713, 119);
            this.txtUpdateNumFlightSeats.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateNumFlightSeats.Name = "txtUpdateNumFlightSeats";
            this.txtUpdateNumFlightSeats.Size = new System.Drawing.Size(159, 34);
            this.txtUpdateNumFlightSeats.TabIndex = 34;
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
            // lblUpdateFlightList
            // 
            this.lblUpdateFlightList.AutoSize = true;
            this.lblUpdateFlightList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateFlightList.Location = new System.Drawing.Point(296, 78);
            this.lblUpdateFlightList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateFlightList.Name = "lblUpdateFlightList";
            this.lblUpdateFlightList.Size = new System.Drawing.Size(135, 28);
            this.lblUpdateFlightList.TabIndex = 22;
            this.lblUpdateFlightList.Text = "Lists of Flights";
            // 
            // btnUpdateFlightSearch
            // 
            this.btnUpdateFlightSearch.BackColor = System.Drawing.Color.Plum;
            this.btnUpdateFlightSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnUpdateFlightSearch.Location = new System.Drawing.Point(691, 75);
            this.btnUpdateFlightSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateFlightSearch.Name = "btnUpdateFlightSearch";
            this.btnUpdateFlightSearch.Size = new System.Drawing.Size(168, 34);
            this.btnUpdateFlightSearch.TabIndex = 24;
            this.btnUpdateFlightSearch.Text = "SEARCH";
            this.btnUpdateFlightSearch.UseVisualStyleBackColor = false;
            this.btnUpdateFlightSearch.Click += new System.EventHandler(this.btnFlightSearch_Click);
            // 
            // cboUpdateFlight
            // 
            this.cboUpdateFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateFlight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUpdateFlight.FormattingEnabled = true;
            this.cboUpdateFlight.Items.AddRange(new object[] {
            "DUB - SHA",
            "JFK - SHA",
            "SHA - PEK",
            "SNN - FCO",
            "DUB - BGY"});
            this.cboUpdateFlight.Location = new System.Drawing.Point(478, 73);
            this.cboUpdateFlight.Margin = new System.Windows.Forms.Padding(4);
            this.cboUpdateFlight.Name = "cboUpdateFlight";
            this.cboUpdateFlight.Size = new System.Drawing.Size(166, 36);
            this.cboUpdateFlight.TabIndex = 25;
            // 
            // lblEndRouteDetails
            // 
            this.lblEndRouteDetails.AutoSize = true;
            this.lblEndRouteDetails.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.lblEndRouteDetails.Location = new System.Drawing.Point(359, 303);
            this.lblEndRouteDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndRouteDetails.Name = "lblEndRouteDetails";
            this.lblEndRouteDetails.Size = new System.Drawing.Size(436, 40);
            this.lblEndRouteDetails.TabIndex = 39;
            this.lblEndRouteDetails.Text = "NO FLIGHT HAS BEEN SELECTED";
            // 
            // grpViewUpdateFlightDetails
            // 
            this.grpViewUpdateFlightDetails.Controls.Add(this.label1);
            this.grpViewUpdateFlightDetails.Controls.Add(this.lblUpdateFlightRouteIdDetails);
            this.grpViewUpdateFlightDetails.Controls.Add(this.lblUpdateFlightRouteDurationDetail);
            this.grpViewUpdateFlightDetails.Controls.Add(this.lblRouteId);
            this.grpViewUpdateFlightDetails.Controls.Add(this.lblUpdateFlightEstArrTimeDetail);
            this.grpViewUpdateFlightDetails.Controls.Add(this.lblUpdateFlightNumberDetail);
            this.grpViewUpdateFlightDetails.Controls.Add(this.lblRouteDuration);
            this.grpViewUpdateFlightDetails.Controls.Add(this.label4);
            this.grpViewUpdateFlightDetails.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpViewUpdateFlightDetails.Location = new System.Drawing.Point(77, 135);
            this.grpViewUpdateFlightDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpViewUpdateFlightDetails.Name = "grpViewUpdateFlightDetails";
            this.grpViewUpdateFlightDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpViewUpdateFlightDetails.Size = new System.Drawing.Size(762, 149);
            this.grpViewUpdateFlightDetails.TabIndex = 40;
            this.grpViewUpdateFlightDetails.TabStop = false;
            this.grpViewUpdateFlightDetails.Text = "View Extra Details";
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
            // lblUpdateFlightRouteIdDetails
            // 
            this.lblUpdateFlightRouteIdDetails.AutoSize = true;
            this.lblUpdateFlightRouteIdDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateFlightRouteIdDetails.ForeColor = System.Drawing.Color.Plum;
            this.lblUpdateFlightRouteIdDetails.Location = new System.Drawing.Point(401, 52);
            this.lblUpdateFlightRouteIdDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateFlightRouteIdDetails.Name = "lblUpdateFlightRouteIdDetails";
            this.lblUpdateFlightRouteIdDetails.Size = new System.Drawing.Size(175, 24);
            this.lblUpdateFlightRouteIdDetails.TabIndex = 17;
            this.lblUpdateFlightRouteIdDetails.Text = "No Route Retrieved";
            // 
            // lblUpdateFlightRouteDurationDetail
            // 
            this.lblUpdateFlightRouteDurationDetail.AutoSize = true;
            this.lblUpdateFlightRouteDurationDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateFlightRouteDurationDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblUpdateFlightRouteDurationDetail.Location = new System.Drawing.Point(111, 97);
            this.lblUpdateFlightRouteDurationDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateFlightRouteDurationDetail.Name = "lblUpdateFlightRouteDurationDetail";
            this.lblUpdateFlightRouteDurationDetail.Size = new System.Drawing.Size(173, 24);
            this.lblUpdateFlightRouteDurationDetail.TabIndex = 19;
            this.lblUpdateFlightRouteDurationDetail.Text = "Does Not Retrieved";
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
            // lblUpdateFlightEstArrTimeDetail
            // 
            this.lblUpdateFlightEstArrTimeDetail.AutoSize = true;
            this.lblUpdateFlightEstArrTimeDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateFlightEstArrTimeDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblUpdateFlightEstArrTimeDetail.Location = new System.Drawing.Point(518, 97);
            this.lblUpdateFlightEstArrTimeDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateFlightEstArrTimeDetail.Name = "lblUpdateFlightEstArrTimeDetail";
            this.lblUpdateFlightEstArrTimeDetail.Size = new System.Drawing.Size(195, 24);
            this.lblUpdateFlightEstArrTimeDetail.TabIndex = 20;
            this.lblUpdateFlightEstArrTimeDetail.Text = "No Duration Retrieved";
            // 
            // lblUpdateFlightNumberDetail
            // 
            this.lblUpdateFlightNumberDetail.AutoSize = true;
            this.lblUpdateFlightNumberDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateFlightNumberDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblUpdateFlightNumberDetail.Location = new System.Drawing.Point(160, 52);
            this.lblUpdateFlightNumberDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateFlightNumberDetail.Name = "lblUpdateFlightNumberDetail";
            this.lblUpdateFlightNumberDetail.Size = new System.Drawing.Size(82, 24);
            this.lblUpdateFlightNumberDetail.TabIndex = 15;
            this.lblUpdateFlightNumberDetail.Text = "N/A0000";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Flight Number:";
            // 
            // cboUpdateArrAirportFlight
            // 
            this.cboUpdateArrAirportFlight.FormattingEnabled = true;
            this.cboUpdateArrAirportFlight.Location = new System.Drawing.Point(713, 50);
            this.cboUpdateArrAirportFlight.Margin = new System.Windows.Forms.Padding(4);
            this.cboUpdateArrAirportFlight.Name = "cboUpdateArrAirportFlight";
            this.cboUpdateArrAirportFlight.Size = new System.Drawing.Size(159, 36);
            this.cboUpdateArrAirportFlight.TabIndex = 39;
            // 
            // cboUpdateDeptAirportFlight
            // 
            this.cboUpdateDeptAirportFlight.FormattingEnabled = true;
            this.cboUpdateDeptAirportFlight.Location = new System.Drawing.Point(224, 57);
            this.cboUpdateDeptAirportFlight.Margin = new System.Windows.Forms.Padding(4);
            this.cboUpdateDeptAirportFlight.Name = "cboUpdateDeptAirportFlight";
            this.cboUpdateDeptAirportFlight.Size = new System.Drawing.Size(159, 36);
            this.cboUpdateDeptAirportFlight.TabIndex = 40;
            // 
            // frmUpdateFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 651);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox cboUpdateOperatorCodeFlight;
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
        private System.Windows.Forms.Label lblUpdateFlightEstArrTimeDetail;
        private System.Windows.Forms.Label lblUpdateFlightNumberDetail;
        private System.Windows.Forms.Label lblRouteDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboUpdateDeptAirportFlight;
        private System.Windows.Forms.ComboBox cboUpdateArrAirportFlight;
    }
}