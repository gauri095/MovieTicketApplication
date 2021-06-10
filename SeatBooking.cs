using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace MovieTicketApplication
{
    public partial class SeatBooking : Form
    {
        public SeatBooking()
        {
            InitializeComponent();
        }
        public static string amount;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string result = "Please Enter ";
            if (cbCities.SelectedIndex == -1)
            {
                result += "a City";
            }
            if (cbCinema.SelectedIndex == -1)
            {
                result += "theatre Name";
            }
            if (txtMovie.Text == string.Empty)
            {
                result += "Movie Name";
            }
            if (dtpDate.Text == string.Empty)
            {
                result += "Date";
            }
            if (txtShowTiming.Text == string.Empty)
            {
                result += "Show Timing";
            }
            if (cbClass.SelectedIndex == -1)
            {
                result += "Class Type";
            }
            if (txtNo_of_Ticket.Text == string.Empty)
            {
                result += "Number of Ticket";
            }
            else
            {
                if (result.Contains(','))
                {
                    result = result.Remove(result.LastIndexOf(','));
                }
            }
            if (result != "Please Enter ")
            {
                MessageBox.Show(result);
            }
            else
            {
                con.Open();
                string insert = "insert into SeatBooking(City,Cinema,Movie,Date,ShowTiming,Class,No_of_Ticket,Amount) values('" + cbCities.Text.ToString() + "','" + cbCinema.Text.ToString() + "','" + txtMovie.Text + "','" + dtpDate.Text + "','" + txtShowTiming.Text + "','" + cbClass.Text.ToString() + "','" + Convert.ToInt32(txtNo_of_Ticket.Text) + "','" + Convert.ToInt32(txtAmount.Text) + "')";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your seat is book successfully");
                con.Close();
                Payment p = new Payment();
                p.Show();
            }
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClass.SelectedIndex == 0)
            {
                lblPrice.Text = "100";
            }
            if (cbClass.SelectedIndex == 1)
            {
                lblPrice.Text = "150";
            }
            if (cbClass.SelectedIndex == 2)
            {
                lblPrice.Text = "200";
            }
        }

        private void txtNo_of_Ticket_Leave(object sender, EventArgs e)
        {
            txtAmount.Text = Convert.ToString(Convert.ToInt32(lblPrice.Text) * Convert.ToInt32(txtNo_of_Ticket.Text));
            amount = txtAmount.Text;
        }

        private void SeatBooking_Load(object sender, EventArgs e)
        {
            txtMovie.Text = MovieList.movieName;
            txtShowTiming.Text = MovieTiming.seatTime;
        }
    }
}
