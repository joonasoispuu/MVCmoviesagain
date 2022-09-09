using Microsoft.AspNetCore.Mvc;

namespace MVCmovies.Controllers
{
    public class OispuuController : Controller
    {
        public IActionResult Oispuu(int? id)
        {
            ViewData["vanus"] = id;
            return View();
        }
    }
}
