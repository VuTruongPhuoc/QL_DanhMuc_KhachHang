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
    public partial class frmUpdateCIMAST : Form
    {
        cfmastservice.CFMASTWebService cfmastsv = new cfmastservice.CFMASTWebService();
        private DataGridView dgv;
        public frmUpdateCIMAST(DataGridView dgvCIMAST)
        {
            InitializeComponent();
            dgv = dgvCIMAST;
        }

        private void frmUpdateCIMAST_Load(object sender, EventArgs e)
        {
            txtAFACCTNO.Text = dgv.Rows[frmCIMAST.dem].Cells[0].Value.ToString();
            txtACCTNO.Text = dgv.Rows[frmCIMAST.dem].Cells[1].Value.ToString();
            txtBALANCE.Text = dgv.Rows[frmCIMAST.dem].Cells[2].Value.ToString();
            dtpLASTCHANGE.Text = dgv.Rows[frmCIMAST.dem].Cells[3].Value.ToString();
        }

        private void btnBoSung_Click(object sender, EventArgs e)
        {
            string afacctno = txtAFACCTNO.Text.ToString().Trim();
            string acctno = txtACCTNO.Text.ToString().Trim();
            int money = Int32.Parse(txtMONEY.Text.ToString().Trim());
            DateTime lastchange = DateTime.Now;
            cfmastsv.SuaThemTienCIMAST(afacctno, acctno, money, lastchange);
            MessageBox.Show("Bổ sung thành công", "Thông báo");
        }

        private void btnTruTien_Click(object sender, EventArgs e)
        {
            string afacctno = txtAFACCTNO.Text.ToString().Trim();
            string acctno = txtACCTNO.Text.ToString().Trim();
            int money = Int32.Parse(txtMONEY.Text.ToString().Trim());
            DateTime lastchange = DateTime.Now;
            cfmastsv.SuaTruTienCIMAST(afacctno, acctno, money, lastchange);
            MessageBox.Show("Trừ tiền thành công", "Thông báo");
            dgv.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
