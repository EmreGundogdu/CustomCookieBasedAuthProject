using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomCookieBased.Data
{
    public class AppRole
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public List<AppUserRole> AppUserRoles { get; set; }
    }
}
