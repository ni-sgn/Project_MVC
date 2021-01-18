using BLL.DTOs.LawSuit;
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

        [HttpPost]
        public IActionResult Index(string StatusType)
        {

            LawSuitListVM model = new LawSuitListVM()
            {
                LawSuits = _lawSuitOperations.GetByStatusType(StatusType)
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

        public IActionResult Update(int Id)
        {
            var lawsuit = _lawSuitOperations.GetLawSuit(Id);
            var model = GetCreateLawSuitModel(lawsuit);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(LawSuitCUVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(GetCreateLawSuitModel(model.LawSuit));
            }
            _lawSuitOperations.UpdateLawSuit(model.LawSuit);

            var viewModel = GetCreateLawSuitModel(model.LawSuit);
            ViewBag.Message = "Lawsuit Data Update Successful";
            return View(viewModel);
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

        public IActionResult Delete(int Id)
        {
            _lawSuitOperations.DeleteLawSuit(Id);
            return RedirectToAction(nameof(Index));
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
