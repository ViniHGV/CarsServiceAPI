using CarServiceAPI.Domain.Entities;
using CarServiceAPI.Domain.UseCases;
using CarServiceAPI.Infra.DataBase;
using CommerceHubAPI.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddScoped<GenericRepository<Car>>();
builder.Services.AddScoped<ListAllCarsUseCase>();
builder.Services.AddScoped<CreateCarUseCase>();
builder.Services.AddScoped<DeleteCarUSeCase>();
builder.Services.AddScoped<UpdateCarUseCase>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("corsPolicy", builder => builder.AllowAnyOrigin()
    .AllowAnyMethod());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("corsPolicy");

app.Run();
