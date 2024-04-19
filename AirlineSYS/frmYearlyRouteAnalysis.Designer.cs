namespace AirlineSYS
{
    partial class frmYearlyRouteAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearlyRouteAnalysis));
            this.munBack = new System.Windows.Forms.Label();
            this.mnuYearlyRouteAnalysis = new System.Windows.Forms.MenuStrip();
            this.chtYearlyRouteAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboYearlyFlightAnalysis = new System.Windows.Forms.ComboBox();
            this.btnYearlyFlightAnalysisSearch = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblSelectYear = new System.Windows.Forms.Label();
            this.grpFlightAnalysis = new System.Windows.Forms.GroupBox();
            this.lblCancelFlightDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chtYearlyRouteAnalysis)).BeginInit();
            this.grpFlightAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munBack.Location = new System.Drawing.Point(808, 1);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.munBack.Size = new System.Drawing.Size(60, 20);
            this.munBack.TabIndex = 11;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // mnuYearlyRouteAnalysis
            // 
            this.mnuYearlyRouteAnalysis.BackColor = System.Drawing.Color.Plum;
            this.mnuYearlyRouteAnalysis.Location = new System.Drawing.Point(0, 0);
            this.mnuYearlyRouteAnalysis.Name = "mnuYearlyRouteAnalysis";
            this.mnuYearlyRouteAnalysis.Padding = new System.Windows.Forms.Padding(0);
            this.mnuYearlyRouteAnalysis.Size = new System.Drawing.Size(871, 24);
            this.mnuYearlyRouteAnalysis.TabIndex = 10;
            // 
            // chtYearlyRouteAnalysis
            // 
            chartArea1.Name = "ChartArea1";
            this.chtYearlyRouteAnalysis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtYearlyRouteAnalysis.Legends.Add(legend1);
            this.chtYearlyRouteAnalysis.Location = new System.Drawing.Point(46, 97);
            this.chtYearlyRouteAnalysis.Name = "chtYearlyRouteAnalysis";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Yearly Route Analysis";
            this.chtYearlyRouteAnalysis.Series.Add(series1);
            this.chtYearlyRouteAnalysis.Size = new System.Drawing.Size(779, 423);
            this.chtYearlyRouteAnalysis.TabIndex = 41;
            this.chtYearlyRouteAnalysis.Text = "chart1";
            this.chtYearlyRouteAnalysis.Visible = false;
            // 
            // cboYearlyFlightAnalysis
            // 
            this.cboYearlyFlightAnalysis.FormattingEnabled = true;
            this.cboYearlyFlightAnalysis.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2024"});
            this.cboYearlyFlightAnalysis.Location = new System.Drawing.Point(419, 47);
            this.cboYearlyFlightAnalysis.Name = "cboYearlyFlightAnalysis";
            this.cboYearlyFlightAnalysis.Size = new System.Drawing.Size(158, 21);
            this.cboYearlyFlightAnalysis.TabIndex = 42;
            // 
            // btnYearlyFlightAnalysisSearch
            // 
            this.btnYearlyFlightAnalysisSearch.BackColor = System.Drawing.Color.Plum;
            this.btnYearlyFlightAnalysisSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnYearlyFlightAnalysisSearch.Location = new System.Drawing.Point(606, 42);
            this.btnYearlyFlightAnalysisSearch.Name = "btnYearlyFlightAnalysisSearch";
            this.btnYearlyFlightAnalysisSearch.Size = new System.Drawing.Size(117, 30);
            this.btnYearlyFlightAnalysisSearch.TabIndex = 40;
            this.btnYearlyFlightAnalysisSearch.Text = "SEARCH";
            this.btnYearlyFlightAnalysisSearch.UseVisualStyleBackColor = false;
            this.btnYearlyFlightAnalysisSearch.Click += new System.EventHandler(this.btnYearlyFlightAnalysisSearch_Click_1);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(344, 537);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(174, 38);
            this.btnConfirm.TabIndex = 39;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click_1);
            // 
            // lblSelectYear
            // 
            this.lblSelectYear.AutoSize = true;
            this.lblSelectYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectYear.Location = new System.Drawing.Point(121, 47);
            this.lblSelectYear.Name = "lblSelectYear";
            this.lblSelectYear.Size = new System.Drawing.Size(255, 21);
            this.lblSelectYear.TabIndex = 38;
            this.lblSelectYear.Text = "Select Concluded Years for Analysis";
            // 
            // grpFlightAnalysis
            // 
            this.grpFlightAnalysis.Controls.Add(this.lblCancelFlightDetails);
            this.grpFlightAnalysis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFlightAnalysis.Location = new System.Drawing.Point(124, 132);
            this.grpFlightAnalysis.Name = "grpFlightAnalysis";
            this.grpFlightAnalysis.Size = new System.Drawing.Size(633, 337);
            this.grpFlightAnalysis.TabIndex = 43;
            this.grpFlightAnalysis.TabStop = false;
            this.grpFlightAnalysis.Text = "Select Year To be Analysed";
            // 
            // lblCancelFlightDetails
            // 
            this.lblCancelFlightDetails.AutoSize = true;
            this.lblCancelFlightDetails.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.lblCancelFlightDetails.Location = new System.Drawing.Point(85, 37);
            this.lblCancelFlightDetails.Name = "lblCancelFlightDetails";
            this.lblCancelFlightDetails.Size = new System.Drawing.Size(462, 31);
            this.lblCancelFlightDetails.TabIndex = 1;
            this.lblCancelFlightDetails.Text = "NO YEAR HAS BEEN ENTERED OR SELECTED";
            // 
            // frmYearlyRouteAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 589);
            this.Controls.Add(this.chtYearlyRouteAnalysis);
            this.Controls.Add(this.cboYearlyFlightAnalysis);
            this.Controls.Add(this.btnYearlyFlightAnalysisSearch);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblSelectYear);
            this.Controls.Add(this.grpFlightAnalysis);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuYearlyRouteAnalysis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYearlyRouteAnalysis";
            this.Text = "Yearly Route Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.chtYearlyRouteAnalysis)).EndInit();
            this.grpFlightAnalysis.ResumeLayout(false);
            this.grpFlightAnalysis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label munBack;
        private System.Windows.Forms.MenuStrip mnuYearlyRouteAnalysis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtYearlyRouteAnalysis;
        private System.Windows.Forms.ComboBox cboYearlyFlightAnalysis;
        private System.Windows.Forms.Button btnYearlyFlightAnalysisSearch;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblSelectYear;
        private System.Windows.Forms.GroupBox grpFlightAnalysis;
        private System.Windows.Forms.Label lblCancelFlightDetails;
    }
}