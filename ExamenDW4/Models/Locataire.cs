namespace ExamenDW4.Models
{
    public class Locataire
    {
        public int ID { get; set; }
        public required string Nom { get; set; }
        public required string Prenom { get; set; }
        public List<Location> Locations { get; set; } = new();
    }
}
