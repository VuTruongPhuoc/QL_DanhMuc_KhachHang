using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace QLTKKH
{
    public partial class frmAccount : Form
    {
        webservice.WebService1 websv = new webservice.WebService1 ();
        DataRead read = new DataRead();
        DataGridView dgv = new DataGridView ();
        public frmAccount(DataGridView dgvCFMAST)
        {
            InitializeComponent();
            dgv = dgvCFMAST;
        }
        public void loaddgv(string check)
        {
            DataTable dt = read.Reader("SE_ACCOUNT WHERE AFACCTNO = '"+check+"'");
            dgvSEAccount.DataSource = dt;           
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            DataTable dt = read.Reader("CustomerAccount where AFACCTNO = '" + dgv.Rows[frmAFMAST.row].Cells[1].Value.ToString() + "'");
            lbBALANCE.Text = dt.Rows[0][4].ToString();
            lbDEPOFEEAMT.Text = dt.Rows[0][5].ToString();
            lbPP.Text = dt.Rows[0][6].ToString();
            loaddgv(dt.Rows[0][1].ToString());
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            frmEnterAccount frm = new frmEnterAccount();
            frm.Show();
        }
    }
}
