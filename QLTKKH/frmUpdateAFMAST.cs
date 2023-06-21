using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace QLTKKH
{
    public partial class frmUpdateAFMAST : Form
    {
        webservice.WebService1 websv = new webservice.WebService1();
        afmastservice._AFMASTWebService afmastsv = new afmastservice._AFMASTWebService();
        cfmastservice.CFMASTWebService cfmast  = new cfmastservice.CFMASTWebService();
        DataRead read = new DataRead();
        private DataGridView dgv;
        public frmUpdateAFMAST(DataGridView dgvAFMAST)
        {
            InitializeComponent();
            dgv = dgvAFMAST;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cboCUSTID.SelectedIndex == -1 || txtACCTNO.TextLength == 4 || txtMARTYPE.TextLength == 0 || txtMRCRLIMITMAX.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
                return;
            }
            string custid = cboCUSTID.SelectedValue.ToString();
            string acctno = txtACCTNO.Text.ToString();
            string martype = txtMARTYPE.Text.ToString();
            long mrcrlimitmax = long.Parse(txtMRCRLIMITMAX.Text.ToString());
            string afacctno = acctno;
            long cidepofeeacr = 0;
            long depofeeamt = 0;
            long currentdebt = 0;
            long balance = 130000000;
            DateTime lastchange = DateTime.Now;

            if (frmAFMAST.str.Trim() == "Sửa tiểu khoản.")
            {
                afmastsv.SuaAFMAST(custid, acctno, martype, mrcrlimitmax);

                MessageBox.Show("Sửa thành công", "Thông báo");
                dgv.DataSource = read.Reader("AFMAST");
                cfmast.SucMua();
                return;
            }
            afmastsv.ThemAFMAST(custid, acctno, martype, mrcrlimitmax, afacctno, balance, cidepofeeacr, depofeeamt,currentdebt, lastchange);
            MessageBox.Show("Thêm thành công", "Thông báo");
            dgv.DataSource = read.Reader("AFMAST");
            cfmast.SucMua();
        }

        private void frmUpdateAFMAST_Load(object sender, EventArgs e)
        {
            Commonfunction comm = new Commonfunction();
            DataTable dt1 = read.Reader("CFMAST");
            comm.FillCombo(dt1, cboCUSTID, "FULLNAME", "CUSTID");

            string xmlData = websv.DataReader("SELECT * FROM AFMAST");
            DataSet dt = new DataSet();
            dt.ReadXml(new StringReader(xmlData));

            if (dt.Tables.Count <= 0)
            {
                txtACCTNO.Text = "0001000001";
            }
            else
            {
                DataTable data = dt.Tables[0];
                int k = Convert.ToInt32(data.Rows.Count.ToString().Trim());
                k++;
                txtACCTNO.Text = "0001" + k.ToString("D6");
            }
            if (frmAFMAST.str.Trim() == "Sửa tiểu khoản.")
            {
                lbTieuKhoan.Text = frmAFMAST.str.Trim();
                cboCUSTID.SelectedValue = dgv.Rows[frmAFMAST.row].Cells[0].Value.ToString();
                txtACCTNO.Text = dgv.Rows[frmAFMAST.row].Cells[1].Value.ToString();
                txtMARTYPE.Text = dgv.Rows[frmAFMAST.row].Cells[2].Value.ToString();
                txtMRCRLIMITMAX.Text = dgv.Rows[frmAFMAST.row].Cells[3].Value.ToString();
            }
            txtACCTNO.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
