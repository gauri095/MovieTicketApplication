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
using System.Text.RegularExpressions;

namespace MovieTicketApplication
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void allMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieList m1 = new MovieList();
            m1.Show();
        }

        private void termsConditionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TermsAndConditions tc = new TermsAndConditions();
            tc.Show();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactUs c = new ContactUs();
            c.Show();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string result = "Please Enter ";
            if (txtFname.Text == string.Empty)
            {
                result += "First Name, ";
            }
            if (txtLname.Text == string.Empty)
            {
                result += "Last Name, ";
            }
            if (txtMobNo.Text == string.Empty)
            {
                result += "Mobile Number, ";
            }
            if (txtEmail.Text == string.Empty)
            {
                result += "Email ID, ";
            }
            if (txtPwd.Text == string.Empty)
            {
                result += "Password, ";
            }
            if (txtConPwd.Text == string.Empty)
            {
                result += " Confirm Password, ";
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
                txtFname.Focus();
            }
            else
            {
                con.Open();
                string ins = "insert into tblRegistration(Fname,Lname, MobileNo, Email, Password) values('" + txtFname.Text + "','" + txtLname.Text + "','" + Convert.ToInt64(txtMobNo.Text) + "','" + txtEmail.Text + "','" + txtPwd.Text + "')";
                SqlCommand cmd = new SqlCommand(ins, con);
                cmd.ExecuteNonQuery();

                string ins1 = "insert into tblLogin(Username,Password) values('" + txtEmail.Text + "','" + txtPwd.Text + "')";
                SqlCommand cmd1 = new SqlCommand(ins1, con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Your data is inserted");
                con.Close();
            }
        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMobNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex rEmail = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9] [\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmail.Text.Length > 0)
            {
                if (!rEmail.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Please provide valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.SelectAll();
                }
            }
        }

        private void txtPwd_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(.{0,7}|[^0-9]*|[^A-Z])$");
            Match match = regex.Match(txtPwd.Text);
            if (!regex.IsMatch(txtPwd.Text))
            {
                MessageBox.Show("Please enter password in correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtConPwd_TextChanged(object sender, EventArgs e)
        {
            var pwd = txtConPwd.Text;
            if (pwd.Equals(txtPwd.Text))
            {
                MessageBox.Show("Password matched");
            }
            else
            {
                MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
