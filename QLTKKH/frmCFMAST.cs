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
        public static int row;
        public frmCFMAST()
        {
            InitializeComponent();
        }
        public void loadgdv()
        {
            string xmldata = websv.DataReader("select * from cfmast");
            DataSet dt = new DataSet();
            dt.ReadXml(new StringReader(xmldata));
            DataTable data = dt.Tables[0];
            dgvCustomer.DataSource = data;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadgdv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            str = "Thêm mới khách hàng.";
            frmUpdateCFMAST frm = new frmUpdateCFMAST(dgvCustomer);
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            str = "Sửa khách hàng.";
            row = dgvCustomer.CurrentCell.RowIndex;
            frmUpdateCFMAST frmAddCustomer = new frmUpdateCFMAST(dgvCustomer);
            frmAddCustomer.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string custid = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            cfmastsv.XoaCFMAST(custid);
            MessageBox.Show("Xoá thành công", "Thông báo");
            loadgdv();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            try
            {
                string xmlData = websv.DataReader("SELECT * FROM AFMAST");
                DataSet dt = new DataSet();
                dt.ReadXml(new StringReader(xmlData));
                string acctno;
                if (dt.Tables.Count <= 0)
                {
                    acctno = "001D000001";
                }
                else
                {
                    DataTable data = dt.Tables[0];
                    int k = Convert.ToInt32(data.Rows.Count.ToString().Trim());
                    k++;
                    acctno = "001D" + k.ToString("D6");
                }
                string custid = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
                string martype = "u".ToString();
                int mrcrlimitmax = 1000000000;
                string afacctno = acctno;
                int balance = 13000000;
                DateTime lastchange = DateTime.Now;
                cfmastsv.ReadProc(custid, acctno, martype, mrcrlimitmax, afacctno, balance, lastchange);
                MessageBox.Show("Thành công.", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Lỗi", "TB");
            }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadgdv();
        }
    }
}
