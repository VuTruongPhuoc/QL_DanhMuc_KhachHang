using System;
using System.Data;
using System.Windows.Forms;

namespace QLTKKH
{
    public partial class frmSetCommand : Form
    {

        odmastservice._ODMASTWebService odmastsv = new odmastservice._ODMASTWebService();
        cfmastservice.CFMASTWebService cfmastsv = new cfmastservice.CFMASTWebService();
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
            txtQUOTEPRICE.Text = "0";
            AutoCompleteStringCollection mcollection = new AutoCompleteStringCollection();
            DataTable dt = read.Reader("SECURITIES_INFO");
            if (dt != null)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    mcollection.Add(dr["SYMBOL"].ToString());
                }
            txtSYMBOL.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSYMBOL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            txtSYMBOL.AutoCompleteCustomSource = mcollection;
            txtSYMBOL.Focus();

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
            if (txtSYMBOL.TextLength == 0 || txtORDERQTTY.TextLength == 0 || txtQUOTEPRICE.TextLength == 0 || long.Parse(txtORDERQTTY.Text.ToString()) == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !", "Thông báo");
                return;
            }
            string custid = dgv.Rows[frmAFMAST.row].Cells[0].Value.ToString();
            string afacctno = dgv.Rows[frmAFMAST.row].Cells[1].Value.ToString();
            string datenow = DateTime.Now.ToString("ddMMyy");
            string orderid = "0001" + datenow;
            DateTime lastchange = DateTime.Now;
            string exectype = "";
            if (grbLenhDat.Text == "MUA")
            {
                exectype = "NB";
                DataTable dt = read.Reader("CIMAST WHERE AFACCTNO = '" + txtAFACCTNO.Text.ToString().Trim() + "'");
                long pp = long.Parse(dt.Rows[0]["PP"].ToString().Trim());
                if (((100 - 0.1) / 100) * long.Parse(txtORDERQTTY.Text.ToString().Trim()) * long.Parse(txtQUOTEPRICE.Text.ToString().Trim()) > pp)
                {
                    MessageBox.Show("Bạn không đủ tiền để mua, Vui lòng thử lại!", "Thông báo");
                    return;
                }

            }
            else if (grbLenhDat.Text == "BÁN")
            {
                exectype = "NS";
                DataTable dt2 = read.Reader("SEMAST WHERE AFACCTNO = '" + txtAFACCTNO.Text.ToString() + "'");
                bool check = false;
                foreach (DataRow row in dt2.Rows)
                {
                    if (txtSYMBOL.Text.Trim().ToUpper() == row["SYMBOL"].ToString().Trim())
                    {
                        check = true;
                    }
                }
                if (check == false)
                {
                    MessageBox.Show("Bạn không có mã niêm yết này, Vui lòng thử lại!", "Thông báo");
                    return;
                }
                DataTable dt3 = read.Reader("SEMAST WHERE AFACCTNO = '" + txtAFACCTNO.Text.ToString().Trim() + "' AND SYMBOL = '" + txtSYMBOL.Text.ToString().Trim().ToUpper() + "'");
                long totalbuyamt = long.Parse(dt3.Rows[0]["TOTALBUYAMT"].ToString().Trim());
                DataTable dt4 = read.Reader("ODMAST WHERE AFACCTNO = '" + txtAFACCTNO.Text.ToString().Trim() + "' AND SYMBOL = '" + txtSYMBOL.Text.ToString().Trim().ToUpper() + "' AND EXECTYPE = 'NS'");
                if (dt4 != null)
                {
                    foreach (DataRow row in dt4.Rows)
                    {
                        totalbuyamt -= long.Parse(row["ORDERQTTY"].ToString().Trim());
                    }
                    if (long.Parse(txtORDERQTTY.Text.Trim()) > totalbuyamt)
                    {
                        MessageBox.Show("Bạn không đủ số lượng loại chứng khoán này , Vui lòng thử lại!", "Thông báo");
                        return;
                    }
                }
                else
                {
                    if (long.Parse(txtORDERQTTY.Text.Trim()) > totalbuyamt)
                    {
                        MessageBox.Show("Bạn không đủ số lượng loại chứng khoán này , Vui lòng thử lại!", "Thông báo");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại lệnh!", "Thông báo");
                return;
            }

            string symbol = txtSYMBOL.Text.ToString().Trim().ToUpper();
            DataTable dt1 = read.Reader("SECURITIES_INFO WHERE SYMBOL = '" + symbol + "'");
            DataRow dr = dt1.Rows[0];
            string codeid = dr["CODEID"].ToString();
            txtQUOTEPRICE.Text = dr["BASICPRICE"].ToString();
            long orderqtty = long.Parse(txtORDERQTTY.Text.ToString().Trim());
            long quoteprice = long.Parse(dr["BASICPRICE"].ToString().Trim());
            long execqtty = 0;
            long execamt = 0;
            long remainqtty = orderqtty - execqtty;
            long cancelqtty = 0;
            double bratio = 100.0 + 0.1;
            char edstatus = 'N';
            if (MessageBox.Show("Bạn có muốn đặt lệnh " + grbLenhDat.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                odmastsv.ThemODMAST(custid, afacctno, orderid, lastchange, exectype, codeid, symbol, orderqtty, quoteprice, execqtty, execamt, remainqtty, cancelqtty, bratio, edstatus);
                cfmastsv.SucMua();
                MessageBox.Show("Thành công.");
            }
        }

        private void btnLenh_Click(object sender, EventArgs e)
        {
            frmODMAST frm = new frmODMAST();
            frm.Show();
        }

        private void txtSYMBOL_TextChanged(object sender, EventArgs e)
        {
            string symbol = txtSYMBOL.Text.ToString().Trim().ToUpper();
            DataTable dt1 = read.Reader("SECURITIES_INFO WHERE SYMBOL = '" + symbol + "'");
            if (dt1 != null)
            {
                DataRow dr = dt1.Rows[0];
                txtQUOTEPRICE.Text = dr["BASICPRICE"].ToString();
            }

        }
    }
}
