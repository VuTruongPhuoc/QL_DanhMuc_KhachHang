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
    public partial class frmUpdateSECURITIES_INFO : Form
    {
        securities_infoservice._SECURITIES_INFOWebService securities_infosv = new securities_infoservice._SECURITIES_INFOWebService();
        DataRead read = new DataRead();
        DataGridView dgv;
        public frmUpdateSECURITIES_INFO(DataGridView dgvSECURITIES_INFO)
        {
            InitializeComponent();
            dgv = dgvSECURITIES_INFO;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtCODEID.TextLength == 0 || txtSYMBOL.TextLength == 0 || txtFLOORPRICE.TextLength == 0 || txtCELINGPRICE.TextLength == 0
                || txtBASICPRICE.TextLength == 0 || txtMRRATIORATE.TextLength == 0 || txtCOMPANY.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
                return;
            }
            string codeid = txtCODEID.Text.ToString().Trim();
            string symbol = txtSYMBOL.Text.ToString().Trim();
            long floorprice = long.Parse(txtFLOORPRICE.Text.ToString().Trim());
            long celingprice = long.Parse(txtCELINGPRICE.Text.ToString().Trim());
            long basicprice = long.Parse(txtBASICPRICE.Text.ToString().Trim());
            Double mrratiorate = Double.Parse(txtMRRATIORATE.Text.ToString().Trim());
            string company = txtCOMPANY.Text.ToString().Trim();

            securities_infosv.ThemSECURITIES_INFO(codeid, symbol, floorprice, celingprice, basicprice, mrratiorate, company);
            MessageBox.Show("Thêm thành công.");
            dgv.DataSource = read.Reader("SECURITIES_INFO");
        }

        private void btnCODEID_Click(object sender, EventArgs e)
        {
            DataTable dt = read.Reader("SECURITIES_INFO");
            int k;
            if(dt == null)
            {
                txtCODEID.Text = "000001";
            }
            else
            {
                //string a = securities_infosv.TinhMaMax("CODEID", "SECURITIES_INFO");
                //k = int.Parse(a.Substring(a.Length - 6));
                k = dt.Rows.Count;
                k++;
                txtCODEID.Text = k.ToString("D6");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
