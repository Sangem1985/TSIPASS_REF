using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for MobileTowerApprovalSystem
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class MobileTowerApprovalSystem : System.Web.Services.WebService
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["tsipassskils"].ToString());


    DataSet ds;
    DataTable dt;
    SqlDataAdapter myDataAdapter;
    comFunctions cmf = new comFunctions();
    General genogj = new General();
    public MobileTowerApprovalSystem()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string MobileTowerApprovalProcess(string intQuessionaireid, string intCFEEnterpid, string UID, string intDeptid, string intApprovalid, string intStageid, string Querytype, string Query_Raised_Text, string AdditionalAmount, string additionaldocs, string Trans_Date, string Created_by, string Sysip)
    {
        int result = 0;
        string lblmsg = "";
        DataTable dt = new DataTable();
        DataRow dr;
        dt.Columns.Add("ErrorCode");
        dt.Columns.Add("ErrorDescription");
        int valid = 0;

        if (intStageid.ToString() == "5")//|| ddlStatus.SelectedValue.ToString()=="9"
        {
            if (Querytype != "")
            {
                if (Querytype != "1" && Querytype != "2" && Querytype != "3")
                {
                    dr = dt.NewRow();
                    dr[0] = "1";
                    dr[1] = "Please Mention correct type of Query";
                    dt.Rows.Add(dr);
                    valid = 1;
                }
                if (Querytype == "3")
                {
                    if (Query_Raised_Text == "")
                    {
                        dr = dt.NewRow();
                        dr[0] = "2";
                        dr[1] = "Please Enter Query Description";
                        dt.Rows.Add(dr);
                        valid = 1;
                    }
                }
                if (Querytype == "2")
                {
                    if (AdditionalAmount == "")
                    {
                        dr = dt.NewRow();
                        dr[0] = "3";
                        dr[1] = "Please Enter Amount";
                        dt.Rows.Add(dr);
                        valid = 1;
                    }
                }
                if (Querytype == "1")
                {
                    if (additionaldocs == "")
                    {
                        dr = dt.NewRow();
                        dr[0] = "4";
                        dr[1] = "Please Enter Additional Documents Required";
                        dt.Rows.Add(dr);
                        valid = 1;
                    }
                }
                if (valid == 0)
                {
                    if (Querytype == "1" || Querytype == "3")
                    {
                        int j = UpdateAdditionalpayments(intCFEEnterpid, "", "Completed", Created_by, intStageid, intDeptid, intApprovalid, Sysip, "");
                        int i = insertQueryResponsedata(result.ToString(), intCFEEnterpid, Query_Raised_Text, "Y", Created_by, intDeptid, intApprovalid, intQuessionaireid, additionaldocs, Querytype, AdditionalAmount);

                        DataSet dsMail = new DataSet();
                    }
                    else if (Querytype == "2")
                    {
                        if (intDeptid == "11" || intDeptid == "13" || intDeptid == "3")
                        {
                            int j = UpdateAdditionalpayments(intCFEEnterpid, AdditionalAmount, "Completed", Created_by, "11", intDeptid, intApprovalid, Sysip, additionaldocs);
                        }
                        else
                        {
                            int j = UpdateAdditionalpayments(intCFEEnterpid, AdditionalAmount, "Completed", Created_by, "11", intDeptid, intApprovalid, Sysip, "");
                        }
                    }

                }

            }


        }
        else if (intStageid == "12")
        {

            int j = UpdateAdditionalpayments(intCFEEnterpid, "", "Completed", Created_by, intStageid, intDeptid, intApprovalid, Sysip, "");
            DataSet dsMail = new DataSet();



        }
        else if (intStageid == "16")
        {
            if (Query_Raised_Text != "")
            {

                if (intDeptid == "11" || intDeptid == "13" || intDeptid == "3")
                {
                    int j = UpdateAdditionalpaymentsBeforePre(intCFEEnterpid, "", "Rejected", Created_by, intStageid, intDeptid, intApprovalid, Query_Raised_Text, Sysip, additionaldocs);

                }
                else
                {
                    int j = UpdateAdditionalpaymentsBeforePre(intCFEEnterpid, "", "Rejected", Created_by, intStageid, intDeptid, intApprovalid, Query_Raised_Text, Sysip, "");

                }
                DataSet dsMail = new DataSet();

            }
            else
            {
                dr = dt.NewRow();
                dr[0] = "2";
                dr[1] = "Please Enter Reason For Rejection";
                dt.Rows.Add(dr);
            }
        }
        if (result > 0 && valid == 0)
        {
            dr = dt.NewRow();
            dr[0] = "3";
            dr[1] = "Successfully Updated";
            dt.Rows.Add(dr);
            if (intStageid == "16")
            {
                if (Query_Raised_Text == "")
                {
                    dr = dt.NewRow();
                    dr[0] = "2";
                    dr[1] = "Please Enter Reason For Rejection";
                    dt.Rows.Add(dr);
                }
            }
        }
        else
        {
            dr = dt.NewRow();
            dr[0] = "4";
            dr[1] = "Updation Failed";
            dt.Rows.Add(dr);
        }
        ds = new DataSet();
        ds.Tables.Add(dt);
        lblmsg = ds.GetXml();

        return lblmsg;








    }

    public int UpdateAdditionalpayments(string intCFEEnterpid, string Amount, string Status, string Created_by, string stageid, string dept, string Approval, string ipaddress, string dcletter)
    {

        SqlCommand com = new SqlCommand();
        com.CommandType = CommandType.StoredProcedure;
        com.CommandText = "[UpdatetDeptApprovalnew_Websrvc]";


        if (intCFEEnterpid.Trim() == "" || intCFEEnterpid.Trim() == null)
            com.Parameters.Add("@intCFEEnterpid", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@intCFEEnterpid", SqlDbType.VarChar).Value = intCFEEnterpid.Trim();


        if (ipaddress.Trim() == "" || ipaddress.Trim() == null)
            com.Parameters.Add("@ipaddress", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@ipaddress", SqlDbType.VarChar).Value = ipaddress.Trim();

        if (Amount.Trim() == "" || Amount.Trim() == null)
            com.Parameters.Add("@Amount", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@Amount", SqlDbType.VarChar).Value = Amount.Trim();


        if (Status.Trim() == "" || Status.Trim() == null)
            com.Parameters.Add("@Status", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@Status", SqlDbType.VarChar).Value = Status.Trim();


        if (Created_by.Trim() == "" || Created_by.Trim() == null)
            com.Parameters.Add("@Created_by", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@Created_by", SqlDbType.VarChar).Value = Created_by.Trim();

        if (stageid.Trim() == "" || stageid.Trim() == null)
            com.Parameters.Add("@stageid", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@stageid", SqlDbType.VarChar).Value = stageid.Trim();


        if (dept.Trim() == "" || dept.Trim() == null)
            com.Parameters.Add("@dept", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@dept", SqlDbType.VarChar).Value = dept.Trim();


        if (Approval.Trim() == "" || Approval.Trim() == null)
            com.Parameters.Add("@Approval", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@Approval", SqlDbType.VarChar).Value = Approval.Trim();

        if (dcletter.Trim() == "" || dcletter.Trim() == null)
            com.Parameters.Add("@DCLetter", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@DCLetter", SqlDbType.VarChar).Value = dcletter.Trim();

        con.Open();


        try
        {
            //return com.ExecuteNonQuery();
            return Convert.ToInt32(com.ExecuteScalar());
        }
        catch (Exception ex)
        {

            throw ex;
            return 0;
        }
        finally
        {
            com.Dispose();
            con.Close();
        }


    }


    public int insertQueryResponsedata(string intEnterpreniourApprovalid, string intCFEEnterpid, string QueryDescription, string QueryStatus, string Created_by, string intDeptid, string intApprovalid, string intQuessionaireid, string additionaldocs, string Querytype, string AdditionalAmount)
    {
        SqlCommand com = new SqlCommand("sp_savequerydetails");
        com.CommandType = CommandType.StoredProcedure;
        com.CommandText = "";

        if (intEnterpreniourApprovalid.Trim() == "" || intEnterpreniourApprovalid.Trim() == null)
            com.Parameters.Add("@intEnterpreniourApprovalid", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@intEnterpreniourApprovalid", SqlDbType.VarChar).Value = intEnterpreniourApprovalid.Trim();

        if (intCFEEnterpid.Trim() == "" || intCFEEnterpid.Trim() == null)
            com.Parameters.Add("@intCFEEnterpid", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@intCFEEnterpid", SqlDbType.VarChar).Value = intCFEEnterpid.Trim();

        if (intQuessionaireid.Trim() == "" || intQuessionaireid.Trim() == null)
            com.Parameters.Add("@intQuessionaireid", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@intQuessionaireid", SqlDbType.VarChar).Value = intQuessionaireid.Trim();

        if (QueryDescription.Trim() == "" || QueryDescription.Trim() == null)
            com.Parameters.Add("@QueryDescription", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@QueryDescription", SqlDbType.VarChar).Value = QueryDescription.Trim();


        if (QueryStatus.Trim() == "" || QueryStatus.Trim() == null)
            com.Parameters.Add("@QueryStatus", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@QueryStatus", SqlDbType.VarChar).Value = QueryStatus.Trim();

        if (Created_by.Trim() == "" || Created_by.Trim() == null)
            com.Parameters.Add("@Created_by", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@Created_by", SqlDbType.VarChar).Value = Created_by.Trim();


        if (intDeptid.Trim() == "" || intDeptid.Trim() == null)
            com.Parameters.Add("@intDeptid", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@intDeptid", SqlDbType.VarChar).Value = intDeptid.Trim();


        if (intApprovalid.Trim() == "" || intApprovalid.Trim() == null)
            com.Parameters.Add("@intApprovalid", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@intApprovalid", SqlDbType.VarChar).Value = intApprovalid.Trim();

        if (additionaldocs.Trim() == "" || additionaldocs.Trim() == null)
            com.Parameters.Add("@additionaldocsDescription", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@additionaldocsDescription", SqlDbType.VarChar).Value = additionaldocs.Trim();

        if (Querytype.Trim() == "" || Querytype.Trim() == null)
            com.Parameters.Add("@Querytype", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@Querytype", SqlDbType.VarChar).Value = Querytype.Trim();

        if (AdditionalAmount.Trim() == "" || AdditionalAmount.Trim() == null)
            com.Parameters.Add("@AdditionalAmount", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@AdditionalAmount", SqlDbType.VarChar).Value = AdditionalAmount.Trim();

        con.Open();


        try
        {
            //return com.ExecuteNonQuery();
            return Convert.ToInt32(com.ExecuteScalar());
        }
        catch (Exception ex)
        {

            throw ex;
            return 0;
        }
        finally
        {
            com.Dispose();
            con.Close();
        }
    }


    public int UpdateAdditionalpaymentsBeforePre(string intCFEEnterpid, string Amount, string Status, string Created_by, string stageid, string dept, string Approval, string Reason, string IPAddress, string RejectedLetter)
    {

        SqlCommand com = new SqlCommand();
        com.CommandType = CommandType.StoredProcedure;
        com.CommandText = "sp_UpdatetMobilApprovalnewBeforePre";


        if (intCFEEnterpid.Trim() == "" || intCFEEnterpid.Trim() == null)
            com.Parameters.Add("@intCFEEnterpid", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@intCFEEnterpid", SqlDbType.VarChar).Value = intCFEEnterpid.Trim();

        if (IPAddress.Trim() == "" || IPAddress.Trim() == null)
            com.Parameters.Add("@IPAddress", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@IPAddress", SqlDbType.VarChar).Value = IPAddress.Trim();

        if (Amount.Trim() == "" || Amount.Trim() == null)
            com.Parameters.Add("@Amount", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@Amount", SqlDbType.VarChar).Value = Amount.Trim();


        if (Status.Trim() == "" || Status.Trim() == null)
            com.Parameters.Add("@Status", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@Status", SqlDbType.VarChar).Value = Status.Trim();


        if (Created_by.Trim() == "" || Created_by.Trim() == null)
            com.Parameters.Add("@Created_by", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@Created_by", SqlDbType.VarChar).Value = Created_by.Trim();

        if (stageid.Trim() == "" || stageid.Trim() == null)
            com.Parameters.Add("@stageid", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@stageid", SqlDbType.VarChar).Value = stageid.Trim();


        if (dept.Trim() == "" || dept.Trim() == null)
            com.Parameters.Add("@dept", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@dept", SqlDbType.VarChar).Value = dept.Trim();


        if (Approval.Trim() == "" || Approval.Trim() == null)
            com.Parameters.Add("@Approval", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@Approval", SqlDbType.VarChar).Value = Approval.Trim();

        if (Reason.Trim() == "" || Reason.Trim() == null)
            com.Parameters.Add("@rejected_reason", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@rejected_reason", SqlDbType.VarChar).Value = Reason.Trim();

        if (RejectedLetter.Trim() == "" || RejectedLetter.Trim() == null)
            com.Parameters.Add("@RejectedLetter", SqlDbType.VarChar).Value = DBNull.Value;
        else
            com.Parameters.Add("@RejectedLetter", SqlDbType.VarChar).Value = RejectedLetter.Trim();

        con.Open();


        try
        {
            //return com.ExecuteNonQuery();
            return Convert.ToInt32(com.ExecuteScalar());
        }
        catch (Exception ex)
        {

            throw ex;
            return 0;
        }
        finally
        {
            com.Dispose();
            con.Close();
        }
    }




    //[WebMethod]
    //public string MobileTowerApprovalProcessAndCertificateUpload(string intQuessionaireid, string EnterprenuerId, string intApprovalid, string intDeptid, string intStageid, string FileName, string FilePath, string Remarks, string FileRefNo, string Modified_by)
    //{
    //    int i = 0;
    //    string lblmsg = "";
    //    DataTable dt = new DataTable();
    //    DataRow dr;
    //    dt.Columns.Add("ErrorCode");
    //    dt.Columns.Add("ErrorDescription");

    //    // Data Retrival
    //    if (intApprovalid == "73")
    //    {
    //        DataSet dsuidno = new DataSet();
    //        dsuidno = GetDepartmentFileno(intQuessionaireid);
    //        string intQuessionaireidcfo = ""; string intCFoEnterpid = ""; string UIDno = "";
    //        if (dsuidno != null && dsuidno.Tables.Count > 0 && dsuidno.Tables[0].Rows.Count > 0)
    //        {
    //            intQuessionaireidcfo = dsuidno.Tables[0].Rows[0]["intQuessionaireCFOid"].ToString();
    //            intCFoEnterpid = dsuidno.Tables[0].Rows[0]["intCFOEnterpid"].ToString();
    //            UIDno = dsuidno.Tables[0].Rows[0]["UID_No"].ToString();
    //        }
    //        string output = DepartmentApprovalProcessAndCertificateUpload(intQuessionaireidcfo, intCFoEnterpid, intApprovalid, intDeptid, intStageid, FileName, FilePath, Remarks, FileRefNo, Modified_by);
    //        return output;
    //    }
    //    if (intDeptid == "11" || intDeptid == "13" || intDeptid == "3")
    //    {
    //        DataSet dsuidno = new DataSet();
    //        dsuidno = GetDepartmentonuid(intQuessionaireid);
    //        if (dsuidno != null && dsuidno.Tables.Count > 0 && dsuidno.Tables[0].Rows.Count > 0)
    //        {
    //            intQuessionaireid = dsuidno.Tables[0].Rows[0]["intQuessionaireid"].ToString();
    //            EnterprenuerId = dsuidno.Tables[0].Rows[0]["intCFEEnterpid"].ToString();
    //        }
    //    }
    //    if (intDeptid == "1")
    //    {
    //        DataSet dsuidno = new DataSet();
    //        dsuidno = GetDepartmentonuid(intQuessionaireid);
    //        if (dsuidno != null && dsuidno.Tables.Count > 0 && dsuidno.Tables[0].Rows.Count > 0)
    //        {
    //            intQuessionaireid = dsuidno.Tables[0].Rows[0]["intQuessionaireid"].ToString();
    //            EnterprenuerId = dsuidno.Tables[0].Rows[0]["intCFEEnterpid"].ToString();
    //        }
    //    }

    //    DataSet dsdatauser = new DataSet();
    //    dsdatauser = GetdataofApprovaldataAprovalbyID(EnterprenuerId, intDeptid);

    //    string Label447 = "", Label448 = "", Label449 = "", Label450 = "";
    //    if (dsdatauser.Tables[0].Rows.Count > 0)
    //    {
    //        Label447 = dsdatauser.Tables[0].Rows[0]["UID_No"].ToString().Trim();
    //        Label448 = dsdatauser.Tables[0].Rows[0]["NameofthePromoter"].ToString().Trim();
    //        Label449 = dsdatauser.Tables[0].Rows[0]["Ent_is"].ToString().Trim();
    //        Label450 = dsdatauser.Tables[0].Rows[0]["PLoutionCategorys"].ToString().Trim();
    //    }
    //    // end
    //    if (intStageid == "13")
    //    {
    //        if (FileName.Trim() != "")
    //        {
    //            int Fileresult = 0;

    //            string FileType = "";
    //            string[] fileType = FileName.Split('.');
    //            int k = fileType.Length;
    //            FileType = fileType[k - 1];
    //            if (intDeptid != "1")
    //            {
    //                FilePath = FilePath.Substring(0, FilePath.LastIndexOf('/'));
    //            }
    //            else
    //            {
    //                FilePath = FilePath.Substring(0, FilePath.LastIndexOf('='));
    //            }
    //            Fileresult = InsertImagedataApproval(intQuessionaireid, EnterprenuerId, FileType, FilePath, FileName, "ApprovalDocument", "", Modified_by, intDeptid, intApprovalid);

    //            i = insertApprovalData(EnterprenuerId, FileRefNo, intStageid, Modified_by, intApprovalid, intDeptid, Remarks, "");
    //            try
    //            {
    //                int M = genogj.InsertDeptDateTracing(intDeptid, intQuessionaireid, Label447, null, null, null, null, System.DateTime.Now.ToString("MM/dd/yyyy"), "CFE", intApprovalid);
    //            }
    //            catch (Exception ex)
    //            {

    //            }
    //            DataSet dscer = new DataSet();
    //            dscer = GetStatusforCertificate(intQuessionaireid);

    //            if (dscer.Tables[0].Rows.Count > 0)
    //            {
    //                int result = 0;
    //                result = UpdCommissionerApprovalNew(EnterprenuerId, intDeptid, intApprovalid, "15", Modified_by, intQuessionaireid);
    //            }
    //        }
    //        else
    //        {
    //            dr = dt.NewRow();
    //            dr[0] = "1";
    //            dr[1] = "Please Upload Approval Document";
    //            dt.Rows.Add(dr);

    //        }
    //    }
    //    else if (intStageid == "15")
    //    {
    //        if (intApprovalid == "25" || intApprovalid == "4")
    //        {
    //            int Fileresult = 0;

    //            string FileType = "";
    //            string[] fileType = FileName.Split('.');
    //            int k = fileType.Length;
    //            FileType = fileType[k - 1];
    //            //FilePath = FilePath.Substring(0, FilePath.LastIndexOf('/'));
    //            Fileresult = InsertImagedataApproval(intQuessionaireid, EnterprenuerId, ".pdf", FilePath, "ReleaseCertificate", "ReleaseDocument", "", Modified_by, intDeptid, intApprovalid);
    //        }
    //    }
    //    else
    //    {
    //        if (Remarks != "")
    //        {
    //            i = insertApprovalData(EnterprenuerId, FileRefNo, intStageid, Modified_by, intApprovalid, intDeptid, Remarks, "");
    //            try
    //            {
    //                int M = genogj.InsertDeptDateTracing(intDeptid, intQuessionaireid, Label447, null, null, null, null, System.DateTime.Now.ToString("MM/dd/yyyy"), "CFE", intApprovalid);
    //            }
    //            catch (Exception ex)
    //            {

    //            }
    //        }
    //        else
    //        {
    //            dr = dt.NewRow();
    //            dr[0] = "2";
    //            dr[1] = "Please Enter Reason For Rejection..";
    //            dt.Rows.Add(dr);
    //        }
    //    }

    //    if (i != 999)
    //    {
    //        DataSet dsMail1 = new DataSet();
    //        dsMail1 = GetShowEmailidandMobileNumbernew(intQuessionaireid, intDeptid);
    //        if (intStageid == "13")
    //        {
    //            //if (dsMail1.Tables[0].Rows.Count > 0)
    //            //{
    //            //    cmf.SendMailTSiPASS(dsMail1.Tables[0].Rows[0]["Email"].ToString().Trim(), "Dear " + Label448 + " - (" + Label447 + ") :<br/><br/> <b>" + dsMail1.Tables[0].Rows[0]["Dept_Name"].ToString().Trim() + " has issued an" + "Approved" + " to your application.Please login to TS-iPASS to download your approval. Thank You.</b>");
    //            //}
    //            //if (dsMail1.Tables[0].Rows[0]["MobileNo"].ToString().Trim() != "")
    //            //{
    //            //    cmf.SendSingleSMS(dsMail1.Tables[0].Rows[0]["MobileNo"].ToString().Trim(), "Dear " + Label448 + " - (" + Label447 + ") ," + dsMail1.Tables[0].Rows[0]["Dept_Name"].ToString().Trim() + " has issued an " + "Approved" + " to your application.Please login to TS-iPASS to download your approval. Thank You.");
    //            //}

    //            dr = dt.NewRow();
    //            dr[0] = "3";
    //            dr[1] = "Status Updated Successfully";
    //            dt.Rows.Add(dr);
    //            //Response.Redirect("frmDepartementDashboardNew.aspx");
    //        }
    //        else
    //        {
    //            //if (dsMail1.Tables[0].Rows.Count > 0)
    //            //{
    //            //    cmf.SendMailTSiPASS(dsMail1.Tables[0].Rows[0]["Email"].ToString().Trim(), "Dear " + Label448 + " - (" + Label447 + ") :<br/><br/> <b>" + dsMail1.Tables[0].Rows[0]["Dept_Name"].ToString().Trim() + " has " + "Rejected" + " your application.Please login to TS-iPASS Appeal for Rejection. Thank You.</b>");
    //            //}
    //            //if (dsMail1.Tables[0].Rows[0]["MobileNo"].ToString().Trim() != "")
    //            //{
    //            //    cmf.SendSingleSMS(dsMail1.Tables[0].Rows[0]["MobileNo"].ToString().Trim(), "Dear " + Label448 + " - (" + Label447 + ") ," + dsMail1.Tables[0].Rows[0]["Dept_Name"].ToString().Trim() + " has " + "Rejected" + " your application.Please login to TS-iPASS Appeal for Rejection. Thank You.");
    //            //}
    //            dr = dt.NewRow();
    //            dr[0] = "3";
    //            dr[1] = "Status Updated Successfully";
    //            dt.Rows.Add(dr);
    //        }
    //    }
    //    else
    //    {
    //        dr = dt.NewRow();
    //        dr[0] = "4";
    //        dr[1] = "failed";
    //        dt.Rows.Add(dr);
    //    }

    //    ds = new DataSet();
    //    ds.Tables.Add(dt);
    //    lblmsg = ds.GetXml();

    //    return lblmsg;
    //}
}




