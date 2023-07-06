using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTKKH
{
    public partial class frmLNSCHD : Form
    {
        DataRead read = new DataRead();
        DataGridView dgv = new DataGridView();
        public frmLNSCHD( DataGridView dgvLNMAST)
        {   
            InitializeComponent();
            dgv = dgvLNMAST;
        }
        public void loaddgv()
        {
            DataTable dt = read.Reader("LNSCHD WHERE ACCTNO = '" + dgv.Rows[frmLNMAST.row].Cells["ACCTNO"].Value.ToString() + "'");
            dgvLNSCHD.DataSource = dt;
        }

        private void frmLNSCHD_Load(object sender, EventArgs e)
        {
            loaddgv();
        }
    }
}
