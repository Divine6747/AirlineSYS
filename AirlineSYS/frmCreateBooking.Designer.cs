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
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumBaggage = new System.Windows.Forms.TextBox();
            this.grpCreateBookingDetails = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.grpCreateBookingDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.lblAirportCode.Location = new System.Drawing.Point(35, 49);
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
            this.lblAirportName.Location = new System.Drawing.Point(439, 50);
            this.lblAirportName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAirportName.Name = "lblAirportName";
            this.lblAirportName.Size = new System.Drawing.Size(186, 25);
            this.lblAirportName.TabIndex = 9;
            this.lblAirportName.Text = "Select Arrival Airport";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label7.Location = new System.Drawing.Point(423, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "No. Baggage";
            // 
            // txtNumBaggage
            // 
            this.txtNumBaggage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNumBaggage.Location = new System.Drawing.Point(600, 165);
            this.txtNumBaggage.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumBaggage.Name = "txtNumBaggage";
            this.txtNumBaggage.Size = new System.Drawing.Size(85, 32);
            this.txtNumBaggage.TabIndex = 38;
            // 
            // grpCreateBookingDetails
            // 
            this.grpCreateBookingDetails.Controls.Add(this.groupBox1);
            this.grpCreateBookingDetails.Controls.Add(this.btnSearchDest);
            this.grpCreateBookingDetails.Controls.Add(this.cboArrAirportBooking);
            this.grpCreateBookingDetails.Controls.Add(this.cboDeptAirportBooking);
            this.grpCreateBookingDetails.Controls.Add(this.lblAirportName);
            this.grpCreateBookingDetails.Controls.Add(this.lblAirportCode);
            this.grpCreateBookingDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.grpCreateBookingDetails.Location = new System.Drawing.Point(35, 85);
            this.grpCreateBookingDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpCreateBookingDetails.Name = "grpCreateBookingDetails";
            this.grpCreateBookingDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpCreateBookingDetails.Size = new System.Drawing.Size(999, 389);
            this.grpCreateBookingDetails.TabIndex = 15;
            this.grpCreateBookingDetails.TabStop = false;
            this.grpCreateBookingDetails.Text = "Create Booking Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFlightTime);
            this.groupBox1.Controls.Add(this.lblFlightDate);
            this.groupBox1.Controls.Add(this.lblArrAirport);
            this.groupBox1.Controls.Add(this.labelblDeptAirport);
            this.groupBox1.Controls.Add(this.txtNumBaggage);
            this.groupBox1.Controls.Add(this.lblFlightNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblFlightTimedetail);
            this.groupBox1.Controls.Add(this.lblFlightNumberDetail);
            this.groupBox1.Controls.Add(this.lblFlightDateDetails);
            this.groupBox1.Controls.Add(this.lblDeptAirportDetail);
            this.groupBox1.Controls.Add(this.lblArrAirportDetail);
            this.groupBox1.Location = new System.Drawing.Point(103, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 236);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Details";
            // 
            // lblFlightTime
            // 
            this.lblFlightTime.AutoSize = true;
            this.lblFlightTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightTime.Location = new System.Drawing.Point(423, 115);
            this.lblFlightTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightTime.Name = "lblFlightTime";
            this.lblFlightTime.Size = new System.Drawing.Size(147, 28);
            this.lblFlightTime.TabIndex = 53;
            this.lblFlightTime.Text = "Departure Time";
            // 
            // lblFlightDate
            // 
            this.lblFlightDate.AutoSize = true;
            this.lblFlightDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightDate.Location = new System.Drawing.Point(36, 168);
            this.lblFlightDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightDate.Name = "lblFlightDate";
            this.lblFlightDate.Size = new System.Drawing.Size(146, 28);
            this.lblFlightDate.TabIndex = 52;
            this.lblFlightDate.Text = "Departure Date";
            // 
            // lblArrAirport
            // 
            this.lblArrAirport.AutoSize = true;
            this.lblArrAirport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrAirport.Location = new System.Drawing.Point(423, 62);
            this.lblArrAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrAirport.Name = "lblArrAirport";
            this.lblArrAirport.Size = new System.Drawing.Size(137, 28);
            this.lblArrAirport.TabIndex = 51;
            this.lblArrAirport.Text = "Arrival Airport";
            // 
            // labelblDeptAirport
            // 
            this.labelblDeptAirport.AutoSize = true;
            this.labelblDeptAirport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelblDeptAirport.Location = new System.Drawing.Point(36, 61);
            this.labelblDeptAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelblDeptAirport.Name = "labelblDeptAirport";
            this.labelblDeptAirport.Size = new System.Drawing.Size(168, 28);
            this.labelblDeptAirport.TabIndex = 50;
            this.labelblDeptAirport.Text = "Departure Airport";
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumber.Location = new System.Drawing.Point(36, 115);
            this.lblFlightNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(139, 28);
            this.lblFlightNumber.TabIndex = 46;
            this.lblFlightNumber.Text = "Flight Number";
            // 
            // lblFlightTimedetail
            // 
            this.lblFlightTimedetail.AutoSize = true;
            this.lblFlightTimedetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightTimedetail.ForeColor = System.Drawing.Color.Plum;
            this.lblFlightTimedetail.Location = new System.Drawing.Point(595, 115);
            this.lblFlightTimedetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightTimedetail.Name = "lblFlightTimedetail";
            this.lblFlightTimedetail.Size = new System.Drawing.Size(95, 28);
            this.lblFlightTimedetail.TabIndex = 49;
            this.lblFlightTimedetail.Text = "Unknown";
            // 
            // lblFlightNumberDetail
            // 
            this.lblFlightNumberDetail.AutoSize = true;
            this.lblFlightNumberDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumberDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblFlightNumberDetail.Location = new System.Drawing.Point(221, 115);
            this.lblFlightNumberDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightNumberDetail.Name = "lblFlightNumberDetail";
            this.lblFlightNumberDetail.Size = new System.Drawing.Size(95, 28);
            this.lblFlightNumberDetail.TabIndex = 45;
            this.lblFlightNumberDetail.Text = "Unknown";
            // 
            // lblFlightDateDetails
            // 
            this.lblFlightDateDetails.AutoSize = true;
            this.lblFlightDateDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightDateDetails.ForeColor = System.Drawing.Color.Plum;
            this.lblFlightDateDetails.Location = new System.Drawing.Point(221, 168);
            this.lblFlightDateDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightDateDetails.Name = "lblFlightDateDetails";
            this.lblFlightDateDetails.Size = new System.Drawing.Size(84, 28);
            this.lblFlightDateDetails.TabIndex = 46;
            this.lblFlightDateDetails.Text = "Uknown";
            // 
            // lblDeptAirportDetail
            // 
            this.lblDeptAirportDetail.AutoSize = true;
            this.lblDeptAirportDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptAirportDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblDeptAirportDetail.Location = new System.Drawing.Point(221, 62);
            this.lblDeptAirportDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeptAirportDetail.Name = "lblDeptAirportDetail";
            this.lblDeptAirportDetail.Size = new System.Drawing.Size(95, 28);
            this.lblDeptAirportDetail.TabIndex = 48;
            this.lblDeptAirportDetail.Text = "Unknown";
            // 
            // lblArrAirportDetail
            // 
            this.lblArrAirportDetail.AutoSize = true;
            this.lblArrAirportDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrAirportDetail.ForeColor = System.Drawing.Color.Plum;
            this.lblArrAirportDetail.Location = new System.Drawing.Point(595, 62);
            this.lblArrAirportDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrAirportDetail.Name = "lblArrAirportDetail";
            this.lblArrAirportDetail.Size = new System.Drawing.Size(95, 28);
            this.lblArrAirportDetail.TabIndex = 47;
            this.lblArrAirportDetail.Text = "Unknown";
            // 
            // btnSearchDest
            // 
            this.btnSearchDest.BackColor = System.Drawing.Color.Plum;
            this.btnSearchDest.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSearchDest.Location = new System.Drawing.Point(813, 46);
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
            this.cboArrAirportBooking.Location = new System.Drawing.Point(650, 43);
            this.cboArrAirportBooking.Margin = new System.Windows.Forms.Padding(4);
            this.cboArrAirportBooking.Name = "cboArrAirportBooking";
            this.cboArrAirportBooking.Size = new System.Drawing.Size(138, 33);
            this.cboArrAirportBooking.TabIndex = 43;
            // 
            // cboDeptAirportBooking
            // 
            this.cboDeptAirportBooking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeptAirportBooking.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboDeptAirportBooking.FormattingEnabled = true;
            this.cboDeptAirportBooking.Location = new System.Drawing.Point(276, 43);
            this.cboDeptAirportBooking.Margin = new System.Windows.Forms.Padding(4);
            this.cboDeptAirportBooking.Name = "cboDeptAirportBooking";
            this.cboDeptAirportBooking.Size = new System.Drawing.Size(138, 33);
            this.cboDeptAirportBooking.TabIndex = 42;
            // 
            // btnBookingFlightConfirm
            // 
            this.btnBookingFlightConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnBookingFlightConfirm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBookingFlightConfirm.Location = new System.Drawing.Point(428, 495);
            this.btnBookingFlightConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookingFlightConfirm.Name = "btnBookingFlightConfirm";
            this.btnBookingFlightConfirm.Size = new System.Drawing.Size(232, 47);
            this.btnBookingFlightConfirm.TabIndex = 16;
            this.btnBookingFlightConfirm.Text = "CONFIRM";
            this.btnBookingFlightConfirm.UseVisualStyleBackColor = false;
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
            this.label1.ForeColor = System.Drawing.Color.Plum;
            this.label1.Location = new System.Drawing.Point(349, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 54;
            this.label1.Text = "Unknown";
            // 
            // frmCreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 560);
            this.Controls.Add(this.btnBookingFlightConfirm);
            this.Controls.Add(this.grpCreateBookingDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuCreateBooking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCreateBooking";
            this.Text = "Create Booking";
            this.Load += new System.EventHandler(this.frmCreateBooking_Load);
            this.grpCreateBookingDetails.ResumeLayout(false);
            this.grpCreateBookingDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuCreateBooking;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.Label lblAirportCode;
        private System.Windows.Forms.Label lblAirportName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumBaggage;
        private System.Windows.Forms.GroupBox grpCreateBookingDetails;
        private System.Windows.Forms.Button btnBookingFlightConfirm;
        private System.Windows.Forms.ComboBox cboArrAirportBooking;
        private System.Windows.Forms.ComboBox cboDeptAirportBooking;
        private System.Windows.Forms.Label lblFlightTimedetail;
        private System.Windows.Forms.Label lblDeptAirportDetail;
        private System.Windows.Forms.Label lblArrAirportDetail;
        private System.Windows.Forms.Label lblFlightDateDetails;
        private System.Windows.Forms.Label lblFlightNumberDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.Label labelblDeptAirport;
        private System.Windows.Forms.Label lblArrAirport;
        private System.Windows.Forms.Label lblFlightTime;
        private System.Windows.Forms.Label lblFlightDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSearchDest;
        private System.Windows.Forms.Label label1;
    }
}