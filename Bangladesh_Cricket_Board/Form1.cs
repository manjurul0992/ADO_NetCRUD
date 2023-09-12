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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=BCB;Trusted_Connection=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT id,name FROM MatchFormat";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            colMatchFormat.DataSource = ds.Tables[0];
            colMatchFormat.DisplayMember = "name";
            colMatchFormat.ValueMember = "id";
            con.Close();

        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlTransaction ts = con.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Transaction = ts;
                cmd.CommandText = "INSERT INTO players(name,run) VALUES(@name,@run) SELECT @@IDENTITY";
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@run", txtRun.Text);
                int id = Convert.ToInt32(cmd.ExecuteScalar());

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells["colMatchFormat"].Value != null && dataGridView1.Rows[i].Cells["colPrize"].Value != null)
                    {
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = con;
                        cmd2.Transaction = ts;
                        cmd2.CommandText = "INSERT INTO prize(playerId,MatchFormatId,prize) VALUES(@playerId,@MatchFormatId,@prize)";
                        cmd2.Parameters.AddWithValue("@playerId", id);
                        cmd2.Parameters.AddWithValue("@MatchFormatId", dataGridView1.Rows[i].Cells["colMatchFormat"].Value);
                        cmd2.Parameters.AddWithValue("@prize", dataGridView1.Rows[i].Cells["colPrize"].Value);
                        cmd2.ExecuteNonQuery();
                    }
                }
                ts.Commit();
                MessageBox.Show("Data Inserted successfully!!!");
            }
            catch (Exception ex)
            {
                ts.Rollback();
                MessageBox.Show(ex.Message + "\nData not saved!!!");
            }
            con.Close();

        }
    }
}

