using ExamenDW4.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamenDW4.Data
{
    public class Donnees
    {
        public async static Task Charger(Bails bails)
        {
            await bails.Database.MigrateAsync();

            //if (await bails.Appartements.AnyAsync())
            //{
            //    return;
            //}

            //var app20 = new Appartement()
            //{
            //    Numero = 20,
            //    Surface = 600,
            //    Meuble = true,
            //    Type = Models.Type.Loft
            //};

            //var app30 = new Appartement()
            //{
            //    Numero = 30,
            //    Surface = 700,
            //    Meuble = true,
            //    Type = Models.Type.Studio
            //};

            //var app40 = new Appartement()
            //{
            //    Numero = 40,
            //    Surface = 800,
            //    Meuble = false,
            //    Type = Models.Type.Studio
            //};

            //var app50 = new Appartement()
            //{
            //    Numero = 50,
            //    Surface = 750,
            //    Meuble = false,
            //    Type = Models.Type.Penthouse
            //};


            //var alexandre = new Locataire()
            //{
            //    Nom = "Robitaille",
            //    Prenom = "Alexandre"
            //};

            //var mariesoleil = new Locataire()
            //{
            //    Nom = "Dionne",
            //    Prenom = "Marie-Soleil"
            //};

            //var deborah = new Locataire()
            //{
            //    Nom = "Guenova",
            //    Prenom = "Deborah"
            //};

            //var location1 = new Location() 
            //{
                
            //}

        }
    }
}
