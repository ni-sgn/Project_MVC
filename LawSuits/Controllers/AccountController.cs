using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using DAL.Entities;
using BLL.DTOs.SystemUser;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace LawSuits.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<SystemUser> _userManager;
        private SignInManager<SystemUser> _singInManager;

        public AccountController(UserManager<SystemUser> userManager, SignInManager<SystemUser> singInManager)
        {
            _userManager = userManager;
            _singInManager = singInManager;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                SystemUser user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await _singInManager.PasswordSignInAsync(user, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        return Redirect(returnUrl ?? "/");
                    }
                }
                ModelState.AddModelError("", "Invalid Email Or Password");
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _singInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

    }
}
