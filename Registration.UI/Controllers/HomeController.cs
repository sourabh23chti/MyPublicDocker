using IdentityService.Controllers;
using Microsoft.AspNetCore.Mvc;
using Registration.UI.Models;
using System.Diagnostics;

namespace Registration.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AuthApiController _controller;

        public HomeController(ILogger<HomeController> logger,AuthApiController controller)
        {
            _logger = logger;
            _controller = controller;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Register";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        { 
         var result=  _controller.Login();
          return View();
        }

        
        public IActionResult RegistrationForm()
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
