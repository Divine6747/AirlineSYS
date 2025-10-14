﻿namespace AirlineSYS
{
    partial class frmEndRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEndRoute));
            this.munBack = new System.Windows.Forms.Label();
            this.mnuEndRoute = new System.Windows.Forms.MenuStrip();
            this.btnEndRouteConfirm = new System.Windows.Forms.Button();
            this.grpEndRouteDetails = new System.Windows.Forms.GroupBox();
            this.lblEndRouteDetails = new System.Windows.Forms.Label();
            this.lblAddAirport = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEndRoute = new System.Windows.Forms.ComboBox();
            this.btnRouteSearch = new System.Windows.Forms.Button();
            this.mnuBack = new System.Windows.Forms.Label();
            this.grpEndRouteDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(1143, 0);
            this.munBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.munBack.Size = new System.Drawing.Size(77, 25);
            this.munBack.TabIndex = 5;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // mnuEndRoute
            // 
            this.mnuEndRoute.BackColor = System.Drawing.Color.Plum;
            this.mnuEndRoute.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuEndRoute.Location = new System.Drawing.Point(0, 0);
            this.mnuEndRoute.Name = "mnuEndRoute";
            this.mnuEndRoute.Padding = new System.Windows.Forms.Padding(0);
            this.mnuEndRoute.Size = new System.Drawing.Size(1105, 24);
            this.mnuEndRoute.TabIndex = 4;
            // 
            // btnEndRouteConfirm
            // 
            this.btnEndRouteConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnEndRouteConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndRouteConfirm.Location = new System.Drawing.Point(436, 569);
            this.btnEndRouteConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEndRouteConfirm.Name = "btnEndRouteConfirm";
            this.btnEndRouteConfirm.Size = new System.Drawing.Size(232, 47);
            this.btnEndRouteConfirm.TabIndex = 19;
            this.btnEndRouteConfirm.Text = "CONFIRM";
            this.btnEndRouteConfirm.UseVisualStyleBackColor = false;
            this.btnEndRouteConfirm.Click += new System.EventHandler(this.btnEndRouteConfirm_Click);
            // 
            // grpEndRouteDetails
            // 
            this.grpEndRouteDetails.Controls.Add(this.lblEndRouteDetails);
            this.grpEndRouteDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEndRouteDetails.Location = new System.Drawing.Point(191, 165);
            this.grpEndRouteDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEndRouteDetails.Name = "grpEndRouteDetails";
            this.grpEndRouteDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEndRouteDetails.Size = new System.Drawing.Size(723, 383);
            this.grpEndRouteDetails.TabIndex = 18;
            this.grpEndRouteDetails.TabStop = false;
            this.grpEndRouteDetails.Text = "End Route Details";
            // 
            // lblEndRouteDetails
            // 
            this.lblEndRouteDetails.AutoSize = true;
            this.lblEndRouteDetails.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.lblEndRouteDetails.Location = new System.Drawing.Point(145, 49);
            this.lblEndRouteDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndRouteDetails.Name = "lblEndRouteDetails";
            this.lblEndRouteDetails.Size = new System.Drawing.Size(433, 40);
            this.lblEndRouteDetails.TabIndex = 0;
            this.lblEndRouteDetails.Text = "NO ROUTE HAS BEEN SELECTED";
            // 
            // lblAddAirport
            // 
            this.lblAddAirport.AutoSize = true;
            this.lblAddAirport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAirport.Location = new System.Drawing.Point(464, 33);
            this.lblAddAirport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddAirport.Name = "lblAddAirport";
            this.lblAddAirport.Size = new System.Drawing.Size(138, 37);
            this.lblAddAirport.TabIndex = 17;
            this.lblAddAirport.Text = "End Route";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "List of Routes";
            // 
            // cboEndRoute
            // 
            this.cboEndRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEndRoute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEndRoute.FormattingEnabled = true;
            this.cboEndRoute.Items.AddRange(new object[] {
            "DUB - SHA",
            "JFK - SHA",
            "SHA - PEK",
            "SNN - FCO",
            "DUB - BGY"});
            this.cboEndRoute.Location = new System.Drawing.Point(441, 95);
            this.cboEndRoute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEndRoute.Name = "cboEndRoute";
            this.cboEndRoute.Size = new System.Drawing.Size(195, 36);
            this.cboEndRoute.TabIndex = 23;
            // 
            // btnRouteSearch
            // 
            this.btnRouteSearch.BackColor = System.Drawing.Color.Plum;
            this.btnRouteSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRouteSearch.Location = new System.Drawing.Point(665, 94);
            this.btnRouteSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRouteSearch.Name = "btnRouteSearch";
            this.btnRouteSearch.Size = new System.Drawing.Size(156, 37);
            this.btnRouteSearch.TabIndex = 24;
            this.btnRouteSearch.Text = "SEARCH";
            this.btnRouteSearch.UseVisualStyleBackColor = false;
            this.btnRouteSearch.Click += new System.EventHandler(this.btnRouteSearch_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.mnuBack.AutoSize = true;
            this.mnuBack.BackColor = System.Drawing.Color.Violet;
            this.mnuBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBack.Location = new System.Drawing.Point(1025, 0);
            this.mnuBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Padding = new System.Windows.Forms.Padding(13, 2, 13, 2);
            this.mnuBack.Size = new System.Drawing.Size(77, 29);
            this.mnuBack.TabIndex = 25;
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // frmEndRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 640);
            this.Controls.Add(this.mnuBack);
            this.Controls.Add(this.btnRouteSearch);
            this.Controls.Add(this.cboEndRoute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEndRouteConfirm);
            this.Controls.Add(this.grpEndRouteDetails);
            this.Controls.Add(this.lblAddAirport);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuEndRoute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEndRoute";
            this.Text = "End Route";
            this.Load += new System.EventHandler(this.frmEndRoute_Load);
            this.grpEndRouteDetails.ResumeLayout(false);
            this.grpEndRouteDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuEndRoute;
        private System.Windows.Forms.Button btnEndRouteConfirm;
        private System.Windows.Forms.GroupBox grpEndRouteDetails;
        private System.Windows.Forms.Label lblAddAirport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEndRoute;
        private System.Windows.Forms.Button btnRouteSearch;
        private System.Windows.Forms.Label lblEndRouteDetails;
        private System.Windows.Forms.Label mnuBack;
    }
}