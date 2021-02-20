using Inlamningsuppgift1_ASP.NETMVC.Areas.Identity.Pages.Account.Manage;
using Inlamningsuppgift1_ASP.NETMVC.Data;
using Inlamningsuppgift1_ASP.NETMVC.Models;
using Inlamningsuppgift1_ASP.NETMVC.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_ASP.NETMVC.Controllers
{

    [Authorize(Roles = "Admin")]

    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IIdentityService _identityService;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<DeletePersonalDataModel> _logger;


        public UsersController(UserManager<ApplicationUser> userManager, IIdentityService identityService, RoleManager<IdentityRole> roleManager, ILogger<DeletePersonalDataModel> logger)
        {
            _userManager = userManager;
            _identityService = identityService;
            _roleManager = roleManager;
            _logger = logger;
        }

        public async Task<ActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            var userViewModel = new List<ApplicationUser>();
            foreach (ApplicationUser user in users)
            {
                var thisViewModel = new UserViewModel
                {
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Roles = await GetUserRoles(user)
                };
                userViewModel.Add(thisViewModel);
            }

            return View(users);
        }
        private async Task<List<string>> GetUserRoles(ApplicationUser user)
        {
            return new List<string>(await _userManager.GetRolesAsync(user));
        }

        // GET: UsersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Delete/5
        public async Task <ActionResult> Delete(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            return View();
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var result = await _userManager.DeleteAsync(user);

            var userId = await _userManager.GetUserIdAsync(user);
            if (!result.Succeeded)
            {
                throw new InvalidOperationException($"Unexpected error occurred deleting user with ID '{userId}'.");
            }

            _logger.LogInformation("Deleted '{UserId}'.", userId);

            return View();

        }

        public async Task<IActionResult> AllStudentsList()
        {

            ViewBag.Users = await _identityService.GetAllUsersWithRoleAsync();
            return View();


        }            

    }
}






