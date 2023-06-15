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
using System.Xml.Linq;

namespace QLTKKH
{
    public partial class frmUpdateCFMAST : Form
    {
        webservice.WebService1 websv = new webservice.WebService1();
        cfmastservice.CFMASTWebService cfmastsv = new cfmastservice.CFMASTWebService();
        DataRead read = new DataRead();
        DataGridView dgv;
        public frmUpdateCFMAST(DataGridView dgvCustomer)
        {
            InitializeComponent();
            dgv = dgvCustomer;
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            Commonfunction comm = new Commonfunction();
            DataTable dt = read.Reader("ALLCODE");
            comm.FillCombo(dt,cboIDTYPE,"CDCONTENT", "CDVAL");
           

            string xmlData1 = websv.DataReader("SELECT * FROM CFMAST");
            DataSet dt1 = new DataSet();
            dt1.ReadXml(new StringReader(xmlData1));
           
            if (dt1.Tables.Count <= 0)
            {
                txtCUSTID.Text = "00000001";
            }
            else
            {
                DataTable data1 = dt1.Tables[0];
                int k = Convert.ToInt32(data1.Rows.Count.ToString().Trim());
                k++;
                txtCUSTID.Text = k.ToString("D8");
            }
            txtCUSTOYOCD.Text = "001C";
            txtCUSTID.ReadOnly = true;
            if (frmCFMAST.str.Trim() == "Sửa khách hàng.")
            {
                lbKhachHang.Text = frmCFMAST.str.Trim();
                txtCUSTID.Text = dgv.Rows[frmCFMAST.row].Cells[0].Value.ToString();
                txtFULLNAME.Text = dgv.Rows[frmCFMAST.row].Cells[1].Value.ToString();
                string luuky = dgv.Rows[frmCFMAST.row].Cells[2].Value.ToString();
                txtCUSTOYOCD.Text = luuky.Substring(0, 10);
                txtCUSTOYOCD.ReadOnly = true;
                cboIDTYPE.SelectedItem = dgv.Rows[frmCFMAST.row].Cells[3].Value.ToString();
                txtIDCODE.Text = dgv.Rows[frmCFMAST.row].Cells[4].Value.ToString();
                dtpIDDATE.Text = dgv.Rows[frmCFMAST.row].Cells[5].Value.ToString();
                txtADDRESS.Text = dgv.Rows[frmCFMAST.row].Cells[6].Value.ToString();
                txtPHONE.Text = dgv.Rows[frmCFMAST.row].Cells[7].Value.ToString();
                txtMOBILE.Text = dgv.Rows[frmCFMAST.row].Cells[8].Value.ToString();
                txtEMAIL.Text = dgv.Rows[frmCFMAST.row].Cells[9].Value.ToString();
                btnSoLuuKy.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCUSTID.TextLength == 0 || txtFULLNAME.TextLength == 0 || txtCUSTOYOCD.TextLength == 4 || txtIDCODE.TextLength == 0
                || txtADDRESS.TextLength == 0 || txtPHONE.TextLength == 0 || txtMOBILE.TextLength == 0 || txtEMAIL.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
                return;
            }
            string makh = txtCUSTID.Text.Trim();
            string ten = txtFULLNAME.Text.Trim();
            string soluuky = txtCUSTOYOCD.Text.Trim();
            string loaigiay = cboIDTYPE.SelectedValue.ToString().Trim();
            string sogiay = txtIDCODE.Text.Trim();
            dtpIDDATE.Format = DateTimePickerFormat.Custom;
            dtpIDDATE.CustomFormat = "yyyy-MM-dd";
            DateTime ngaycap = dtpIDDATE.Value;
            string diachi = txtADDRESS.Text.Trim();
            string dienthoai = txtPHONE.Text.Trim();
            string somobile = txtMOBILE.Text.Trim();
            string email = txtEMAIL.Text.Trim();
            if (frmCFMAST.str.Trim() == "Sửa khách hàng.")
            {
                cfmastsv.SuaCFMAST(makh, ten, soluuky, loaigiay, sogiay, ngaycap, diachi, dienthoai, somobile, email);

                MessageBox.Show("Sửa thành công.", "Thông báo");
                return;
            }
            cfmastsv.ThemCFMAST(makh, ten, soluuky, loaigiay, sogiay, ngaycap, diachi, dienthoai, somobile, email);
            MessageBox.Show("Thêm thành công.", "Thông báo");
        }

        private void btnSoLuuKy_Click(object sender, EventArgs e)
        {
            try
            {
                string xmlData = websv.DataReader("SELECT * FROM CFMAST");
                DataSet dt = new DataSet();
                dt.ReadXml(new StringReader(xmlData));
                DataTable data = dt.Tables[0];
                int k = Convert.ToInt32(data.Rows.Count.ToString());
                k++;
                txtCUSTOYOCD.Text = "001C" + k.ToString("D6");
            }
            catch
            {

            }
           
        }
    }
}
