using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UserInfo
    {
        private string clientname;
        private string email;

        public string ClientName
            {
            set { clientname = value; }
            get { return clientname; }
            }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public UserInfo()
        {
            ClientName = "";

            Email = "";

        }

       public UserInfo (string Uemail, string Uclientname)
        {
            ClientName = Uclientname;
            Email = Uemail;
        }

    }
}