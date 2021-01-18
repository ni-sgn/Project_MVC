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
using Microsoft.AspNetCore.Authorization;


namespace LawSuits.Controllers
{
    [Authorize]
    public class PersonController : Controller
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonOperations _personOperations;
        private readonly ILawSuitOperations _lawSuitOperations;

        public PersonController(ILogger<PersonController> logger, IPersonOperations personOperations, ILawSuitOperations lawSuitOperations)
        {
            _logger = logger;
            _personOperations = personOperations;
            _lawSuitOperations = lawSuitOperations;
        }

        public IActionResult Index()
        {
            PersonListVM model = new PersonListVM()
            {
                People = _personOperations.GetAll()
            };
            return View(model);
        }

        public IActionResult Create()
        {
            var model = GetCreatePersonModel(new PersonCUDTO());
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(PersonCUVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(GetCreatePersonModel(model.Person));
            }
            _personOperations.CreatePerson(model.Person);
            return RedirectToAction(nameof(Index));
        }

        
        public IActionResult Update(int id)
        {
            var person = _personOperations.GetPerson(id);
            var model = GetCreatePersonModel(person);
            return View(model);
        }
        
        [HttpPost]
        public IActionResult Update(PersonCUVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(GetCreatePersonModel(model.Person));
            }
            _personOperations.UpdatePerson(model.Person);

            var viewModel = GetCreatePersonModel(model.Person);
            ViewBag.Message = "Person Data Update Successful";
            return View(viewModel);
        }

        private PersonCUVM GetCreatePersonModel(PersonCUDTO person)
        {
            PersonCUVM model = new PersonCUVM()
            {
                Components = _personOperations.GetPersonFormComponents(),
                Person = person
            };
            return model;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
