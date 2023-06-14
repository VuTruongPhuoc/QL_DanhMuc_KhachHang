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
            OracleDataReader reader = command.ExecuteReader();
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
        public void AddCustomer(string makh, string ten, string soluuky, string loaigiay, string sogiay, string ngaycap, string diachi, string dienthoai, string somobile, string email)
        {
            string sql = "INSERT INTO CFMAST(CUSTID,FULLNAME,CUSTODYCD,IDTYPE,IDCODE,IDDATE,ADDRESS,PHONE,MOBILE,EMAIL) " +
                     "VALUES (N'" + makh + "', N'" + ten + "', N'" + soluuky + "', N'" + loaigiay + "'," +
                     "N'" + sogiay + "', DATE '" + ngaycap + "', N'" + diachi + "',N'" + dienthoai + "',N'" + somobile + "',N'" + email + "')";
            websv.DataChange(sql);

        }
        [WebMethod]
        [Obsolete]
        public void FixCustomer(string makh, string ten, string soluuky, string loaigiay, string sogiay, string ngaycap, string diachi, string dienthoai, string somobile, string email)
        {
            string sql = "UPDATE CFMAST SET FULLNAME = N'" + ten + "',CUSTODYCD = N'" + soluuky + "',IDTYPE = N'" + loaigiay + "'," +
                        "IDCODE = N'" + sogiay + "',IDDATE = DATE '" + ngaycap + "'," +
                        "ADDRESS = N'" + diachi + "',PHONE = N'" + dienthoai + "',MOBILE = N'" + somobile + "',EMAIL = N'" + email + "' WHERE CUSTID = N'" + makh + "'";
            websv.DataChange(sql);
        }
        [WebMethod]
        [Obsolete]
        public void DeleteCustomer(string MaKh)
        {
            string sql = "delete CFMAST where CUSTID = '" + MaKh + "'";
            websv.DataChange(sql);
        }
    }
}
