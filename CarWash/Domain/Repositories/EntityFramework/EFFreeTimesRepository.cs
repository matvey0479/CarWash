using CarWash.Domain.Entites;
using CarWash.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;


namespace CarWash.Domain.Repositories.EntityFramework
{
    public class EFFreeTimesRepository:IFreeTimesRepository
    {
        private readonly AppDbContext context;
        public EFFreeTimesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<FreeTime> GetFreeTimes()
        {
            return context.FreeTimes;
        }
        public IQueryable<FreeTime> GetFreeTimes(DateOnly? date)
        {
            return context.FreeTimes.Where(x => x.Date == date);
        }
        public List<DateOnly> GetDate()
        {
            var date = context.FreeTimes
                 .Select(x => x.Date).Distinct()
                 .OrderBy(x => x)
                 .ToList();
            return date;


        }
        public FreeTime GetFreeTime(int id)
        {
            return context.FreeTimes.FirstOrDefault(x => x.Id == id);
        }
        public FreeTime GetFreeTime(DateOnly date, TimeOnly time)
        {
            return context.FreeTimes.FirstOrDefault(x => x.Date == date && x.Time==time);
        
        }
        public void AddFreeTime(FreeTime freeTime)
        {
            context.FreeTimes.Add(freeTime);
            context.SaveChanges();
        }

        public void DeleteFreeTime(int id)
        {
            context.FreeTimes.Remove(GetFreeTime(id));
            context.SaveChanges();
            
        }

    }
}
