using DrHeuerVorstellung.Models;
using DrHeuerVorstellung.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DrHeuerVorstellung.Controllers
{
    public class KategorienController : Controller
    {
        private readonly IUmschulungService _umschulungService;

        public KategorienController(IUmschulungService umschulungService)
        {
            _umschulungService = umschulungService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(); // enthält die flex-box Ansicht
        }

        [HttpGet]
        public IActionResult DetailsPartial(string typ)
        {
            var model = new KategorieViewModel();

            switch (typ.ToLower())
            {
                case "umschulung":
                    model.Name = "Umschulung";
                    model.Description = "Verkürzte Ausbildung mit IHK-Abschluss, ideal für Quereinsteiger.";
                    break;

                case "weiterbildung":
                    model.Name = "Weiterbildung";
                    model.Description = "Zertifizierte Kurse für Fachkräfte – von Netzwerken bis Datenbanken.";
                    break;

                default:
                    model.Name = "Unbekannt";
                    model.Description = "Keine Informationen verfügbar.";
                    break;
            }

            return PartialView("_KategorieDetails", model);
        }
    }
}
