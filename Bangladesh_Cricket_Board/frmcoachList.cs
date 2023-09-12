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
    public partial class frmcoachList : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=BCB;Trusted_Connection=True;");
        public frmcoachList()
        {
            InitializeComponent();
        }

        private void frmcoachList_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT c.coachId,c.coachName,c.coachContact,c.coachContact,c.picture,m.name FROM coachs c INNER JOIN MatchFormat m ON c.MatchFormatId=m.id", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
