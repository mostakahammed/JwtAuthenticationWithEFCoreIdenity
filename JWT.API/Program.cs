using JWT.API.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var con_str = builder.Configuration.GetConnectionString("db");

builder.Services.AddDbContext<AuthDbContext>(options =>
{
    options.UseSqlServer(con_str, op => op.MigrationsHistoryTable
        (
            tableName: HistoryRepository.DefaultTableName,
            schema: "auth"
        )
    );
});
builder.Services.AddDbContext<JwtDbContext>(options =>
{
    options.UseSqlServer(con_str, op => op.MigrationsHistoryTable
        (
        tableName: HistoryRepository.DefaultTableName
       )
    );
});

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
