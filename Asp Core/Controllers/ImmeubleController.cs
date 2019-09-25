using Gestion_Location.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_Location.Controllers
{
    public class ImmeubleController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddImmeuble([FromBody] Immeuble immeuble)
        {
            return RedirectToAction("Index");
        }
    }
}