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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateBooking));
            this.munBack = new System.Windows.Forms.Label();
            this.mnuCreateBooking = new System.Windows.Forms.MenuStrip();
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.lblAirportCode = new System.Windows.Forms.Label();
            this.lblAirportName = new System.Windows.Forms.Label();
            this.lblNumBaggage = new System.Windows.Forms.Label();
            this.grpCreateBookingDetails = new System.Windows.Forms.GroupBox();
            this.grpBookingDetails = new System.Windows.Forms.GroupBox();
            this.nudNumBaggage = new System.Windows.Forms.NumericUpDown();
            this.lblFlightTime = new System.Windows.Forms.Label();
            this.lblFlightDate = new System.Windows.Forms.Label();
            this.lblArrAirport = new System.Windows.Forms.Label();
            this.labelblDeptAirport = new System.Windows.Forms.Label();
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.lblFlightTimedetail = new System.Windows.Forms.Label();
            this.lblFlightNumberDetail = new System.Windows.Forms.Label();
            this.lblFlightDateDetails = new System.Windows.Forms.Label();
            this.lblDeptAirportDetail = new System.Windows.Forms.Label();
            this.lblArrAirportDetail = new System.Windows.Forms.Label();
            this.btnSearchDest = new System.Windows.Forms.Button();
            this.cboArrAirportBooking = new System.Windows.Forms.ComboBox();
            this.cboDeptAirportBooking = new System.Windows.Forms.ComboBox();
            this.btnBookingFlightConfirm = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstArrTimeDetails = new System.Windows.Forms.Label();
            this.grpCreateBookingDetails.SuspendLayout();
            this.grpBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumBaggage)).BeginInit();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11F);
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
            this.mnuCreateBooking.Font = new System.Drawing.Font("Segoe UI", 11F);
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
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAddAirport.Location = new System.Drawing.Point(25, 28);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(111, 20);
            this.lblAddAirport.TabIndex = 14;
            this.lblAddAirport.Text = "Create Booking";
            // 
            // lblAirportCode
            // 
            this.lblAirportCode.AutoSize = true;
            this.lblAirportCode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAirportCode.Location = new System.Drawing.Point(26, 40);
            this.lblAirportCode.Name = "lblAirportCode";
            this.lblAirportCode.Size = new System.Drawing.Size(171, 20);
            this.lblAirportCode.TabIndex = 7;
            this.lblAirportCode.Text = "Select Departure Airport";
            // 
            // lblAirportName
            // 
            this.lblAirportName.AutoSize = true;
            this.lblAirportName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAirportName.Location = new System.Drawing.Point(329, 41);
            this.lblAirportName.Name = "lblAirportName";
            this.lblAirportName.Size = new System.Drawing.Size(147, 20);
            this.lblAirportName.TabIndex = 9;
            this.lblAirportName.Text = "Select Arrival Airport";
            // 
            // lblNumBaggage
            // 
            this.lblNumBaggage.AutoSize = true;
            this.lblNumBaggage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNumBaggage.Location = new System.Drawing.Point(317, 136);
            this.lblNumBaggage.Name = "lblNumBaggage";
            this.lblNumBaggage.Size = new System.Drawing.Size(96, 20);
            this.lblNumBaggage.TabIndex = 39;
            this.lblNumBaggage.Text = "No. Baggage";
            this.lblNumBaggage.Visible = false;
            // 
            // grpCreateBookingDetails
            // 
            this.grpCreateBookingDetails.Controls.Add(this.grpBookingDetails);
            this.grpCreateBookingDetails.Controls.Add(this.btnSearchDest);
            this.grpCreateBookingDetails.Controls.Add(this.cboArrAirportBooking);
            this.grpCreateBookingDetails.Controls.Add(this.cboDeptAirportBooking);
            this.grpCreateBookingDetails.Controls.Add(this.lblAirportName);
            this.grpCreateBookingDetails.Controls.Add(this.lblAirportCode);
            this.grpCreateBookingDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.grpCreateBookingDetails.Location = new System.Drawing.Point(26, 69);
            this.grpCreateBookingDetails.Name = "grpCreateBookingDetails";
            this.grpCreateBookingDetails.Size = new System.Drawing.Size(749, 322);
            this.grpCreateBookingDetails.TabIndex = 15;
            this.grpCreateBookingDetails.TabStop = false;
            this.grpCreateBookingDetails.Text = "Create Booking Details";
            // 
            // grpBookingDetails
            // 
            this.grpBookingDetails.Controls.Add(this.lblEstArrTimeDetails);
            this.grpBookingDetails.Controls.Add(this.label1);
            this.grpBookingDetails.Controls.Add(this.nudNumBaggage);
            this.grpBookingDetails.Controls.Add(this.lblFlightTime);
            this.grpBookingDetails.Controls.Add(this.lblFlightDate);
            this.grpBookingDetails.Controls.Add(this.lblArrAirport);
            this.grpBookingDetails.Controls.Add(this.labelblDeptAirport);
            this.grpBookingDetails.Controls.Add(this.lblFlightNumber);
            this.grpBookingDetails.Controls.Add(this.lblNumBaggage);
            this.grpBookingDetails.Controls.Add(this.lblFlightTimedetail);
            this.grpBookingDetails.Controls.Add(this.lblFlightNumberDetail);
            this.grpBookingDetails.Controls.Add(this.lblFlightDateDetails);
            this.grpBookingDetails.Controls.Add(this.lblDeptAirportDetail);
            this.grpBookingDetails.Controls.Add(this.lblArrAirportDetail);
            this.grpBookingDetails.Location = new System.Drawing.Point(77, 89);
            this.grpBookingDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpBookingDetails.Name = "grpBookingDetails";
            this.grpBookingDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpBookingDetails.Size = new System.Drawing.Size(594, 208);
            this.grpBookingDetails.TabIndex = 45;
            this.grpBookingDetails.TabStop = false;
            this.grpBookingDetails.Text = "Booking Details";
            // 
            // nudNumBaggage
            // 
            this.nudNumBaggage.Location = new System.Drawing.Point(457, 137);
            this.nudNumBaggage.Margin = new System.Windows.Forms.Padding(2);
            this.nudNumBaggage.Name = "nudNumBaggage";
            this.nudNumBaggage.Size = new System.Drawing.Size(34, 27);
            this.nudNumBaggage.TabIndex = 17;
            this.nudNumBaggage.Visible = false;
            // 
            // lblFlightTime
            // 
            this.lblFlightTime.AutoSize = true;
            this.lblFlightTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightTime.Location = new System.Drawing.Point(317, 93);
            this.lblFlightTime.Name = "lblFlightTime";
            this.lblFlightTime.Size = new System.Drawing.Size(118, 21);
            this.lblFlightTime.TabIndex = 53;
            this.lblFlightTime.Text = "Departure Time";
            // 
            // lblFlightDate
            // 
            this.lblFlightDate.AutoSize = true;
            this.lblFlightDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightDate.Location = new System.Drawing.Point(27, 136);
            this.lblFlightDate.Name = "lblFlightDate";
            this.lblFlightDate.Size = new System.Drawing.Size(116, 21);
            this.lblFlightDate.TabIndex = 52;
            this.lblFlightDate.Text = "Departure Date";
            // 
            // lblArrAirport
            // 
            this.lblArrAirport.AutoSize = true;
            this.lblArrAirport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrAirport.Location = new System.Drawing.Point(317, 50);
            this.lblArrAirport.Name = "lblArrAirport";
            this.lblArrAirport.Size = new System.Drawing.Size(109, 21);
            this.lblArrAirport.TabIndex = 51;
            this.lblArrAirport.Text = "Arrival Airport";
            // 
            // labelblDeptAirport
            // 
            this.labelblDeptAirport.AutoSize = true;
            this.labelblDeptAirport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelblDeptAirport.Location = new System.Drawing.Point(27, 50);
            this.labelblDeptAirport.Name = "labelblDeptAirport";
            this.labelblDeptAirport.Size = new System.Drawing.Size(133, 21);
            this.labelblDeptAirport.TabIndex = 50;
            this.labelblDeptAirport.Text = "Departure Airport";
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumber.Location = new System.Drawing.Point(27, 93);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(111, 21);
            this.lblFlightNumber.TabIndex = 46;
            this.lblFlightNumber.Text = "Flight Number";
            // 
            // lblFlightTimedetail
            // 
            this.lblFlightTimedetail.AutoSize = true;
            this.lblFlightTimedetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightTimedetail.ForeColor = System.Drawing.Color.Plum;
            this.lblFlightTimedetail.Location = new System.Drawing.Point(446, 93);
            this.lblFlightTimedetail.Name = "lblFlightTimedetail";
            this.lblFlightTimedetail.Size = new System.Drawing.Size(77, 21);
            this.lblFlightTimedetail.TabIndex = 49;
            this.lblFlightTimedetail.Text = "Unknown";
            // 
            // lblFlightNumberDetail
            // 
            this.lblFlightNumberDetail.AutoSize = true;
            this.lblFlightNumberDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumberDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblFlightNumberDetail.Location = new System.Drawing.Point(166, 93);
            this.lblFlightNumberDetail.Name = "lblFlightNumberDetail";
            this.lblFlightNumberDetail.Size = new System.Drawing.Size(77, 21);
            this.lblFlightNumberDetail.TabIndex = 45;
            this.lblFlightNumberDetail.Text = "Unknown";
            // 
            // lblFlightDateDetails
            // 
            this.lblFlightDateDetails.AutoSize = true;
            this.lblFlightDateDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightDateDetails.ForeColor = System.Drawing.Color.Plum;
            this.lblFlightDateDetails.Location = new System.Drawing.Point(166, 136);
            this.lblFlightDateDetails.Name = "lblFlightDateDetails";
            this.lblFlightDateDetails.Size = new System.Drawing.Size(68, 21);
            this.lblFlightDateDetails.TabIndex = 46;
            this.lblFlightDateDetails.Text = "Uknown";
            // 
            // lblDeptAirportDetail
            // 
            this.lblDeptAirportDetail.AutoSize = true;
            this.lblDeptAirportDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptAirportDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblDeptAirportDetail.Location = new System.Drawing.Point(166, 50);
            this.lblDeptAirportDetail.Name = "lblDeptAirportDetail";
            this.lblDeptAirportDetail.Size = new System.Drawing.Size(77, 21);
            this.lblDeptAirportDetail.TabIndex = 48;
            this.lblDeptAirportDetail.Text = "Unknown";
            // 
            // lblArrAirportDetail
            // 
            this.lblArrAirportDetail.AutoSize = true;
            this.lblArrAirportDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrAirportDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblArrAirportDetail.Location = new System.Drawing.Point(446, 50);
            this.lblArrAirportDetail.Name = "lblArrAirportDetail";
            this.lblArrAirportDetail.Size = new System.Drawing.Size(77, 21);
            this.lblArrAirportDetail.TabIndex = 47;
            this.lblArrAirportDetail.Text = "Unknown";
            // 
            // btnSearchDest
            // 
            this.btnSearchDest.BackColor = System.Drawing.Color.Plum;
            this.btnSearchDest.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSearchDest.Location = new System.Drawing.Point(610, 37);
            this.btnSearchDest.Name = "btnSearchDest";
            this.btnSearchDest.Size = new System.Drawing.Size(112, 26);
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
            this.cboArrAirportBooking.Location = new System.Drawing.Point(488, 35);
            this.cboArrAirportBooking.Name = "cboArrAirportBooking";
            this.cboArrAirportBooking.Size = new System.Drawing.Size(104, 28);
            this.cboArrAirportBooking.TabIndex = 43;
            // 
            // cboDeptAirportBooking
            // 
            this.cboDeptAirportBooking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptAirportBooking.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboDeptAirportBooking.FormattingEnabled = true;
            this.cboDeptAirportBooking.Location = new System.Drawing.Point(207, 35);
            this.cboDeptAirportBooking.Name = "cboDeptAirportBooking";
            this.cboDeptAirportBooking.Size = new System.Drawing.Size(104, 28);
            this.cboDeptAirportBooking.TabIndex = 42;
            // 
            // btnBookingFlightConfirm
            // 
            this.btnBookingFlightConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnBookingFlightConfirm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBookingFlightConfirm.Location = new System.Drawing.Point(321, 412);
            this.btnBookingFlightConfirm.Name = "btnBookingFlightConfirm";
            this.btnBookingFlightConfirm.Size = new System.Drawing.Size(174, 38);
            this.btnBookingFlightConfirm.TabIndex = 16;
            this.btnBookingFlightConfirm.Text = "CONFIRM";
            this.btnBookingFlightConfirm.UseVisualStyleBackColor = false;
            this.btnBookingFlightConfirm.Visible = false;
            this.btnBookingFlightConfirm.Click += new System.EventHandler(this.btnBookingFlightConfirm_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 54;
            this.label1.Text = "Est Arrival Time";
            // 
            // lblEstArrTimeDetails
            // 
            this.lblEstArrTimeDetails.AutoSize = true;
            this.lblEstArrTimeDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstArrTimeDetails.ForeColor = System.Drawing.Color.Plum;
            this.lblEstArrTimeDetails.Location = new System.Drawing.Point(166, 170);
            this.lblEstArrTimeDetails.Name = "lblEstArrTimeDetails";
            this.lblEstArrTimeDetails.Size = new System.Drawing.Size(68, 21);
            this.lblEstArrTimeDetails.TabIndex = 55;
            this.lblEstArrTimeDetails.Text = "Uknown";
            // 
            // frmCreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.btnBookingFlightConfirm);
            this.Controls.Add(this.grpCreateBookingDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuCreateBooking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateBooking";
            this.Text = "Create Booking";
            this.Load += new System.EventHandler(this.frmCreateBooking_Load);
            this.grpCreateBookingDetails.ResumeLayout(false);
            this.grpCreateBookingDetails.PerformLayout();
            this.grpBookingDetails.ResumeLayout(false);
            this.grpBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumBaggage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuCreateBooking;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.Label lblAirportCode;
        private System.Windows.Forms.Label lblAirportName;
        private System.Windows.Forms.Label lblNumBaggage;
        private System.Windows.Forms.GroupBox grpCreateBookingDetails;
        private System.Windows.Forms.ComboBox cboArrAirportBooking;
        private System.Windows.Forms.ComboBox cboDeptAirportBooking;
        private System.Windows.Forms.Label lblFlightTimedetail;
        private System.Windows.Forms.Label lblDeptAirportDetail;
        private System.Windows.Forms.Label lblArrAirportDetail;
        private System.Windows.Forms.Label lblFlightNumberDetail;
        private System.Windows.Forms.GroupBox grpBookingDetails;
        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.Label labelblDeptAirport;
        private System.Windows.Forms.Label lblArrAirport;
        private System.Windows.Forms.Label lblFlightTime;
        private System.Windows.Forms.Label lblFlightDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSearchDest;
        public System.Windows.Forms.Label lblFlightDateDetails;
        public System.Windows.Forms.Button btnBookingFlightConfirm;
        public System.Windows.Forms.NumericUpDown nudNumBaggage;
        public System.Windows.Forms.Label lblEstArrTimeDetails;
        private System.Windows.Forms.Label label1;
    }
}