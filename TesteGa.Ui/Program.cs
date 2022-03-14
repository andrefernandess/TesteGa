using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TesteGa.Application.Interfaces;
using TesteGa.Application.Services;
using TesteGa.Repository.Context;
using TesteGa.Repository.Interfaces;
using TesteGa.Repository.Repositories;
using TesteGa.Ui.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});


//Pontos a melhorar/refatorar - Criar arquivo de configuracao para injecao de dependencia separado da classe Program.cs
builder.Services.AddScoped<DataContext>();
builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();
builder.Services.AddScoped<IFazendaRepository, FazendaRepository>();
builder.Services.AddScoped<IAnimalService, AnimalService>();
builder.Services.AddScoped<IFazendaService, FazendaService>();

var mapperConfig = new MapperConfiguration(c =>
{
    c.AddProfile(new TesteGaProfile());
});

builder.Services.AddSingleton(mapperConfig.CreateMapper());

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
