using DrHeuerVorstellung.Data;
using DrHeuerVorstellung.Models;
using DrHeuerVorstellung.Services;
using DrHeuerVorstellung.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DrHeuerVorstellung.Controllers
{
    public class KontaktController : Controller
    {
        private readonly IUmschulungService _umschulungService;
        private readonly IStandortService _standortService;
        private readonly IKontaktService _kontaktService;

        public KontaktController(
            IUmschulungService umschulungService,
            IStandortService standortService,
            IKontaktService kontaktService)
        {
            _umschulungService = umschulungService;
            _standortService = standortService;
            _kontaktService = kontaktService;
        }

        [HttpGet]
        public IActionResult Formular()
        {
            var model = new KontaktViewModel
            {
                Standorte = _standortService.GetStandorte()
                    .Select(s => new SelectListItem { Value = s, Text = s }).ToList(),

                Umschulungen = _umschulungService.GetUmschulungen()
                    .Select(u => new SelectListItem { Value = u, Text = u }).ToList()
            };

            return View(model);
        }

        public IActionResult Bestaetigung()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Formular(KontaktViewModel model)
        {
            if (ModelState.IsValid)
            {
                _kontaktService.SpeichereKontakt(model);
                return RedirectToAction("Bestaetigung");
            }

            // Wenn nicht valid, Listen erneut befüllen:
            model.Standorte = _standortService.GetStandorte()
                .Select(s => new SelectListItem { Value = s, Text = s }).ToList();

            model.Umschulungen = _umschulungService.GetUmschulungen()
                .Select(u => new SelectListItem { Value = u, Text = u }).ToList();

            return View(model);
        }
    }
}

