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
    /// Summary description for _LNMASTWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class _LNMASTWebService : System.Web.Services.WebService
    {
        WebService1 websv = new WebService1 ();
        [WebMethod]
        [Obsolete]
        public void ThemLNMAST(string acctno, long prinnml, long intdue, long intnmlacr,long prinpaid,long intpaid, long prinovd, long intnmlovd,long intovdacr, long rate1, long rate2, long rate3,DateTime lastdate, DateTime opndate, DateTime rlsdate)
        {
            OracleCommand command = new OracleCommand();
            OracleConnection conn = new OracleConnection(websv.getConnect());
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ThemLNMAST";

            command.Parameters.Add("p_acctno", OracleDbType.Varchar2).Value = acctno;
            command.Parameters.Add("p_prinnml", OracleDbType.Long).Value = prinnml;
            command.Parameters.Add("p_intdue", OracleDbType.Long).Value = intdue;
            command.Parameters.Add("p_intnmlacr", OracleDbType.Long).Value = intnmlacr;
            command.Parameters.Add("p_prinpaid",OracleDbType.Long).Value = prinpaid;
            command.Parameters.Add("p_intpaid",OracleDbType.Long).Value = intpaid;
            command.Parameters.Add("p_prinovd", OracleDbType.Long).Value = prinovd;
            command.Parameters.Add("p_intnmlovd", OracleDbType.Long).Value = intnmlovd;
            command.Parameters.Add("p_intovdacr", OracleDbType.Long).Value = intovdacr;
            command.Parameters.Add("p_rate1", OracleDbType.Long).Value = rate1;
            command.Parameters.Add("p_rate2", OracleDbType.Long).Value = rate2;
            command.Parameters.Add("p_rate3", OracleDbType.Long).Value = rate3;
            command.Parameters.Add("p_lastdate",OracleDbType.Date).Value = lastdate;
            command.Parameters.Add("p_opndate", OracleDbType.Date).Value = opndate;
            command.Parameters.Add("p_rlsdate", OracleDbType.Date).Value = rlsdate;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
