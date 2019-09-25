using Microsoft.AspNetCore.Mvc;

namespace Gestion_Location.Controllers
{
    public class LocataireController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}