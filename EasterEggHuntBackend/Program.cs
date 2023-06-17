using Microsoft.EntityFrameworkCore;
using EasterEggHuntBackend.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<RiddleDbContext>(opts =>
{
    opts.UseSqlServer(
        builder.Configuration["ConnectionStrings:EasterEggHuntBackendConnection"]);
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();

app.Run();
