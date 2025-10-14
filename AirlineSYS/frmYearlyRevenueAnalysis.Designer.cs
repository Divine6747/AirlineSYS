﻿namespace AirlineSYS
{
    partial class frmYearlyRevenueAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearlyRevenueAnalysis));
            this.munBack = new System.Windows.Forms.Label();
            this.mnuYearlyRevenueAnalysis = new System.Windows.Forms.MenuStrip();
            this.chtYearlyRevenueAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboYearlyRevenueAnalysisYears = new System.Windows.Forms.ComboBox();
            this.btnYearlyRevenueAnalysisSearch = new System.Windows.Forms.Button();
            this.btnRevenueConfirm = new System.Windows.Forms.Button();
            this.lblSelectYear = new System.Windows.Forms.Label();
            this.grpFlightAnalysis = new System.Windows.Forms.GroupBox();
            this.lblCancelFlightDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chtYearlyRevenueAnalysis)).BeginInit();
            this.grpFlightAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(1239, 1);
            this.munBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.munBack.Size = new System.Drawing.Size(77, 25);
            this.munBack.TabIndex = 11;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // mnuYearlyRevenueAnalysis
            // 
            this.mnuYearlyRevenueAnalysis.BackColor = System.Drawing.Color.Plum;
            this.mnuYearlyRevenueAnalysis.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuYearlyRevenueAnalysis.Location = new System.Drawing.Point(0, 0);
            this.mnuYearlyRevenueAnalysis.Name = "mnuYearlyRevenueAnalysis";
            this.mnuYearlyRevenueAnalysis.Padding = new System.Windows.Forms.Padding(0);
            this.mnuYearlyRevenueAnalysis.Size = new System.Drawing.Size(1316, 24);
            this.mnuYearlyRevenueAnalysis.TabIndex = 10;
            // 
            // chtYearlyRevenueAnalysis
            // 
            chartArea1.Name = "ChartArea1";
            this.chtYearlyRevenueAnalysis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtYearlyRevenueAnalysis.Legends.Add(legend1);
            this.chtYearlyRevenueAnalysis.Location = new System.Drawing.Point(61, 119);
            this.chtYearlyRevenueAnalysis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chtYearlyRevenueAnalysis.Name = "chtYearlyRevenueAnalysis";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Yearly Revenue Analysis";
            this.chtYearlyRevenueAnalysis.Series.Add(series1);
            this.chtYearlyRevenueAnalysis.Size = new System.Drawing.Size(1239, 519);
            this.chtYearlyRevenueAnalysis.TabIndex = 35;
            this.chtYearlyRevenueAnalysis.Text = "chart1";
            this.chtYearlyRevenueAnalysis.Visible = false;
            // 
            // cboYearlyRevenueAnalysisYears
            // 
            this.cboYearlyRevenueAnalysisYears.FormattingEnabled = true;
            this.cboYearlyRevenueAnalysisYears.Location = new System.Drawing.Point(576, 54);
            this.cboYearlyRevenueAnalysisYears.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboYearlyRevenueAnalysisYears.Name = "cboYearlyRevenueAnalysisYears";
            this.cboYearlyRevenueAnalysisYears.Size = new System.Drawing.Size(159, 24);
            this.cboYearlyRevenueAnalysisYears.TabIndex = 36;
            // 
            // btnYearlyRevenueAnalysisSearch
            // 
            this.btnYearlyRevenueAnalysisSearch.BackColor = System.Drawing.Color.Plum;
            this.btnYearlyRevenueAnalysisSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnYearlyRevenueAnalysisSearch.Location = new System.Drawing.Point(839, 49);
            this.btnYearlyRevenueAnalysisSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYearlyRevenueAnalysisSearch.Name = "btnYearlyRevenueAnalysisSearch";
            this.btnYearlyRevenueAnalysisSearch.Size = new System.Drawing.Size(156, 37);
            this.btnYearlyRevenueAnalysisSearch.TabIndex = 34;
            this.btnYearlyRevenueAnalysisSearch.Text = "SEARCH";
            this.btnYearlyRevenueAnalysisSearch.UseVisualStyleBackColor = false;
            this.btnYearlyRevenueAnalysisSearch.Click += new System.EventHandler(this.btnYearlyRevenueAnalysisSearch_Click);
            // 
            // btnRevenueConfirm
            // 
            this.btnRevenueConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnRevenueConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenueConfirm.Location = new System.Drawing.Point(459, 661);
            this.btnRevenueConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRevenueConfirm.Name = "btnRevenueConfirm";
            this.btnRevenueConfirm.Size = new System.Drawing.Size(232, 47);
            this.btnRevenueConfirm.TabIndex = 33;
            this.btnRevenueConfirm.Text = "CONFIRM";
            this.btnRevenueConfirm.UseVisualStyleBackColor = false;
            this.btnRevenueConfirm.Click += new System.EventHandler(this.btnRevenueConfirm_Click_1);
            // 
            // lblSelectYear
            // 
            this.lblSelectYear.AutoSize = true;
            this.lblSelectYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectYear.Location = new System.Drawing.Point(165, 54);
            this.lblSelectYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectYear.Name = "lblSelectYear";
            this.lblSelectYear.Size = new System.Drawing.Size(317, 28);
            this.lblSelectYear.TabIndex = 32;
            this.lblSelectYear.Text = "Select Concluded Years for Analysis";
            // 
            // grpFlightAnalysis
            // 
            this.grpFlightAnalysis.Controls.Add(this.lblCancelFlightDetails);
            this.grpFlightAnalysis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFlightAnalysis.Location = new System.Drawing.Point(165, 162);
            this.grpFlightAnalysis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFlightAnalysis.Name = "grpFlightAnalysis";
            this.grpFlightAnalysis.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFlightAnalysis.Size = new System.Drawing.Size(844, 415);
            this.grpFlightAnalysis.TabIndex = 37;
            this.grpFlightAnalysis.TabStop = false;
            this.grpFlightAnalysis.Text = "Select Year To be Analysed";
            // 
            // lblCancelFlightDetails
            // 
            this.lblCancelFlightDetails.AutoSize = true;
            this.lblCancelFlightDetails.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.lblCancelFlightDetails.Location = new System.Drawing.Point(113, 46);
            this.lblCancelFlightDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCancelFlightDetails.Name = "lblCancelFlightDetails";
            this.lblCancelFlightDetails.Size = new System.Drawing.Size(585, 40);
            this.lblCancelFlightDetails.TabIndex = 1;
            this.lblCancelFlightDetails.Text = "NO YEAR HAS BEEN ENTERED OR SELECTED";
            // 
            // frmYearlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 721);
            this.Controls.Add(this.chtYearlyRevenueAnalysis);
            this.Controls.Add(this.cboYearlyRevenueAnalysisYears);
            this.Controls.Add(this.btnYearlyRevenueAnalysisSearch);
            this.Controls.Add(this.btnRevenueConfirm);
            this.Controls.Add(this.lblSelectYear);
            this.Controls.Add(this.grpFlightAnalysis);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuYearlyRevenueAnalysis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmYearlyRevenueAnalysis";
            this.Text = "Yearly Revenue Analysis";
            this.Load += new System.EventHandler(this.frmYearlyRevenueAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtYearlyRevenueAnalysis)).EndInit();
            this.grpFlightAnalysis.ResumeLayout(false);
            this.grpFlightAnalysis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuYearlyRevenueAnalysis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtYearlyRevenueAnalysis;
        private System.Windows.Forms.ComboBox cboYearlyRevenueAnalysisYears;
        private System.Windows.Forms.Button btnYearlyRevenueAnalysisSearch;
        private System.Windows.Forms.Button btnRevenueConfirm;
        private System.Windows.Forms.Label lblSelectYear;
        private System.Windows.Forms.GroupBox grpFlightAnalysis;
        private System.Windows.Forms.Label lblCancelFlightDetails;
    }
}