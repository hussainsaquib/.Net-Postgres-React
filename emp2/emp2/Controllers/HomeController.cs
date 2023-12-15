using Dapper;
using emp2.Models;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System.Diagnostics;
//hello this is to test

namespace emp2.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Hello()
        {
            return View();
        }
        public IActionResult Employee()
        {
            using (var connection = new NpgsqlConnection("Host=localhost;Username=postgres;password=Saqu123#;Database=Employees"))
            {
                //connection.Open();
                var query = "SELECT * FROM employee";
             
                
            return Ok(connection.Query<Employee>(query));
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}