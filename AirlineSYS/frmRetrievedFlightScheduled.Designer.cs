using AirlineSYS.Properties;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRetrievedFlightScheduled));
            this.grgRetrievedFlightScheduled = new System.Windows.Forms.DataGridView();
            this.lblEstArrTimeDetail = new System.Windows.Forms.Label();
            this.btnFlightBookingConfirm = new System.Windows.Forms.Button();
            this.mnuScheduleFlight = new System.Windows.Forms.MenuStrip();
            this.munBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grgRetrievedFlightScheduled)).BeginInit();
            this.SuspendLayout();
            // 
            // grgRetrievedFlightScheduled
            // 
            this.grgRetrievedFlightScheduled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grgRetrievedFlightScheduled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grgRetrievedFlightScheduled.Location = new System.Drawing.Point(41, 104);
            this.grgRetrievedFlightScheduled.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grgRetrievedFlightScheduled.Name = "grgRetrievedFlightScheduled";
            this.grgRetrievedFlightScheduled.RowHeadersWidth = 51;
            this.grgRetrievedFlightScheduled.RowTemplate.Height = 24;
            this.grgRetrievedFlightScheduled.Size = new System.Drawing.Size(963, 267);
            this.grgRetrievedFlightScheduled.TabIndex = 3;
            // 
            // lblEstArrTimeDetail
            // 
            this.lblEstArrTimeDetail.AutoSize = true;
            this.lblEstArrTimeDetail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstArrTimeDetail.ForeColor = System.Drawing.Color.Black;
            this.lblEstArrTimeDetail.Location = new System.Drawing.Point(253, 39);
            this.lblEstArrTimeDetail.Name = "lblEstArrTimeDetail";
            this.lblEstArrTimeDetail.Size = new System.Drawing.Size(538, 32);
            this.lblEstArrTimeDetail.TabIndex = 21;
            this.lblEstArrTimeDetail.Text = "Click On Row Content To Select Flight Preference\r\n";
            // 
            // btnFlightBookingConfirm
            // 
            this.btnFlightBookingConfirm.BackColor = System.Drawing.Color.Plum;
            this.btnFlightBookingConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlightBookingConfirm.Location = new System.Drawing.Point(435, 403);
            this.btnFlightBookingConfirm.Name = "btnFlightBookingConfirm";
            this.btnFlightBookingConfirm.Size = new System.Drawing.Size(174, 38);
            this.btnFlightBookingConfirm.TabIndex = 22;
            this.btnFlightBookingConfirm.Text = "CONFIRM";
            this.btnFlightBookingConfirm.UseVisualStyleBackColor = false;
            this.btnFlightBookingConfirm.Click += new System.EventHandler(this.btnFlightBookingConfirm_Click);
            // 
            // mnuScheduleFlight
            // 
            this.mnuScheduleFlight.BackColor = System.Drawing.Color.Plum;
            this.mnuScheduleFlight.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuScheduleFlight.Location = new System.Drawing.Point(0, 0);
            this.mnuScheduleFlight.Name = "mnuScheduleFlight";
            this.mnuScheduleFlight.Padding = new System.Windows.Forms.Padding(0);
            this.mnuScheduleFlight.Size = new System.Drawing.Size(1045, 24);
            this.mnuScheduleFlight.TabIndex = 23;
            // 
            // munBack
            // 
            this.munBack.AutoSize = true;
            this.munBack.BackColor = System.Drawing.Color.Violet;
            this.munBack.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.munBack.Location = new System.Drawing.Point(848, -1);
            this.munBack.Name = "munBack";
            this.munBack.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.munBack.Size = new System.Drawing.Size(60, 20);
            this.munBack.TabIndex = 24;
            this.munBack.Text = "Back";
            this.munBack.Click += new System.EventHandler(this.munBack_Click);
            // 
            // frmRetrievedFlightScheduled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 463);
            this.Controls.Add(this.munBack);
            this.Controls.Add(this.mnuScheduleFlight);
            this.Controls.Add(this.btnFlightBookingConfirm);
            this.Controls.Add(this.lblEstArrTimeDetail);
            this.Controls.Add(this.grgRetrievedFlightScheduled);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRetrievedFlightScheduled";
            this.Text = "frmRetrievedFlightScheduled";
            this.Load += new System.EventHandler(this.frmRetrievedFlightScheduled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grgRetrievedFlightScheduled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grgRetrievedFlightScheduled;
        private System.Windows.Forms.Label lblEstArrTimeDetail;
        private System.Windows.Forms.Button btnFlightBookingConfirm;
        private System.Windows.Forms.MenuStrip mnuScheduleFlight;
        private System.Windows.Forms.Label munBack;
    }
}