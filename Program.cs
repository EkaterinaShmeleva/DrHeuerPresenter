using DrHeuerVorstellung.Data;
using DrHeuerVorstellung.Models;
using DrHeuerVorstellung.Services;
using DrHeuerVorstellung.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IStandortService, StandortService>();
builder.Services.AddScoped<IUmschulungService, UmschulungService>();
builder.Services.AddScoped<IKontaktService, KontaktService>();

builder.Services.AddDbContext<AppDbContext>(options 
    => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddMemoryCache();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    // Migrationen anwenden (optional)
    context.Database.Migrate(); // oder context.Database.EnsureCreated();

    // Standorte einfügen, wenn leer
    if (!context.Standorte.Any())
    {
        context.Standorte.AddRange(
            new Standort { Name = "Neuss" },
            new Standort { Name = "Bochum" }
        );
    }

    // Fachrichtungen einfügen, wenn leer
    if (!context.Fachrichtungen.Any())
    {
        context.Fachrichtungen.AddRange(
            new Fachrichtung { Name = "Fachinformatiker/in Anwendungsentwicklung (FIAE)" },
            new Fachrichtung { Name = "Fachinformatiker/in Systemintegration (FISI)" }
        );
    }

    // Änderungen speichern
    context.SaveChanges();
}

app.Run();




