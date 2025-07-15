namespace DrHeuerVorstellung.Models
{
    public class Fachrichtung
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public ICollection<StandortFachrichtung> StandortFachrichtungen { get; set; } = new List<StandortFachrichtung>();
    }

}
