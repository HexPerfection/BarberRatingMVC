using ItKariera.Data;
using ItKariera.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItKariera.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ReviewsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var reviews = await _context.Reviews
                .Include(r => r.Barber)
                .Where(r => r.UserId == userId)
                .ToListAsync();

            return View(reviews);
        }

        // GET: Reviews/Create/5
        public async Task<IActionResult> Create(int id)
        {
            var barber = await _context.Barbers.FindAsync(id);
            if (barber == null)
            {
                return NotFound();
            }

            ViewData["BarberName"] = barber.Name;

            var review = new Review
            {
                BarberId = barber.Id
            };

            return View(review);
        }

        // POST: Reviews/Create/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Content,Rating,BarberId")] Review review)
        {
            review.UserId = _userManager.GetUserId(User);
            review.CreatedAt = DateTime.Now;

            _context.Add(review);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Barbers");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            if (review == null || review.UserId != _userManager.GetUserId(User))
            {
                return NotFound();
            }

            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .Include(r => r.Barber)
                .FirstOrDefaultAsync(r => r.Id == id && r.UserId == _userManager.GetUserId(User));

            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // POST: Review/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Content,Rating,BarberId")] Review review)
        {
            if (id != review.Id)
            {
                return NotFound();
            }

            try
            {
                review.UserId = _userManager.GetUserId(User); // Ensure the user ID is set correctly
                review.CreatedAt = DateTime.Now;
                _context.Update(review);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReviewExists(review.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));


        }

        private bool ReviewExists(int id)
        {
            return _context.Reviews.Any(e => e.Id == id);
        }
    }
}