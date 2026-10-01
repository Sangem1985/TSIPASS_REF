using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TSIPASSPropertiesModel
/// </summary>
public class TSIPASSPropertiesModel
{
    //public TSIPASSPropertiesModel()
    //{
    //    //
    //    // TODO: Add constructor logic here
    //    //
    //}

    #region TSIPASS insert user parmeters
    public class InsertUserDetailsResponse
    {
        public string TSIPASSUserID { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseMesssage { get; set; }
    }
    public class InsertNSWSUserRequest
    {
        //USER DETAILS
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string username { get; set; }
        //  public string Password { get; set; }
        public string investorSwsId { get; set; }
        public string CreatedIP { get; set; }
        //public string Firstname { get; set; }
        //public string Lastname { get; set; }
        // public string Address { get; set; }
        //public string Location { get; set; }
        // public string PANcardno { get; set; }
        //  public string AadharNo { get; set; }
        //public string NSWSCAFID { get; set; }

    }
    #endregion

    #region nsws send redirection parmeters
    public class requestredirectionurlnsws
    {
        public string departmentId { get; set; }
        public string licenseId { get; set; }
        public string redirectionUrl { get; set; }
        public string stateId { get; set; }
        public string swsId { get; set; }
    }
    public class responseofredirectionurlnsws
    {
        public string status { get; set; }
        public string message { get; set; }
        public string data { get; set; }
    }

    #endregion


    #region cafdetailsparmeters
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class SubField
    {
        public string name { get; set; }
        public string fieldKey { get; set; }
    }

    public class Field
    {
        public string name { get; set; }
        public string fieldKey { get; set; }
        public string serialNumber { get; set; }
        public string inputValue { get; set; }
        public List<SubField> subFields { get; set; }
    }

    public class Section
    {
        public string name { get; set; }
        public List<Field> fields { get; set; }
        public string sectionKey { get; set; }
        public string serialNumber { get; set; }
    }

    public class Data
    {
        public string investorSWSId { get; set; }
        public long dateOfInitiation { get; set; }
        public List<Section> sections { get; set; }
        public List<string> stateLicenses { get; set; }
    }

    public class ResponseSvc
    {
        public bool status { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
    }

    #endregion


    #region Masters
    public class MasterStatusResponse
    {
        public string ResponseCode { get; set; }
        public string ResponseMesssage { get; set; }
        public List<Districts> districts { get; set; }
        public List<Mandals> mandalmaster { get; set; }
        public List<Villages> villagemaster { get; set; }
        public List<ConstitutionUnit> constitutionunit { get; set; }
        public List<LineofActivity> lineofactivity { get; set; }
        public List<ProposalType> proposaltype { get; set; }
        public List<TypeofEnterprises> typeofenterprises { get; set; }
        public List<PowerrequirementtypeHP> powerrequirementtypehp { get; set; }
        public List<RegulationTypes> regulationtypes { get; set; }
        public List<Voltage> voltage { get; set; }
        public List<Castes> castes { get; set; }
        public List<Categoryofregistration> categoryofregistration { get; set; }
        public List<buildingtypes> buildingtypes { get; set; }
        public List<LandUseasperMasterPlan> landUseaspermasterPlan { get; set; }
        public List<ApproachRoadtypes> approachroadtypes { get; set; }
        public List<BuildingApprovalMaster> buildingapprovalMaster { get; set; }
        public List<landtype> Landtype { get; set; }
        public List<IndustrialParkMaster> industrialparkmaster { get; set; }
        public List<DepartmentMaster> departmentMaster { get; set; }
        public List<DepartmentApprovalMaster> departmentapprovalMaster { get; set; }
        public List<ApprovalMaster> approvalmaster { get; set; }


