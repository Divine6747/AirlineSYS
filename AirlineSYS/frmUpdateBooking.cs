﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    public partial class frmUpdateBooking : Form
    {
        frmAirlineMainMenu parent;
        private DateTime originalFlightDate;

        public frmUpdateBooking()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmUpdateBooking(frmAirlineMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void munBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAirlineMainMenu frmAirlineMainMenu = new frmAirlineMainMenu();
            frmAirlineMainMenu.Show();
        }


        private void btnUpdateBookingIDSearch_Click(object sender, EventArgs e)
        {
            grpUpdateCreateBookingDetails.Visible = true;
            grpRetriveUpdateBooking.Visible = true;
            int bookingID = Convert.ToInt32(txtBookingID.Text);
            DataTable dt = Booking.findBookingDetails(bookingID);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                lblUpdateFlightNumber.Text = row["FlightNumber"].ToString();
                cboDeptimeDetail.Text = row["FlightTime"].ToString();
                dptUpdateBookingDate.Text = ((DateTime)row["FlightDate"]).ToString();
                lblSeatNumDetail.Text = row["SeatNum"].ToString();
                nudNumBaggage.Text = row["NumBaggage"].ToString();
                lblUpdatePassengerID.Text = row["PassengerID"].ToString();
                lblUpdateBookingRouteID.Text = row["RouteID"].ToString();
                int routeID = Convert.ToInt32(row["RouteID"]);

                originalFlightDate = (DateTime)row["FlightDate"];
                dptUpdateBookingDate.Text = originalFlightDate.ToString();

                Route route = Route.getAirportsByRouteID(routeID);

                if (route != null)
                {
                    cboUpdateDeptAirportDetail.Text = route.getDepartureAirport();
                    cboUpdateArrAirportDetail.Text = route.getArrivalAirport();
                }
                else
                {
                    MessageBox.Show("Selected route details are not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                lblUpdateBookingID.Text = row["BookingID"].ToString();
                lbFlightBookingPriceDetail.Text = row["AmountPaid"].ToString();
                txtUpdateForeName.Text = row["forename"].ToString();
                txtUpdateSurname.Text = row["surname"].ToString();
                txtUpdateBookingEmail.Text = row["Email"].ToString();
                dtpDOBUpdate.Text = ((DateTime)row["DateOfBirth"]).ToString();
                txtUpdateBooingPhone.Text = row["Phone"].ToString();
                txtUpdateEircode.Text = row["Eircode"].ToString();
            }
            else
            {
                MessageBox.Show("No booking found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        private void btnUpadateBookingConfirm_Click(object sender, EventArgs e)
        {

            int passengerID = Convert.ToInt32(lblUpdatePassengerID.Text);
            if (!ValidateUpdatedBookingPersonalDetails.ValidatePersonalDetails(txtUpdateForeName.Text, txtUpdateSurname.Text, dtpDOBUpdate.Value, txtUpdateBookingEmail.Text, txtUpdateBooingPhone.Text, txtUpdateEircode.Text) || !ValidateUpdatedBookingPersonalDetails.ValidateNumBaggage(Convert.ToInt32(nudNumBaggage.Value)))
            {
                return;
            }
            else
            {
                Passenger updatedPassenger = new Passenger(
                    Convert.ToInt32(lblUpdatePassengerID.Text),
                    txtUpdateForeName.Text,
                    txtUpdateSurname.Text,
                    DateTime.Parse(dtpDOBUpdate.Text),
                    txtUpdateBookingEmail.Text,
                    txtUpdateBooingPhone.Text,
                    txtUpdateEircode.Text
                );

                updatedPassenger.updatePassenger(passengerID);

                Booking updatedBooking = new Booking(
                    Convert.ToInt32(lblUpdateBookingID.Text),
                    Convert.ToInt32(lblUpdatePassengerID.Text),
                    Convert.ToInt32(lblUpdateBookingRouteID.Text),
                    lblUpdateFlightNumber.Text,
                    cboDeptimeDetail.Text,
                    DateTime.Parse(dptUpdateBookingDate.Text),
                    Convert.ToInt32(lblSeatNumDetail.Text),
                    Convert.ToInt32(nudNumBaggage.Value),
                    Convert.ToDecimal(lbFlightBookingPriceDetail.Text),
                    "CONFIRMED"
                );

                updatedBooking.updateBooking();

                MessageBox.Show("Booking and passenger details have been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Booking details have been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ifRouteChange()
        {
            MessageBox.Show("Sorry, but the route cannot be changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ifDateChange()
        {
            DialogResult dateChange = MessageBox.Show("Sorry, but the date cannot be changed. Do you wish to book another flight?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dateChange == DialogResult.Yes)
            {
                frmCreateBooking frmCreateBooking = new frmCreateBooking();
                frmCreateBooking.Show();
                this.Hide();
            }
            else if (dateChange == DialogResult.No)
            {
                dptUpdateBookingDate.Value = originalFlightDate;
            }
        }
        private void ifTimeChange()
        {
            MessageBox.Show("Sorry, but the departure time cannot be changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void askToBookAnotherFlight()
        {
            DialogResult flightConfirm = MessageBox.Show("Do you wish to book another flight?", "Book Flight", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (flightConfirm == DialogResult.Yes)
            {
                frmCreateBooking frmCreateBooking = new frmCreateBooking();
                frmCreateBooking.Show();
                this.Hide();
            }
        }

        private void cboUpdateDeptAirportDetail_MouseClick(object sender, MouseEventArgs e)
        {
            ifRouteChange();
            askToBookAnotherFlight();
        }

        private void cboUpdateArrAirportDetail_MouseClick(object sender, MouseEventArgs e)
        {
            ifRouteChange();
            askToBookAnotherFlight();
        }

        private void dptUpdateBookingDate_ValueChanged(object sender, EventArgs e)
        {
            int bookingID = Convert.ToInt32(txtBookingID.Text);

            DataTable dt = Booking.findBookingDetails(bookingID);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                DateTime originalFlightDate = (DateTime)row["FlightDate"];
                DateTime newFlightDate = dptUpdateBookingDate.Value;

                if (newFlightDate != originalFlightDate)
                {
                    ifDateChange();
                }
            }

        }

        private void cboDeptimeDetail_MouseClick(object sender, MouseEventArgs e)
        {
            ifTimeChange();
            askToBookAnotherFlight();
        }
    }
}
