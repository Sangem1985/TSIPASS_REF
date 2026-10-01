using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Mail;
//using TSIPassBE;
//using TSIPassBL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Text;
using System.Threading;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
/// <summary>
/// Summary description for LEGALWebservice
/// </summary>
public class LEGALWebservice
{
    Legalverify objverify = new Legalverify();
    //LegalVerificationTest.TSLMServiceImplService objlegal = new LegalVerificationTest.TSLMServiceImplService();
    LegalVerification.TSLMServiceImplService objlegal = new LegalVerification.TSLMServiceImplService();
    DataSet ds = new DataSet();

    DataSet dsdept = new DataSet();
    DataTable dt = new DataTable();
    public LEGALWebservice()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public void webserviceLEGAL(string UIDNO)
    {
        ds = objverify.GetDepartmentonuidLEGAL(UIDNO);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string deptid = dt.Rows[i]["intApprovalid"].ToString();
                if (deptid == "162")
                {
                    dsdept = objverify.getdepartmentdetailsonuidLEGAL(UIDNO, deptid);
                    if (dsdept != null && dsdept.Tables.Count > 0 && dsdept.Tables[0].Rows.Count > 0)
                    {
                        string LGVID = dsdept.Tables[0].Rows[0]["intCFEEnterpid"].ToString();
                        string legalApplID = dsdept.Tables[0].Rows[0]["NICApplicationno"].ToString();
                        string registrationType = dsdept.Tables[0].Rows[0]["RegistrationType"].ToString();
                        string merchantOrderNumber = dsdept.Tables[0].Rows[0]["BankName"].ToString();
                        string bankReferenceNumber = dsdept.Tables[0].Rows[0]["TransactionNO"].ToString();
                        string bankTransactionDate = dsdept.Tables[0].Rows[0]["TransactionDate"].ToString();
                        string bankName = dsdept.Tables[0].Rows[0]["BankName"].ToString();
                        string amount = dsdept.Tables[0].Rows[0]["Approval_Fee"].ToString();

                        try
                        {
                            ServicePointManager.Expect100Continue = true;
                            ServicePointManager.SecurityProtocol = //SecurityProtocolType.Tls12;
                            SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                            string outputlegal = objlegal.updatePaymentResponseFromTSiPass(LGVID, legalApplID, registrationType, merchantOrderNumber, bankReferenceNumber, bankTransactionDate, bankName, amount);
                            if (outputlegal == "Successfully Updated")
                            {
                                objverify.UpdateDepartwebserviceflagLEGAL(UIDNO, "268", "AP", outputlegal, "Y");
                            }

                        }
                        catch (Exception ex)
                        {

                        }

                    }
                }

            }


        }
    }
}