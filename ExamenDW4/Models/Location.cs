using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenDW4.Models
{
    [PrimaryKey(nameof(AppartementID), nameof(LocataireID), nameof(DateDebut))]
    public class Location
    {
        public int AppartementID { get; set; }
        public int LocataireID { get; set; }
        public required Appartement Appartement { get; set; }
        public required Locataire Locataire { get; set; }
        public required int LoyerMensuel { get; set; }
        [Column(TypeName = "date")]
        public required DateTime DateDebut { get; set; }
        [Column(TypeName = "date")]
        public required DateTime DateFin { get; set; }



    }
}
