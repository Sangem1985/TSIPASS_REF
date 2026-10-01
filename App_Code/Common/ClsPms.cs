 using System.Data;
using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Globalization;
using System.IO;
using System.Configuration;
using DataAccessLayer;
using System.Text;
//using Microsoft.Practices.EnterpriseLibrary.Common;
//using Microsoft.Practices.EnterpriseLibrary.Data;
/// <summary>
/// Summary description for ClsPms
/// </summary>
public class ClsPms
{
    private SqlConnection connSqlHelper = new SqlConnection(ConfigurationManager.ConnectionStrings["TSiPASSSkils"].ConnectionString);
    DB.DB con = new DB.DB();
    DataSet ds;
    DataTable dt;
    SqlDataAdapter myDataAdapter;
    public ClsPms()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DataSet GetModuleName()
    {
        con.OpenConnection();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        try
        {
           
            da = new SqlDataAdapter("USP_GET_MODULE_TABLE", con.GetConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure; 
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.CloseConnection();
        }
        
    }

    public DataSet GetTableNames(string module_cd)
    {
        con.OpenConnection();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        try
        {
            da = new SqlDataAdapter("USP_GET_MODULE_TABLE", con.GetConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@MODULE", SqlDbType.VarChar).Value = module_cd;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        //return ds;
    }

    public DataSet GetTableColumns(string module_cd, string table_name)
    {
        con.OpenConnection();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        try
        {
            da = new SqlDataAdapter("USP_GET_MODULE_TABLE", con.GetConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@MODULE", SqlDbType.VarChar).Value = module_cd;
            da.SelectCommand.Parameters.Add("@TABLENAME", SqlDbType.VarChar).Value = table_name;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw ex;
        }
         
    }

    public DataSet GetTableData(string table_name, string column_name, string value)
    {
        con.OpenConnection();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        try
        {
            da = new SqlDataAdapter("USP_GET_TABLE", con.GetConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@TABLE", SqlDbType.VarChar).Value = table_name;
            da.SelectCommand.Parameters.Add("@COLUMN", SqlDbType.VarChar).Value = column_name;
            da.SelectCommand.Parameters.Add("@VALUE", SqlDbType.VarChar).Value = value;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw ex;
        }        
    }
}