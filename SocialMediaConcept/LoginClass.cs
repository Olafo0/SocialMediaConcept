using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaConcept
{
    public class LoginClass
    {
        public string? LoginUsername { get; set; }
        public string? LoginPassword { get; set; }

        public LoginClass(string? LoginUsername, string? LoginPassword)
        {
            this.LoginUsername = LoginUsername;
            this.LoginPassword = LoginPassword;
        }

        public LoginClass()
        {

        }
    }
}
