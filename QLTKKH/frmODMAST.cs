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
        cfmastservice.CFMASTWebService cfmastsv = new cfmastservice.CFMASTWebService();
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
            string orderid = dgvODMAST.CurrentRow.Cells["ORDERID"].Value.ToString();
            if (!(MessageBox.Show("Bạn có muốn huỷ lệnh không? ", "Thông báo " + dgvODMAST.CurrentRow.Cells["CUSTID"].Value.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                return;
            odmastsv.HuyODMAST(orderid);
            cfmastsv.SucMua();
            MessageBox.Show("Thành công", "Thông báo");
            loaddgv();
        }

        private void dgvODMAST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(dgvODMAST.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (dgvODMAST.Columns[e.ColumnIndex].Name == "ORDERMATCH")
                {
                    string custid = dgvODMAST.CurrentRow.Cells["CUSTID"].Value.ToString();
                    string orderid = dgvODMAST.CurrentRow.Cells["ORDERID"].Value.ToString();
                    string exectype = dgvODMAST.CurrentRow.Cells["EXECTYPE"].Value.ToString();
                    string symbol = dgvODMAST.CurrentRow.Cells["SYMBOL"].Value.ToString(); ;
                    long orderqtty = long.Parse(dgvODMAST.CurrentRow.Cells["ORDERQTTY"].Value.ToString());
                    long quoteprice = long.Parse(dgvODMAST.CurrentRow.Cells["QUOTEPRICE"].Value.ToString());
                    long execqtty = long.Parse(dgvODMAST.CurrentRow.Cells["EXECQTTY"].Value.ToString());
                    long execamt = long.Parse(dgvODMAST.CurrentRow.Cells["EXECAMT"].Value.ToString());
                    long remainqtty = long.Parse(dgvODMAST.CurrentRow.Cells["REMAINQTTY"].Value.ToString());
                    odmastsv.Update_ODMAST(custid,orderid, exectype, symbol, orderqtty, quoteprice, execqtty, execamt, remainqtty);
                    loaddgv();
                }
            }    
             
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!(MessageBox.Show("Bạn có muốn thực hiện thanh toán không? ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                return;
            odmastsv.ThanhToan();
            cfmastsv.SucMua();
            MessageBox.Show("Thành công.", "Thông báo");
            loaddgv();
            
        }
    }
}
