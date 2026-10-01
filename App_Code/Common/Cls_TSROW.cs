using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Reflection;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;


/// <summary>
/// Summary description for Cls_TSROW
/// </summary>
public class Cls_TSROW
{
    string strConnectionString = ConfigurationManager.ConnectionStrings["TSiPASSSkils"].ConnectionString;

    //public Cls_TSROW()
    //{
    //    //
    //    // TODO: Add constructor logic here
    //    //
    //}

    public class TSROWInsertVo
    {
        public string intQuessionaireid { get; set; }
        public string intCFEEnterpid { get; set; }
        public string uid { get; set; }
        public string applicant_name { get; set; }
        //public bool adminChangresPayment { get; set; }
        public string admin_charges { get; set; }
        //public string applicationCharges { get; set; }
        //public string applicationGstCharges { get; set; }
        //public string applicationPaymentDate { get; set; }
        //public bool applicationPaymentDone { get; set; }
        //public string applicationPaymentNumber { get; set; }
        //public string applicationStatus { get; set; }
        public string auth_person_desg { get; set; }
        public string appmade_name { get; set; }
        public string auth_person_email { get; set; }
        public string auth_person_mobile { get; set; }
        public string auth_person_name { get; set; }
        public string bldg_street { get; set; }
        public string bldg_area_structure { get; set; }
        //public Int32 bldg_district_id { get; set; }
        public string bldg_height { get; set; }
        public string bldg_latitude { get; set; }
        public string bldg_longtide { get; set; }
       // public Int32 bldg_mandal_id { get; set; }
        public string bldg_name { get; set; }
       // public Int32 bldg_village_id { get; set; }
        //public string city_town { get; set; }
        public Int32 createdBy { get; set; }
        public string gstCharges { get; set; }
        //public string ip_address { get; set; }
        public string land_city_town { get; set; }
        //public Int32 land_district_id { get; set; }
        public string land_latitude { get; set; }
        public string land_longitude { get; set; }
        //public Int32 land_mandal_id { get; set; }
        public string land_plot_no { get; set; }
        public string land_required { get; set; }
        public string land_road_street { get; set; }
       // public Int32 land_village_id { get; set; }
        public string land_ward_block_locality { get; set; }
        public string matter_work_proposed { get; set; }
        public string measure_proposed { get; set; }
        public string mode_time_work { get; set; }
        public string owner_address { get; set; }
        public string owner_name { get; set; }
        public string plot_flat_no { get; set; }
        public string proposed_extent { get; set; }
        public string public_incon { get; set; }
        public string road_street { get; set; }
        public string department_id { get; set; }
        //public string dept_area_id { get; set; }
        public Int32 district_id { get; set; }
        //public string inspectionRemarks { get; set; }
       //public string inspectionDate { get; set; }
        public Int32 mandal_id { get; set; }
        public Int32 mobileTowerType { get; set; }
        public string pin_code { get; set; }
        //public string totalApplicationCharges { get; set; }
        public Int32 updatedBy { get; set; }
        public string updatedIpAddress { get; set; }
        public string updatedOn { get; set; }
        public Int32 village_id { get; set; }
        public Int32 workHmdaId { get; set; }
        //public Int32 workIalaId { get; set; }
        public Int32 workWardId { get; set; }
        public string work_city_town { get; set; }
        public Int32 work_district_id { get; set; }
        public Int32 work_mandal_id { get; set; }
        public Int32 work_municipality_id { get; set; }
        public Int32 work_village_id { get; set; }
        //public string certificatePath { get; set; }
        public string mobileTowerHeight { get; set; }
        public string mobileTowerSize { get; set; }
        public Int32 workVillageRdId { get; set; }
        public string bldg_stores { get; set; }
        public string bldg_house_num { get; set; }
        public string bldg_locality { get; set; }
        public string bldg_landmark { get; set; }
        public string bldg_structure_pin_code { get; set; }
        public string appmade_address { get; set; }
        public string appmade_mob_num { get; set; }
        //public string appmade_email { get; set; }
        public string submitVal { get; set; }

        //public paymentForm 
        public IList<filesList> filesList { get; set; }

        public paymentForm paymentvo { get; set; }

        public mobileTowerStatusForm mobileTowerStatusFormvo { get; set; }

    }



    public class Response
    {
        public string response_code { get; set; }
        public string response_msg { get; set; }
    }

    public class paymentForm
    {
        public string responseBankCode { get; set; }
        public string responseErrMsg { get; set; }
        public string responseMsg { get; set; }
        public string responseRqst { get; set; }
        public string responseStatus { get; set; }
        public string tpslTxnId { get; set; }
        public string transAmt { get; set; }
        public string responseHash { get; set; }
        public string rqstToken { get; set; }
        public string tpslRfndId { get; set; }
        public string responseTime { get; set; }
    }


    public class filesList
    {
        //public bool is_mandatory { get; set; }
       // public string upload_file { get; set; }

        public string documentDescriptionNum { get; set; }
        public string documentId { get; set; }

        public string filePath { get; set; }
       // public string shortName { get; set; }
    }
    public class mobileTowerStatusForm
    {
        public string actionTakenBy { get; set; }
        public string form_type { get; set; }
        public string isActive { get; set; }
        public string actionTakenName { get; set; }
        public string ipAddress { get; set; }
        public string remark { get; set; }
        public string status { get; set; }
        public string status_id { get; set; }
    }

}