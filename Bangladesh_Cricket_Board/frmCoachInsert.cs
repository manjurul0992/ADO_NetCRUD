using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bangladesh_Cricket_Board
{
    public partial class frmCoachInsert : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=BCB;Trusted_Connection=True;");
        public frmCoachInsert()
        {
            InitializeComponent();
        }

        private void frmCoachInsert_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT id,name FROM MatchFormat";

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbMatchFormat.DataSource = ds.Tables[0];
            cmbMatchFormat.DisplayMember = "name";
            cmbMatchFormat.ValueMember = "id";
            con.Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPicture.Text = openFileDialog1.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPicture.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);


            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO coachs(coachName,coachContact,coachEmail,coachSalary,picture,MatchFormatId,dateOfBirth,gender) VALUES(@n,@c,@e,@s,@p,@m,@d,@g)";
            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@c", txtContact.Text);
            cmd.Parameters.AddWithValue("@e", txtEmail.Text);
            cmd.Parameters.AddWithValue("@s", txtSalary.Text);
            cmd.Parameters.AddWithValue("@d", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@g", chkGender.Checked.ToString());
            cmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarBinary) { Value = ms.ToArray() });

            cmd.Parameters.AddWithValue("@m", cmbMatchFormat.SelectedValue);
            cmd.ExecuteNonQuery();
            //cmd.BeginExecuteNonQuery();
            lblMsg.Text = "Data Inserted successfully!!!";
            con.Close();
        }
    }
}


