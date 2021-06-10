using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketApplication
{
    public partial class MovieTiming : Form
    {
        public MovieTiming()
        {
            InitializeComponent();
        }
        public static string seatTime;
        private void btnTime1_Click(object sender, EventArgs e)
        {
            seatTime = "9:30 AM";
            SeatBooking sb = new SeatBooking();
            sb.Show();
        }

        private void btnTime2_Click(object sender, EventArgs e)
        {
            seatTime = "12:30 AM";
            SeatBooking sb = new SeatBooking();
            sb.Show();
        }

        private void btnTime3_Click(object sender, EventArgs e)
        {
            seatTime = "3:30 AM";
            SeatBooking sb = new SeatBooking();
            sb.Show();
        }

        private void btnTime4_Click(object sender, EventArgs e)
        {
            seatTime = "6:30 AM";
            SeatBooking sb = new SeatBooking();
            sb.Show();
        }

        private void btnTime5_Click(object sender, EventArgs e)
        {
            seatTime = "9:30 PM";
            SeatBooking sb = new SeatBooking();
            sb.Show();
        }
    }
}
