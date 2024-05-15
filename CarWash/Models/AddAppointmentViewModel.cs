using System.ComponentModel.DataAnnotations;
using CarWash.Domain.Entites;

namespace CarWash.Models
{
    public class AddAppointmentViewModel
    {

        public Client client { get; set; }
        public ServiceItem serviceItem { get; set; }
        public FreeTime freeTime { get; set; }
        public Appointment appointment { get; set; }
        public IQueryable<Client> clients { get; set; }
        public IQueryable<FreeTime> freeTimes { get; set; }
        public IQueryable<ServiceItem> serviceItems { get; set; }
        public IQueryable<Appointment> appointments { get; set; }

        public AddAppointmentViewModel()
        {

        }


    }
}
