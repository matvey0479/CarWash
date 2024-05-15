using Microsoft.EntityFrameworkCore;
using CarWash.Domain.Repositories.Abstract;
using CarWash.Domain.Entites;

namespace CarWash.Domain.Repositories.EntityFramework
{
    public class EFServiceItemsRepository:IServiceItemsRepository
    {
        private readonly AppDbContext context;
        public EFServiceItemsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<ServiceItem> GetServiceItems()
        {
            return context.ServiceItems;
        }
        public ServiceItem GetServiceItem(string title)
        {
            return context.ServiceItems.FirstOrDefault(x => x.Title == title);
        }
        public void AddServiceItem(ServiceItem serviceItem)
        {
            context.ServiceItems.Add(serviceItem);
            context.SaveChanges();
        }
        public void DeleteServiceItem(string title)
        {
            context.ServiceItems.Remove(GetServiceItem(title));
            context.SaveChanges();
        }
  

    }
}
