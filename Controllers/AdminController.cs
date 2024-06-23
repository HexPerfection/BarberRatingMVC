using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ItKariera.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using ItKariera.Data;

namespace ItKariera.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        public ContentViewModel UsersBarbersReviews { get; set; }

        public AdminController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            var barbers = await _context.Barbers.ToListAsync();
            var reviews = await _context.Reviews.ToListAsync();

            UsersBarbersReviews = new ContentViewModel { Users = users, Barbers = barbers, Reviews = reviews };
            

            return View(UsersBarbersReviews);
        }

        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }


        [HttpPost]
        public async Task<IActionResult> EditUser(ApplicationUser user)
        {
            var existingUser = await _userManager.FindByIdAsync(user.Id);
            if (existingUser == null)
            {
                return NotFound();
            }

            existingUser.UserName = user.UserName;
            existingUser.FirstName = user.FirstName;
            existingUser.LastName = user.LastName;

            var result = await _userManager.UpdateAsync(existingUser);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(user);
        }

        public async Task<IActionResult> EditBarber(int id)
        {
            var barber = await _context.Barbers.FindAsync(id);
            if (barber == null)
            {
                return NotFound();
            }

            return View(barber);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBarber(Barber barber, IFormFile profilePicture)
        {
            var existingBarber = await _context.Barbers.FindAsync(barber.Id);
            if (existingBarber == null)
            {
                return NotFound();
            }

            existingBarber.Name = barber.Name;
            existingBarber.Description = barber.Description;

            // Update profile picture if a new one is uploaded
            if (profilePicture != null && profilePicture.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    await profilePicture.CopyToAsync(ms);
                    var fileBytes = ms.ToArray();
                    existingBarber.ProfilePicture = "data:image/jpeg;base64," + Convert.ToBase64String(fileBytes);
                }
            }

            _context.Barbers.Update(existingBarber);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return RedirectToAction("Index");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteBarber(int id)
        {
            var barber = await _context.Barbers.Where(b => b.Id == id).FirstOrDefaultAsync();
            if (barber == null)
            {
                return NotFound();
            }

            var result = _context.Barbers.Remove(barber);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // Add User
        public IActionResult AddUser()
        {
            return View(new ApplicationUser());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUser(ApplicationUser user, string password)
        {
            if (ModelState.IsValid)
            {              
                var result = await _userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(user);
        }

        // Add Barber
        public IActionResult AddBarber()
        {
            return View(new Barber());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBarber(Barber barber, IFormFile profilePicture)
        {

            if (profilePicture != null && profilePicture.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    await profilePicture.CopyToAsync(ms);
                    var fileBytes = ms.ToArray();
                    barber.ProfilePicture = "data:image/jpeg;base64," + Convert.ToBase64String(fileBytes);
                }
            }
            _context.Barbers.Add(barber);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // Edit Review
        public async Task<IActionResult> EditReview(int id)
        {
            var review = await _context.Reviews.Include(r => r.Barber).FirstOrDefaultAsync(r => r.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            review.User = await _userManager.FindByIdAsync(review.UserId);

            return View(review);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditReview([Bind("Id,Content,Rating,BarberId")] Review review)
        {
            var existingReview = await _context.Reviews.FindAsync(review.Id);
            if (existingReview == null)
            {
                return NotFound();
            }

            existingReview.Content = review.Content;
            existingReview.CreatedAt = DateTime.Now;

            _context.Reviews.Update(existingReview);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteReview(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }

            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
