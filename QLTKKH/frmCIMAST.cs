using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTKKH
{
    public partial class frmCIMAST : Form
    {
        public static int row = 0;
        webservice.WebService1 websv = new webservice.WebService1 ();
        DataRead read = new DataRead ();
        public frmCIMAST()
        {
            InitializeComponent();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            row = dgvCIMAST.CurrentCell.RowIndex;
            frmUpdateCIMAST frm = new frmUpdateCIMAST(dgvCIMAST);
            frm.Show();
        }
        public void loadgdv()
        {
            DataTable dt = read.Reader("CIMAST");
            dgvCIMAST.DataSource = dt;

        }

        private void frmCIMAST_Load(object sender, EventArgs e)
        {
            loadgdv();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadgdv ();
        }
    }
}
