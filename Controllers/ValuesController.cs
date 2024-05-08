using LoginWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Web.UI.WebControls;
using Login = LoginWebApi.Models.Login;
using System.Configuration;
using System.Data.SqlClient;


namespace LoginWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {

        }

         [Route("api/values/GetLogin")]
         [HttpPost]
         public HttpResponseMessage GetLogin(HttpRequestMessage request, Login login)
         {
                HttpResponseMessage response = new HttpResponseMessage();
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebApiCon"].ConnectionString);
                SqlDataAdapter adapter = null;
                DataTable dt = new DataTable();

                if (login != null)
                {
                    try
                    {
                        conn.Open();
                    adapter = new SqlDataAdapter("SELECT * FROM tblAdminLogin WHERE Email=@Username AND Password=@Password", conn);
                        adapter.SelectCommand.Parameters.AddWithValue("@Username", login.Username);
                        adapter.SelectCommand.Parameters.AddWithValue("@Password", login.Password);
                        adapter.Fill(dt);
                    if(login.Username!=null && login.Password!=null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            response = request.CreateResponse(HttpStatusCode.OK, new { statuscode = true, statusmsg = "Logged in" });
                        }
                        else
                        {
                            response = request.CreateResponse(HttpStatusCode.Unauthorized, new { statuscode = false, statusmsg = "Login failed: Invalid username or password" });
                        }
                        
                    }
                    else
                    {
                        response = request.CreateResponse(HttpStatusCode.InternalServerError, new { statuscode = false, statusmsg = "Some Error !!!" });
                    }
                       
                    }
                    catch (Exception ex)
                    {
                        response = request.CreateResponse(HttpStatusCode.InternalServerError, new { statuscode = false, statusmsg = "Some Error !!! " + ex.Message });
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, new { statuscode = false, statusmsg = "Error: Invalid login data" });
                }

                return response;
            }
        
    }
}
