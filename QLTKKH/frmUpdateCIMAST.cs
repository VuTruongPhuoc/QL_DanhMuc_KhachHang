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
            txtAFACCTNO.Text = dgv.Rows[frmCIMAST.row].Cells["AFACCTNO"].Value.ToString();
            txtCURRENTDEBT.Text = dgv.Rows[frmCIMAST.row].Cells["CURRENTDEBT"].Value.ToString();
            txtBALANCE.Text = dgv.Rows[frmCIMAST.row].Cells["BALANCE"].Value.ToString();
            txtCIDEPOFEEACR.Text = dgv.Rows[frmCIMAST.row].Cells["CIDEPOFEEACR"].Value.ToString();
            txtDEPOFEEAMT.Text = dgv.Rows[frmCIMAST.row].Cells["DEPOFEEAMT"].Value.ToString();
            dtpLASTCHANGE.Text = dgv.Rows[frmCIMAST.row].Cells["LASTCHANGE"].Value.ToString();
        }

        private void btnBoSung_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thực hiện nộp tiền không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            string afacctno = txtAFACCTNO.Text.ToString().Trim();
            double money = double.Parse(txtMONEY.Text.ToString().Trim());
            double depofeeamt = double.Parse(txtDEPOFEEAMT.Text.ToString().Trim());
            DateTime lastchange = DateTime.Now;
            cfmastsv.SuaThemTienCIMAST(afacctno, money, depofeeamt, lastchange);
            cfmastsv.SucMua();
            dgv.DataSource = read.Reader("CIMAST");
            txtBALANCE.Text = dgv.Rows[frmCIMAST.row].Cells["BALANCE"].Value.ToString();
            txtCURRENTDEBT.Text = dgv.Rows[frmCIMAST.row].Cells["CURRENTDEBT"].Value.ToString();
            MessageBox.Show("Thành công.", "Thông báo");
        }

        private void btnTruTien_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thực hiện thu tiền không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            if (double.Parse(txtBALANCE.Text.ToString()) < double.Parse(txtDEPOFEEAMT.Text.ToString()) || double.Parse(txtMONEY.Text.ToString().Trim()) > double.Parse(txtBALANCE.Text.ToString().Trim()))
            {
                MessageBox.Show("Không đủ tiền để thu!", "Thông báo");
                return;
            }
            string afacctno = txtAFACCTNO.Text.ToString().Trim();
            double money = double.Parse(txtMONEY.Text.ToString().Trim());
            double depofeeamt = double.Parse(txtDEPOFEEAMT.Text.ToString().Trim());
            DateTime lastchange = DateTime.Now;
            cfmastsv.SuaTruTienCIMAST(afacctno,money, depofeeamt, lastchange);
            cfmastsv.SucMua();
            dgv.DataSource = read.Reader("CIMAST");
            txtBALANCE.Text = dgv.Rows[frmCIMAST.row].Cells["BALANCE"].Value.ToString();
            txtDEPOFEEAMT.Text = dgv.Rows[frmCIMAST.row].Cells["DEPOFEEAMT"].Value.ToString();
            MessageBox.Show("Thành công", "Thông báo");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCURRENTDEBT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
