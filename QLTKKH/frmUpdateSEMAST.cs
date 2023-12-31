﻿using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace QLTKKH
{
    public partial class frmUpdateSEMAST : Form
    {
        webservice.WebService1 websv = new webservice.WebService1 ();
        semastservice._SEMASTWebService semastsv = new semastservice._SEMASTWebService ();
        cfmastservice.CFMASTWebService cfmastsv = new cfmastservice.CFMASTWebService ();
        private DataGridView dgv;
        DataRead read = new DataRead ();
        Commonfunction comm = new Commonfunction ();
        public frmUpdateSEMAST(DataGridView dgvSEMAST)
        {
            InitializeComponent();
            dgv = dgvSEMAST;
        }

        private void frmUpdateSEMAST_Load(object sender, EventArgs e)
        {
            lbTaiSanCK.Text = frmSEMAST.str.ToString().Trim();
            DataTable dt1 = read.Reader("AFMAST");
            comm.FillCombo(dt1, cboAFACCTNO, "ACCTNO", "ACCTNO");
            DataTable dt2 = read.Reader("SECURITIES_INFO");
            comm.FillCombo(dt2, cboCODEID, "SYMBOL", "CODEID");
            dtpOPNDATE.Value = DateTime.Now;
            string afacctno = cboAFACCTNO.SelectedValue.ToString().Trim();
            string codeid = cboCODEID.SelectedValue.ToString().Trim();
            txtACCTNO.Text = afacctno + codeid;
            if (lbTaiSanCK.Text == "Sửa tài sản chứng khoán.")
            {
                cboAFACCTNO.SelectedValue = dgv.Rows[frmSEMAST.row].Cells[0].Value.ToString().Trim();
                txtACCTNO.Text = dgv.Rows[frmSEMAST.row].Cells[1].Value.ToString().Trim();
                btnACCTNO.Enabled = false;
                cboCODEID.SelectedValue = dgv.Rows[frmSEMAST.row].Cells[2].Value.ToString().Trim();
                txtTOTALBUYAMT.Text = dgv.Rows[frmSEMAST.row].Cells[4].Value.ToString().Trim();
                dtpOPNDATE.Text = dgv.Rows[frmSEMAST.row].Cells[5].Value.ToString().Trim();
                dtpCLSDATE.Text = dgv.Rows[frmSEMAST.row].Cells[6].Value.ToString().Trim();
                dtpLASTDATE.Text = dgv.Rows[frmSEMAST.row].Cells[7].Value.ToString().Trim();
            }    
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtACCTNO.TextLength == 11 || txtTOTALBUYAMT.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
                return;
            }    
            string afacctno = cboAFACCTNO.SelectedValue.ToString().Trim();
            string codeid = cboCODEID.SelectedValue.ToString().Trim();
            string acctno = afacctno + codeid;
            
            string symbol = cboCODEID.Text.ToString().Trim();
            int totalbuyamt = int.Parse(txtTOTALBUYAMT.Text.ToString().Trim());
            DateTime opndate = dtpOPNDATE.Value;
            DateTime clsdate = dtpCLSDATE.Value;
            DateTime lastdate = dtpLASTDATE.Value;
            if (lbTaiSanCK.Text == "Sửa tài sản chứng khoán.")
            {
                semastsv.SuaSEMAST(afacctno, acctno, codeid,symbol, totalbuyamt, opndate, clsdate, lastdate);
                MessageBox.Show("Sửa thành công", "Thông báo");
                dgv.DataSource = read.Reader("SEMAST");
                cfmastsv.SucMua();
                return;
            }
            semastsv.ThemSEMAST(afacctno, acctno, codeid,symbol, totalbuyamt, opndate, clsdate, lastdate);
            MessageBox.Show("Thêm thành công", "Thông báo");
            txtTOTALBUYAMT.Text = "0".ToString();
            dgv.DataSource = read.Reader("SEMAST");
            cfmastsv.SucMua();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboAFACCTNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCODEID.Items.Count != 0)
            {
                string afacctno = cboAFACCTNO.SelectedValue.ToString().Trim();
                string codeid = cboCODEID.SelectedValue.ToString().Trim();
                txtACCTNO.Text = afacctno + codeid;
            }    
            
        }
        private void cboCODEID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string afacctno = cboAFACCTNO.SelectedValue.ToString().Trim();
            string codeid = cboCODEID.SelectedValue.ToString().Trim();
            txtACCTNO.Text = afacctno + codeid;
        }


    }
}
