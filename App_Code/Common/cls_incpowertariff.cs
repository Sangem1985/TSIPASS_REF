using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Globalization;
using System.IO;
using DataAccessLayer;

/// <summary>
/// Summary description for cls_incpowertariff
/// </summary>
public class cls_incpowertariff
{
    string strConnectionString = ConfigurationManager.ConnectionStrings["TSiPASSSkils"].ConnectionString;
    //public cls_incpowertariff()
    //{
    //    //
    //    // TODO: Add constructor logic here
    //    //
    //}

    public string InsertCompanyforApplication(incpowertariffproperties pacd)
    {
        SqlConnection connection = new SqlConnection(strConnectionString);
        SqlTransaction transaction = null;
        int retValue = 0;
        string APNo = null;
        try
        {
            connection.Open();
            transaction = connection.BeginTransaction();
            SqlCommand cmdpacd = new SqlCommand("incpt_insertappofincpowertariff", connection);
            cmdpacd.CommandType = CommandType.StoredProcedure;
            cmdpacd.Transaction = transaction;
            if (Convert.ToString(pacd.incpowrtariffid) == "" || Convert.ToString(pacd.incpowrtariffid) == null)
            {
                cmdpacd.Parameters.AddWithValue("@incpowrtariffid", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@incpowrtariffid", SqlDbType.VarChar).Value = pacd.incpowrtariffid;
            }
            if (Convert.ToString(pacd.fileno) == "" || Convert.ToString(pacd.fileno) == null)
            {
                cmdpacd.Parameters.AddWithValue("@fileno", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@fileno", SqlDbType.VarChar).Value = pacd.fileno;
            }
            if (Convert.ToString(pacd.dateingmoffice) == "" || Convert.ToString(pacd.dateingmoffice) == null)
            {
                cmdpacd.Parameters.AddWithValue("@dateingmoffice", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@dateingmoffice", SqlDbType.VarChar).Value = pacd.dateingmoffice;
            }
            if (Convert.ToString(pacd.filenoheadoffice) == "" || Convert.ToString(pacd.filenoheadoffice) == null)
            {
                cmdpacd.Parameters.AddWithValue("@filenoheadoffice", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@filenoheadoffice", SqlDbType.VarChar).Value = pacd.filenoheadoffice;
            }
            if (Convert.ToString(pacd.eligibleno) == "" || Convert.ToString(pacd.eligibleno) == null)
            {
                cmdpacd.Parameters.AddWithValue("@eligibleno", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@eligibleno", SqlDbType.VarChar).Value = pacd.eligibleno;
            }         
            if (Convert.ToString(pacd.invst_subfileno) == "" || Convert.ToString(pacd.invst_subfileno) == null)
            {
                cmdpacd.Parameters.AddWithValue("@invst_subfileno", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@invst_subfileno", SqlDbType.VarChar).Value = pacd.invst_subfileno;
            }
            if (Convert.ToString(pacd.nameoftheunit) == "" || Convert.ToString(pacd.nameoftheunit) == null)
            {
                cmdpacd.Parameters.AddWithValue("@nameoftheunit", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@nameoftheunit", SqlDbType.VarChar).Value = pacd.nameoftheunit;
            }
            if (Convert.ToString(pacd.addressoftheunit) == "" || Convert.ToString(pacd.addressoftheunit) == null)
            {
                cmdpacd.Parameters.AddWithValue("@addressoftheunit", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@addressoftheunit", SqlDbType.VarChar).Value = pacd.addressoftheunit;
            }
            if (Convert.ToString(pacd.constitutiooftheindustry) == "" || Convert.ToString(pacd.constitutiooftheindustry) == null)
            {
                cmdpacd.Parameters.AddWithValue("@constitutiooftheindustry", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@constitutiooftheindustry", SqlDbType.VarChar).Value = pacd.constitutiooftheindustry;
            }
            if (Convert.ToString(pacd.constitID) == "" || Convert.ToString(pacd.constitID) == null)
            {
                cmdpacd.Parameters.AddWithValue("@constitID", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@constitID", SqlDbType.VarChar).Value = pacd.constitID;
            }
            if (Convert.ToString(pacd.IncentiveID) == "" || Convert.ToString(pacd.IncentiveID) == null)
            {
                cmdpacd.Parameters.AddWithValue("@IncentiveID", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@IncentiveID", SqlDbType.VarChar).Value = pacd.IncentiveID;
            }
            if (Convert.ToString(pacd.socialstatus) == "" || Convert.ToString(pacd.socialstatus) == null)
            {
                cmdpacd.Parameters.AddWithValue("@socialstatus", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@socialstatus", SqlDbType.VarChar).Value = pacd.socialstatus;
            }
            if (Convert.ToString(pacd.socialstatusid) == "" || Convert.ToString(pacd.socialstatusid) == null)
            {
                cmdpacd.Parameters.AddWithValue("@socialstatusid", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@socialstatusid", SqlDbType.VarChar).Value = pacd.socialstatusid;
            }
            if (Convert.ToString(pacd.nemeproppartnrmpmd) == "" || Convert.ToString(pacd.nemeproppartnrmpmd) == null)
            {
                cmdpacd.Parameters.AddWithValue("@nemeproppartnrmpmd", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@nemeproppartnrmpmd", SqlDbType.VarChar).Value = pacd.nemeproppartnrmpmd;
            }
            if (Convert.ToString(pacd.schemename) == "" || Convert.ToString(pacd.schemename) == null)
            {
                cmdpacd.Parameters.AddWithValue("@schemename", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@schemename", SqlDbType.VarChar).Value = pacd.schemename;
            }
            if (Convert.ToString(pacd.schemeID) == "" || Convert.ToString(pacd.schemeID) == null)
            {
                cmdpacd.Parameters.AddWithValue("@schemeID", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@schemeID", SqlDbType.VarChar).Value = pacd.schemeID;
            }
            if (Convert.ToString(pacd.SSIregiemlno) == "" || Convert.ToString(pacd.SSIregiemlno) == null)
            {
                cmdpacd.Parameters.AddWithValue("@SSIregiemlno", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@SSIregiemlno", SqlDbType.VarChar).Value = pacd.SSIregiemlno;
            }
            if (Convert.ToString(pacd.dateapp) == "" || Convert.ToString(pacd.dateapp) == null)
            {
                cmdpacd.Parameters.AddWithValue("@dateapp", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@dateapp", SqlDbType.VarChar).Value = pacd.dateapp;
            }
            if (Convert.ToString(pacd.lineofactivity) == "" || Convert.ToString(pacd.lineofactivity) == null)
            {
                cmdpacd.Parameters.AddWithValue("@lineofactivity", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@lineofactivity", SqlDbType.VarChar).Value = pacd.lineofactivity;
            }
            if (Convert.ToString(pacd.lineofactivityid) == "" || Convert.ToString(pacd.lineofactivityid) == null)
            {
                cmdpacd.Parameters.AddWithValue("@lineofactivityid", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@lineofactivityid", SqlDbType.VarChar).Value = pacd.lineofactivityid;
            }
            if (Convert.ToString(pacd.units) == "" || Convert.ToString(pacd.units) == null)
            {
                cmdpacd.Parameters.AddWithValue("@units", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@units", SqlDbType.VarChar).Value = pacd.units;
            }
            if (Convert.ToString(pacd.capcity) == "" || Convert.ToString(pacd.capcity) == null)
            {
                cmdpacd.Parameters.AddWithValue("@capcity", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@capcity", SqlDbType.VarChar).Value = pacd.capcity;
            }        
            if (Convert.ToString(pacd.unittype) == "" || Convert.ToString(pacd.unittype) == null)
            {
                cmdpacd.Parameters.AddWithValue("@unittype", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@unittype", SqlDbType.VarChar).Value = pacd.unittype;
            }
            if (Convert.ToString(pacd.unittypeid) == "" || Convert.ToString(pacd.unittypeid) == null)
            {
                cmdpacd.Parameters.AddWithValue("@unittypeid", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@unittypeid", SqlDbType.VarChar).Value = pacd.unittypeid;
            }


            if (Convert.ToString(pacd.dateofcommesemetofprodn) == "" || Convert.ToString(pacd.dateofcommesemetofprodn) == null)
            {
                cmdpacd.Parameters.AddWithValue("@dateofcommesemetofprodn", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@dateofcommesemetofprodn", SqlDbType.VarChar).Value = pacd.dateofcommesemetofprodn;
            }


            if (Convert.ToString(pacd.nameoffinancinginstituition) == "" || Convert.ToString(pacd.nameoffinancinginstituition) == null)
            {
                cmdpacd.Parameters.AddWithValue("@nameoffinancinginstituition", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@nameoffinancinginstituition", SqlDbType.VarChar).Value = pacd.nameoffinancinginstituition;
            }


            if (Convert.ToString(pacd.fixedassetsLandname) == "" || Convert.ToString(pacd.fixedassetsLandname) == null)
            {
                cmdpacd.Parameters.AddWithValue("@fixedassetsLandname", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@fixedassetsLandname", SqlDbType.VarChar).Value = pacd.fixedassetsLandname;
            }

            if (Convert.ToString(pacd.landapprovedprocst) == "" || Convert.ToString(pacd.landapprovedprocst) == null)
            {
                cmdpacd.Parameters.AddWithValue("@landapprovedprocst", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@landapprovedprocst", SqlDbType.VarChar).Value = pacd.landapprovedprocst;
            }


            if (Convert.ToString(pacd.landexistprocst) == "" || Convert.ToString(pacd.landexistprocst) == null)
            {
                cmdpacd.Parameters.AddWithValue("@landexistprocst", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@landexistprocst", SqlDbType.VarChar).Value = pacd.landexistprocst;
            }

            if (Convert.ToString(pacd.landinvstprocst) == "" || Convert.ToString(pacd.landinvstprocst) == null)
            {
                cmdpacd.Parameters.AddWithValue("@landinvstprocst", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@landinvstprocst", SqlDbType.VarChar).Value = pacd.landinvstprocst;
            }


            if (Convert.ToString(pacd.fixedassestsbuildingname) == "" || Convert.ToString(pacd.fixedassestsbuildingname) == null)
            {
                cmdpacd.Parameters.AddWithValue("@fixedassestsbuildingname", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@fixedassestsbuildingname", SqlDbType.VarChar).Value = pacd.fixedassestsbuildingname;
            }


            if (Convert.ToString(pacd.buildingapprovedprocst) == "" || Convert.ToString(pacd.buildingapprovedprocst) == null)
            {
                cmdpacd.Parameters.AddWithValue("@buildingapprovedprocst", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@buildingapprovedprocst", SqlDbType.VarChar).Value = pacd.buildingapprovedprocst;
            }


            if (Convert.ToString(pacd.buildingexistprocst) == "" || Convert.ToString(pacd.buildingexistprocst) == null)
            {
                cmdpacd.Parameters.AddWithValue("@buildingexistprocst", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@buildingexistprocst", SqlDbType.VarChar).Value = pacd.buildingexistprocst;
            }

    
            if (Convert.ToString(pacd.buildinginvstprocst) == "" || Convert.ToString(pacd.buildinginvstprocst) == null)
            {
                cmdpacd.Parameters.AddWithValue("@buildinginvstprocst", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@buildinginvstprocst", SqlDbType.VarChar).Value = pacd.buildinginvstprocst;
            }

            if (Convert.ToString(pacd.fixedassestsplantmcname) == "" || Convert.ToString(pacd.fixedassestsplantmcname) == null)
            {
                cmdpacd.Parameters.AddWithValue("@fixedassestsplantmcname", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@fixedassestsplantmcname", SqlDbType.VarChar).Value = pacd.fixedassestsplantmcname;
            }

            if (Convert.ToString(pacd.plantmcapprovedprocst) == "" || Convert.ToString(pacd.plantmcapprovedprocst) == null)
            {
                cmdpacd.Parameters.AddWithValue("@plantmcapprovedprocst", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@plantmcapprovedprocst", SqlDbType.VarChar).Value = pacd.plantmcapprovedprocst;
            }

            if (Convert.ToString(pacd.plantmcexistprocst) == "" || Convert.ToString(pacd.plantmcexistprocst) == null)
            {
                cmdpacd.Parameters.AddWithValue("@plantmcexistprocst", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@plantmcexistprocst", SqlDbType.VarChar).Value = pacd.plantmcexistprocst;
            }

            if (Convert.ToString(pacd.plantmcinvstprocst) == "" || Convert.ToString(pacd.plantmcinvstprocst) == null)
            {
                cmdpacd.Parameters.AddWithValue("@plantmcinvstprocst", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@plantmcinvstprocst", SqlDbType.VarChar).Value = pacd.plantmcinvstprocst;
            }

            if (Convert.ToString(pacd.fixedassesttotapprovedprocst) == "" || Convert.ToString(pacd.fixedassesttotapprovedprocst) == null)
            {
                cmdpacd.Parameters.AddWithValue("@fixedassesttotapprovedprocst", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@fixedassesttotapprovedprocst", SqlDbType.VarChar).Value = pacd.fixedassesttotapprovedprocst;
            }
            if (Convert.ToString(pacd.fixedassestexistprocst) == "" || Convert.ToString(pacd.fixedassestexistprocst) == null)
            {
                cmdpacd.Parameters.AddWithValue("@fixedassestexistprocst", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@fixedassestexistprocst", SqlDbType.VarChar).Value = pacd.fixedassestexistprocst;
            }
            if (Convert.ToString(pacd.fixedassestinvstprocst) == "" || Convert.ToString(pacd.fixedassestinvstprocst) == null)
            {
                cmdpacd.Parameters.AddWithValue("@fixedassestinvstprocst", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@fixedassestinvstprocst", SqlDbType.VarChar).Value = pacd.fixedassestinvstprocst;
            }
            if (Convert.ToString(pacd.installcappriorofed) == "" || Convert.ToString(pacd.installcappriorofed) == null)
            {
                cmdpacd.Parameters.AddWithValue("@installcappriorofed", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@installcappriorofed", SqlDbType.VarChar).Value = pacd.installcappriorofed;
            }
            if (Convert.ToString(pacd.installcapundered) == "" || Convert.ToString(pacd.installcapundered) == null)
            {
                cmdpacd.Parameters.AddWithValue("@installcapundered", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@installcapundered", SqlDbType.VarChar).Value = pacd.installcapundered;
            }
            if (Convert.ToString(pacd.perincinvstundered) == "" || Convert.ToString(pacd.perincinvstundered) == null)
            {
                cmdpacd.Parameters.AddWithValue("@perincinvstundered", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@perincinvstundered", SqlDbType.VarChar).Value = pacd.perincinvstundered;
            }
            if (Convert.ToString(pacd.perinccapundered) == "" || Convert.ToString(pacd.perinccapundered) == null)
            {
                cmdpacd.Parameters.AddWithValue("@perinccapundered", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@perinccapundered", SqlDbType.VarChar).Value = pacd.perinccapundered;
            }
            if (Convert.ToString(pacd.existingpowerinhp) == "" || Convert.ToString(pacd.existingpowerinhp) == null)
            {
                cmdpacd.Parameters.AddWithValue("@existingpowerinhp", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@existingpowerinhp", SqlDbType.VarChar).Value = pacd.existingpowerinhp;
            }
            if (Convert.ToString(pacd.newpowerconkva) == "" || Convert.ToString(pacd.newpowerconkva) == null)
            {
                cmdpacd.Parameters.AddWithValue("@newpowerconkva", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@newpowerconkva", SqlDbType.VarChar).Value = pacd.newpowerconkva;
            }
            if (Convert.ToString(pacd.dateofnewconrelased) == "" || Convert.ToString(pacd.dateofnewconrelased) == null)
            {
                cmdpacd.Parameters.AddWithValue("@dateofnewconrelased", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.Add("@dateofnewconrelased", SqlDbType.VarChar).Value = pacd.dateofnewconrelased;
            }
            if (Convert.ToString(pacd.serviceconnno) == "" || Convert.ToString(pacd.serviceconnno) == null)
            {
                cmdpacd.Parameters.AddWithValue("@serviceconnno", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@serviceconnno", SqlDbType.VarChar).Value = pacd.serviceconnno;
            }
            if (Convert.ToString(pacd.prefinacialyr1) == "" || Convert.ToString(pacd.prefinacialyr1) == null)
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr1", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr1", SqlDbType.VarChar).Value = pacd.prefinacialyr1;
            }
            if (Convert.ToString(pacd.prefinacialyt1unitsutilised) == "" || Convert.ToString(pacd.prefinacialyt1unitsutilised) == null)
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyt1unitsutilised", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyt1unitsutilised", SqlDbType.VarChar).Value = pacd.prefinacialyt1unitsutilised;
            }
            if (Convert.ToString(pacd.prefinacialyr1rateofunit) == "" || Convert.ToString(pacd.prefinacialyr1rateofunit) == null)
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr1rateofunit", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr1rateofunit", SqlDbType.VarChar).Value = pacd.prefinacialyr1rateofunit;
            }            
            if (Convert.ToString(pacd.prefinacialyr1totpaid) == "" || Convert.ToString(pacd.prefinacialyr1totpaid) == null)
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr1totpaid", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr1totpaid", SqlDbType.VarChar).Value = pacd.prefinacialyr1totpaid;
            }
            if (Convert.ToString(pacd.prefinacialyr2) == "" || Convert.ToString(pacd.prefinacialyr2) == null)
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr2", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr2", SqlDbType.VarChar).Value = pacd.prefinacialyr2;
            }
            if (Convert.ToString(pacd.prefinacialyr2unitsutilised) == "" || Convert.ToString(pacd.prefinacialyr2unitsutilised) == null)
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr2unitsutilised", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr2unitsutilised", SqlDbType.VarChar).Value = pacd.prefinacialyr2unitsutilised;
            }
            if (Convert.ToString(pacd.prefinacialyr2rateofunit) == "" || Convert.ToString(pacd.prefinacialyr2rateofunit) == null)
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr2rateofunit", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr2rateofunit", SqlDbType.VarChar).Value = pacd.prefinacialyr2rateofunit;
            }
            if (Convert.ToString(pacd.prefinacialyr2totpaid) == "" || Convert.ToString(pacd.prefinacialyr2totpaid) == null)
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr2totpaid", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr2totpaid", SqlDbType.VarChar).Value = pacd.prefinacialyr2totpaid;
            }
            if (Convert.ToString(pacd.prefinacialyr3) == "" || Convert.ToString(pacd.prefinacialyr3) == null)
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr3", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr3", SqlDbType.VarChar).Value = pacd.prefinacialyr3;
            }           
            if (Convert.ToString(pacd.prefinacialyr3unitsutilised) == "" || Convert.ToString(pacd.prefinacialyr3unitsutilised) == null)
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr3unitsutilised", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr3unitsutilised", SqlDbType.VarChar).Value = pacd.prefinacialyr3unitsutilised;
            }
            if (Convert.ToString(pacd.prefinacialyr3rateofunit) == "" || Convert.ToString(pacd.prefinacialyr3rateofunit) == null)
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr3rateofunit", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr3rateofunit", SqlDbType.VarChar).Value = pacd.prefinacialyr3rateofunit;
            }
            if (Convert.ToString(pacd.prefinacialyr3totpaid) == "" || Convert.ToString(pacd.prefinacialyr3totpaid) == null)
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr3totpaid", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@prefinacialyr3totpaid", SqlDbType.VarChar).Value = pacd.prefinacialyr3totpaid;
            }
            if (Convert.ToString(pacd.installcapcityem) == "" || Convert.ToString(pacd.installcapcityem) == null)
            {
                cmdpacd.Parameters.AddWithValue("@installcapcityem", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@installcapcityem", SqlDbType.VarChar).Value = pacd.installcapcityem;
            }
            if (Convert.ToString(pacd.yearofprior) == "" || Convert.ToString(pacd.yearofprior) == null)
            {
                cmdpacd.Parameters.AddWithValue("@yearofprior", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@yearofprior", SqlDbType.VarChar).Value = pacd.yearofprior;
            }
            if (Convert.ToString(pacd.rate75perofprod) == "" || Convert.ToString(pacd.rate75perofprod) == null)
            {
                cmdpacd.Parameters.AddWithValue("@rate75perofprod", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@rate75perofprod", SqlDbType.VarChar).Value = pacd.rate75perofprod;
            }
            if (Convert.ToString(pacd.unitsper75perprodn) == "" || Convert.ToString(pacd.unitsper75perprodn) == null)
            {
                cmdpacd.Parameters.AddWithValue("@unitsper75perprodn", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@unitsper75perprodn", SqlDbType.VarChar).Value = pacd.unitsper75perprodn;
            }
            if (Convert.ToString(pacd.totunitsconprior3yrs) == "" || Convert.ToString(pacd.totunitsconprior3yrs) == null)
            {
                cmdpacd.Parameters.AddWithValue("@totunitsconprior3yrs", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@totunitsconprior3yrs", SqlDbType.VarChar).Value = pacd.totunitsconprior3yrs;
            }
            if (Convert.ToString(pacd.averageunitsem) == "" || Convert.ToString(pacd.averageunitsem) == null)
            {
                cmdpacd.Parameters.AddWithValue("@averageunitsem", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@averageunitsem", SqlDbType.VarChar).Value = pacd.averageunitsem;
            }
            if (Convert.ToString(pacd.basepowconsfixperyr) == "" || Convert.ToString(pacd.basepowconsfixperyr) == null)
            {
                cmdpacd.Parameters.AddWithValue("@basepowconsfixperyr", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@basepowconsfixperyr", SqlDbType.VarChar).Value = pacd.basepowconsfixperyr;
            }
            if (Convert.ToString(pacd.basepowconfixpermonnth) == "" || Convert.ToString(pacd.basepowconfixpermonnth) == null)
            {
                cmdpacd.Parameters.AddWithValue("@basepowconfixpermonnth", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@basepowconfixpermonnth", SqlDbType.VarChar).Value = pacd.basepowconfixpermonnth;
            }
            if (Convert.ToString(pacd.noofclaims) == "" || Convert.ToString(pacd.noofclaims) == null)
            {
                cmdpacd.Parameters.AddWithValue("@noofclaims", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@noofclaims", SqlDbType.VarChar).Value = pacd.noofclaims;
            }
            if (Convert.ToString(pacd.powertraiffperunits) == "" || Convert.ToString(pacd.powertraiffperunits) == null)
            {
                cmdpacd.Parameters.AddWithValue("@powertraiffperunits", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@powertraiffperunits", SqlDbType.VarChar).Value = pacd.powertraiffperunits;
            }
            if (Convert.ToString(pacd.eglibleremperunits) == "" || Convert.ToString(pacd.eglibleremperunits) == null)
            {
                cmdpacd.Parameters.AddWithValue("@eglibleremperunits", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@eglibleremperunits", SqlDbType.VarChar).Value = pacd.eglibleremperunits;
            }
            if (Convert.ToString(pacd.grandtotalofclaims) == "" || Convert.ToString(pacd.grandtotalofclaims) == null)
            {
                cmdpacd.Parameters.AddWithValue("@grandtotalofclaims", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@grandtotalofclaims", SqlDbType.VarChar).Value = pacd.grandtotalofclaims;
            }
            if (Convert.ToString(pacd.sayinrs) == "" || Convert.ToString(pacd.sayinrs) == null)
            {
                cmdpacd.Parameters.AddWithValue("@sayinrs", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@sayinrs", SqlDbType.VarChar).Value = pacd.sayinrs;
            }
            if (Convert.ToString(pacd.belatedgrandtotofclaims) == "" || Convert.ToString(pacd.belatedgrandtotofclaims) == null)
            {
                cmdpacd.Parameters.AddWithValue("@belatedgrandtotofclaims", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@belatedgrandtotofclaims", SqlDbType.VarChar).Value = pacd.belatedgrandtotofclaims;
            }
            if (Convert.ToString(pacd.recombygmdic) == "" || Convert.ToString(pacd.recombygmdic) == null)
            {
                cmdpacd.Parameters.AddWithValue("@recombygmdic", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@recombygmdic", SqlDbType.VarChar).Value = pacd.recombygmdic;
            }
            if (Convert.ToString(pacd.eligiblevalue) == "" || Convert.ToString(pacd.eligiblevalue) == null)
            {
                cmdpacd.Parameters.AddWithValue("@eligiblevalue", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@eligiblevalue", SqlDbType.VarChar).Value = pacd.eligiblevalue;
            }
            if (Convert.ToString(pacd.remarks) == "" || Convert.ToString(pacd.remarks) == null)
            {
                cmdpacd.Parameters.AddWithValue("@remarks", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@remarks", SqlDbType.VarChar).Value = pacd.remarks;
            }
            if (Convert.ToString(pacd.createdby) == "" || Convert.ToString(pacd.createdby) == null)
            {
                cmdpacd.Parameters.AddWithValue("@createdby", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@createdby", SqlDbType.VarChar).Value = pacd.createdby;
            }
            if (Convert.ToString(pacd.createdip) == "" || Convert.ToString(pacd.createdip) == null)
            {
                cmdpacd.Parameters.AddWithValue("@createdip", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@createdip", SqlDbType.VarChar).Value = pacd.createdip;
            }
            if (Convert.ToString(pacd.grdtotAmountPaidasperbill) == "" || Convert.ToString(pacd.grdtotAmountPaidasperbill) == null)
            {
                cmdpacd.Parameters.AddWithValue("@grdtotAmountPaidasperbill", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@grdtotAmountPaidasperbill", SqlDbType.VarChar).Value = pacd.grdtotAmountPaidasperbill;
            }
            if (Convert.ToString(pacd.grdtotUnitsConsumedinNos) == "" || Convert.ToString(pacd.grdtotUnitsConsumedinNos) == null)
            {
                cmdpacd.Parameters.AddWithValue("@grdtotUnitsConsumedinNos", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@grdtotUnitsConsumedinNos", SqlDbType.VarChar).Value = pacd.grdtotUnitsConsumedinNos;
            }
            if (Convert.ToString(pacd.grdtotBasefixedpermonthinunits) == "" || Convert.ToString(pacd.grdtotBasefixedpermonthinunits) == null)
            {
                cmdpacd.Parameters.AddWithValue("@grdtotBasefixedpermonthinunits", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@grdtotBasefixedpermonthinunits", SqlDbType.VarChar).Value = pacd.grdtotBasefixedpermonthinunits;
            }
            if (Convert.ToString(pacd.grdtotEligibleUnitsoverabove) == "" || Convert.ToString(pacd.grdtotEligibleUnitsoverabove) == null)
            {
                cmdpacd.Parameters.AddWithValue("@grdtotEligibleUnitsoverabove", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdpacd.Parameters.AddWithValue("@grdtotEligibleUnitsoverabove", SqlDbType.VarChar).Value = pacd.grdtotEligibleUnitsoverabove;
            }
            cmdpacd.Parameters.Add("@APNo", SqlDbType.NVarChar, 500);
            cmdpacd.Parameters["@APNo"].Direction = ParameterDirection.Output;
            //cmdpacd.Parameters.AddWithValue("@Username", pacd.Username);
            //cmdpacd.Parameters.Add("@APNo", SqlDbType.NVarChar, 500);
            //cmdpacd.Parameters["@APNo"].Direction = ParameterDirection.Output;
            retValue = cmdpacd.ExecuteNonQuery();
            transaction.Commit();
            connection.Close();
            APNo = (string)cmdpacd.Parameters["@APNo"].Value;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            connection.Close();
        }
        return APNo;
    }


    public bool DB_insertappofincpowertariffclaimdetails(incpowertariffclaimdetailsproperties objclaim)
    {
        bool output = true;
        SqlConnection con = new SqlConnection(strConnectionString);
        try
        {
            SqlCommand cmdsrc1 = new SqlCommand("incpt_insertappofincpowertariffclaimdetails", con);
            if (Convert.ToString(objclaim.ClaimNo) == "" || Convert.ToString(objclaim.ClaimNo) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@ClaimNo", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@ClaimNo", Convert.ToString(objclaim.ClaimNo));
            }
            if (Convert.ToString(objclaim.DateoffillinginDIC) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@DateoffillinginDIC", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@DateoffillinginDIC", Convert.ToString(objclaim.DateoffillinginDIC));
            }
            if (Convert.ToString(objclaim.Endingdateofid) == "" || Convert.ToString(objclaim.Endingdateofid) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@Endingdateofid", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@Endingdateofid", Convert.ToString(objclaim.Endingdateofid));
            }
            if (Convert.ToString(objclaim.Endingdateof) == "" || Convert.ToString(objclaim.Endingdateof) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@Endingdateof", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@Endingdateof", Convert.ToString(objclaim.Endingdateof));
            }
            if (Convert.ToString(objclaim.HalfYeardate) == "" || Convert.ToString(objclaim.HalfYeardate) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@HalfYeardate", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@HalfYeardate", Convert.ToString(objclaim.HalfYeardate));
            }
            if (Convert.ToString(objclaim.Year) == "" || Convert.ToString(objclaim.Year) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@Year", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@Year", Convert.ToString(objclaim.Year));
            }
            if (Convert.ToString(objclaim.incpowrtariffid) == "" || Convert.ToString(objclaim.incpowrtariffid) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@incpowrtariffid", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@incpowrtariffid", Convert.ToString(objclaim.incpowrtariffid));
            }
            if (Convert.ToString(objclaim.TotalEliglibleamount) == "" || Convert.ToString(objclaim.TotalEliglibleamount) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@TotalEliglibleamount", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@TotalEliglibleamount", Convert.ToString(objclaim.TotalEliglibleamount));
            }
            if (Convert.ToString(objclaim.IsBelated) == "" || Convert.ToString(objclaim.IsBelated) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@IsBelated", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@IsBelated", Convert.ToString(objclaim.IsBelated));
            }
            if (Convert.ToString(objclaim.belatedtotEligibleamountReiembursement) == "" || Convert.ToString(objclaim.belatedtotEligibleamountReiembursement) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@belatedtotEligibleamountReiembursement", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@belatedtotEligibleamountReiembursement", Convert.ToString(objclaim.belatedtotEligibleamountReiembursement));
            }
            if (Convert.ToString(objclaim.Monthyear1) == "" || Convert.ToString(objclaim.Monthyear1) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@Monthyear1", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@Monthyear1", Convert.ToString(objclaim.Monthyear1));
            }
            if (Convert.ToString(objclaim.UnitsConsumedinNosMonthyear1) == "" || Convert.ToString(objclaim.UnitsConsumedinNosMonthyear1) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@UnitsConsumedinNosMonthyear1", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@UnitsConsumedinNosMonthyear1", Convert.ToString(objclaim.UnitsConsumedinNosMonthyear1));
            }
            if (Convert.ToString(objclaim.RateperUnitsMonthyear1) == "" || Convert.ToString(objclaim.RateperUnitsMonthyear1) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@RateperUnitsMonthyear1", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@RateperUnitsMonthyear1", Convert.ToString(objclaim.RateperUnitsMonthyear1));
            }
            if (Convert.ToString(objclaim.AmountPaidasperBillMonthyear1) == "" || Convert.ToString(objclaim.AmountPaidasperBillMonthyear1) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@AmountPaidasperBillMonthyear1", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@AmountPaidasperBillMonthyear1", Convert.ToString(objclaim.AmountPaidasperBillMonthyear1));
            }
            if (Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear1) == "" || Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear1) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@BasefixedpermonthinunitsMonthyear1", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@BasefixedpermonthinunitsMonthyear1", Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear1));
            }
            if (Convert.ToString(objclaim.EligibleUnitsBaseMonthyear1) == "" || Convert.ToString(objclaim.EligibleUnitsBaseMonthyear1) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleUnitsBaseMonthyear1", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleUnitsBaseMonthyear1", Convert.ToString(objclaim.EligibleUnitsBaseMonthyear1));
            }
            if (Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear1) == "" || Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear1) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleRateReimbursementperunitsMonthyear1", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleRateReimbursementperunitsMonthyear1", Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear1));
            }
            if (Convert.ToString(objclaim.EligibleamountReiembursementMonthyear1) == "" || Convert.ToString(objclaim.EligibleamountReiembursementMonthyear1) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleamountReiembursementMonthyear1", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleamountReiembursementMonthyear1", Convert.ToString(objclaim.EligibleamountReiembursementMonthyear1));
            }
            if (Convert.ToString(objclaim.Monthyear2) == "" || Convert.ToString(objclaim.Monthyear2) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@Monthyear2", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@Monthyear2", Convert.ToString(objclaim.Monthyear2));
            }
            if (Convert.ToString(objclaim.UnitsConsumedinNosMonthyear2) == "" || Convert.ToString(objclaim.UnitsConsumedinNosMonthyear2) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@UnitsConsumedinNosMonthyear2", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@UnitsConsumedinNosMonthyear2", Convert.ToString(objclaim.UnitsConsumedinNosMonthyear2));
            }
            if (Convert.ToString(objclaim.RateperUnitsMonthyear2) == "" || Convert.ToString(objclaim.RateperUnitsMonthyear2) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@RateperUnitsMonthyear2", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@RateperUnitsMonthyear2", Convert.ToString(objclaim.RateperUnitsMonthyear2));
            }
            if (Convert.ToString(objclaim.AmountPaidasperBillMonthyear2) == "" || Convert.ToString(objclaim.AmountPaidasperBillMonthyear2) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@AmountPaidasperBillMonthyear2", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@AmountPaidasperBillMonthyear2", Convert.ToString(objclaim.AmountPaidasperBillMonthyear2));
            }
           if (Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear2) == "" || Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear2) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@BasefixedpermonthinunitsMonthyear2", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@BasefixedpermonthinunitsMonthyear2", Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear2));
            }
            if (Convert.ToString(objclaim.EligibleUnitsBaseMonthyear2) == "" || Convert.ToString(objclaim.EligibleUnitsBaseMonthyear2) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleUnitsBaseMonthyear2", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleUnitsBaseMonthyear2", Convert.ToString(objclaim.EligibleUnitsBaseMonthyear2));
            }
            if (Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear2) == "" || Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear2) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleRateReimbursementperunitsMonthyear2", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleRateReimbursementperunitsMonthyear2", Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear2));
            }
            if (Convert.ToString(objclaim.EligibleamountReiembursementMonthyear2) == "" || Convert.ToString(objclaim.EligibleamountReiembursementMonthyear2) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleamountReiembursementMonthyear2", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleamountReiembursementMonthyear2", Convert.ToString(objclaim.EligibleamountReiembursementMonthyear2));
            }
            if (Convert.ToString(objclaim.Monthyear3) == "" || Convert.ToString(objclaim.Monthyear3) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@Monthyear3", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@Monthyear3", Convert.ToString(objclaim.Monthyear3));
            }
            if (Convert.ToString(objclaim.UnitsConsumedinNosMonthyear3) == "" || Convert.ToString(objclaim.UnitsConsumedinNosMonthyear3) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@UnitsConsumedinNosMonthyear3", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@UnitsConsumedinNosMonthyear3", Convert.ToString(objclaim.UnitsConsumedinNosMonthyear3));
            }
            if (Convert.ToString(objclaim.RateperUnitsMonthyear3) == "" || Convert.ToString(objclaim.RateperUnitsMonthyear3) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@RateperUnitsMonthyear3", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@RateperUnitsMonthyear3", Convert.ToString(objclaim.RateperUnitsMonthyear3));
            }
            if (Convert.ToString(objclaim.AmountPaidasperBillMonthyear3) == "" || Convert.ToString(objclaim.AmountPaidasperBillMonthyear3) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@AmountPaidasperBillMonthyear3", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@AmountPaidasperBillMonthyear3", Convert.ToString(objclaim.AmountPaidasperBillMonthyear3));
            }
            if (Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear3) == "" || Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear3) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@BasefixedpermonthinunitsMonthyear3", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@BasefixedpermonthinunitsMonthyear3", Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear3));
            }
            if (Convert.ToString(objclaim.EligibleUnitsBaseMonthyear3) == "" || Convert.ToString(objclaim.EligibleUnitsBaseMonthyear3) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleUnitsBaseMonthyear3", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleUnitsBaseMonthyear3", Convert.ToString(objclaim.EligibleUnitsBaseMonthyear3));
            }
            if (Convert.ToString(objclaim.EligibleamountReiembursementMonthyear3) == "" || Convert.ToString(objclaim.EligibleamountReiembursementMonthyear3) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleamountReiembursementMonthyear3", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleamountReiembursementMonthyear3", Convert.ToString(objclaim.EligibleamountReiembursementMonthyear3));
            }
            if (Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear3) == "" || Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear3) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleRateReimbursementperunitsMonthyear3", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleRateReimbursementperunitsMonthyear3", Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear3));
            }
            if (Convert.ToString(objclaim.Monthyear4) == "" || Convert.ToString(objclaim.Monthyear4) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@Monthyear4", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@Monthyear4", Convert.ToString(objclaim.Monthyear4));
            }
            if (Convert.ToString(objclaim.UnitsConsumedinNosMonthyear4) == "" || Convert.ToString(objclaim.UnitsConsumedinNosMonthyear4) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@UnitsConsumedinNosMonthyear4", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@UnitsConsumedinNosMonthyear4", Convert.ToString(objclaim.UnitsConsumedinNosMonthyear4));
            }
            if (Convert.ToString(objclaim.RateperUnitsMonthyear4) == "" || Convert.ToString(objclaim.RateperUnitsMonthyear4) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@RateperUnitsMonthyear4", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@RateperUnitsMonthyear4", Convert.ToString(objclaim.RateperUnitsMonthyear4));
            }
            if (Convert.ToString(objclaim.AmountPaidasperBillMonthyear4) == "" || Convert.ToString(objclaim.AmountPaidasperBillMonthyear4) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@AmountPaidasperBillMonthyear4", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@AmountPaidasperBillMonthyear4", Convert.ToString(objclaim.AmountPaidasperBillMonthyear4));
            }
            if (Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear4) == "" || Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear4) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@BasefixedpermonthinunitsMonthyear4", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@BasefixedpermonthinunitsMonthyear4", Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear4));
            }
            if (Convert.ToString(objclaim.EligibleUnitsBaseMonthyear4) == "" || Convert.ToString(objclaim.EligibleUnitsBaseMonthyear4) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleUnitsBaseMonthyear4", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleUnitsBaseMonthyear4", Convert.ToString(objclaim.EligibleUnitsBaseMonthyear4));
            }
            if (Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear4) == "" || Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear4) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleRateReimbursementperunitsMonthyear4", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleRateReimbursementperunitsMonthyear4", Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear4));
            }
            if (Convert.ToString(objclaim.EligibleamountReiembursementMonthyear4) == "" || Convert.ToString(objclaim.EligibleamountReiembursementMonthyear4) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleamountReiembursementMonthyear4", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleamountReiembursementMonthyear4", Convert.ToString(objclaim.EligibleamountReiembursementMonthyear4));
            }
            if (Convert.ToString(objclaim.Monthyear5) == "" || Convert.ToString(objclaim.Monthyear5) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@Monthyear5", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@Monthyear5", Convert.ToString(objclaim.Monthyear5));
            }
            if (Convert.ToString(objclaim.UnitsConsumedinNosMonthyear5) == "" || Convert.ToString(objclaim.UnitsConsumedinNosMonthyear5) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@UnitsConsumedinNosMonthyear5", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@UnitsConsumedinNosMonthyear5", Convert.ToString(objclaim.UnitsConsumedinNosMonthyear5));
            }
            if (Convert.ToString(objclaim.RateperUnitsMonthyear5) == "" || Convert.ToString(objclaim.RateperUnitsMonthyear5) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@RateperUnitsMonthyear5", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@RateperUnitsMonthyear5", Convert.ToString(objclaim.RateperUnitsMonthyear5));
            }
            if (Convert.ToString(objclaim.AmountPaidasperBillMonthyear5) == "" || Convert.ToString(objclaim.AmountPaidasperBillMonthyear5) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@AmountPaidasperBillMonthyear5", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@AmountPaidasperBillMonthyear5", Convert.ToString(objclaim.AmountPaidasperBillMonthyear5));
            }
            if (Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear5) == "" || Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear5) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@BasefixedpermonthinunitsMonthyear5", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@BasefixedpermonthinunitsMonthyear5", Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear5));
            }
            if (Convert.ToString(objclaim.EligibleUnitsBaseMonthyear5) == "" || Convert.ToString(objclaim.EligibleUnitsBaseMonthyear5) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleUnitsBaseMonthyear5", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleUnitsBaseMonthyear5", Convert.ToString(objclaim.EligibleUnitsBaseMonthyear5));
            }
            if (Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear5) == "" || Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear5) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleRateReimbursementperunitsMonthyear5", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleRateReimbursementperunitsMonthyear5", Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear5));
            }
            if (Convert.ToString(objclaim.EligibleamountReiembursementMonthyear5) == "" || Convert.ToString(objclaim.EligibleamountReiembursementMonthyear5) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleamountReiembursementMonthyear5", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleamountReiembursementMonthyear5", Convert.ToString(objclaim.EligibleamountReiembursementMonthyear5));
            }
            if (Convert.ToString(objclaim.Monthyear6) == "" || Convert.ToString(objclaim.Monthyear6) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@Monthyear6", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@Monthyear6", Convert.ToString(objclaim.Monthyear6));
            }
            if (Convert.ToString(objclaim.UnitsConsumedinNosMonthyear6) == "" || Convert.ToString(objclaim.UnitsConsumedinNosMonthyear6) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@UnitsConsumedinNosMonthyear6", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@UnitsConsumedinNosMonthyear6", Convert.ToString(objclaim.UnitsConsumedinNosMonthyear6));
            }
            if (Convert.ToString(objclaim.RateperUnitsMonthyear6) == "" || Convert.ToString(objclaim.RateperUnitsMonthyear6) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@RateperUnitsMonthyear6", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@RateperUnitsMonthyear6", Convert.ToString(objclaim.RateperUnitsMonthyear6));
            }
            if (Convert.ToString(objclaim.AmountPaidasperBillMonthyear6) == "" || Convert.ToString(objclaim.AmountPaidasperBillMonthyear6) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@AmountPaidasperBillMonthyear6", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@AmountPaidasperBillMonthyear6", Convert.ToString(objclaim.AmountPaidasperBillMonthyear6));
            }
            if (Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear6) == "" || Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear6) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@BasefixedpermonthinunitsMonthyear6", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@BasefixedpermonthinunitsMonthyear6", Convert.ToString(objclaim.BasefixedpermonthinunitsMonthyear6));
            }
            if (Convert.ToString(objclaim.EligibleUnitsBaseMonthyear6) == "" || Convert.ToString(objclaim.EligibleUnitsBaseMonthyear6) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleUnitsBaseMonthyear6", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleUnitsBaseMonthyear6", Convert.ToString(objclaim.EligibleUnitsBaseMonthyear6));
            }
            if (Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear6) == "" || Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear6) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleRateReimbursementperunitsMonthyear6", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleRateReimbursementperunitsMonthyear6", Convert.ToString(objclaim.EligibleRateReimbursementperunitsMonthyear6));
            }
            if (Convert.ToString(objclaim.EligibleamountReiembursementMonthyear6) == "" || Convert.ToString(objclaim.EligibleamountReiembursementMonthyear6) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleamountReiembursementMonthyear6", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@EligibleamountReiembursementMonthyear6", Convert.ToString(objclaim.EligibleamountReiembursementMonthyear6));
            }
            if (Convert.ToString(objclaim.Createdby) == "" || Convert.ToString(objclaim.Createdby) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@Createdby", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@Createdby", Convert.ToString(objclaim.Createdby));
            }
            if (Convert.ToString(objclaim.createdip) == "" || Convert.ToString(objclaim.createdip) == null)
            {
                cmdsrc1.Parameters.AddWithValue("@createdip", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                cmdsrc1.Parameters.AddWithValue("@createdip", Convert.ToString(objclaim.createdip));
            }
            cmdsrc1.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmdsrc1.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            output = false;
        }

        return output;
    }


    public DataSet DB_getappofincpowertariffbyuseridincentiveid(string createdby, string IncentiveID)
    {
        SqlConnection con = new SqlConnection(strConnectionString);
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        try
        {
            con.Open();
            da = new SqlDataAdapter("incpt_getappofincpowertariffbyuseridincentiveid", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (Convert.ToString(createdby) == null)
            {
                da.SelectCommand.Parameters.Add("@createdby", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                da.SelectCommand.Parameters.Add("@createdby", SqlDbType.VarChar).Value = createdby;
            }
            if (Convert.ToString(IncentiveID) == null)
            {
                da.SelectCommand.Parameters.Add("@IncentiveID", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                da.SelectCommand.Parameters.Add("@IncentiveID", SqlDbType.VarChar).Value = IncentiveID;
            }
            da.Fill(ds);
            return ds;

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    public DataSet DB_getappofincpowertariffclaimdetailsbyincpowrtariffid(string incpowrtariffid)
    {
        SqlConnection con = new SqlConnection(strConnectionString);
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        try
        {
            con.Open();
            da = new SqlDataAdapter("incpt_getappofincpowertariffclaimdetailsbyincpowrtariffid", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (Convert.ToString(incpowrtariffid) == null)
            {
                da.SelectCommand.Parameters.Add("@incpowrtariffid", SqlDbType.VarChar).Value = DBNull.Value;
            }
            else
            {
                da.SelectCommand.Parameters.Add("@incpowrtariffid", SqlDbType.VarChar).Value = incpowrtariffid;
            }
            da.Fill(ds);
            return ds;

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    //public DataSet DB_insertnswscafdatacfedata(string intUserid)
    //{
    //    SqlConnection con = new SqlConnection(strConnectionString);
    //    SqlDataAdapter da;
    //    DataSet ds = new DataSet();
    //    try
    //    {
    //        con.Open();
    //        da = new SqlDataAdapter("nsws_datatocfeques", con);
    //        da.SelectCommand.CommandType = CommandType.StoredProcedure;
    //        da.SelectCommand.Parameters.Add("@intUserid", SqlDbType.VarChar).Value = intUserid;
    //        da.Fill(ds);
    //        return ds;

    //    }
    //    catch (Exception ex)
    //    {
    //        throw ex;
    //    }
    //    finally
    //    {
    //        con.Close();
    //    }
    //}

}

public class incpowertariffproperties
{
    public int incpowrtariffid { get; set; }
    public string fileno { get; set; }
    public DateTime dateingmoffice { get; set; }
    public string filenoheadoffice { get; set; }
    public string eligibleno { get; set; }
    public string invst_subfileno { get; set; }
    public string nameoftheunit { get; set; }
    public string addressoftheunit { get; set; }
    public string constitutiooftheindustry { get; set; }
    public string constitID { get; set; }
    public string IncentiveID { get; set; }
    public string socialstatus { get; set; }
    public int socialstatusid { get; set; }
    public string nemeproppartnrmpmd { get; set; }
    public string schemename { get; set; }
    public string schemeID { get; set; }
    public string SSIregiemlno { get; set; }
    public DateTime dateapp { get; set; }
    public string lineofactivity { get; set; }
    public string lineofactivityid { get; set; }
    public string units { get; set; }
    public int capcity { get; set; }
    public string unittype { get; set; }
    public string unittypeid { get; set; }
    public DateTime dateofcommesemetofprodn { get; set; }
    public string nameoffinancinginstituition { get; set; }
    public string fixedassetsLandname { get; set; }
    public int landapprovedprocst { get; set; }
    public int landexistprocst { get; set; }
    public int landinvstprocst { get; set; }
    public string fixedassestsbuildingname { get; set; }
    public int buildingapprovedprocst { get; set; }
    public int buildingexistprocst { get; set; }
    public int buildinginvstprocst { get; set; }
    public string fixedassestsplantmcname { get; set; }
    public int plantmcapprovedprocst { get; set; }
    public int plantmcexistprocst { get; set; }
    public int plantmcinvstprocst { get; set; }
    public int fixedassesttotapprovedprocst { get; set; }
    public int fixedassestexistprocst { get; set; }
    public int fixedassestinvstprocst { get; set; }
    public int installcappriorofed { get; set; }
    public int installcapundered { get; set; }
    public decimal perincinvstundered { get; set; }
    public decimal perinccapundered { get; set; }
    public decimal existingpowerinhp { get; set; }
    public decimal newpowerconkva { get; set; }
    public DateTime dateofnewconrelased { get; set; }
    public string serviceconnno { get; set; }
    public string prefinacialyr1 { get; set; }
    public int prefinacialyt1unitsutilised { get; set; }
    public decimal prefinacialyr1rateofunit { get; set; }
    public decimal prefinacialyr1totpaid { get; set; }
    public string prefinacialyr2 { get; set; }
    public int prefinacialyr2unitsutilised { get; set; }
    public decimal prefinacialyr2rateofunit { get; set; }
    public decimal prefinacialyr2totpaid { get; set; }
    public string prefinacialyr3 { get; set; }
    public int prefinacialyr3unitsutilised { get; set; }
    public decimal prefinacialyr3rateofunit { get; set; }
    public decimal prefinacialyr3totpaid { get; set; }
    public int installcapcityem { get; set; }
    public int yearofprior { get; set; }
    public decimal rate75perofprod { get; set; }
    public decimal unitsper75perprodn { get; set; }
    public decimal totunitsconprior3yrs { get; set; }
    public decimal averageunitsem { get; set; }
    public decimal basepowconsfixperyr { get; set; }
    public decimal basepowconfixpermonnth { get; set; }
    public int noofclaims { get; set; }
    public decimal powertraiffperunits { get; set; }
    public decimal eglibleremperunits { get; set; }
    public decimal grandtotalofclaims { get; set; }
    public decimal sayinrs { get; set; }
    public decimal belatedgrandtotofclaims { get; set; }
    public decimal recombygmdic { get; set; }
    public string eligiblevalue { get; set; }
    public string remarks { get; set; }
    public string createdby { get; set; }
    public DateTime createdon { get; set; }
    public string createdip { get; set; }
    public string modifiedby { get; set; }
    public DateTime modifiedon { get; set; }
    public string modifiedip { get; set; }
    public decimal grdtotUnitsConsumedinNos { get; set; }
    public decimal grdtotAmountPaidasperbill { get; set; }
    public decimal grdtotBasefixedpermonthinunits { get; set; }
    public decimal grdtotEligibleUnitsoverabove { get; set; }

}


public class incpowertariffclaimdetailsproperties
{
    public int incpowertariffclaimid   { get; set; }
    public int ClaimNo   { get; set; }
    public DateTime DateoffillinginDIC   { get; set; }
    public string Endingdateofid   { get; set; }
    public string Endingdateof    { get; set; }
    public string HalfYeardate { get; set; }
    public string Year { get; set; }
    public int incpowrtariffid { get; set; }
    public string TotalEliglibleamount { get; set; }
    public bool IsBelated     { get; set; }
    public decimal belatedtotEligibleamountReiembursement { get; set; }
    public string Monthyear1  { get; set; }
    public decimal UnitsConsumedinNosMonthyear1 { get; set; }
    public decimal RateperUnitsMonthyear1   { get; set; }
    public decimal AmountPaidasperBillMonthyear1 { get; set; }
    public decimal BasefixedpermonthinunitsMonthyear1 { get; set; }
    public decimal EligibleUnitsBaseMonthyear1 { get; set; }
    public decimal EligibleRateReimbursementperunitsMonthyear1 { get; set; }
    public decimal EligibleamountReiembursementMonthyear1 { get; set; }
    public string Monthyear2  { get; set; }
    public decimal UnitsConsumedinNosMonthyear2 { get; set; }
    public decimal RateperUnitsMonthyear2 { get; set; }
    public decimal AmountPaidasperBillMonthyear2 { get; set; }
    public decimal BasefixedpermonthinunitsMonthyear2 { get; set; }
    public decimal EligibleUnitsBaseMonthyear2 { get; set; }
    public decimal EligibleRateReimbursementperunitsMonthyear2 { get; set; }
    public decimal EligibleamountReiembursementMonthyear2 { get; set; }
    public string Monthyear3  { get; set; }
    public decimal UnitsConsumedinNosMonthyear3 { get; set; }
    public decimal RateperUnitsMonthyear3 { get; set; }
    public decimal AmountPaidasperBillMonthyear3 { get; set; }
    public decimal BasefixedpermonthinunitsMonthyear3 { get; set; }
    public decimal EligibleUnitsBaseMonthyear3 { get; set; }
    public decimal EligibleRateReimbursementperunitsMonthyear3 { get; set; }
    public decimal EligibleamountReiembursementMonthyear3 { get; set; }
    public string Monthyear4  { get; set; }
    public decimal UnitsConsumedinNosMonthyear4 { get; set; }
    public decimal RateperUnitsMonthyear4 { get; set; }
    public decimal AmountPaidasperBillMonthyear4 { get; set; }
    public decimal BasefixedpermonthinunitsMonthyear4 { get; set; }
    public decimal EligibleUnitsBaseMonthyear4 { get; set; }
    public decimal EligibleRateReimbursementperunitsMonthyear4 { get; set; }
    public decimal EligibleamountReiembursementMonthyear4 { get; set; }
    public string Monthyear5  { get; set; }
    public decimal UnitsConsumedinNosMonthyear5 { get; set; }
    public decimal RateperUnitsMonthyear5 { get; set; }
    public decimal AmountPaidasperBillMonthyear5 { get; set; }
    public decimal BasefixedpermonthinunitsMonthyear5 { get; set; }
    public decimal EligibleUnitsBaseMonthyear5 { get; set; }
    public decimal EligibleRateReimbursementperunitsMonthyear5 { get; set; }
    public decimal EligibleamountReiembursementMonthyear5 { get; set; }
    public string Monthyear6  { get; set; }
    public decimal UnitsConsumedinNosMonthyear6 { get; set; }
    public decimal RateperUnitsMonthyear6 { get; set; }
    public decimal AmountPaidasperBillMonthyear6 { get; set; }
    public decimal BasefixedpermonthinunitsMonthyear6 { get; set; }
    public decimal EligibleUnitsBaseMonthyear6 { get; set; }
    public decimal EligibleRateReimbursementperunitsMonthyear6 { get; set; }
    public decimal EligibleamountReiembursementMonthyear6 { get; set; }
    public string Createdby   { get; set; }
    public DateTime Createdon { get; set; }
    public string createdip   { get; set; }
    public string modifiedby  { get; set; }
    public DateTime modifiedon { get; set; }
    public string modifiedip  { get; set; }
    public bool isactive { get; set; }

}