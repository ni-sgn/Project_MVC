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
    public class PersonController : Controller
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonOperations _personOperations;
        private readonly ILawSuitOperations _lawSuitOperations;
        private readonly ISystemUserOperations _systemUserOperations;

        public PersonController(ILogger<PersonController> logger, IPersonOperations personOperations, ILawSuitOperations lawSuitOperations, ISystemUserOperations systemUserOperations)
        {
            _logger = logger;
            _personOperations = personOperations;
            _lawSuitOperations = lawSuitOperations;
            _systemUserOperations = systemUserOperations;
        }

        public IActionResult Index()
        {

            PersonListVM model = new PersonListVM()
            {
                People = _personOperations.GetAll()
            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
