using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Meublé")]
        public required bool Meuble { get; set; }
        [Display(Name = "Type d'appartement")]
        public required TypeAppartement TypeAppartement { get; set; }
        public List<Location> Locations { get; set; } = new();
    }
}
