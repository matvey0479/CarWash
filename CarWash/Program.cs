using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CarWash.Service;
using CarWash.Domain;
using CarWash.Domain.Repositories.Abstract;
using CarWash.Domain.Repositories.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DateOnlyTimeOnly.AspNet.Converters;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IClientsRepository, EFClientsRepository>();
builder.Services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
builder.Services.AddTransient<IFreeTimesRepository, EFFreeTimesRepository>();
builder.Services.AddTransient<IAppointmentsRepository, EFAppointmentsRepository>();
builder.Services.AddTransient<ITakenTimeRepository, EFTakenTimeRepository>();
builder.Services.AddTransient<DataManager>();

builder.Configuration.Bind("Project", new Config());
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));
builder.Services.AddDateOnlyTimeOnlyStringConverters();
builder.Services.AddSwaggerGen(c => c.UseDateOnlyTimeOnlyStringConverters());

builder.Services.AddIdentity<IdentityUser,IdentityRole>(opts =>
{
    opts.User.RequireUniqueEmail = true;
    opts.Password.RequiredLength = 4;
    opts.Password.RequireNonAlphanumeric = false;
    opts.Password.RequireLowercase = false;
    opts.Password.RequireUppercase = false;
    opts.Password.RequireDigit = false;
}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(opts =>
{
    opts.Cookie.Name = "myCompanyAuth";
    opts.Cookie.HttpOnly = true;
    opts.LoginPath = "/account/login";
    opts.AccessDeniedPath = "/account/accessdenied";
    opts.SlidingExpiration = true;
});

builder.Services.AddAuthorization(x =>
{
    x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
});

builder.Services.AddControllersWithViews(x =>
{
    x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
});
   

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/errors");
    app.UseHsts();
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
});
app.Run();
