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
    public partial class frmEnterAccount : Form
    {
        Commonfunction comm = new Commonfunction();
        DataRead read = new DataRead();
        public frmEnterAccount()
        {
            InitializeComponent();
        }

        private void frmEnterAccount_Load(object sender, EventArgs e)
        {
            comm.FillCombo(read.Reader("AFMAST"), cboACCTNO, "ACCTNO", "ACCTNO");
        }
    }
}
