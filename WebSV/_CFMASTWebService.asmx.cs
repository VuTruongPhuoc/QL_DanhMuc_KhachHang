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
    /// Summary description for CFMASTWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CFMASTWebService : System.Web.Services.WebService
    {
        WebService1 websv = new WebService1();
        [WebMethod]
        [Obsolete]
        public void ReadProc(string custid, string acctno, string martype, int mrcrlimitmax, string afacctno, int balance, DateTime lastchange)
        {
            OracleConnection conn = null;
            OracleCommand command = new OracleCommand();
            conn = new OracleConnection(websv.getConnect());
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DuyetCFMAST";

            command.Parameters.Add("p_custid", OracleDbType.Varchar2).Value = custid;
            command.Parameters.Add("p_acctno", OracleDbType.Varchar2).Value = acctno;
            command.Parameters.Add("p_martype", OracleDbType.Varchar2).Value = martype;
            command.Parameters.Add("p_mrcrlimitmax", OracleDbType.Int32).Value = mrcrlimitmax;
            command.Parameters.Add("p_afacctno", OracleDbType.Varchar2).Value = afacctno;
            command.Parameters.Add("p_balance", OracleDbType.Int32).Value = balance;
            command.Parameters.Add("p_lastchange", OracleDbType.Date).Value = lastchange;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        [Obsolete]
        public void SuaThemTienCIMAST(string afacctno, string acctno, int money, DateTime lastchange)
        {
            OracleConnection conn = null;
            OracleCommand command = new OracleCommand();
            conn = new OracleConnection(websv.getConnect());
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SuaThemTienCIMAST";

            command.Parameters.Add("p_afacctno", OracleDbType.Varchar2).Value = afacctno;
            command.Parameters.Add("p_acctno", OracleDbType.Varchar2).Value = acctno;
            command.Parameters.Add("p_money", OracleDbType.Int32).Value = money;
            command.Parameters.Add("p_lastchange", OracleDbType.Date).Value = lastchange;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        [Obsolete]
        public void SuaTruTienCIMAST(string afacctno, string acctno, int money, DateTime lastchange)
        {
            OracleConnection conn = null;
            OracleCommand command = new OracleCommand();
            conn = new OracleConnection(websv.getConnect());
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SuaTruTienCIMAST";

            command.Parameters.Add("p_afacctno", OracleDbType.Varchar2).Value = afacctno;
            command.Parameters.Add("p_acctno", OracleDbType.Varchar2).Value = acctno;
            command.Parameters.Add("p_money", OracleDbType.Int32).Value = money;
            command.Parameters.Add("p_lastchange", OracleDbType.Date).Value = lastchange;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        [Obsolete]
        public void ThemCFMAST(string custid, string fullname, string custodycd, string idtype, string idcode, DateTime iddate, string address, string phone, string mobile, string email)
        {
            OracleConnection conn = null;
            OracleCommand command = new OracleCommand();
            conn = new OracleConnection(websv.getConnect());
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ThemCFMAST";

            command.Parameters.Add("p_custid", OracleDbType.Varchar2).Value = custid;
            command.Parameters.Add("p_fullname", OracleDbType.Varchar2).Value = fullname;
            command.Parameters.Add("p_custodycd", OracleDbType.Varchar2).Value = custodycd;
            command.Parameters.Add("p_idtype", OracleDbType.Varchar2).Value = idtype;
            command.Parameters.Add("p_idcode", OracleDbType.Varchar2).Value = idcode;
            command.Parameters.Add("p_iddate", OracleDbType.Date).Value = iddate;
            command.Parameters.Add("p_address", OracleDbType.Varchar2).Value = address;
            command.Parameters.Add("p_phone", OracleDbType.Varchar2).Value = phone;
            command.Parameters.Add("p_mobile", OracleDbType.Varchar2).Value = mobile;
            command.Parameters.Add("p_email", OracleDbType.Varchar2).Value = email;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        [Obsolete]
        public void SuaCFMAST(string custid, string fullname, string custodycd, string idtype, string idcode, DateTime iddate, string address, string phone, string mobile, string email)
        {
            OracleConnection conn = null;
            OracleCommand command = new OracleCommand();
            conn = new OracleConnection(websv.getConnect());
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SuaCFMAST";

            command.Parameters.Add("p_custid", OracleDbType.Varchar2).Value = custid;
            command.Parameters.Add("p_fullname", OracleDbType.Varchar2).Value = fullname;
            command.Parameters.Add("p_custodycd", OracleDbType.Varchar2).Value = custodycd;
            command.Parameters.Add("p_idtype", OracleDbType.Varchar2).Value = idtype;
            command.Parameters.Add("p_idcode", OracleDbType.Varchar2).Value = idcode;
            command.Parameters.Add("p_iddate", OracleDbType.Date).Value = iddate;
            command.Parameters.Add("p_address", OracleDbType.Varchar2).Value = address;
            command.Parameters.Add("p_phone", OracleDbType.Varchar2).Value = phone;
            command.Parameters.Add("p_mobile", OracleDbType.Varchar2).Value = mobile;
            command.Parameters.Add("p_email", OracleDbType.Varchar2).Value = email;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        [Obsolete]
        public void XoaCFMAST(string custid)
        {
            OracleConnection conn = null;
            OracleCommand command = new OracleCommand();
            conn = new OracleConnection(websv.getConnect());
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "XoaCFMAST";

            command.Parameters.Add("p_custid", OracleDbType.Varchar2).Value = custid;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
