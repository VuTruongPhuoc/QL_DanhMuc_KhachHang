using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Xml.Serialization;
using System.Drawing;
using System.Web.Services.Protocols;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;

namespace WebSV
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        static string host = "localhost";
        static int port = 1521;
        static string sid = "orcl";
        static string user = "KHACHHANG";
        static string password = "123";
        static string connectionString = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;
        [Obsolete]
        OracleConnection conn = null;

        public string getConnect()
        {
            return connectionString;
        }
        [Obsolete]
        public void Connect()
        {
            conn = new OracleConnection(connectionString);
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }
        [Obsolete]
        public void Closed()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
                conn.Dispose();
            }
        }
        [WebMethod]
        [Obsolete]
        public string DataReader(string select)
        {
            DataSet dt = new DataSet();
            Connect();
            OracleDataAdapter adapter = new OracleDataAdapter(select, conn);
            adapter.Fill(dt);
            Closed();
            return dt.GetXml();
        }
        [WebMethod]
        [Obsolete]
        public void DataChange(string sql)
        {
            Connect();
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.Connection = conn;
            oracleCommand.CommandText = sql;
            oracleCommand.ExecuteNonQuery();
            Closed();
        }
    }
}
