using CarWash.Domain.Entites;

namespace CarWash.Domain.Repositories.Abstract
{
    public interface IAppointmentsRepository
    {
        IQueryable<Appointment> GetAppointments();
        List<Appointment> GetAppointmentsByClient(Client client);
        List<Appointment> GetAppointmentsByDate(DateOnly date);

        void AddAppointment(Appointment appointment);
        void DeleteAppointment(int id);

    }
}
