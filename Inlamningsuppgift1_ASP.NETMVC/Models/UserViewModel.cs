using Inlamningsuppgift1_ASP.NETMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_ASP.NETMVC.Models
{
    public class UserViewModel : ApplicationUser
    {
        public IEnumerable<string> Roles { get; set; }

        public string Role { get; set; }
    }
}
