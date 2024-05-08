using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginWebApi.Models
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool statuscode { get; set; }
        public string statusmsg { get; set; }
        
    }
   
}