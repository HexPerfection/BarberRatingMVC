using Microsoft.AspNetCore.Mvc;

namespace ItKariera.Models
{
    public class ContentViewModel : Controller
    {
        public IList<ApplicationUser> Users { get; set; }
        public IList<Barber> Barbers { get; set; }

        public IList<Review> Reviews { get; set; }
    }
}
