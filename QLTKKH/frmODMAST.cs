using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTKKH
{
    public partial class frmODMAST : Form
    {
        odmastservice._ODMASTWebService odmastsv = new odmastservice._ODMASTWebService();
        DataRead read = new DataRead();
        public frmODMAST()
        {
            InitializeComponent();
        }
        public void loaddgv()
        {
            DataTable dt = read.Reader("ODMAST");
            
            dgvODMAST.DataSource = dt;
        }

        private void frmODMAST_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column = dgvODMAST.Columns["LAST_CHANGE"];
            column.DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvODMAST.Columns["AFACCTNO"].Visible = false;
            dgvODMAST.Columns["CODEID"].Visible = false;
            loaddgv();
        }

        private void dgvODMAST_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvODMAST.Columns[e.ColumnIndex].Name == "EXECTYPE")
            {
                if (e.Value != null && e.Value.ToString() == "NB")
                {
                    e.Value = "MUA";
                    e.FormattingApplied = true;
                }else if(e.Value != null && e.Value.ToString() == "NS")
                {
                    e.Value = "BÁN";
                    e.FormattingApplied = true;
                }
            }

        }

        private void btnHuyLenh_Click(object sender, EventArgs e)
        {
            string orderid = dgvODMAST.CurrentRow.Cells[1].Value.ToString();
            if (!(MessageBox.Show("Bạn có muốn huỷ lệnh không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                return;
            odmastsv.HuyODMAST(orderid);
            MessageBox.Show("Thành công", "Thông báo");
            loaddgv();
        }
    }
}
