using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MovieTicketApplication
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            txtamt.Text = SeatBooking.amount;
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);
        public void valid()
        {
            string result = "Please Enter ";
            if (txtName.Text == string.Empty)
            {
                result += "Name,";
            }
            if (txtCreditNo.Text == string.Empty)
            {
                result += "Credit Number,";
            }
            if (txtCvvNo.Text == string.Empty)
            {
                result += "CVV Number,";
            }
            if (txtamt.Text == string.Empty)
            {
                result += "Amount,";
            }
            if (cbCardTyp.SelectedIndex == -1)
            {
                result += "Card Type";
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
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else
            {
                con.Open();
                string insert = "insert into Payment(CreditCardType,NameOnCC,CreditCardNo,ExpiryDate,CVV_No,Amount) values('" + cbCardTyp.Text.ToString() + "','" + txtName.Text + "','" + txtCreditNo.Text + "','" + dtpDate.Text.ToString() + "','" + txtCvvNo.Text + "','" + txtamt.Text + "')";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully");
                con.Close();
            }
        }
        private void btnTicket_Click(object sender, EventArgs e)
        {
            valid();
        }

        private void txtCreditNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only digit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only characters(A-Z or a-z)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtCvvNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only digit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only digit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
