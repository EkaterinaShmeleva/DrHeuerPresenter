using DrHeuerVorstellung.Models;
using Microsoft.AspNetCore.Mvc;


namespace DrHeuerVorstellung.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult DetailsPartial(string typ)
        {
            var course = new Course();

            if (typ == "umschulung")
            {
                course.Description = "Der Beruf des Fachinformatikers enthält ein breites Spektrum an interessanten " +
                    "und anspruchsvollen Aufgaben. Zu den typischen Tätigkeiten eines Fachinformatikers gehören z. B. die Planung, " +
                    "Beschaffung und Einrichtung der IT-Ausstattung für Unternehmen.";
            }
            else if (typ == "weiterbildung")
            {
                course.Description = "Unsere IT-Weiterbildungen bieten praxisnahe Inhalte und ermöglichen den Erwerb von " +
                    "anerkannten Hersteller-Zertifikaten wie Microsoft, Cisco, AWS oder CompTIA.";
            }
            else
            {
                return Content("");
            }

            return PartialView("_CourseSummaryPartial", course);
        }

    }
}
