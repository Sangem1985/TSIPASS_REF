using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Data;


/// <summary>
/// Summary description for Cls_NSWSKeyCloak
/// </summary>
public class Cls_NSWSKeyCloak
{
    string url = "http://103.154.75.191:8080/realms/TSIPASS_NSWS/protocol/openid-connect/token";
    string accessToken = "";
    public Cls_NSWSKeyCloak()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    private void CallUATToken()
    {
        try
        {
            //string clientId = "your_client_id";
            // string clientSecret = "your_client_secret";
            string apiUrl = url + "token";

            using (var client = new HttpClient())
            {
                //string credentials = clientId + ":" + clientSecret;
                //byte[] credentialsBytes = Encoding.ASCII.GetBytes(credentials);
                //string base64Credentials = Convert.ToBase64String(credentialsBytes);
                // string base64Credentials = "ME4wUDBtQm1NdGVGcTNZX1c5cjdZRkxQZWswYTpwQmVWd3hzTjdJWnVfcEdKUzk1MFZoUmxjQVlh";
                //string base64Credentials = "N0ZHUFV1cUZBX0NTSGF3V29sZVBmTlB2aXh3YTp5N2tfbXFOMlJtUFdBZ3J1R0Rwc0l0bW4yS0lh";

                //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", base64Credentials);

                var postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
                postData.Add(new KeyValuePair<string, string>("username", "userpri-client"));
                postData.Add(new KeyValuePair<string, string>("password", "WpyXnvLMdG0amzfPCFxlK1S33DqWQYEw"));

                var content = new FormUrlEncodedContent(postData);
                LogErrorFile.LogData(content.ToString());
                var response = client.PostAsync(apiUrl, content).Result;
                LogErrorFile.LogData(response.ToString());
                var result = response.Content.ReadAsStringAsync().Result;
                dynamic json = JsonConvert.DeserializeObject(result);
                LogErrorFile.LogData(result.ToString());
                accessToken = json.access_token;
                LogErrorFile.LogData("1");
                LogErrorFile.LogData(accessToken);
                // Store or use the access token as needed
            }
        }
        catch (Exception ex)
        {
           // GetCINResponse(ex.ToString());
            LogErrorFile.LogData("errortoken" + ex.ToString());
        }
    }
}