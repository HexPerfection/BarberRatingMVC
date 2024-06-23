using ItKariera.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItKariera.Controllers
{
    public class BarbersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BarbersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Barber
        public async Task<IActionResult> Index(string searchString)
        {
            var barbers = from b in _context.Barbers
                          select b;

            if (!string.IsNullOrEmpty(searchString))
            {
                barbers = barbers.Where(b => b.Name.Contains(searchString));
            }

            return View(await barbers.ToListAsync());
        }
    }
}
