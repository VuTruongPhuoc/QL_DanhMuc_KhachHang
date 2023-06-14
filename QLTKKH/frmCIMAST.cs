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
    public partial class frmCIMAST : Form
    {
        public static int dem = 0;
        webservice.WebService1 websv = new webservice.WebService1 ();
        public frmCIMAST()
        {
            InitializeComponent();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            dem = dgvCIMAST.CurrentCell.RowIndex;
            frmUpdateCIMAST frm = new frmUpdateCIMAST(dgvCIMAST);
            frm.Show();
        }
        public void loadgdv()
        {
            string xmlData = websv.DataReader("SELECT * FROM CIMAST");
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
            dgvCIMAST.DataSource = data;
            
        }

        private void frmCIMAST_Load(object sender, EventArgs e)
        {
            loadgdv();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadgdv ();
        }
    }
}
