using BLL.DTOs.Person;
using BLL.Interfaces;
using LawSuits.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LawSuits.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonOperations _personOperations;
        private readonly ILawSuitOperations _lawSuitOperations;

        public HomeController(ILogger<HomeController> logger, IPersonOperations personOperations, ILawSuitOperations lawSuitOperations)
        {
            _logger = logger;
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
