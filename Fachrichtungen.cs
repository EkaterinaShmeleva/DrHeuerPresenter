using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DrHeuerVorstellung.Models
{
    public class Fachrichtungen
    {
        //public int Id { get; set; }

        public List<SelectListItem> Fachrichtung = new List<SelectListItem>()
        {
            new SelectListItem { Text = "Anwendungsentwicklung", Value = "ae"},
            new SelectListItem { Text = "Systemintegration", Value = "si"}
        };
    }
}