        //public Districts districts { get; set; }
        //public Mandals mandalmaster { get; set; }
        //public Villages villagemaster { get; set; }
        //public ConstitutionUnit constitutionunit { get; set; }
        //public LineofActivity lineofactivity { get; set; }
        //public ProposalType proposaltype { get; set; }
        //public TypeofEnterprises typeofenterprises { get; set; }
        //public PowerrequirementtypeHP powerrequirementtypehp { get; set; }
        //public RegulationTypes regulationtypes { get; set; }
        //public Voltage voltage { get; set; }
        //public Castes castes { get; set; }
        //public Categoryofregistration categoryofregistration { get; set; }
        //public buildingtypes buildingtypes { get; set; }
        //public LandUseasperMasterPlan landUseaspermasterPlan { get; set; }
        //public ApproachRoadtypes approachroadtypes { get; set; }
        //public BuildingApprovalMaster buildingapprovalMaster { get; set; }
        //public landtype Landtype { get; set; }
        //public IndustrialParkMaster industrialparkmaster { get; set; }
        //public DepartmentMaster departmentMaster { get; set; }
        //public DepartmentApprovalMaster departmentapprovalMaster { get; set; }
        //public ApprovalMaster approvalmaster { get; set; }
    }

    public class Districts
    {
        public string DistrictName { get; set; }
        public Int32 DistrictID { get; set; }

    }
    public class Mandals
    {
        public string MandalID { get; set; }
        public string MandalName { get; set; }
        public string DistrictName { get; set; }
        public string DistrictID { get; set; }
    }
    public class Villages
    {
        public string VillageName { get; set; }
        public string VillageID { get; set; }
        public string MandalID { get; set; }
        public string MandalName { get; set; }
        public string DistrictName { get; set; }
        public string DistrictID { get; set; }
    }

    public class ConstitutionUnit
    {
        public string ConstitutionUnitName { get; set; }
        public Int32 ConstitutionUnitID { get; set; }

    }
    public class LineofActivity
    {
        public string LineofActivityName { get; set; }
        public Int32 LineofActivityID { get; set; }
        //public string PollutionCategoryType { get; set; }

    }
    public class ProposalType
    {
        public string ProposalName { get; set; }
        public Int32 ProposalID { get; set; }

    }
    public class TypeofEnterprises
    {
        public string TypeofEnterpriseName { get; set; }
        public Int32 TypeofEnterpriseID { get; set; }
    }

    public class PowerrequirementtypeHP
    {
        public string PowerrequirementHP { get; set; }
        public Int32 PowerrequirementHPID { get; set; }

    }
    public class RegulationTypes
    {
        public string RegulationName { get; set; }
        public Int32 RegulationID { get; set; }

    }
    public class Voltage
    {
        public string VoltageName { get; set; }
        public Int32 VoltageID { get; set; }

    }
    public class Castes
    {
        public string Caste { get; set; }
        public Int32 CasteID { get; set; }

    }
    public class Categoryofregistration
    {
        public string Catregistration { get; set; }
        public Int32 CatregID { get; set; }

    }
    public class buildingtypes
    {
        public string typeofbuilding { get; set; }
        public Int32 typeofbuildID { get; set; }
    }
    public class LandUseasperMasterPlan
    {
        public string LandMasterPlan { get; set; }
        public Int32 LandMasterPlanID { get; set; }
    }
    public class ApproachRoadtypes
    {
        public string TypeApproachRoad { get; set; }
        public Int32 TypeApproachRoadID { get; set; }
    }
    public class BuildingApprovalMaster
    {
        public string BuildingApproval { get; set; }
        public Int32 BuildingApprovalID { get; set; }

    }
    public class landtype
    {
        public string Islandpartof { get; set; }
        public Int32 IslandpartofID { get; set; }
    }
    public class IndustrialParkMaster
    {

