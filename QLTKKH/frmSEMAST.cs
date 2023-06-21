using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTKKH
{
    public partial class frmSEMAST : Form
    {
        public static string str = "Thêm mới tài sản chứng khoán.";
        webservice.WebService1 websv = new webservice.WebService1 ();
        semastservice._SEMASTWebService semastsv = new semastservice._SEMASTWebService ();
        cfmastservice.CFMASTWebService cfmastsv = new cfmastservice.CFMASTWebService ();
        DataRead read = new DataRead ();
        public static int row = 0;
        public frmSEMAST()
        {
            InitializeComponent();
        }

        private void frmSEMAST_Load(object sender, EventArgs e)
        {
            loaddgv();
        }
        public void loaddgv()
        {
            DataTable dt = read.Reader("SEMAST");
            dgvSEMAST.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            str = "Thêm mới tài sản chứng khoán.";
            frmUpdateSEMAST frm = new frmUpdateSEMAST(dgvSEMAST);
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            str = "Sửa tài sản chứng khoán.";
            row = dgvSEMAST.CurrentCell.RowIndex;
            frmUpdateSEMAST frm = new frmUpdateSEMAST(dgvSEMAST);
            frm.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string acctno = dgvSEMAST.CurrentRow.Cells[1].Value.ToString();
            semastsv.XoaSEMAST(acctno);
            MessageBox.Show("Xoá thành công", "Thông báo");
            loaddgv();
            cfmastsv.SucMua();
        }

        private void btnSECURITIES_INFO_Click(object sender, EventArgs e)
        {
            frmSECURITIES_INFO frm = new frmSECURITIES_INFO();
            frm.Show();
        }
    }
}
