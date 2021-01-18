using BLL.DTOs.LawSuit;
using BLL.Interfaces;
using LawSuits.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LawSuits.Controllers
{
    public class LawSuitController : Controller
    { 
        private readonly ILawSuitOperations _lawSuitOperations;

        public LawSuitController(ILawSuitOperations lawSuitOperations)
        {
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

        public IActionResult Create()
        {
            var model = GetCreateLawSuitModel(new LawSuitCUDTO());
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(LawSuitCUVM model)
        {
            if(!ModelState.IsValid)
            {
                View(GetCreateLawSuitModel(new LawSuitCUDTO()));
            }
            _lawSuitOperations.CreateLawSuit(model.LawSuit);
            return RedirectToAction(nameof(Index));
        }

        private LawSuitCUVM GetCreateLawSuitModel(LawSuitCUDTO lawsuit)
        {
            LawSuitCUVM model = new LawSuitCUVM()
            {
                LawSuit = lawsuit,
                Components = _lawSuitOperations.GetLawSuitCUComponents(),
            };
            return model;
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
