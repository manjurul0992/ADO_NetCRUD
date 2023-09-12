using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bangladesh_Cricket_Board
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            frm.IsMdiContainer = true;
            //frm.MdiParent = this;

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMatchFormat fs = new frmMatchFormat();
            fs.Show();
            fs.IsMdiContainer = true;
            //fs.MdiParent = this;
        }
        private void coachInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoachInsert fte = new frmCoachInsert();
            fte.Show();
            fte.IsMdiContainer = true;
           
        }

        private void coachUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate_Delete fte = new frmUpdate_Delete();
            fte.Show();
            fte.IsMdiContainer = true;
    
        }

        private void coachListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcoachList ft = new frmcoachList();
            ft.Show();
            ft.IsMdiContainer = true;
   
        }

        private void coachSalaryInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoachSalaryReport fcsr = new frmCoachSalaryReport();
            fcsr.Show();
            //fcsr.MdiParent = this;
           fcsr.IsMdiContainer = true;
        }

        private void playerRunSalaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlayerRunSalaryReport fcsr = new frmPlayerRunSalaryReport();
            fcsr.Show();
            //fcsr.MdiParent = this;
            fcsr.IsMdiContainer = true;
        }
    }
}
