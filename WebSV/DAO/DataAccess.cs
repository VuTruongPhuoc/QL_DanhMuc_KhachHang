using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using Oracle.ManagedDataAccess.Client;

namespace WebSV.DAO
{
    public class DataAccess
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
        [Obsolete]
        public void DataChange(string sql)
        {
            Connect();
            OracleCommand orclCommand = new OracleCommand();
            orclCommand.Connection = conn;
            orclCommand.CommandText = sql;
            orclCommand.ExecuteNonQuery();
            Closed();
        }
    }
}