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
        cfmastservice.CFMASTWebService cfmastsv = new cfmastservice.CFMASTWebService();
        lnmastservice._LNMASTWebService lnmastsv = new lnmastservice._LNMASTWebService();
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
            string custid = dgvAFMAST.CurrentRow.Cells["CUSTID"].Value.ToString();
            string acctno = dgvAFMAST.CurrentRow.Cells["ACCTNO"].Value.ToString();
            afmastsv.XoaAFMAST(custid,acctno);
            MessageBox.Show("Xoá thành công", "Thông báo");
            loadgdv();
            cfmastsv.SucMua();
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

        private void dgvAFMAST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAFMAST.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {       
                if (dgvAFMAST.Columns[e.ColumnIndex].Name == "btnThemLNMAST")
                {
                    if (dgvAFMAST.CurrentRow.Cells["MARTYPE"].Value.ToString() == "Y")
                    {
                        string acctno = dgvAFMAST.CurrentRow.Cells["ACCTNO"].Value.ToString();
                        long prinnml = 0;
                        long intdue = 0;
                        long intnmlacr = 0;
                        long rate1 = 10;
                        long rate2 = 12;
                        long rate3 = 14;
                        DateTime lastdate = DateTime.Now;
                        DateTime opndate = DateTime.Now;
                        DateTime rlsdate = DateTime.Now;

                        if(MessageBox.Show("Bạn có muốn thêm tài khoản nợ không ?","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            lnmastsv.ThemLNMAST(acctno,prinnml,intdue, intnmlacr,rate1,rate2,rate3,lastdate,opndate,rlsdate);
                            MessageBox.Show("Thành công", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không phải tài khoản Margin,Vui lòng thử lại!", "Thông báo");
                        return;
                    }
                }
            }
        }
    }
}
