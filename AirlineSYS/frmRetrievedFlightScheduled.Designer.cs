namespace AirlineSYS
{
    partial class frmRetrievedFlightScheduled
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
            this.grgRetrievedFlightScheduled = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grgRetrievedFlightScheduled)).BeginInit();
            this.SuspendLayout();
            // 
            // grgRetrievedFlightScheduled
            // 
            this.grgRetrievedFlightScheduled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grgRetrievedFlightScheduled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grgRetrievedFlightScheduled.Location = new System.Drawing.Point(76, -1);
            this.grgRetrievedFlightScheduled.Name = "grgRetrievedFlightScheduled";
            this.grgRetrievedFlightScheduled.RowHeadersWidth = 51;
            this.grgRetrievedFlightScheduled.RowTemplate.Height = 24;
            this.grgRetrievedFlightScheduled.Size = new System.Drawing.Size(1591, 680);
            this.grgRetrievedFlightScheduled.TabIndex = 3;
            // 
            // frmRetrievedFlightScheduled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1753, 680);
            this.Controls.Add(this.grgRetrievedFlightScheduled);
            this.Name = "frmRetrievedFlightScheduled";
            this.Text = "frmRetrievedFlightScheduled";
            this.Load += new System.EventHandler(this.frmRetrievedFlightScheduled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grgRetrievedFlightScheduled)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grgRetrievedFlightScheduled;
    }
}