using Inlamningsuppgift1_ASP.NETMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_ASP.NETMVC.Models
{
    public class ViewClassModel
    {
        public string Id { get; set; }
        public ApplicationUser Teacher { get; set; }
        public ICollection<ApplicationUser> Students { get; set; }
    }
}
