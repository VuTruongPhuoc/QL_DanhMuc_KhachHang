using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTKKH
{
    internal class Commonfunction
    {
        public void FillCombo(DataTable dt, ComboBox cbo, String DisPlay, String Value)
        {
            cbo.DataSource = dt;
            cbo.DisplayMember = DisPlay;
            cbo.ValueMember = Value;
        }
    }
}
