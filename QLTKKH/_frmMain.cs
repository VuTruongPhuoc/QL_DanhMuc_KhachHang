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
    public partial class _frmMain : Form
    {
        public _frmMain()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCFMAST frm = new frmCFMAST();
            frm.Show();
        }

        private void tiểuKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAFMAST frm= new frmAFMAST();
            frm.Show();
        }

        private void tiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCIMAST frm = new frmCIMAST();
            frm.Show();
        }

        private void chứngKhoánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSEMAST frm = new frmSEMAST();
            frm.Show();
        }

    }
}
