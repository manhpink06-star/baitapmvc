using Microsoft.AspNetCore.Mvc;

namespace baitapmvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}