using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomCookieBased.Data
{
    public class AppUserRole
    {
        public int UserId { get; set; }
        public AppUser AppUser { get; set; }
        public int RoleId { get; set; }
        public AppRole AppRole { get; set; }
        
    }
}
