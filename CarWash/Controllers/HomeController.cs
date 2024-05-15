using Microsoft.AspNetCore.Mvc;
using CarWash.Models;
using CarWash.Domain;
using CarWash.Domain.Entites;

namespace CarWash.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
