namespace AirlineSYS
{
    partial class frmAirlineMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAirlineMainMenu));
            this.picAirlineMainMenu = new System.Windows.Forms.PictureBox();
            this.mnuAirlineMainMenu = new System.Windows.Forms.MenuStrip();
            this.airportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddAirport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddOperator = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEndRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.munUpdateAirport = new System.Windows.Forms.ToolStripMenuItem();
            this.flightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScheduleFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearFlightAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearRouteAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.munExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAirlineMainMenu)).BeginInit();
            this.mnuAirlineMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picAirlineMainMenu
            // 
            this.picAirlineMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAirlineMainMenu.BackgroundImage")));
            this.picAirlineMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAirlineMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("picAirlineMainMenu.Image")));
            this.picAirlineMainMenu.Location = new System.Drawing.Point(0, 28);
            this.picAirlineMainMenu.Name = "picAirlineMainMenu";
            this.picAirlineMainMenu.Size = new System.Drawing.Size(800, 422);
            this.picAirlineMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAirlineMainMenu.TabIndex = 0;
            this.picAirlineMainMenu.TabStop = false;
            // 
            // mnuAirlineMainMenu
            // 
            this.mnuAirlineMainMenu.BackColor = System.Drawing.Color.Plum;
            this.mnuAirlineMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.airportToolStripMenuItem,
            this.flightToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.mnuAirlineMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuAirlineMainMenu.Name = "mnuAirlineMainMenu";
            this.mnuAirlineMainMenu.Size = new System.Drawing.Size(800, 28);
            this.mnuAirlineMainMenu.TabIndex = 1;
            // 
            // airportToolStripMenuItem
            // 
            this.airportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddAirport,
            this.mnuAddOperator,
            this.mnuCreateRoute,
            this.mnuEndRoute,
            this.munUpdateAirport});
            this.airportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportToolStripMenuItem.Name = "airportToolStripMenuItem";
            this.airportToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.airportToolStripMenuItem.Text = "Routes";
            // 
            // mnuAddAirport
            // 
            this.mnuAddAirport.Name = "mnuAddAirport";
            this.mnuAddAirport.Size = new System.Drawing.Size(178, 24);
            this.mnuAddAirport.Text = "Add Airport";
            this.mnuAddAirport.Click += new System.EventHandler(this.mnuAddAirport_Click_1);
            // 
            // mnuAddOperator
            // 
            this.mnuAddOperator.Name = "mnuAddOperator";
            this.mnuAddOperator.Size = new System.Drawing.Size(178, 24);
            this.mnuAddOperator.Text = "Add Operator";
            this.mnuAddOperator.Click += new System.EventHandler(this.mnuAddOperator_Click_1);
            // 
            // mnuCreateRoute
            // 
            this.mnuCreateRoute.Name = "mnuCreateRoute";
            this.mnuCreateRoute.Size = new System.Drawing.Size(178, 24);
            this.mnuCreateRoute.Text = "Create Route";
            this.mnuCreateRoute.Click += new System.EventHandler(this.mnuCreateRoute_Click_1);
            // 
            // mnuEndRoute
            // 
            this.mnuEndRoute.Name = "mnuEndRoute";
            this.mnuEndRoute.Size = new System.Drawing.Size(178, 24);
            this.mnuEndRoute.Text = "End Route";
            this.mnuEndRoute.Click += new System.EventHandler(this.mnuEndRoute_Click_1);
            // 
            // munUpdateAirport
            // 
            this.munUpdateAirport.Name = "munUpdateAirport";
            this.munUpdateAirport.Size = new System.Drawing.Size(178, 24);
            this.munUpdateAirport.Text = "Update Airport";
            this.munUpdateAirport.Click += new System.EventHandler(this.munUpdateAirport_Click);
            // 
            // flightToolStripMenuItem
            // 
            this.flightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuScheduleFlight,
            this.mnuUpdateFlight,
            this.mnuCancelFlight});
            this.flightToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightToolStripMenuItem.Name = "flightToolStripMenuItem";
            this.flightToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.flightToolStripMenuItem.Text = "Flights";
            // 
            // mnuScheduleFlight
            // 
            this.mnuScheduleFlight.Name = "mnuScheduleFlight";
            this.mnuScheduleFlight.Size = new System.Drawing.Size(179, 24);
            this.mnuScheduleFlight.Text = "Schedule Flight";
            this.mnuScheduleFlight.Click += new System.EventHandler(this.mnuScheduleFlight_Click_1);
            // 
            // mnuUpdateFlight
            // 
            this.mnuUpdateFlight.Name = "mnuUpdateFlight";
            this.mnuUpdateFlight.Size = new System.Drawing.Size(179, 24);
            this.mnuUpdateFlight.Text = "Update Flight";
            this.mnuUpdateFlight.Click += new System.EventHandler(this.mnuUpdateFlight_Click_1);
            // 
            // mnuCancelFlight
            // 
            this.mnuCancelFlight.Name = "mnuCancelFlight";
            this.mnuCancelFlight.Size = new System.Drawing.Size(179, 24);
            this.mnuCancelFlight.Text = "Cancel Flight";
            this.mnuCancelFlight.Click += new System.EventHandler(this.mnuCancelFlight_Click_1);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateBooking,
            this.mnuUpdateBooking,
            this.mnuCancelBooking});
            this.bookingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.bookingToolStripMenuItem.Text = "Bookings";
            // 
            // mnuCreateBooking
            // 
            this.mnuCreateBooking.Name = "mnuCreateBooking";
            this.mnuCreateBooking.Size = new System.Drawing.Size(186, 24);
            this.mnuCreateBooking.Text = "Create Booking";
            this.mnuCreateBooking.Click += new System.EventHandler(this.mnuCreateBooking_Click_1);
            // 
            // mnuUpdateBooking
            // 
            this.mnuUpdateBooking.Name = "mnuUpdateBooking";
            this.mnuUpdateBooking.Size = new System.Drawing.Size(186, 24);
            this.mnuUpdateBooking.Text = "Update Booking";
            this.mnuUpdateBooking.Click += new System.EventHandler(this.mnuUpdateBooking_Click_1);
            // 
            // mnuCancelBooking
            // 
            this.mnuCancelBooking.Name = "mnuCancelBooking";
            this.mnuCancelBooking.Size = new System.Drawing.Size(186, 24);
            this.mnuCancelBooking.Text = "Cancel Booking";
            this.mnuCancelBooking.Click += new System.EventHandler(this.mnuCancelBooking_Click_1);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYearFlightAnalysis,
            this.mnuYearRevenue,
            this.mnuYearRouteAnalysis});
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // mnuYearFlightAnalysis
            // 
            this.mnuYearFlightAnalysis.Name = "mnuYearFlightAnalysis";
            this.mnuYearFlightAnalysis.Size = new System.Drawing.Size(223, 24);
            this.mnuYearFlightAnalysis.Text = "Year Flight Analysis";
            this.mnuYearFlightAnalysis.Click += new System.EventHandler(this.mnuYearFlightAnalysis_Click);
            // 
            // mnuYearRevenue
            // 
            this.mnuYearRevenue.Name = "mnuYearRevenue";
            this.mnuYearRevenue.Size = new System.Drawing.Size(223, 24);
            this.mnuYearRevenue.Text = "Year Revenue Analysis";
            this.mnuYearRevenue.Click += new System.EventHandler(this.mnuYearRevenue_Click);
            // 
            // mnuYearRouteAnalysis
            // 
            this.mnuYearRouteAnalysis.Name = "mnuYearRouteAnalysis";
            this.mnuYearRouteAnalysis.Size = new System.Drawing.Size(223, 24);
            this.mnuYearRouteAnalysis.Text = "Year Route Analysis";
            this.mnuYearRouteAnalysis.Click += new System.EventHandler(this.mnuYearRouteAnalysis_Click);
            // 
            // munExit
            // 
            this.munExit.AutoSize = true;
            this.munExit.BackColor = System.Drawing.Color.Violet;
            this.munExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munExit.Location = new System.Drawing.Point(746, 3);
            this.munExit.Name = "munExit";
            this.munExit.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.munExit.Size = new System.Drawing.Size(53, 24);
            this.munExit.TabIndex = 13;
            this.munExit.Text = "Exit";
            this.munExit.Click += new System.EventHandler(this.munExit_Click_1);
            // 
            // frmAirlineMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.munExit);
            this.Controls.Add(this.picAirlineMainMenu);
            this.Controls.Add(this.mnuAirlineMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuAirlineMainMenu;
            this.Name = "frmAirlineMainMenu";
            this.Text = "Airline Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picAirlineMainMenu)).EndInit();
            this.mnuAirlineMainMenu.ResumeLayout(false);
            this.mnuAirlineMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAirlineMainMenu;
        private System.Windows.Forms.MenuStrip mnuAirlineMainMenu;
        private System.Windows.Forms.ToolStripMenuItem airportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddAirport;
        private System.Windows.Forms.ToolStripMenuItem mnuAddOperator;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateRoute;
        private System.Windows.Forms.ToolStripMenuItem mnuEndRoute;
        private System.Windows.Forms.ToolStripMenuItem flightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuScheduleFlight;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateFlight;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelFlight;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateBooking;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuYearFlightAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuYearRevenue;
        private System.Windows.Forms.ToolStripMenuItem mnuYearRouteAnalysis;
        private System.Windows.Forms.ToolStripMenuItem munUpdateAirport;
        private System.Windows.Forms.Label munExit;
    }
}

