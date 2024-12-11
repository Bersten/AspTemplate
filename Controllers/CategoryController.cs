using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Exercice.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Exercice.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categories.ToListAsync();
            return View(categories);
        }

        // Afficher les détails d'une catégorie avec ses produits
        public async Task<IActionResult> Details(int id)
        {
            var category = await _context.Categories
                .Include(c => c.Products)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // Récupérer les catégories avec au moins un produit dont le prix dépasse un montant donné
        public async Task<IActionResult> CategoriesWithExpensiveProducts(decimal price)
        {
            var categories = await _context.Categories
                .Where(c => c.Products.Any(p => p.Price > price))
                .Include(c => c.Products)
                .ToListAsync();

            return View(categories);
        }
    }
}
