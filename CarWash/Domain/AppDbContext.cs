using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using CarWash.Service.Converters;
using CarWash.Domain.Entites;
namespace CarWash.Domain
{
    public class AppDbContext:IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
        public DbSet<Client> clients { get; set; }
        public DbSet<ServiceItem> ServiceItems { get;set; }
        public DbSet<FreeTime> FreeTimes { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<TakenTime> takenTimes { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            base.ConfigureConventions(builder);

            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter, DateOnlyComparer>()
                .HaveColumnType("date");

            builder.Properties<TimeOnly>()
                .HaveConversion<TimeOnlyConverter, TimeOnlyComparer>();


        }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "5e8cf896-f975-4254-906c-afd297b9855b",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelbuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "6f0feb5e-47f8-41c0-9d57-5de5372c4ae2",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@mail.com",
                NormalizedEmail = "MY@MAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "pass"),
                SecurityStamp = string.Empty
            });

            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "5e8cf896-f975-4254-906c-afd297b9855b",
                UserId = "6f0feb5e-47f8-41c0-9d57-5de5372c4ae2"

            });
            modelbuilder.Entity<ServiceItem>().HasData(new ServiceItem
            {
                Id =1,
                Title = "Техническая мойка",
                Description = "Наружная мойка автомобиля при помощи моечной установки без использования химических средств и шампуней.",
                Price = "300"
                

            });
            modelbuilder.Entity<ServiceItem>().HasData(new ServiceItem
            {
                Id = 2,
                Title = "Комплексная мойка",
                Description = "Мойка кузова машины. Чистка салона, ковриков и сидений. Чистка багажника. Чистка шин и дисков и шин",
                Price = "600"


            });

            var id = 1;
            var date = new DateOnly(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day);
            for (int i = 0; i < 31; i++)
            {

                var time = new TimeOnly(10, 0);
                for (int j = 0; j < 24; j++)
                {
                    
                    modelbuilder.Entity<FreeTime>().HasData(new FreeTime
                    {
                        Id = id,
                        Date = date,
                        Time = time
                    });
                    time = time.AddMinutes(30);
                    id++;

                }
                date = date.AddDays(1);
            }



        }
    }
}
