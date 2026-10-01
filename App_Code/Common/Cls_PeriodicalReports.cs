using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Globalization;
using System.IO;
using System.Configuration;
using DataAccessLayer;

/// <summary>
/// Summary description for Cls_PeriodicalReports
/// </summary>
public class Cls_PeriodicalReports
{
     

    private SqlConnection connSqlHelper = new SqlConnection(ConfigurationManager.ConnectionStrings["TSiPASSSkils"].ConnectionString);
    DB.DB con = new DB.DB();
    comFunctions cmf = new comFunctions();
    public Cls_PeriodicalReports()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DataSet GetPMEGPSuccess(string PMEGPID)
    {
        con.OpenConnection();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        try
        {
            da = new SqlDataAdapter("USP_GET_PMEGPSUCCESSSTROIES", con.GetConnection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (PMEGPID.Trim() == "" || PMEGPID.Trim() == null)
                da.SelectCommand.Parameters.Add("@PmegpID", SqlDbType.VarChar).Value = "%";
            else
                da.SelectCommand.Parameters.Add("@PmegpID", SqlDbType.VarChar).Value = PMEGPID.ToString();
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
    public int InsertPMEGPSuccessDetails(PMEGPSuccessDetails PMEGPSuccessDetailsVO)
    {
        string str = ConfigurationManager.ConnectionStrings["TSiPASSSkils"].ConnectionString;
        int valid;
        SqlConnection connection = new SqlConnection(str);
        SqlTransaction transaction = null;
        connection.Open();
        transaction = connection.BeginTransaction();
        try
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "procinsert_tbl_PMEGP";
            com.Transaction = transaction;
            com.Connection = connection;
            com.Parameters.AddWithValue("@ApplicantName", PMEGPSuccessDetailsVO.ApplicantName);
            com.Parameters.AddWithValue("@FatherorSpouseName", PMEGPSuccessDetailsVO.FatherorSpouseName);
            com.Parameters.AddWithValue("@caste", PMEGPSuccessDetailsVO.caste);
            com.Parameters.AddWithValue("@Age", PMEGPSuccessDetailsVO.Age);
            com.Parameters.AddWithValue("@Educationalqualifiaction", PMEGPSuccessDetailsVO.Educationalqualifiaction);
            com.Parameters.AddWithValue("@HNO", PMEGPSuccessDetailsVO.HNO);
            com.Parameters.AddWithValue("@Street", PMEGPSuccessDetailsVO.Street);
            com.Parameters.AddWithValue("@VillageWard", PMEGPSuccessDetailsVO.VillageWard);
            com.Parameters.AddWithValue("@Mandalmunicipality", PMEGPSuccessDetailsVO.Mandalmunicipality);
            com.Parameters.AddWithValue("@District", PMEGPSuccessDetailsVO.District);
            com.Parameters.AddWithValue("@Aadharnumber", PMEGPSuccessDetailsVO.Aadharnumber);
            com.Parameters.AddWithValue("@Pannumber", PMEGPSuccessDetailsVO.Pannumber);
            com.Parameters.AddWithValue("@Udayamregisternumber", PMEGPSuccessDetailsVO.Udayamregisternumber);
            com.Parameters.AddWithValue("@Rationcradnumber", PMEGPSuccessDetailsVO.Rationcradnumber);
            com.Parameters.AddWithValue("@Contactnumber", PMEGPSuccessDetailsVO.Contactnumber);
            com.Parameters.AddWithValue("@Emailid", PMEGPSuccessDetailsVO.Emailid);
            com.Parameters.AddWithValue("@EDPcertifiacte", PMEGPSuccessDetailsVO.EDPcertifiacte);
            com.Parameters.AddWithValue("@Anyotherprograms", PMEGPSuccessDetailsVO.Anyotherprograms);
            com.Parameters.AddWithValue("@Unitname", PMEGPSuccessDetailsVO.Unitname);
            com.Parameters.AddWithValue("@Lineofactivity", PMEGPSuccessDetailsVO.Lineofactivity);
            com.Parameters.AddWithValue("@productname", PMEGPSuccessDetailsVO.productname);
            com.Parameters.AddWithValue("@unitsofproduction", PMEGPSuccessDetailsVO.unitsofproduction);
            com.Parameters.AddWithValue("@Dateofcommencementproduction", PMEGPSuccessDetailsVO.Dateofcommencementproduction);
            com.Parameters.AddWithValue("@Employement", PMEGPSuccessDetailsVO.Employement);
            com.Parameters.AddWithValue("@Investment", PMEGPSuccessDetailsVO.Investment);
            com.Parameters.AddWithValue("@Benificarycontribution", PMEGPSuccessDetailsVO.Benificarycontribution);
            com.Parameters.AddWithValue("@Bankloan", PMEGPSuccessDetailsVO.Bankloan);
            com.Parameters.AddWithValue("@production", PMEGPSuccessDetailsVO.production);
            com.Parameters.AddWithValue("@Subsidyclaim", PMEGPSuccessDetailsVO.Subsidyclaim);
            com.Parameters.AddWithValue("@Mmadjustments", PMEGPSuccessDetailsVO.Mmadjustments);
            com.Parameters.AddWithValue("@Annualsales", PMEGPSuccessDetailsVO.Annualsales);
            com.Parameters.AddWithValue("@Annualprofit", PMEGPSuccessDetailsVO.Annualprofit);
            com.Parameters.AddWithValue("@Loanrepaymentcompleted", PMEGPSuccessDetailsVO.Loanrepaymentcompleted);
            com.Parameters.AddWithValue("@Physicalvericationdate", PMEGPSuccessDetailsVO.Physicalvericationdate);
            com.Parameters.AddWithValue("@B_Assetvalue", PMEGPSuccessDetailsVO.B_Assetvalue);
            com.Parameters.AddWithValue("@A_Assetvalue", PMEGPSuccessDetailsVO.A_Assetvalue);
            com.Parameters.AddWithValue("@B_House", PMEGPSuccessDetailsVO.B_House);
            com.Parameters.AddWithValue("@A_House", PMEGPSuccessDetailsVO.A_House);
            com.Parameters.AddWithValue("@B_Land", PMEGPSuccessDetailsVO.B_Land);
            com.Parameters.AddWithValue("@A_Land", PMEGPSuccessDetailsVO.A_Land);
            com.Parameters.AddWithValue("@B_Vehicles", PMEGPSuccessDetailsVO.B_Vehicles);
            com.Parameters.AddWithValue("@A_Vehicles", PMEGPSuccessDetailsVO.A_Vehicles);
            com.Parameters.AddWithValue("@B_Health", PMEGPSuccessDetailsVO.B_Health);
            com.Parameters.AddWithValue("@A_Health", PMEGPSuccessDetailsVO.A_Health);
            com.Parameters.AddWithValue("@B_Childreneducation", PMEGPSuccessDetailsVO.B_Childreneducation);
            com.Parameters.AddWithValue("@A_Childreneducation", PMEGPSuccessDetailsVO.A_Childreneducation);
            com.Parameters.AddWithValue("@B_Reinvestments", PMEGPSuccessDetailsVO.B_Reinvestments);
            com.Parameters.AddWithValue("@A_Reinvestments", PMEGPSuccessDetailsVO.A_Reinvestments); 
            com.Parameters.AddWithValue("@Applicantphoto", PMEGPSuccessDetailsVO.Applicantphoto);
            com.Parameters.AddWithValue("@UnitPhoto", PMEGPSuccessDetailsVO.UnitPhoto); 
            com.Parameters.Add("@Valid", SqlDbType.Int, 500);
            com.Parameters["@Valid"].Direction = ParameterDirection.Output;
            com.ExecuteNonQuery();
            valid = (Int32)com.Parameters["@Valid"].Value;
            transaction.Commit();
            connection.Close();
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            throw ex;
        }
        finally
        {
            connection.Close();
            connection.Dispose();
        }
        return valid;
    }
    
}