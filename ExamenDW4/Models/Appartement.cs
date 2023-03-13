namespace ExamenDW4.Models
{
    public enum TypeAppartement
    {
        Loft,
        Studio,
        Penthouse
    }
    public class Appartement
    {
        public int ID { get; set; }
        public required int Numero { get; set; }
        public required int Surface { get; set; }
        public required bool Meuble { get; set; }
        public required TypeAppartement TypeAppartement { get; set; }
        public List<Location> Locations { get; set; } = new();
    }
}
