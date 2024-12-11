using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Exercice.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Exercice.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        // Afficher la liste des utilisateurs
        public async Task<IActionResult> Index()
        {
            var users = await _context.User.Include(u => u.UserProfile).ToListAsync();
            return View(users);
        }

        // Afficher les détails d'un utilisateur
        public async Task<IActionResult> Details(int id)
        {
            var user = await _context.User
                .Include(u => u.UserProfile)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // Rechercher des utilisateurs par biographie
        public async Task<IActionResult> Search(string keyword)
        {
            var users = await _context.User
                .Include(u => u.UserProfile)
                .Where(u => u.UserProfile.Biography.Contains(keyword))
                .ToListAsync();

            return View(users);
        }
    }
}
