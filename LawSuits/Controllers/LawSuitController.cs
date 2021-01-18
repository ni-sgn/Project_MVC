using BLL.Interfaces;
using LawSuits.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace LawSuits.Controllers
{
    [Authorize]
    public class LawSuitController : Controller
    { 
        private readonly IPersonOperations _personOperations;
        private readonly ILawSuitOperations _lawSuitOperations;

        public LawSuitController(IPersonOperations personOperations, ILawSuitOperations lawSuitOperations)        
        {
            _personOperations = personOperations;
            _lawSuitOperations = lawSuitOperations;
        }

        public IActionResult Index()
        {

            LawSuitListVM model = new LawSuitListVM()
            {
                LawSuits = _lawSuitOperations.GetAll()
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
