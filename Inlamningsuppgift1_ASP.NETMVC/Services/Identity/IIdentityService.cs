using Inlamningsuppgift1_ASP.NETMVC.Data;
using Inlamningsuppgift1_ASP.NETMVC.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_ASP.NETMVC.Services
{
    public interface IIdentityService
    {
        Task CreateRootAccountAsync();
        IEnumerable<ApplicationUser> GetAllUsers();
        Task<IEnumerable<UserViewModel>> GetAllUsersWithRoleAsync();
    }
}
