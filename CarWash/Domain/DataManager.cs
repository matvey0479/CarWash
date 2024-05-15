using CarWash.Domain.Repositories.Abstract;
namespace CarWash.Domain
{
    public class DataManager
    {
        public IClientsRepository clients { get; set; }
        public IServiceItemsRepository serviceItems { get; set; }
        public IFreeTimesRepository freeTimes { get; set; }
        public IAppointmentsRepository appointments { get; set; }
        public ITakenTimeRepository takenTimes { get; set; }
        public DataManager(IClientsRepository clients, IServiceItemsRepository serviceItems, IFreeTimesRepository freeTimes, IAppointmentsRepository appointments, ITakenTimeRepository takenTimes)
        {
            this.clients = clients;
            this.serviceItems = serviceItems;
            this.freeTimes = freeTimes;
            this.appointments = appointments;
            this.takenTimes = takenTimes;
        }
    }
}
