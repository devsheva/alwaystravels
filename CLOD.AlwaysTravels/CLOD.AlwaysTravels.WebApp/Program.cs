using CLOD.AlwaysTravels.AppCore.Interfaces.Repositories;
using CLOD.AlwaysTravels.AppCore.Interfaces.Services;
using CLOD.AlwaysTravels.AppCore.Services;
using CLOD.AlwaysTravels.Infrastructure.Repositories;

RepoDb.PostgreSqlBootstrap.Initialize();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add singleton
builder.Services.AddSingleton<ITravelsService, TravelsService>();
builder.Services.AddSingleton<ITravelsRepository, TravelsRepository>();
builder.Services.AddSingleton<IStagesRepository, StagesRepository>();
builder.Services.AddSingleton<IStagesService, StagesService>();
builder.Services.AddSingleton<IPackagesRepository, PackagesRepository>();
builder.Services.AddSingleton<IPackagesService, PackagesService>();
builder.Services.AddSingleton<ISPService, SPService>();
builder.Services.AddSingleton<ISPRepository, SPRepository>();

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
