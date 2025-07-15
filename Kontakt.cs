using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrHeuerVorstellung.Models
{
    public class Kontakt
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Vorname { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        public string? Nachricht { get; set; }

        [Required]
        public bool ZustimmungDSGVO { get; set; }

        public string? SelectedUmschulung { get; set; }

        public string? SelectedStandort { get; set; }
    }

}
