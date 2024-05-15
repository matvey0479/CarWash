using CarWash.Domain.Entites;

namespace CarWash.Domain.Repositories.Abstract
{
    public interface IFreeTimesRepository
    {
        IQueryable<FreeTime> GetFreeTimes();
        IQueryable<FreeTime> GetFreeTimes(DateOnly? date);
        List<DateOnly> GetDate();
        FreeTime GetFreeTime(int id);

        FreeTime GetFreeTime(DateOnly date,TimeOnly time);
        void AddFreeTime(FreeTime freeTime);
        void DeleteFreeTime(int id);
    }
}
