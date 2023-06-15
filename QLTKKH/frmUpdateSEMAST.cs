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
    public partial class frmUpdateSEMAST : Form
    {
        webservice.WebService1 websv = new webservice.WebService1 ();
        semastservice._SEMASTWebService semastsv = new semastservice._SEMASTWebService ();
        private DataGridView dgv;
        DataRead read = new DataRead ();
        Commonfunction comm = new Commonfunction ();
        public frmUpdateSEMAST(DataGridView dgvSEMAST)
        {
            InitializeComponent();
            dgv = dgvSEMAST;
        }

        private void frmUpdateSEMAST_Load(object sender, EventArgs e)
        {
            lbTaiSanCK.Text = frmSEMAST.str.ToString().Trim();
            DataTable dt = read.Reader("CFMAST");
            comm.FillCombo(dt, cboCUSTID, "FULLNAME", "CUSTID");
            DataTable dt1 = read.Reader("AFMAST WHERE CUSTID = '" + cboCUSTID.SelectedValue.ToString().Trim() + "'");
            comm.FillCombo(dt1, cboAFACCTNO, "ACCTNO", "ACCTNO");
            DataTable dt2 = read.Reader("SECURITIES_INFO");
            comm.FillCombo(dt2, cboCODEID, "SYMBOL", "CODEID");
            dtpOPNDATE.Value = DateTime.Now;
            txtACCTNO.Text = "001E.00001F";
            if (lbTaiSanCK.Text == "Sửa tài sản chứng khoán.")
            {
                cboCUSTID.SelectedItem = dgv.Rows[frmSEMAST.row].Cells[0].Value.ToString().Trim();
                cboAFACCTNO.SelectedItem = dgv.Rows[frmSEMAST.row].Cells[1].Value.ToString().Trim();
                txtACCTNO.Text = dgv.Rows[frmSEMAST.row].Cells[2].Value.ToString().Trim();
                btnACCTNO.Enabled = false;
                cboCODEID.SelectedItem = dgv.Rows[frmSEMAST.row].Cells[3].Value.ToString().Trim();
                txtTOTALBUYAMT.Text = dgv.Rows[frmSEMAST.row].Cells[4].Value.ToString().Trim();
                dtpOPNDATE.Text = dgv.Rows[frmSEMAST.row].Cells[5].Value.ToString().Trim();
                dtpCLSDATE.Text = dgv.Rows[frmSEMAST.row].Cells[6].Value.ToString().Trim();
                dtpLASTDATE.Text = dgv.Rows[frmSEMAST.row].Cells[7].Value.ToString().Trim();
            }    
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtACCTNO.TextLength == 11 || txtTOTALBUYAMT.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
                return;
            }    
            string custid = cboCUSTID.SelectedValue.ToString().Trim();
            string afacctno = cboAFACCTNO.Text.ToString().Trim();
            string acctno = txtACCTNO.Text.ToString().Trim();
            string codeid = cboCODEID.SelectedValue.ToString().Trim();
            int totalbuyamt = int.Parse(txtTOTALBUYAMT.Text.ToString().Trim());
            DateTime opndate = dtpOPNDATE.Value;
            DateTime clsdate = dtpCLSDATE.Value;
            DateTime lastdate = dtpLASTDATE.Value;
            if (lbTaiSanCK.Text == "Sửa tài sản chứng khoán.")
            {
                semastsv.SuaSEMAST(custid, afacctno, acctno, codeid, totalbuyamt, opndate, clsdate, lastdate);
                MessageBox.Show("Sửa thành công", "Thông báo");
                return;
            }
            semastsv.ThemSEMAST(custid, afacctno, acctno, codeid, totalbuyamt, opndate, clsdate, lastdate);
            MessageBox.Show("Thêm thành công", "Thông báo");
        }

        private void cboCUSTID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = read.Reader("AFMAST WHERE CUSTID = '" + cboCUSTID.SelectedValue.ToString().Trim() + "'");
            comm.FillCombo(dt1, cboAFACCTNO, "ACCTNO", "ACCTNO");
        }

        private void btnACCTNO_Click(object sender, EventArgs e)
        {
            string xmlData1 = websv.DataReader("SELECT * FROM SEMAST");
            DataSet dt1 = new DataSet();
            dt1.ReadXml(new StringReader(xmlData1));

            if (dt1.Tables.Count <= 0)
            {
                txtACCTNO.Text = "001E.00001F.000001";
            }
            else
            {
                DataTable data1 = dt1.Tables[0];
                int k = Convert.ToInt32(data1.Rows.Count.ToString().Trim());
                k++;
                txtACCTNO.Text = "001E.00001F." + k.ToString("D6");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
