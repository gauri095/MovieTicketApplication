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
    public partial class ContactUs : Form
    {
        public ContactUs()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string i = "insert into tblContact(Name,Email,Message) values('" + txtName.Text + "','" + txtMail.Text + "','" + txtMsg.Text + "')";
            SqlCommand cmd = new SqlCommand(i, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thank you for Contacting Us");
            con.Close();
        }
    }
}
