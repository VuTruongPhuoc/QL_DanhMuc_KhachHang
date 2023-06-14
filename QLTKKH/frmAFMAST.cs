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
    public partial class frmAFMAST : Form
    {
        public static string str = "Thêm mới tiểu khoản.";
        webservice.WebService1 websv = new webservice.WebService1();
        afmastservice._AFMASTWebService afmastsv = new afmastservice._AFMASTWebService();
        public frmAFMAST()
        {
            InitializeComponent();
        }
        private void frmAFMAST_Load(object sender, EventArgs e)
        {
            loadgdv();
        }
        public void loadgdv()
        {
            string xmlData = websv.DataReader("SELECT * FROM AFMAST");
            DataSet dt = new DataSet();
            dt.ReadXml(new StringReader(xmlData));
            DataTable data = null;
            if (dt != null && dt.Tables.Count > 0)
            {
                data = dt.Tables[0];
            }
            else
            {
                data = null;
            }
            dgvAFMAST.DataSource = data;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            str = "Thêm mới tiểu khoản.";
            frmUpdateAFMAST frm = new frmUpdateAFMAST();
            frm.Show();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            str = "Sửa tiểu khoản.";
            LuuThongTin.makh = dgvAFMAST.CurrentRow.Cells[0].Value.ToString();
            LuuThongTin.mahd = dgvAFMAST.CurrentRow.Cells[1].Value.ToString();
            LuuThongTin.chovaykhong = dgvAFMAST.CurrentRow.Cells[2].Value.ToString();
            LuuThongTin.hanmuc = int.Parse(dgvAFMAST.CurrentRow.Cells[3].Value.ToString());
            frmUpdateAFMAST frm = new frmUpdateAFMAST();
            frm.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string custid = dgvAFMAST.CurrentRow.Cells[0].Value.ToString();
            string acctno = dgvAFMAST.CurrentRow.Cells[1].Value.ToString();
            afmastsv.XoaAFMAST(custid,acctno);
            MessageBox.Show("Xoá thành công", "Thông báo");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadgdv();
        }
        public class LuuThongTin
        {
            static public string makh;
            static public string mahd;
            static public string chovaykhong;
            static public int hanmuc;
        }
    }
}
