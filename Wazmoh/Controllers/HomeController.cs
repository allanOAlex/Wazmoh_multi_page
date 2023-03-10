using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Wazmoh.Models;

namespace Wazmoh.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.ActionName = "Index";
            return View();
        }

        public IActionResult Company()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Recognition()
        {
            return View();
        }

        public IActionResult WhatsApp()
        {
            string url = "https://web.whatsapp.com/";
            return Redirect(url);
        }

        public IActionResult Facebook()
        {
            string url = "https://www.facebook.com/";
            return Redirect(url);
        }

        public IActionResult Twitter()
        {
            string url = "https://twitter.com/";
            return Redirect(url);
        }

        public IActionResult Instagram()
        {
            string url = "https://www.instagram.com/";
            return Redirect(url);
        }

        public IActionResult LinkedIn()
        {
            string url = "https://www.linkedin.com/";
            return Redirect(url);
        }

        public IActionResult Email()
        {
            string url = "mailto:allan.alex0803@gmail.com";
            return Redirect(url);
        }

        public IActionResult GitHub()
        {
            string url = "https://github.com/allanOAlex";
            return Redirect(url);
        }

        public IActionResult AuthorProfile()
        {
            string url = "";
            return Redirect(url);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}