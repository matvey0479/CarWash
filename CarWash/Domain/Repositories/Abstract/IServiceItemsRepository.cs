using CarWash.Domain.Entites;

namespace CarWash.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItem(string title);
        void AddServiceItem(ServiceItem serviceItem);
        void DeleteServiceItem(string title);
    }
}
