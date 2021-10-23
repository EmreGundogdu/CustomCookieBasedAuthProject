using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomCookieBased.Models
{
    public class UserSignInModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
