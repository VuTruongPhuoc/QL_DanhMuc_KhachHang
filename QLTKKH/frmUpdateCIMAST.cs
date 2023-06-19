using System;
using System.Windows.Forms;

namespace QLTKKH
{
    public partial class frmUpdateCIMAST : Form
    {
        cfmastservice.CFMASTWebService cfmastsv = new cfmastservice.CFMASTWebService();
        private DataGridView dgv;
        DataRead read = new DataRead();
        public frmUpdateCIMAST(DataGridView dgvCIMAST)
        {
            InitializeComponent();
            dgv = dgvCIMAST;
        }

        private void frmUpdateCIMAST_Load(object sender, EventArgs e)
        {
            txtAFACCTNO.Text = dgv.Rows[frmCIMAST.row].Cells[0].Value.ToString();
            txtACCTNO.Text = dgv.Rows[frmCIMAST.row].Cells[1].Value.ToString();
            txtBALANCE.Text = dgv.Rows[frmCIMAST.row].Cells[2].Value.ToString();
            txtCIDEPOFEEACR.Text = dgv.Rows[frmCIMAST.row].Cells[3].Value.ToString();
            txtDEPOFEEAMT.Text = dgv.Rows[frmCIMAST.row].Cells[4].Value.ToString();
            dtpLASTCHANGE.Text = dgv.Rows[frmCIMAST.row].Cells[5].Value.ToString();
            txtMONEY.Text = txtDEPOFEEAMT.Text;
        }

        private void btnBoSung_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thực hiện nộp tiền không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            string afacctno = txtAFACCTNO.Text.ToString().Trim();
            string acctno = txtACCTNO.Text.ToString().Trim();
            long money = long.Parse(txtMONEY.Text.ToString().Trim());
            long depofeeamt = long.Parse(txtDEPOFEEAMT.Text.ToString().Trim());
            DateTime lastchange = DateTime.Now;
            cfmastsv.SuaThemTienCIMAST(afacctno, acctno, money, depofeeamt, lastchange);
            dgv.DataSource = read.Reader("CIMAST");
            txtBALANCE.Text = dgv.Rows[frmCIMAST.row].Cells[2].Value.ToString();
            MessageBox.Show("Thành công.", "Thông báo");
        }

        private void btnTruTien_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thực hiện thu tiền không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            if (long.Parse(txtBALANCE.Text.ToString()) < long.Parse(txtDEPOFEEAMT.Text.ToString()) || long.Parse(txtMONEY.Text.ToString().Trim()) > long.Parse(txtBALANCE.Text.ToString().Trim()))
            {
                MessageBox.Show("Không đủ tiền để thu!", "Thông báo");
                return;
            }
            string afacctno = txtAFACCTNO.Text.ToString().Trim();
            string acctno = txtACCTNO.Text.ToString().Trim();
            long money = long.Parse(txtMONEY.Text.ToString().Trim());
            long depofeeamt = long.Parse(txtDEPOFEEAMT.Text.ToString().Trim());
            DateTime lastchange = DateTime.Now;
            cfmastsv.SuaTruTienCIMAST(afacctno, acctno, money, depofeeamt, lastchange);
            dgv.DataSource = read.Reader("CIMAST");
            txtBALANCE.Text = dgv.Rows[frmCIMAST.row].Cells[2].Value.ToString();
            txtDEPOFEEAMT.Text = dgv.Rows[frmCIMAST.row].Cells[4].Value.ToString();
            MessageBox.Show("Thành công", "Thông báo");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
