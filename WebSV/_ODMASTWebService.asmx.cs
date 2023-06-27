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
        public void ThemODMAST(string afacctno,string orderid, DateTime lastchange, string exectype,string codeid, string symbol, long orderqtty, long price, long execqtty, long execamt, long remainqtty, long cancelqtty)
        {
            OracleConnection conn = new OracleConnection(websv.getConnect()); ;
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ThemODMAST";

            command.Parameters.Add("p_afacctno",OracleDbType.Varchar2).Value = afacctno;
            command.Parameters.Add("p_orderid", OracleDbType.Varchar2).Value = orderid;
            command.Parameters.Add("p_lastchange", OracleDbType.Date).Value = lastchange;
            command.Parameters.Add("p_exectype", OracleDbType.Varchar2).Value = exectype;
            command.Parameters.Add("p_codeid",OracleDbType.Varchar2).Value = codeid;
            command.Parameters.Add("p_symbol", OracleDbType.NVarchar2).Value = symbol;
            command.Parameters.Add("p_orderqtty", OracleDbType.Long).Value = orderqtty;
            command.Parameters.Add("p_price", OracleDbType.Long).Value = price;
            command.Parameters.Add("p_execqtty", OracleDbType.Long).Value = execqtty;
            command.Parameters.Add("p_execamt", OracleDbType.Long).Value = execamt;
            command.Parameters.Add("p_remainqtty", OracleDbType.Long).Value = remainqtty;
            command.Parameters.Add("p_cancelqtty", OracleDbType.Long).Value = cancelqtty;
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
    }
}
