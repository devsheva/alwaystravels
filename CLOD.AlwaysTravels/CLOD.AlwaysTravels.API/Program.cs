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

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
