using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Inlamningsuppgift1_ASP.NETMVC.Data;
using Inlamningsuppgift1_ASP.NETMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Inlamningsuppgift1_ASP.NETMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ClassesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ClassesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: Classes
        public async Task<IActionResult> Index()
        {
            await _userManager.Users.ToListAsync();
            return View(await _context.Classes.ToListAsync());
        }

        // GET: Classes/Details/5
        public async Task<IActionResult> Details(string id, ViewClassModel model)
        {

            var schoolClass = await _context.Classes.FirstOrDefaultAsync(m => m.Id == id);
            var students = await _userManager.GetUsersInRoleAsync("Student");

            var users = await _context.Users.ToListAsync();

            var viewModel = new ViewClassModel
            {
                Id = schoolClass.Id,
                Teacher = schoolClass.Teacher,
                Students = students
            };

            return View(viewModel);
        }

        // GET: Classes/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.Teachers = await _userManager.GetUsersInRoleAsync("Teacher");

            return View();
        }

        // POST: Classes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClassName,TeacherId,Created")] SchoolClass schoolClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schoolClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(schoolClass);
        }

        // GET: Classes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {

            //ViewBag.Teachers = await _userManager.GetUsersInRoleAsync("Teacher");
            //var students = await _userManager.GetUsersInRoleAsync("Student");

            var schoolClass = await _context.Classes.FindAsync(id);
            var students = await _userManager.GetUsersInRoleAsync("Student");

            if (schoolClass == null)
            {
                return NotFound();
            }

            var model = new List<AddUserModel>();

            foreach (var student in students)
            {

                var addStudentModel = new AddUserModel
                {
                    UserId = student.Id,
                    UserName = student.UserName
                };

                addStudentModel.IsSelected = false;
                model.Add(addStudentModel);
            }
            return View(model);
        }

        // POST: Classes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id")] SchoolClass schoolClass, List<AddUserModel> model)
        {
            if (ModelState.IsValid)
            {
                for (int i = 0; i < model.Count; i++)
                {
                    var student = await _userManager.FindByIdAsync(model[i].UserId);

                    if (model[i].IsSelected)
                    {
                        schoolClass.Students.Add(student);
                        _context.Classes.Update(schoolClass);
                        _context.SaveChanges();
                    }
                }


                return RedirectToAction(nameof(Index));
            }
            return View(schoolClass);
        }

        //GET: Classes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schoolClass = await _context.Classes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schoolClass == null)
            {
                return NotFound();
            }

            return View(schoolClass);
        }

        // POST: Classes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var schoolClass = await _context.Classes.FindAsync(id);
            _context.Classes.Remove(schoolClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchoolClassExists(string id)
        {
            return _context.Classes.Any(e => e.Id == id);
        }

        // GET: Classes/Edit/5
        public async Task<IActionResult> AddTeacher(string id)
        {

            if (id == null)
            {
                return NotFound();
            }

            ViewBag.Teachers = await _userManager.GetUsersInRoleAsync("Teacher");
            return View();
        }

        // POST: Classes/Edit/5
        [HttpPost]
        public async Task<IActionResult> AddTeacher(string id, [Bind("Id")] SchoolClass schoolClass, AddTeacherModel model)
        {
            if (ModelState.IsValid)
            {
                var teacher = await _userManager.FindByIdAsync(model.Teacher);
                schoolClass.Teacher = teacher;
                _context.Classes.Update(schoolClass);
                _context.Entry(schoolClass).State = EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction("Index", "Classes");

            }
            return View(schoolClass);
        }
    }
}
