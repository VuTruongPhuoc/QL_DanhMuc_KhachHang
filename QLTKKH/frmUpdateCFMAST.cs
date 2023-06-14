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
        public frmUpdateCFMAST()
        {
            InitializeComponent();
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            Commonfunction comm = new Commonfunction();
            string xmlData = websv.DataReader("SELECT * FROM ALLCODE");
            DataSet dt = new DataSet();
            dt.ReadXml(new StringReader(xmlData));
            DataTable data = dt.Tables[0];
            comm.FillCombo(data, cboIDTYPE, "CDCONTENT", "CDVAL");
           

            string xmlData1 = websv.DataReader("SELECT * FROM CFMAST");
            DataSet dt1 = new DataSet();
            dt1.ReadXml(new StringReader(xmlData1));
            DataTable data1 = dt1.Tables[0];
            if (dt1.Tables.Count <= 0)
            {
                txtCUSTID.Text = "00000001";
            }
            else
            {
                int k = Convert.ToInt32(data1.Rows[data1.Rows.Count - 1][0].ToString().Trim());
                k++;
                txtCUSTID.Text = k.ToString("D8");
            }
            txtCUSTOYOCD.Text = "001C";
            txtCUSTID.ReadOnly = true;
            if (frmCFMAST.str.Trim() == "Sửa khách hàng.")
            {
                lbKhachHang.Text = frmCFMAST.str.Trim();
                txtCUSTID.Text = frmCFMAST.LuuThongTin.ma;
                txtFULLNAME.Text = frmCFMAST.LuuThongTin.ten;
                string luuky = frmCFMAST.LuuThongTin.soluky;
                txtCUSTOYOCD.Text = luuky.Substring(0, 10);
                txtCUSTOYOCD.ReadOnly = true;
                cboIDTYPE.SelectedItem = frmCFMAST.LuuThongTin.loaigiay;
                txtIDCODE.Text = frmCFMAST.LuuThongTin.magiay;
                dtpIDDATE.Text = frmCFMAST.LuuThongTin.ngaycap;
                txtADDRESS.Text = frmCFMAST.LuuThongTin.diachi;
                txtPHONE.Text = frmCFMAST.LuuThongTin.phone;
                txtMOBILE.Text = frmCFMAST.LuuThongTin.mobile;
                txtEMAIL.Text = frmCFMAST.LuuThongTin.email;
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
            string ngaycap = dtpIDDATE.Text.Trim();
            string diachi = txtADDRESS.Text.Trim();
            string dienthoai = txtPHONE.Text.Trim();
            string somobile = txtMOBILE.Text.Trim();
            string email = txtEMAIL.Text.Trim();
            if (frmCFMAST.str.Trim() == "Sửa khách hàng.")
            {
                cfmastsv.FixCustomer(makh, ten, soluuky, loaigiay, sogiay, ngaycap, diachi, dienthoai, somobile, email);
    
                MessageBox.Show("Sửa thành công.", "Thông báo");
                return;
            }
            cfmastsv.AddCustomer(makh, ten, soluuky, loaigiay, sogiay, ngaycap, diachi, dienthoai, somobile, email);
            MessageBox.Show("Thêm thành công.", "Thông báo");
        }

        private void btnSoLuuKy_Click(object sender, EventArgs e)
        {
            string xmlData = websv.DataReader("SELECT * FROM CFMAST");
            DataSet dt = new DataSet();
            dt.ReadXml(new StringReader(xmlData));
            DataTable data = dt.Tables[0];
            int k = Convert.ToInt32(data.Rows[data.Rows.Count - 1][0].ToString());
            k++;
            txtCUSTOYOCD.Text = "001C" + k.ToString("D6");
        }

        private void cboIDTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
