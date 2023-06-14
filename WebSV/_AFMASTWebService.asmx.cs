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
    /// Summary description for _AFMASTWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class _AFMASTWebService : System.Web.Services.WebService
    {
        WebService1 websv = new WebService1();
        [WebMethod]
        [Obsolete]
        public void ThemAFMAST(string custid, string acctno, string martype, int mrcrlimitmax)
        {
            OracleConnection conn = null;
            OracleCommand command = new OracleCommand();
            conn = new OracleConnection(websv.getConnect());
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ThemAFMAST";

            command.Parameters.Add("p_custid", OracleDbType.Varchar2).Value = custid;
            command.Parameters.Add("p_acctno", OracleDbType.Varchar2).Value = acctno;
            command.Parameters.Add("p_martype", OracleDbType.Varchar2).Value = martype;
            command.Parameters.Add("p_mrcrlimitmax", OracleDbType.Int32).Value = mrcrlimitmax;
            conn.Open();
            OracleDataReader reader = command.ExecuteReader();
            conn.Close();
        }
        [WebMethod]
        [Obsolete]
        public void SuaAFMAST(string custid, string acctno, string martype, int mrcrlimitmax)
        {
            OracleConnection conn = null;
            OracleCommand command = new OracleCommand();
            conn = new OracleConnection(websv.getConnect());
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SuaAFMAST";

            command.Parameters.Add("p_custid", OracleDbType.Varchar2).Value = custid;
            command.Parameters.Add("p_acctno", OracleDbType.Varchar2).Value = acctno;
            command.Parameters.Add("p_martype", OracleDbType.Varchar2).Value = martype;
            command.Parameters.Add("p_mrcrlimitmax", OracleDbType.Int32).Value = mrcrlimitmax;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        [Obsolete]
        public void XoaAFMAST(string custid, string acctno)
        {
            OracleConnection conn = null;
            OracleCommand command = new OracleCommand();
            conn = new OracleConnection(websv.getConnect());
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "XoaAFMAST";

            command.Parameters.Add("p_custid", OracleDbType.Varchar2).Value = custid;
            command.Parameters.Add("p_acctno", OracleDbType.Varchar2).Value = acctno;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
