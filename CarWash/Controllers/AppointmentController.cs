using Microsoft.AspNetCore.Mvc;
using CarWash.Models;
using CarWash.Domain;
using CarWash.Domain.Entites;
using DateOnlyTimeOnly.AspNet.Converters;

namespace CarWash.Controllers
{
    
    public class AppointmentController : Controller
    {
        private readonly DataManager dataManager;

        AddAppointmentViewModel model = new AddAppointmentViewModel();
 
        public AppointmentController(DataManager dataManager)
        {
            this.dataManager = dataManager;

        }

        public IActionResult Index()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            DateOnly date = new DateOnly(year, month, day);
            model.freeTimes = dataManager.freeTimes.GetFreeTimes(date);
            model.serviceItems = dataManager.serviceItems.GetServiceItems();
            return View(model);
        }

        public IActionResult ShowFreeTime (DateOnly date)
        {
            model.freeTimes = dataManager.freeTimes.GetFreeTimes(date);
            return PartialView("_ShowFreeTimePartialView", model);
        }

        public IActionResult AddAppointment(Client client, ServiceItem serviceItem,FreeTime freeTime,DateOnly date)
        {
            dataManager.clients.AddClient(client);
            FreeTime fTime = dataManager.freeTimes.GetFreeTime(date, freeTime.Time);
            TakenTime tTime = new TakenTime { Date = fTime.Date, Time = fTime.Time };
            dataManager.takenTimes.AddTakenTime(tTime);
            ServiceItem service = dataManager.serviceItems.GetServiceItem(serviceItem.Title);
            dataManager.appointments.AddAppointment(new Appointment { Client = dataManager.clients.GetClient(client.PhoneNumper), ServiceItem = service, time = tTime });
            dataManager.freeTimes.DeleteFreeTime(fTime.Id);
            return RedirectToAction("Index", "Home");
        }
        
    }
}
