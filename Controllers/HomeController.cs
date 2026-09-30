using baitapmvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace baitapmvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Weekend()
        {
            DateTime today = DateTime.Now;

            int dayNumber = (int)today.DayOfWeek;

            var dayInfo = await _context.NgayTrongTuan
                .FirstOrDefaultAsync(x => x.DayNumber == dayNumber);

            ViewBag.Today = today;

            return View(dayInfo);
        }
    }
}