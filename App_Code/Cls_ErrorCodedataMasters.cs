using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
//using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

/// <summary>
/// Summary description for Cls_ErrorCodedataMasters
/// </summary>
public class Cls_ErrorCodedataMasters
{
    //public Cls_ErrorCodedataMasters()
    //{
    //    //
    //    // TODO: Add constructor logic here
    //    //
    //}

    public enum ErrorCodes
    {
        [DescriptionHelper("Success")]
        Success = 100,
        [DescriptionHelper("No Data Found")]
        NoDataFound = 200,
        [DescriptionHelper("Failed")]
        Failed = 101,
        [DescriptionHelper("Fail to Login")]
        Fail_to_Login = 112,
        [DescriptionHelper("Login Name is Required.")]
        Login_Name_Required = 248,
        [DescriptionHelper("User Id is Required.")]
        User_Id_Required = 249,
    }

    public static void LogerrorDB(Exception ex, string CreatedBy)
    {

        string constr = ConfigurationManager.ConnectionStrings["ConnectionStringwebapi"].ConnectionString;
        try
        {
            DataSet dsdata = new DataSet();
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmdsrc = new SqlCommand("INS_ErrorLog", con);
                cmdsrc.Parameters.AddWithValue("@Message", ex.Message);
                cmdsrc.Parameters.AddWithValue("@StackTrace", ex.StackTrace);
                cmdsrc.Parameters.AddWithValue("@Source", ex.Source);
                cmdsrc.Parameters.AddWithValue("@TargetSite", ex.TargetSite.ToString());
                cmdsrc.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmdsrc.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmdsrc.ExecuteNonQuery();
                con.Close();
            }
        }
        catch (Exception ee)
        {
            LogError(ex);
            LogError(ee);
        }
    }
    public static void LogError(Exception ex)
    {
        string filename = "ErrorLog_" + DateTime.Now.ToString("dd") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("yyyy");

        string message = string.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));
        message += Environment.NewLine;
        message += "-----------------------------------------------------------";
        message += Environment.NewLine;
        message += string.Format("Message: {0}", ex.Message);
        message += Environment.NewLine;
        message += string.Format("StackTrace: {0}", ex.StackTrace);
        message += Environment.NewLine;
        message += string.Format("Source: {0}", ex.Source);
        message += Environment.NewLine;
        message += string.Format("TargetSite: {0}", ex.TargetSite.ToString());
        message += Environment.NewLine;
        message += "-----------------------------------------------------------";
        message += Environment.NewLine;
        string path = System.Web.HttpContext.Current.Server.MapPath("~/ErrorLog/");
        string FileName = filename + ".txt";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        path = path + FileName;
        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine(message);
            writer.Close();
        }
    }
    public static void LogData(string strData, string Pagename)
    {
        string filename = "LogData_" + DateTime.Now.ToString("dd") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("hh") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss") + Pagename;

        string message = string.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));
        message += Environment.NewLine;
        message += "-----------------------------------------------------------";
        message += Environment.NewLine;
        message += string.Format("Message: {0}", strData);

        message += Environment.NewLine;
        message += "-----------------------------------------------------------";
        message += Environment.NewLine;
        string path = System.Web.HttpContext.Current.Server.MapPath("~/ErrorLogData/" + filename.Trim().TrimStart().TrimEnd() + ".txt");
        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine(message);
            writer.Close();
        }
    }
}

public class DescriptionHelperAttribute : Attribute
{
    public DescriptionHelperAttribute(string description)
    {
        this.Description = description;
    }

    public string Description { get; protected set; }
}
class MyPolicy : ICertificatePolicy
{
    public bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem) { return true; }
}