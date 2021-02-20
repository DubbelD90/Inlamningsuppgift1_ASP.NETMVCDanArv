using Inlamningsuppgift1_ASP.NETMVC.Data;
using Inlamningsuppgift1_ASP.NETMVC.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_ASP.NETMVC.Services.Identity
{
    public class IdentityService : IIdentityService
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IdentityService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public async Task CreateRootAccountAsync()
        {
            if (!_userManager.Users.Any())
            {
                var user = new ApplicationUser() { 
                    UserName = "admin@domain.com",
                    FirstName = "Admin",
                    LastName = "Account",
                    Email = "admin@domain.com",
                    DateOfBirth = DateTime.Now
                };
                var result = await _userManager.CreateAsync(user, "BytMig123!");

                if (result.Succeeded)
                {
                    if (!_roleManager.Roles.Any())
                    {
                        await _roleManager.CreateAsync(new IdentityRole("Admin"));
                        await _roleManager.CreateAsync(new IdentityRole("Teacher"));
                        await _roleManager.CreateAsync(new IdentityRole("Student"));
                    }
                    await _userManager.AddToRoleAsync(user, "Admin");
                }
            }
        }


        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            return _userManager.Users;
        }

        public async Task<IEnumerable<UserViewModel>> GetAllUsersWithRoleAsync()
        {
            var users = GetAllUsers();
            var userlist = new List<UserViewModel>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                var role = roles.FirstOrDefault();

                userlist.Add(new UserViewModel
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Role = role
                });

            }
            return userlist;
        }
        

    }
}
