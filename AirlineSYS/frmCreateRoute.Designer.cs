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
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.lblDepartAirport = new System.Windows.Forms.Label();
            this.lblArrAirport = new System.Windows.Forms.Label();
            this.lblRouteDuration = new System.Windows.Forms.Label();
            this.grpOperatorDetails = new System.Windows.Forms.GroupBox();
            this.txtRouteDur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoutePrice = new System.Windows.Forms.TextBox();
            this.txtRouteArr = new System.Windows.Forms.TextBox();
            this.txtRouteDept = new System.Windows.Forms.TextBox();
            this.btnCreateRouteConfirm = new System.Windows.Forms.Button();
            this.lblRouteID = new System.Windows.Forms.Label();
            this.lblRoute = new System.Windows.Forms.Label();
            this.mnuBack = new System.Windows.Forms.Label();
            this.mnuCreateRoute = new System.Windows.Forms.MenuStrip();
            this.grpOperatorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(362, 48);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(215, 46);
            this.lblAddAirport.TabIndex = 14;
            this.lblAddAirport.Text = "Create Route";
            // 
            // lblDepartAirport
            // 
            this.lblDepartAirport.AutoSize = true;
            this.lblDepartAirport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartAirport.Location = new System.Drawing.Point(46, 54);
            this.lblDepartAirport.Name = "lblDepartAirport";
            this.lblDepartAirport.Size = new System.Drawing.Size(168, 28);
            this.lblDepartAirport.TabIndex = 7;
            this.lblDepartAirport.Text = "Departure Airport";
            // 
            // lblArrAirport
            // 
            this.lblArrAirport.AutoSize = true;
            this.lblArrAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrAirport.Location = new System.Drawing.Point(439, 58);
            this.lblArrAirport.Name = "lblArrAirport";
            this.lblArrAirport.Size = new System.Drawing.Size(122, 24);
            this.lblArrAirport.TabIndex = 9;
            this.lblArrAirport.Text = "Arrival Airport";
            // 
            // lblRouteDuration
            // 
            this.lblRouteDuration.AutoSize = true;
            this.lblRouteDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteDuration.Location = new System.Drawing.Point(439, 120);
            this.lblRouteDuration.Name = "lblRouteDuration";
            this.lblRouteDuration.Size = new System.Drawing.Size(108, 24);
            this.lblRouteDuration.TabIndex = 17;
            this.lblRouteDuration.Text = "Ticket Price";
            // 
            // grpOperatorDetails
            // 
            this.grpOperatorDetails.Controls.Add(this.txtRouteDur);
            this.grpOperatorDetails.Controls.Add(this.label2);
            this.grpOperatorDetails.Controls.Add(this.txtRoutePrice);
            this.grpOperatorDetails.Controls.Add(this.txtRouteArr);
            this.grpOperatorDetails.Controls.Add(this.txtRouteDept);
            this.grpOperatorDetails.Controls.Add(this.lblRouteDuration);
            this.grpOperatorDetails.Controls.Add(this.lblArrAirport);
            this.grpOperatorDetails.Controls.Add(this.lblDepartAirport);
            this.grpOperatorDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperatorDetails.Location = new System.Drawing.Point(41, 108);
            this.grpOperatorDetails.Name = "grpOperatorDetails";
            this.grpOperatorDetails.Size = new System.Drawing.Size(799, 191);
            this.grpOperatorDetails.TabIndex = 15;
            this.grpOperatorDetails.TabStop = false;
            this.grpOperatorDetails.Text = "Route Details";
            // 
            // txtRouteDur
            // 
            this.txtRouteDur.Location = new System.Drawing.Point(225, 115);
            this.txtRouteDur.Name = "txtRouteDur";
            this.txtRouteDur.Size = new System.Drawing.Size(169, 34);
            this.txtRouteDur.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Duration";
            // 
            // txtRoutePrice
            // 
            this.txtRoutePrice.Location = new System.Drawing.Point(584, 110);
            this.txtRoutePrice.Name = "txtRoutePrice";
            this.txtRoutePrice.Size = new System.Drawing.Size(169, 34);
            this.txtRoutePrice.TabIndex = 20;
            // 
            // txtRouteArr
            // 
            this.txtRouteArr.Location = new System.Drawing.Point(584, 54);
            this.txtRouteArr.Name = "txtRouteArr";
            this.txtRouteArr.Size = new System.Drawing.Size(169, 34);
            this.txtRouteArr.TabIndex = 19;
            // 
            // txtRouteDept
            // 
            this.txtRouteDept.Location = new System.Drawing.Point(225, 54);
            this.txtRouteDept.Name = "txtRouteDept";
            this.txtRouteDept.Size = new System.Drawing.Size(169, 34);
            this.txtRouteDept.TabIndex = 18;
            // 
            // btnCreateRouteConfirm
            // 
            this.btnCreateRouteConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnCreateRouteConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRouteConfirm.Location = new System.Drawing.Point(377, 330);
            this.btnCreateRouteConfirm.Name = "btnCreateRouteConfirm";
            this.btnCreateRouteConfirm.Size = new System.Drawing.Size(184, 45);
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
            this.lblRouteID.Location = new System.Drawing.Point(790, 66);
            this.lblRouteID.Name = "lblRouteID";
            this.lblRouteID.Size = new System.Drawing.Size(30, 24);
            this.lblRouteID.TabIndex = 28;
            this.lblRouteID.Text = "00";
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoute.Location = new System.Drawing.Point(701, 66);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(82, 24);
            this.lblRoute.TabIndex = 27;
            this.lblRoute.Text = "Route ID";
            // 
            // mnuBack
            // 
            this.mnuBack.AutoSize = true;
            this.mnuBack.BackColor = System.Drawing.Color.Violet;
            this.mnuBack.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBack.Location = new System.Drawing.Point(802, 4);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.mnuBack.Size = new System.Drawing.Size(78, 30);
            this.mnuBack.TabIndex = 0;
            this.mnuBack.Text = "Back";
            this.mnuBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuCreateRoute
            // 
            this.mnuCreateRoute.BackColor = System.Drawing.Color.Plum;
            this.mnuCreateRoute.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCreateRoute.Location = new System.Drawing.Point(0, 0);
            this.mnuCreateRoute.Name = "mnuCreateRoute";
            this.mnuCreateRoute.Size = new System.Drawing.Size(880, 24);
            this.mnuCreateRoute.TabIndex = 30;
            this.mnuCreateRoute.Text = "menuStrip1";
            // 
            // frmCreateRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 396);
            this.Controls.Add(this.mnuBack);
            this.Controls.Add(this.lblRouteID);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.btnCreateRouteConfirm);
            this.Controls.Add(this.grpOperatorDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.mnuCreateRoute);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuCreateRoute;
            this.Name = "frmCreateRoute";
            this.Text = "Create Route";
            this.Load += new System.EventHandler(this.frmCreateRoute_Load);
            this.grpOperatorDetails.ResumeLayout(false);
            this.grpOperatorDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lblRouteID;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label mnuBack;
        private System.Windows.Forms.TextBox txtRouteDept;
        private System.Windows.Forms.MenuStrip mnuCreateRoute;
    }
}