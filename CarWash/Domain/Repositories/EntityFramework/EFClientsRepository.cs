using Microsoft.EntityFrameworkCore;
using CarWash.Domain.Repositories.Abstract;
using CarWash.Domain.Entites;

namespace CarWash.Domain.Repositories.EntityFramework
{
    public class EFClientsRepository:IClientsRepository
    {
        private readonly AppDbContext context;
        public EFClientsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<Client> GetClients()
        {
            return context.clients;
        }
        public Client GetClient(string phoneNumber)
        {
            return context.clients.FirstOrDefault(x => x.PhoneNumper == phoneNumber);
        }
        public void AddClient(Client client)
        {
            if (context.clients.All(x=>x.PhoneNumper!=client.PhoneNumper))
                context.clients.Add(client);
            context.SaveChanges();
        }
        public void DeleteClient(string phoneNumber)
        {
            context.clients.Remove(GetClient(phoneNumber));
            context.SaveChanges();
        }
    }
}
