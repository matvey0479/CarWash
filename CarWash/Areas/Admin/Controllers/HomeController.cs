using Microsoft.AspNetCore.Mvc;
using CarWash.Domain;


namespace CarWash.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class HomeController : Controller
    {

        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;

        }
        public IActionResult Index()
        {
            var appointments = dataManager.appointments.GetAppointments();
            return View(appointments);
        }
    }
}
