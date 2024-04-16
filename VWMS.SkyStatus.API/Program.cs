using Microsoft.EntityFrameworkCore;
using VWMS.SkyStatus.API;
using VWMS.SkyStatus.API.Repositories;
using VWMS.SkyStatus.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddXmlSerializerFormatters();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddDbContext<VWMSContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("VWMSContextConnection")));

// Register the StatusMessageRepository and StatusMessageService
builder.Services.AddScoped<StatusMessageRepository>();
builder.Services.AddScoped<StatusMessageService>();

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
