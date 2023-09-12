using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bangladesh_Cricket_Board
{
    public partial class frmLogin : Form
    {
            SqlConnection con = new SqlConnection("Server=.;Database=BCB;Trusted_Connection=True;");
            public frmLogin()
            {
                InitializeComponent();
            }

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                frmRegistry fr = new frmRegistry();
                fr.Show();

            }

            private void btnLogin_Click(object sender, EventArgs e)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM users where userName='" + txtUserName.Text + "' and userPassword='" + txtPassword.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    frmHome fm = new frmHome();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or password!!!");
                }
                con.Close();
            }
    }
}
