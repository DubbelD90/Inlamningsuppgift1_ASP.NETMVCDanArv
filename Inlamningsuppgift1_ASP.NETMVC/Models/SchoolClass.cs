using Inlamningsuppgift1_ASP.NETMVC.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_ASP.NETMVC.Models
{
    public class SchoolClass
    {
        [Required]
        [Key]
        public string Id { get; set; }

        public ApplicationUser Teacher { get; set; }

        public ICollection<ApplicationUser> Students { get; set; }

        public SchoolClass(string id)
        {
            Id = id;
        }

        public SchoolClass()
        {
            Students = new HashSet<ApplicationUser>();
        }
    }
}