using ExamenDW4.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamenDW4.Data
{
    public class Donnees
    {
        public async static Task Charger(Bails bails)
        {
            await bails.Database.MigrateAsync();

            if (await bails.Appartements.AnyAsync())
            {
                return;
            }

            var app20 = new Appartement()
            {
                Numero = 20,
                Surface = 600,
                Meuble = true,
                TypeAppartement = TypeAppartement.Loft
            };

            var app30 = new Appartement()
            {
                Numero = 30,
                Surface = 700,
                Meuble = true,
                TypeAppartement = TypeAppartement.Studio
            };

            var app40 = new Appartement()
            {
                Numero = 40,
                Surface = 800,
                Meuble = false,
                TypeAppartement = TypeAppartement.Studio
            };

            var app50 = new Appartement()
            {
                Numero = 50,
                Surface = 750,
                Meuble = false,
                TypeAppartement = TypeAppartement.Penthouse
            };


            var alexandre = new Locataire()
            {
                Nom = "Robitaille",
                Prenom = "Alexandre"
            };

            var mariesoleil = new Locataire()
            {
                Nom = "Dionne",
                Prenom = "Marie-Soleil"
            };

            var deborah = new Locataire()
            {
                Nom = "Guenova",
                Prenom = "Deborah"
            };

            var location1 = new Location()
            {
                Appartement = app30,
                Locataire = alexandre,
                LoyerMensuel = 1200,
                DateDebut = new DateTime(2023, 01, 01),
                DateFin = new DateTime(2024, 06, 30)
            };

            var location2 = new Location()
            {
                Appartement = app40,
                Locataire = deborah,
                LoyerMensuel = 1600,
                DateDebut = new DateTime(2022, 04, 01),
                DateFin = new DateTime(2024, 06, 30)
            };

            var location3 = new Location()
            {
                Appartement = app50,
                Locataire = mariesoleil,
                LoyerMensuel = 1100,
                DateDebut = new DateTime(2021, 11, 01),
                DateFin = new DateTime(2022, 10, 30)
            };
        }
    }
}
