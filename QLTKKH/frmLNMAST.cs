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
    public partial class frmLNMAST : Form
    {
        public static int row;
        DataRead read = new DataRead();
        public frmLNMAST()
        {
            InitializeComponent();
        }
        public void loaddgv()
        {
            DataTable dt = read.Reader("LNMAST");
            dgvLNMAST.DataSource = dt;
        }

        private void frmLNMAST_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void dgvLNMAST_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dgvLNMAST.CurrentCell.RowIndex;
            frmLNSCHD frm = new frmLNSCHD(dgvLNMAST);
            frm.Show();
        }
    }
}
