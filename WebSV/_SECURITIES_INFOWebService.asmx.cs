using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;

namespace WebSV
{
    /// <summary>
    /// Summary description for _SECURITIES_INFOWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class _SECURITIES_INFOWebService : System.Web.Services.WebService
    {
        WebService1 websv = new WebService1 ();
        [WebMethod]
        [Obsolete]
        public void ThemSECURITIES_INFO(string codeid, string symbol, long floorprice, long celingprice, long basicprice, Double mrratiorate, string company)
        {
            OracleCommand command = new OracleCommand();
            OracleConnection conn = new OracleConnection(websv.getConnect());
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ThemSECURITIES_INFO";

            command.Parameters.Add("p_codeid",OracleDbType.Varchar2).Value = codeid;
            command.Parameters.Add("p_symbol",OracleDbType.NVarchar2).Value = symbol;
            command.Parameters.Add("p_floorprice",OracleDbType.Long).Value = floorprice;
            command.Parameters.Add("p_celingprice",OracleDbType.Long).Value= celingprice;
            command.Parameters.Add("p_basicprice",OracleDbType.Long).Value = basicprice;    
            command.Parameters.Add("p_mrratiorate",OracleDbType.Double).Value = mrratiorate;
            command.Parameters.Add("p_company",OracleDbType.NVarchar2).Value = company;
            conn.Open ();
            command.ExecuteNonQuery ();
            conn.Close();
        }
        [WebMethod]
        [Obsolete]
        public void XoaSECURITIES_INFO(string codeid)
        {
            OracleConnection conn = new OracleConnection(websv.getConnect());
            OracleCommand command = new OracleCommand ();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "XoaSECURITIES_INFO";

            command.Parameters.Add("p_codeid",OracleDbType.Varchar2).Value = codeid;

            conn.Open ();
            command.ExecuteNonQuery();
            conn.Close ();

        }
        [WebMethod]
        [Obsolete]
        public string TinhMaMax(string column1, string table1)
        {
            OracleConnection conn = new OracleConnection(websv.getConnect());
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "TinhMaMax";

            command.Parameters.Add("column1", OracleDbType.Varchar2).Value = column1;
            command.Parameters.Add("table1", OracleDbType.Varchar2).Value = table1;
            command.Parameters.Add("result", OracleDbType.Varchar2, ParameterDirection.Output);

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

            return command.Parameters["result"].Value.ToString();
        }


    }
}
