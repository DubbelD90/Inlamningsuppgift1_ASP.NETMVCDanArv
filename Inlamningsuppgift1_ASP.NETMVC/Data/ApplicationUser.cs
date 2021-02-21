using Inlamningsuppgift1_ASP.NETMVC.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_ASP.NETMVC.Data
{
    public class ApplicationUser : IdentityUser
    {

        [Required]
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }

        [Required]
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

        [Required]
        [PersonalData]
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }


        public string GetDisplayName()
        {
            return $"{FirstName} {LastName}";
        }

        public string DisplayName => $"{FirstName} {LastName}";

    }
}
