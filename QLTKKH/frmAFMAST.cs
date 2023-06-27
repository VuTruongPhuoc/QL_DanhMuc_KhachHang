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
        public static int row;
        webservice.WebService1 websv = new webservice.WebService1();
        afmastservice._AFMASTWebService afmastsv = new afmastservice._AFMASTWebService();
        cfmastservice.CFMASTWebService cfmast = new cfmastservice.CFMASTWebService();
        DataRead read = new DataRead();
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
            DataTable dt = read.Reader("AFMAST");
            dgvAFMAST.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            str = "Thêm mới tiểu khoản.";
            frmUpdateAFMAST frm = new frmUpdateAFMAST(dgvAFMAST);
            frm.Show();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            str = "Sửa tiểu khoản.";
            row = dgvAFMAST.CurrentCell.RowIndex;
            frmUpdateAFMAST frm = new frmUpdateAFMAST(dgvAFMAST);
            frm.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string custid = dgvAFMAST.CurrentRow.Cells[0].Value.ToString();
            string acctno = dgvAFMAST.CurrentRow.Cells[1].Value.ToString();
            afmastsv.XoaAFMAST(custid,acctno);
            MessageBox.Show("Xoá thành công", "Thông báo");
            loadgdv();
            cfmast.SucMua();
        }

        private void dgvAFMAST_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dgvAFMAST.CurrentCell.RowIndex;
            frmSECURITIES_Account frm = new frmSECURITIES_Account(dgvAFMAST);
            frm.Show();
        }

        private void btnDatLenh_Click(object sender, EventArgs e)
        {
            row = dgvAFMAST.CurrentCell.RowIndex;
            frmSetCommand frm = new frmSetCommand(dgvAFMAST);
            frm.Show();
        }
    }
}
