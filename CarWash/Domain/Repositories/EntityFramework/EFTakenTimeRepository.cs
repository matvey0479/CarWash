using CarWash.Domain.Entites;
using CarWash.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace CarWash.Domain.Repositories.EntityFramework
{
    public class EFTakenTimeRepository:ITakenTimeRepository
    {
        private readonly AppDbContext context;
        public EFTakenTimeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<TakenTime> GetTakenTimes()
        {
            return context.takenTimes;
        }
        public TakenTime GetTakenTime(int id)
        {
            return context.takenTimes.FirstOrDefault(x => x.Id == id);
        }

        public void AddTakenTime(TakenTime time)
        {
            context.takenTimes.Add(time);
            context.SaveChanges();
        }

        public void DeleteTakenTime(int id)
        {
            context.takenTimes.Remove(GetTakenTime(id));
            context.SaveChanges();
        }
    }
}
