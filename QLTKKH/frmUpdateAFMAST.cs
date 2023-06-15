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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLTKKH
{
    public partial class frmUpdateAFMAST : Form
    {
        webservice.WebService1 websv = new webservice.WebService1 ();
        afmastservice._AFMASTWebService afmastsv = new afmastservice._AFMASTWebService ();
        DataRead read = new DataRead ();
        private DataGridView dgv;
        public frmUpdateAFMAST(DataGridView dgvAFMAST)
        {
            InitializeComponent();
            dgv = dgvAFMAST;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string custid = cboCUSTID.SelectedValue.ToString();
            string acctno = txtACCTNO.Text.ToString();
            string martype = txtMARTYPE.Text.ToString();
            
            int mrcrlimitmax = Int32.Parse(txtMRCRLIMITMAX.Text.ToString());
            if (frmAFMAST.str.Trim() == "Sửa tiểu khoản.")
            {
                afmastsv.SuaAFMAST(custid, acctno, martype, mrcrlimitmax);

                MessageBox.Show("Sửa thành công", "Thông báo");
                return;
            }
            afmastsv.ThemAFMAST(custid, acctno, martype, mrcrlimitmax);
            MessageBox.Show("Thêm thành công", "Thông báo");
        }

        private void frmUpdateAFMAST_Load(object sender, EventArgs e)
        {
            Commonfunction comm = new Commonfunction();
            DataTable dt1= read.Reader("ALLCODE");
            comm.FillCombo(dt1, cboCUSTID, "FULLNAME", "CUSTID");

            string xmlData = websv.DataReader("SELECT * FROM AFMAST");
            DataSet dt = new DataSet();
            dt.ReadXml(new StringReader(xmlData));
            
            if (dt.Tables.Count <= 0)
            {
                txtACCTNO.Text = "001D000001";
            }
            else
            {
                DataTable data = dt.Tables[0];
                int k = Convert.ToInt32(data.Rows.Count.ToString().Trim());
                k++;
                txtACCTNO.Text = "001D" + k.ToString("D6");
            }
            if (frmAFMAST.str.Trim() == "Sửa tiểu khoản.")
            {
                lbTieuKhoan.Text = frmAFMAST.str.Trim();
                cboCUSTID.SelectedItem = dgv.Rows[frmAFMAST.row].Cells[0].Value.ToString();
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
