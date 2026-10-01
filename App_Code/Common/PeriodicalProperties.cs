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
/// Summary description for PeriodicalProperties
/// </summary>
public class PeriodicalProperties
{
    public PeriodicalProperties()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
public class PMEGPSuccessDetails
{
    public string PmegpID { get; set; }
    public string ApplicantName { get; set; }
    public string FatherorSpouseName { get; set; }
    public string caste { get; set; }
    public string Age { get; set; }
    public string Educationalqualifiaction { get; set; }
    public string HNO { get; set; }
    public string Street { get; set; }
    public string VillageWard { get; set; }
    public string Mandalmunicipality { get; set; }
    public string District { get; set; }
    public string Aadharnumber { get; set; }
    public string Pannumber { get; set; }
    public string Udayamregisternumber { get; set; }
    public string Rationcradnumber { get; set; }
    public string Contactnumber { get; set; }
    public string Emailid { get; set; }
    public string EDPcertifiacte { get; set; }
    public string Anyotherprograms { get; set; }
    public string Unitname { get; set; }
    public string Lineofactivity { get; set; }
    public string productname { get; set; }
    public string unitsofproduction { get; set; }
    public string Dateofcommencementproduction { get; set; }
    public string Employement { get; set; }
    public string Investment { get; set; }
    public string Benificarycontribution { get; set; }
    public string Bankloan { get; set; }
    public string production { get; set; }
    public string Subsidyclaim { get; set; }
    public string Mmadjustments { get; set; }
    public string Annualsales { get; set; }
    public string Annualprofit { get; set; }
    public string Loanrepaymentcompleted { get; set; }
    public string Physicalvericationdate { get; set; }
    public string B_Assetvalue { get; set; }
    public string A_Assetvalue { get; set; }
    public string B_House { get; set; }
    public string A_House { get; set; }
    public string B_Land { get; set; }
    public string A_Land { get; set; }
    public string B_Vehicles { get; set; }
    public string A_Vehicles { get; set; }
    public string B_Health { get; set; }
    public string A_Health { get; set; }
    public string B_Childreneducation { get; set; }
    public string A_Childreneducation { get; set; }
    public string B_Reinvestments { get; set; }
    public string A_Reinvestments { get; set; }
    public string Applicantphoto { get; set; }
    public string UnitPhoto { get; set; }
    public string Createdby { get; set; }
    public string Modifiedby { get; set; }
    public string Flag { get; set; }
    public string FileName { get; set; }
    public string ContentType { get; set; }
    public string Unit_FileName { get; set; }
    public string Unit_ContentType { get; set; }
}
public class PMEGPFamily
{
    public string PMEGPID { get; set; }
    public string Person { get; set; }
    public string Name { get; set; }
    public string Age { get; set; }
    public string Profession { get; set; }
    public string CreatedBy { get; set; }
}
