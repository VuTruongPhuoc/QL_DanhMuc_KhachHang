using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Services;

namespace WebSV
{
    /// <summary>
    /// Summary description for _ODMASTWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class _ODMASTWebService : System.Web.Services.WebService
    {
        WebService1 websv = new WebService1 ();
        [WebMethod]
        [Obsolete]
        public void ThemODMAST(string custid , string afacctno,string orderid, DateTime lastchange, string exectype,string codeid, string symbol, 
            long orderqtty, long quoteprice, long execqtty, long execamt, long remainqtty, long cancelqtty, double bratio, char edstatus)
        {
            OracleConnection conn = new OracleConnection(websv.getConnect()); ;
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ThemODMAST";

            command.Parameters.Add("p_custid",OracleDbType.Varchar2).Value = custid;
            command.Parameters.Add("p_afacctno",OracleDbType.Varchar2).Value = afacctno;
            command.Parameters.Add("p_orderid", OracleDbType.Varchar2).Value = orderid;
            command.Parameters.Add("p_lastchange", OracleDbType.Date).Value = lastchange;
            command.Parameters.Add("p_exectype", OracleDbType.Varchar2).Value = exectype;
            command.Parameters.Add("p_codeid",OracleDbType.Varchar2).Value = codeid;
            command.Parameters.Add("p_symbol", OracleDbType.NVarchar2).Value = symbol;
            command.Parameters.Add("p_orderqtty", OracleDbType.Long).Value = orderqtty;
            command.Parameters.Add("p_quoteprice", OracleDbType.Long).Value = quoteprice;
            command.Parameters.Add("p_execqtty", OracleDbType.Long).Value = execqtty;
            command.Parameters.Add("p_execamt", OracleDbType.Long).Value = execamt;
            command.Parameters.Add("p_remainqtty", OracleDbType.Long).Value = remainqtty;
            command.Parameters.Add("p_cancelqtty", OracleDbType.Long).Value = cancelqtty;
            command.Parameters.Add("p_bratio", OracleDbType.Double).Value = bratio;
            command.Parameters.Add("p_edstatus", OracleDbType.Char).Value = edstatus;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        [Obsolete]
        public void HuyODMAST(string orderid)
        {
            OracleConnection conn = new OracleConnection(websv.getConnect()); ;
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "HuyODMAST";

            command.Parameters.Add("p_orderid", OracleDbType.Varchar2).Value = orderid;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        [Obsolete]
        public void Update_ODMAST(string custid, string orderid, string exectype,string symbol, long orderqtty, long quoteprice, long execqtty, long execamt, long remainqtty)
        {
            OracleConnection conn = new OracleConnection(websv.getConnect()); ;
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "update_odmast";

            command.Parameters.Add("p_custid",OracleDbType.Varchar2).Value = custid;
            command.Parameters.Add("p_orderid", OracleDbType.Varchar2).Value = orderid;
            command.Parameters.Add("p_exectype", OracleDbType.Varchar2).Value = exectype;
            command.Parameters.Add("p_symbol", OracleDbType.NVarchar2).Value = symbol;
            command.Parameters.Add("p_orderqtty", OracleDbType.Long).Value = orderqtty;
            command.Parameters.Add("p_quoteprice", OracleDbType.Long).Value = quoteprice;
            command.Parameters.Add("p_execqtty", OracleDbType.Long).Value = execqtty;
            command.Parameters.Add("p_execamt", OracleDbType.Long).Value = execamt;
            command.Parameters.Add("p_remainqtty", OracleDbType.Long).Value = remainqtty;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        [Obsolete]
        public void ThanhToan()
        {
            OracleConnection conn = new OracleConnection(websv.getConnect()); ;
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ThanhToan";
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

    }
}
