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
    public partial class frmCFMAST : Form
    {
        public static string str = "Thêm mới khách hàng.";
        webservice.WebService1 websv = new webservice.WebService1();
        cfmastservice.CFMASTWebService cfmastsv = new cfmastservice.CFMASTWebService();
        DataRead read = new DataRead();
        public static int row;
        public frmCFMAST()
        {
            InitializeComponent();
        }
        public void loadgdv()
        {
            DataTable dt = read.Reader("CFMAST");
            dgvCFMAST.DataSource= dt;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadgdv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            str = "Thêm mới khách hàng.";
            frmUpdateCFMAST frm = new frmUpdateCFMAST(dgvCFMAST);
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            str = "Sửa khách hàng.";
            row = dgvCFMAST.CurrentCell.RowIndex;
            frmUpdateCFMAST frmAddCustomer = new frmUpdateCFMAST(dgvCFMAST);
            frmAddCustomer.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string custid = dgvCFMAST.CurrentRow.Cells[0].Value.ToString();
            cfmastsv.XoaCFMAST(custid);
            MessageBox.Show("Xoá thành công", "Thông báo");
            loadgdv();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {

            string xmlData = websv.DataReader("SELECT * FROM CIMAST");
            DataSet dt = new DataSet();
            dt.ReadXml(new StringReader(xmlData));
            string acctno;
            if (dt.Tables.Count <= 0)
            {
                acctno = "001C000001";
            }
            else
            {
                DataTable data = dt.Tables[0];
                int k = Convert.ToInt32(data.Rows.Count.ToString().Trim());
                k++;
                acctno = "001C" + k.ToString("D6");
            }
            string xmlData1 = websv.DataReader("SELECT * FROM AFMAST");
            DataSet dt1 = new DataSet();
            dt1.ReadXml(new StringReader(xmlData1));
            string afacctno;
            if (dt1.Tables.Count <= 0)
            {
                afacctno = "001C000001";
            }
            else
            {
                DataTable data1 = dt1.Tables[0];
                int k = Convert.ToInt32(data1.Rows.Count.ToString().Trim());
                k++;
                afacctno = "001C" + k.ToString("D6");
            }
            string custid = dgvCFMAST.CurrentRow.Cells[0].Value.ToString();
            string martype = "O".ToString();
            long mrcrlimitmax = 1000000000;
            long cidepofeeacr = 0;
            long depofeeamt = 0;
            long balance = 130000000;
            DateTime lastchange = DateTime.Now;
            cfmastsv.DuyetCFMAST(custid, acctno, martype, mrcrlimitmax, afacctno, balance, cidepofeeacr, depofeeamt, lastchange);
            MessageBox.Show("Thành công.", "Thông báo");
            
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadgdv();
        }
    }
}
