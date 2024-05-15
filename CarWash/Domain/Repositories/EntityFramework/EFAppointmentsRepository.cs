using Microsoft.EntityFrameworkCore;
using CarWash.Domain.Repositories.Abstract;
using CarWash.Domain.Entites;
using System.Threading.Tasks;

namespace CarWash.Domain.Repositories.EntityFramework
{
    public class EFAppointmentsRepository:IAppointmentsRepository
    {
        private readonly AppDbContext context;
        public EFAppointmentsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<Appointment> GetAppointments()
        {
            return context.Appointments.Include(x=>x.Client).Include(x=>x.ServiceItem).Include(x=>x.time);
        }
        public List<Appointment> GetAppointmentsByClient(Client client)
        {
            List<Appointment> appointments = new List<Appointment>();
            foreach(var appointment in context.Appointments)
            {
                if(appointment.Client==client)
                    appointments.Add(appointment);
            }
            return appointments;
        }
        public List<Appointment> GetAppointmentsByDate(DateOnly date)
        {
            List<Appointment> appointments = new List<Appointment>();
            foreach (var appointment in context.Appointments)
            { 
                if (appointment.time.Date == date)
                    appointments.Add(appointment);
            }
            return appointments;
        }
        public void AddAppointment(Appointment appointment)
        {
            context.Appointments.Add(appointment);
            context.SaveChanges();
        }
        public void DeleteAppointment(int id)
        {
            context.Appointments.Remove(new Appointment { Id = id });
            context.SaveChanges();
        }
    }
}
