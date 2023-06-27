using QLTKKH.odmastservice;
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
    public partial class frmSetCommand : Form
    {
        odmastservice._ODMASTWebService odmastsv = new odmastservice._ODMASTWebService();
        DataRead read = new DataRead();
        DataGridView dgv = new DataGridView();
        public frmSetCommand(DataGridView dgvAFMAST)
        {
            InitializeComponent();
            dgv = dgvAFMAST;
        }
        private void frmSetCommand_Load(object sender, EventArgs e)
        {
            txtAFACCTNO.Text = dgv.Rows[frmAFMAST.row].Cells[1].Value.ToString();
            txtPRICE.Text = "0";
        }
        private void btnMua_Click(object sender, EventArgs e)
        {
            grbLenhDat.Text = "MUA";
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            grbLenhDat.Text = "BÁN";
        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            if(txtSYMBOL.TextLength == 0 || txtORDERQTTY.TextLength == 0 || txtPRICE.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "Thông báo");
            }   
            string afacctno = dgv.Rows[frmAFMAST.row].Cells[1].Value.ToString();
            string orderid = null;
            string datenow = DateTime.Now.ToString("ddMMyy");
            DataTable dt = read.Reader("ODMAST");
            int k;
            if (dt == null)
            {
                orderid = "0001" + datenow + "000001";
            }
            else
            {
                k = dt.Rows.Count;
                k++;
                orderid = "0001" + datenow + k.ToString("D6");
            }
            DateTime lastchange = DateTime.Now;
            string exectype = "";
            if (grbLenhDat.Text == "MUA")
            {
                exectype = "NB";
            }else if(grbLenhDat.Text == "BÁN")
            {
                exectype = "NS";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại lệnh!", "Thông báo");
                return;
            }
            
            string symbol = txtSYMBOL.Text.ToString().Trim().ToUpper();
            DataTable dt1 = read.Reader("SECURITIES_INFO WHERE SYMBOL = '"+symbol+"'");
            DataRow dr = dt1.Rows[0];
            string codeid = dr["CODEID"].ToString();
            long orderqtty = long.Parse(txtORDERQTTY.Text.ToString().Trim());
            long price = long.Parse(txtPRICE.Text.ToString().Trim());
            long execqtty = 0;
            long execamt = 0;
            long remainqtty = 0;
            long cancelqtty = 0;

            if (MessageBox.Show("Bạn có muốn đặt lệnh " + grbLenhDat.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                odmastsv.ThemODMAST(afacctno,orderid, lastchange, exectype,codeid, symbol, orderqtty, price, execqtty, execamt, remainqtty, cancelqtty);
                MessageBox.Show("Thành công.");
            }
            change();
        }

        private void btnLenh_Click(object sender, EventArgs e)
        {
            frmODMAST frm = new frmODMAST();
            frm.Show();
        }

        private void txtORDERQTTY_TextChanged(object sender, EventArgs e)
        {

            change();
        }
       

        private void txtSYMBOL_TextChanged(object sender, EventArgs e)
        {
            change();
        }
        public void change()
        {
            if (txtORDERQTTY.TextLength == 0)
            {
                txtPRICE.Text = "0";
                return;
            }

            string symbol = txtSYMBOL.Text.ToString().Trim().ToUpper();
            DataTable dt1 = read.Reader("SECURITIES_INFO WHERE SYMBOL = '" + symbol + "'");
            if (dt1 != null)
            {
                DataRow dr = dt1.Rows[0];
                long orderqtty = long.Parse(txtORDERQTTY.Text.ToString().Trim());
                txtPRICE.Text = (orderqtty * long.Parse(dr["BASICPRICE"].ToString())).ToString();
            }
            else
            {
                txtPRICE.Text = "0";
            }
        }

        
    }
}
