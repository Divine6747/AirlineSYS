namespace AirlineSYS
{
    partial class frmCreateRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateRoute));
            this.munBack = new System.Windows.Forms.Label();
            this.mnuCreateRoute = new System.Windows.Forms.MenuStrip();
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.lblDepartAirport = new System.Windows.Forms.Label();
            this.lblArrAirport = new System.Windows.Forms.Label();
            this.lblRouteDuration = new System.Windows.Forms.Label();
            this.grpOperatorDetails = new System.Windows.Forms.GroupBox();
            this.txtRouteDur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRouteStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoutePrice = new System.Windows.Forms.TextBox();
            this.txtRouteArr = new System.Windows.Forms.TextBox();
            this.btnCreateRouteConfirm = new System.Windows.Forms.Button();
            this.lblRouteID = new System.Windows.Forms.Label();
            this.lblRoute = new System.Windows.Forms.Label();
            this.mnuBack = new System.Windows.Forms.Label();
            this.txtRouteDept = new System.Windows.Forms.TextBox();
            this.grpOperatorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(867, -1);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.munBack.Size = new System.Drawing.Size(60, 24);
            this.munBack.TabIndex = 5;
            this.munBack.Text = "Back";
            // 
            // mnuCreateRoute
            // 
            this.mnuCreateRoute.BackColor = System.Drawing.Color.Plum;
            this.mnuCreateRoute.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCreateRoute.Location = new System.Drawing.Point(0, 0);
            this.mnuCreateRoute.Name = "mnuCreateRoute";
            this.mnuCreateRoute.Padding = new System.Windows.Forms.Padding(0);
            this.mnuCreateRoute.Size = new System.Drawing.Size(818, 24);
            this.mnuCreateRoute.TabIndex = 4;
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(324, 33);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(170, 37);
            this.lblAddAirport.TabIndex = 14;
            this.lblAddAirport.Text = "Create Route";
            // 
            // lblDepartAirport
            // 
            this.lblDepartAirport.AutoSize = true;
            this.lblDepartAirport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartAirport.Location = new System.Drawing.Point(31, 62);
            this.lblDepartAirport.Name = "lblDepartAirport";
            this.lblDepartAirport.Size = new System.Drawing.Size(133, 21);
            this.lblDepartAirport.TabIndex = 7;
            this.lblDepartAirport.Text = "Departure Airport";
            // 
            // lblArrAirport
            // 
            this.lblArrAirport.AutoSize = true;
            this.lblArrAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrAirport.Location = new System.Drawing.Point(421, 64);
            this.lblArrAirport.Name = "lblArrAirport";
            this.lblArrAirport.Size = new System.Drawing.Size(95, 18);
            this.lblArrAirport.TabIndex = 9;
            this.lblArrAirport.Text = "Arrival Airport";
            // 
            // lblRouteDuration
            // 
            this.lblRouteDuration.AutoSize = true;
            this.lblRouteDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteDuration.Location = new System.Drawing.Point(421, 115);
            this.lblRouteDuration.Name = "lblRouteDuration";
            this.lblRouteDuration.Size = new System.Drawing.Size(86, 18);
            this.lblRouteDuration.TabIndex = 17;
            this.lblRouteDuration.Text = "Ticket Price";
            // 
            // grpOperatorDetails
            // 
            this.grpOperatorDetails.Controls.Add(this.txtRouteDur);
            this.grpOperatorDetails.Controls.Add(this.label2);
            this.grpOperatorDetails.Controls.Add(this.txtRouteStatus);
            this.grpOperatorDetails.Controls.Add(this.label1);
            this.grpOperatorDetails.Controls.Add(this.txtRoutePrice);
            this.grpOperatorDetails.Controls.Add(this.txtRouteArr);
            this.grpOperatorDetails.Controls.Add(this.txtRouteDept);
            this.grpOperatorDetails.Controls.Add(this.lblRouteDuration);
            this.grpOperatorDetails.Controls.Add(this.lblArrAirport);
            this.grpOperatorDetails.Controls.Add(this.lblDepartAirport);
            this.grpOperatorDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperatorDetails.Location = new System.Drawing.Point(42, 102);
            this.grpOperatorDetails.Name = "grpOperatorDetails";
            this.grpOperatorDetails.Size = new System.Drawing.Size(735, 229);
            this.grpOperatorDetails.TabIndex = 15;
            this.grpOperatorDetails.TabStop = false;
            this.grpOperatorDetails.Text = "Route Details";
            // 
            // txtRouteDur
            // 
            this.txtRouteDur.Location = new System.Drawing.Point(180, 109);
            this.txtRouteDur.Name = "txtRouteDur";
            this.txtRouteDur.Size = new System.Drawing.Size(169, 29);
            this.txtRouteDur.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Duration";
            // 
            // txtRouteStatus
            // 
            this.txtRouteStatus.Location = new System.Drawing.Point(180, 159);
            this.txtRouteStatus.Name = "txtRouteStatus";
            this.txtRouteStatus.Size = new System.Drawing.Size(169, 29);
            this.txtRouteStatus.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Status";
            // 
            // txtRoutePrice
            // 
            this.txtRoutePrice.Location = new System.Drawing.Point(534, 110);
            this.txtRoutePrice.Name = "txtRoutePrice";
            this.txtRoutePrice.Size = new System.Drawing.Size(169, 29);
            this.txtRoutePrice.TabIndex = 20;
            // 
            // txtRouteArr
            // 
            this.txtRouteArr.Location = new System.Drawing.Point(534, 59);
            this.txtRouteArr.Name = "txtRouteArr";
            this.txtRouteArr.Size = new System.Drawing.Size(169, 29);
            this.txtRouteArr.TabIndex = 19;
            // 
            // btnCreateRouteConfirm
            // 
            this.btnCreateRouteConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnCreateRouteConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRouteConfirm.Location = new System.Drawing.Point(320, 357);
            this.btnCreateRouteConfirm.Name = "btnCreateRouteConfirm";
            this.btnCreateRouteConfirm.Size = new System.Drawing.Size(174, 38);
            this.btnCreateRouteConfirm.TabIndex = 16;
            this.btnCreateRouteConfirm.Text = "CONFIRM";
            this.btnCreateRouteConfirm.UseVisualStyleBackColor = false;
            this.btnCreateRouteConfirm.Click += new System.EventHandler(this.btnCreateRouteConfirm_Click);
            // 
            // lblRouteID
            // 
            this.lblRouteID.AutoSize = true;
            this.lblRouteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteID.ForeColor = System.Drawing.Color.Violet;
            this.lblRouteID.Location = new System.Drawing.Point(762, 52);
            this.lblRouteID.Name = "lblRouteID";
            this.lblRouteID.Size = new System.Drawing.Size(0, 18);
            this.lblRouteID.TabIndex = 28;
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoute.Location = new System.Drawing.Point(695, 52);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(66, 18);
            this.lblRoute.TabIndex = 27;
            this.lblRoute.Text = "Route ID";
            // 
            // mnuBack
            // 
            this.mnuBack.AutoSize = true;
            this.mnuBack.BackColor = System.Drawing.Color.Violet;
            this.mnuBack.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBack.Location = new System.Drawing.Point(753, 0);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.mnuBack.Size = new System.Drawing.Size(65, 23);
            this.mnuBack.TabIndex = 29;
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // txtRouteDept
            // 
            this.txtRouteDept.Location = new System.Drawing.Point(180, 56);
            this.txtRouteDept.Name = "txtRouteDept";
            this.txtRouteDept.Size = new System.Drawing.Size(169, 29);
            this.txtRouteDept.TabIndex = 18;
            // 
            // frmCreateRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 407);
            this.Controls.Add(this.mnuBack);
            this.Controls.Add(this.lblRouteID);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.btnCreateRouteConfirm);
            this.Controls.Add(this.grpOperatorDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuCreateRoute);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateRoute";
            this.Text = "Create Route";
            this.Load += new System.EventHandler(this.frmCreateRoute_Load);
            this.grpOperatorDetails.ResumeLayout(false);
            this.grpOperatorDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuCreateRoute;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.Label lblDepartAirport;
        private System.Windows.Forms.Label lblArrAirport;
        private System.Windows.Forms.Label lblRouteDuration;
        private System.Windows.Forms.GroupBox grpOperatorDetails;
        private System.Windows.Forms.Button btnCreateRouteConfirm;
        private System.Windows.Forms.TextBox txtRoutePrice;
        private System.Windows.Forms.TextBox txtRouteArr;
        private System.Windows.Forms.TextBox txtRouteDur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRouteStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRouteID;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label mnuBack;
        private System.Windows.Forms.TextBox txtRouteDept;
    }
}