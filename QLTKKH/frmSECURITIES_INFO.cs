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
    public partial class frmSECURITIES_INFO : Form
    {
        securities_infoservice._SECURITIES_INFOWebService securities_infosv = new securities_infoservice._SECURITIES_INFOWebService();
        DataRead read = new DataRead();
        public frmSECURITIES_INFO()
        {
            InitializeComponent();
        }

        private void frmSECURITIES_INFO_Load(object sender, EventArgs e)
        {
            loaddgv();
        }
        public void loaddgv()
        {
            dgvSECURITIES_INFO.DataSource = read.Reader("SECURITIES_INFO");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmUpdateSECURITIES_INFO frm = new frmUpdateSECURITIES_INFO(dgvSECURITIES_INFO);
            frm.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string codeid = dgvSECURITIES_INFO.CurrentRow.Cells["CODEID"].Value.ToString().Trim();
            securities_infosv.XoaSECURITIES_INFO(codeid);
            loaddgv();
        }
    }
}
