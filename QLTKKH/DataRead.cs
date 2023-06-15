using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLTKKH
{
    internal class DataRead
    {
        webservice.WebService1 websv = new webservice.WebService1 ();
        public DataTable Reader(string table)
        {
            string xml = websv.DataReader("SELECT * FROM " + table);
            
            DataSet dt = new DataSet();
            dt.ReadXml(new StringReader(xml));
            DataTable data = null;
            if (dt != null && dt.Tables.Count > 0)
            {
                data = dt.Tables[0];
            }
            else
            {
                data = null;
            }
            return data;
        }
    }
}
