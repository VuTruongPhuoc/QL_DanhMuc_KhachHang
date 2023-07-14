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
        public void DuyetCFMAST(string custid, string acctno, string martype, long mrcrlimitmax, string afacctno, long balance, long pp , long cidepofeeacr,long depofeeamt,long currentdebt, DateTime lastchange, string status)
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
            command.Parameters.Add("p_mrcrlimitmax", OracleDbType.Long).Value = mrcrlimitmax;
            command.Parameters.Add("p_afacctno", OracleDbType.Varchar2).Value = afacctno;
            command.Parameters.Add("p_balance", OracleDbType.Long).Value = balance;
            command.Parameters.Add("p_pp",OracleDbType.Long).Value = pp;
            command.Parameters.Add("p_cidepofeeacr", OracleDbType.Long).Value = cidepofeeacr;
            command.Parameters.Add("p_depofeeamt", OracleDbType.Long).Value = depofeeamt;
            command.Parameters.Add("p_currentdebt", OracleDbType.Long).Value = currentdebt;
            command.Parameters.Add("p_lastchange", OracleDbType.Date).Value = lastchange;
            command.Parameters.Add("p_status", OracleDbType.Varchar2).Value = status;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        [Obsolete]
        public void SuaThemTienCIMAST(string afacctno,  double money,double depofeeamt, DateTime lastchange)
        {
            OracleConnection conn = null;
            OracleCommand command = new OracleCommand();
            conn = new OracleConnection(websv.getConnect());
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SuaThemTienCIMAST";

            command.Parameters.Add("p_afacctno", OracleDbType.Varchar2).Value = afacctno;
            command.Parameters.Add("p_money", OracleDbType.Double).Value = money;
            command.Parameters.Add("p_depofeeamt", OracleDbType.Double).Value = depofeeamt;
            command.Parameters.Add("p_lastchange", OracleDbType.Date).Value = lastchange;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        [Obsolete]
        public void SuaTruTienCIMAST(string afacctno,double money,double depofeeamt, DateTime lastchange)
        {
            OracleConnection conn = null;
            OracleCommand command = new OracleCommand();
            conn = new OracleConnection(websv.getConnect());
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SuaTruTienCIMAST";

            command.Parameters.Add("p_afacctno", OracleDbType.Varchar2).Value = afacctno;
            command.Parameters.Add("p_money", OracleDbType.Double).Value = money;
            command.Parameters.Add("p_depofeeamt", OracleDbType.Double).Value = depofeeamt;
            command.Parameters.Add("p_lastchange", OracleDbType.Date).Value = lastchange;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        [Obsolete]
        public void SucMua()
        {
            OracleConnection conn = new OracleConnection(websv.getConnect());
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SucMua";
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close() ;
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
