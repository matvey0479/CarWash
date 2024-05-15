using CarWash.Domain.Entites;

namespace CarWash.Domain.Repositories.Abstract
{
    public interface IClientsRepository
    {
        IQueryable<Client> GetClients();
        Client GetClient(string phoneNumber);
        void AddClient(Client client);
        void DeleteClient(string phoneNumber);
    }
}
