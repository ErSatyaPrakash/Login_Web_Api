using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoginWebApi.Models
{
    public class dbLayers
    {
        //public HttpResponseMessage GetLogin(HttpRequestMessage request, Login login)
        //{
        //    HttpResponseMessage response = new HttpResponseMessage();
        //    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebApiCon"].ConnectionString);
        //    SqlDataAdapter adapter = null;
        //    DataTable dt = new DataTable();

        //    if (login != null)
        //    {
        //        try
        //        {
        //            conn.Open();
        //            adapter = new SqlDataAdapter("SELECT * FROM tbl_users WHERE Username=@Username AND Password=@Password", conn);
        //            adapter.SelectCommand.Parameters.AddWithValue("@Username", login.Username);
        //            adapter.SelectCommand.Parameters.AddWithValue("@Password", login.Password);
        //            adapter.Fill(dt);

        //            if (dt.Rows.Count > 0)
        //            {
        //                response = request.CreateResponse(HttpStatusCode.OK, new { statuscode = true, statusmsg = "Logged in" });
        //            }
        //            else
        //            {
        //                response = request.CreateResponse(HttpStatusCode.Unauthorized, new { statuscode = false, statusmsg = "Login failed: Invalid username or password" });
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            response = request.CreateResponse(HttpStatusCode.InternalServerError, new { statuscode = false, statusmsg = "Error: " + ex.Message });
        //        }
        //        finally
        //        {
        //            conn.Close();
        //        }
        //    }
        //    else
        //    {
        //        response = request.CreateResponse(HttpStatusCode.BadRequest, new { statuscode = false, statusmsg = "Error: Invalid login data" });
        //    }

        //    return response;
        //}
    }
}
