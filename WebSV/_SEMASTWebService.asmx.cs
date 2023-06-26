using Microsoft.SqlServer.Server;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebSV
{
    /// <summary>
    /// Summary description for _SEMASTWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class _SEMASTWebService : System.Web.Services.WebService
    {
        WebService1 websv = new WebService1();
        [WebMethod]
        [Obsolete]
        public void ThemSEMAST(string afacctno, string acctno, string codeid,string symbol, int totalbuyamt, DateTime opndate, DateTime clsdate, DateTime lastdate)
        {
            OracleConnection conn = null;
            OracleCommand command = new OracleCommand();
            conn = new OracleConnection(websv.getConnect());
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ThemSEMAST";

            command.Parameters.Add("p_afacctno", OracleDbType.Varchar2).Value = afacctno;
            command.Parameters.Add("p_acctno", OracleDbType.Varchar2).Value = acctno;
            command.Parameters.Add("p_codeid", OracleDbType.Varchar2).Value = codeid;
            command.Parameters.Add("p_symbol",OracleDbType.Varchar2).Value = symbol;
            command.Parameters.Add("p_totalbuyamt", OracleDbType.Int64).Value = totalbuyamt;
            command.Parameters.Add("p_opndate", OracleDbType.Date).Value = opndate;
            command.Parameters.Add("p_clsdate", OracleDbType.Date).Value = clsdate;
            command.Parameters.Add("p_lastdate", OracleDbType.Date).Value = lastdate;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        [Obsolete]
        public void SuaSEMAST(string afacctno, string acctno, string codeid,string symbol, int totalbuyamt, DateTime opndate, DateTime clsdate, DateTime lastdate)
        {
            OracleConnection conn = null;
            OracleCommand command = new OracleCommand();
            conn = new OracleConnection(websv.getConnect());
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SuaSEMAST";

            command.Parameters.Add("p_afacctno", OracleDbType.Varchar2).Value = afacctno;
            command.Parameters.Add("p_acctno", OracleDbType.Varchar2).Value = acctno;
            command.Parameters.Add("p_codeid", OracleDbType.Varchar2).Value = codeid;
            command.Parameters.Add("p_symbol", OracleDbType.Varchar2).Value = symbol;
            command.Parameters.Add("p_totalbuyamt", OracleDbType.Int64).Value = totalbuyamt;
            command.Parameters.Add("p_opndate", OracleDbType.Date).Value = opndate;
            command.Parameters.Add("p_clsdate", OracleDbType.Date).Value = clsdate;
            command.Parameters.Add("p_lastdate", OracleDbType.Date).Value = lastdate;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        [Obsolete]
        public void XoaSEMAST(string acctno)
        {
            OracleConnection conn = null;
            OracleCommand command = new OracleCommand();
            conn = new OracleConnection(websv.getConnect());
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "XoaSEMAST";

            command.Parameters.Add("p_acctno", OracleDbType.Varchar2).Value = acctno;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
