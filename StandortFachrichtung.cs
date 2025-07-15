namespace DrHeuerVorstellung.Models
{
    public class StandortFachrichtung
    {
        public int StandortId { get; set; }
        public Standort Standort { get; set; } = null!;

        public int FachrichtungId { get; set; }
        public Fachrichtung Fachrichtung { get; set; } = null!;
    }

}
