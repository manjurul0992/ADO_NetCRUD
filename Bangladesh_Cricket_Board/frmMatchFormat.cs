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
using System.Xml.Linq;

namespace Bangladesh_Cricket_Board
{
    public partial class frmMatchFormat : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=BCB;Trusted_Connection=True;");
        public frmMatchFormat()
        {
            InitializeComponent();
        }

        private void frmMatchFormat_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM MatchFormat";

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO MatchFormat(name) VALUES('" + txtMTName.Text + "')", con);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Inserted Successfully!!";
            ClearAll();
            con.Close();
            LoadGrid();
        }
        private void ClearAll()
        {
            txtMTName.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE MatchFormat SET name='" + txtMTName.Text + "' WHERE id='"+txtId.Text+"'", con);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Updated Successfully!!";
            con.Close();
            ClearAll();
            LoadGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM MatchFormat WHERE id=" + txtId.Text + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtMTName.Text = dt.Rows[0][1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM MatchFormat WHERE id=" + txtId.Text + "", con);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Deleted Successfully!!";
            con.Close();
            ClearAll();
        }
    }
}
