using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrHeuerVorstellung.Models
{
    public class KontaktViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name ist erforderlich")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Vorname ist erforderlich")]
        public string? Vorname { get; set; }

        [Required(ErrorMessage = "E-Mail ist erforderlich")]
        [EmailAddress(ErrorMessage = "Ungültige E-Mail-Adresse")]
        public string? Email { get; set; }

        public string? Nachricht { get; set; }

        [Required(ErrorMessage = "Bitte bestätigen Sie die Datenschutzerklärung")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Bitte akzeptieren Sie die DSGVO.")]
        public bool ZustimmungDSGVO { get; set; }

        public List<SelectListItem>? Standorte { get; set; }

        public List<SelectListItem>? Umschulungen { get; set; }

        public string? SelectedUmschulung { get; set; }

        public string? SelectedStandort { get; set; }
    }
}
