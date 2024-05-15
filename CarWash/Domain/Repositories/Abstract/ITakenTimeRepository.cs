using CarWash.Domain.Entites;

namespace CarWash.Domain.Repositories.Abstract
{
    public interface ITakenTimeRepository
    {
        IQueryable<TakenTime> GetTakenTimes();
        TakenTime GetTakenTime(int id);
       
        void AddTakenTime(TakenTime time);
        void DeleteTakenTime(int id);
    }
}
