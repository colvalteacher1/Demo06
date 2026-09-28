using Demo06.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo06.Controllers
{
    public class HomeController : Controller
    {
        private readonly Colvalteacher4205w6Context context;

        public HomeController(Colvalteacher4205w6Context _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            return View(context.People.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
