using Class07.App.Models;
using System.Collections.Generic;
using Class07.App.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Class07.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Ensure the view always receives a non-null list
            var students = new List<StudentVM>();
            return View(students);
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
