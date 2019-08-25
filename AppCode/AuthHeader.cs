using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace ServicesTest.AppCode
{
    public class AuthHeader:SoapHeader
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string IP { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(this.IP))
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                return false;
            }
            return true;
        }
    }
}