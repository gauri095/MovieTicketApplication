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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);
        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            string s = "select * from tblLogin where Username='" + txtusrname.Text + "' and Password='" + txtpwd.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblLogin");
            if(ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Login Successful");
                MovieList m1 = new MovieList();
                m1.Show();
            }
            else
            {
                MessageBox.Show("Please check credentials", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtusrname.Clear();
            txtpwd.Clear();
        }
    }
}