        public string VillageName { get; set; }
        public string VillageID { get; set; }
        public string MandalName { get; set; }
        public string MandalID { get; set; }
        public string DistrictName { get; set; }
        public string DistrictID { get; set; }
        public string IndustrialParkName { get; set; }
        public string IndustrialParkID { get; set; }

    }
    public class DepartmentMaster
    {
        public string DepartmentName { get; set; }
        public Int32 DepartmentID { get; set; }
    }
    public class DepartmentApprovalMaster
    {
        public string DepartmentName { get; set; }
        public Int32 DepartmentID { get; set; }
        public string ApprovalName { get; set; }
        public Int32 ApprovalID { get; set; }

    }
    public class ApprovalMaster
    {
        public string ApprovalName { get; set; }
        public Int32 ApprovalID { get; set; }
    }
    #endregion


    #region dharaniparmeters

    public class Dharanidatarequest
    {
        public int DharaniredirectID { get; set; }
        public int intQuessionaireid { get; set; }
        public int intCFEEnterpid { get; set; }
        public int TsipassDeptID { get; set; }
        public int TsipassApprovalid { get; set; }
        public int DharaniID { get; set; }
        public string AmountPaid { get; set; }
        public string TranscationNo { get; set; }
        public string TranscationDate { get; set; }
        public string BankName { get; set; }
        public string PassBookNumber { get; set; }
        public string SROID { get; set; }
        public string SROName { get; set; }
        public string SlotDate { get; set; }
        public string Slottime { get; set; }
        public string echallandocuurl { get; set; }
        public string Transcationsummarydocurl { get; set; }
        public string SlotAdvisoryreceiptdocurl { get; set; }
    }

    public class DharanidataResponse
    {
        public string redirectionUrl { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseMesssage { get; set; }
    }

    #endregion



    #region nsws parmeters
    //public class ResponseSvc
    //{
    //    public bool status { get; set; }
    //    public string message { get; set; }
    //    public Data data { get; set; }
    //}
    //public class Data
    //{
    //    public string investorSWSId { get; set; }
    //    public long dateOfInitiation { get; set; }
    //    public List<Section> sections { get; } = new List<Section>();
    //}
    //public class Section
    //{
    //    public string name { get; set; }
    //    public List<Field> fields { get; } = new List<Field>();
    //    public string sectionKey { get; set; }
    //    public string serialNumber { get; set; }
    //}
    //public class Field
    //{
    //    public string name { get; set; }
    //    public string fieldKey { get; set; }
    //    public string serialNumber { get; set; }
    //    public string inputValue { get; set; }
    //    public List<SubField> subFields { get; } = new List<SubField>();
    //}
    //public class SubField
    //{
    //    public string name { get; set; }
    //}
    #endregion
    #region NSWS CAF DETAILS Parmeters


    //public class CAFDetailsresponseDBpar
    //{
    //    public string status { get; set; }
    //    public string message { get; set; }
    //    public IList<dataDB> Ilistcafdata { get; set; }
    //}
    //public class dataDB
    //{
    //    public string investorSWSId { get; set; }
    //    public string dateOfInitiation { get; set; }
    //    public IList<sectionsDB> IlistsectionList { get; set; }
    //}
    ////public class CAFDetailsresponseDBpar
    ////{
    ////    public string status { get; set; }
    ////    public string message { get; set; }
    ////    public string investorSWSId { get; set; }
    ////    public string dateOfInitiation { get; set; }
    ////}
    //public class sectionsDB
    //{
    //    public string name { get; set; }
    //    public IList<fieldsDB> IlistcafdetailsfieldsList { get; set; }
    //    public string sectionKey { get; set; }
    //    //sections serialNumber
    //    public string serialNumber { get; set; }
    //}
    //public class fieldsDB
    //{
    //    public string name { get; set; }
    //    public string fieldKey { get; set; }
    //    //fields serialNumber
    //    public string serialNumber { get; set; }

    //    //"name": "TS-iPASS Common Application Form", "sectionKey": "S-1","serialNumber": "0"
    //    // "name": "Proposal", "sectionKey": "S-4","serialNumber": "3"
    //    public string inputValue { get; set; }
    //    public IList<subFieldsDB> IlistsubFieldsList { get; set; }
    //}
    //public class subFieldsDB
    //{
    //    public string name { get; set; }
    //}

    #endregion
}