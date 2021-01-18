using System;
using BLL.DTOs.SystemUser;
using BLL.Interfaces;
using LawSuits.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Service.Contracts;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;

namespace LawSuits.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<SystemUser> _userManager;

        public AdminController(UserManager<SystemUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index() {
            return View(_userManager.Users);
        }

        public IActionResult CreateUser() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDTO model) {
            if (ModelState.IsValid) {
                SystemUser user = new SystemUser(){
                    UserName = model.UserName,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                };

                IdentityResult result = await _userManager.CreateAsync(user, model.Password); 
                if (result.Succeeded) {
                    return RedirectToAction(nameof(Index));
                } else {
                    foreach(IdentityError error in result.Errors) {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }
    }
}
