using ExamenDW4.Data;
using ExamenDW4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamenDW4.Controllers
{
    public class AppartementController : Controller
    {
        private readonly Bails _bails;

        public AppartementController(Bails bails)
        {
            _bails= bails;
        }
        public async Task<IActionResult> Index()
        {
            var appartement = await _bails.Appartements.ToListAsync();
            return View(appartement);
        }

        public async Task<IActionResult> Modification(int id)
        {
            var appartement = await _bails.Appartements.FindAsync(id);

            if (appartement != null)
            {
                return View(appartement);
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Modification(int id, Appartement donnees)
        {
            if (!ModelState.IsValid)
            {
                return View(donnees);
            }

            var appartement = await _bails.Appartements.FindAsync(id);

            if (appartement != null)
            {
                
                appartement.Numero = donnees.Numero;
                appartement.Surface = donnees.Surface;
                appartement.Meuble = donnees.Meuble;
                appartement.TypeAppartement = donnees.TypeAppartement;

                await _bails.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return NotFound();
        }
    }
}
