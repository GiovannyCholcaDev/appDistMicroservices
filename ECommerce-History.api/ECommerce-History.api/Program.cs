using appDist.Event.MQ.Src;
using appDist.Event.MQ.Src.Bus;
using ECommerce_History.api.Messages.Events;
using ECommerce_History.api.Messages.EventsHandlers;
using ECommerce_History.api.Persistences;
using ECommerce_History.api.Services.Implementations;
using ECommerce_History.api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


///MQ
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddRabbitMQ();
builder.Services.AddTransient<TransactionHistoryEventHandler>();
builder.Services.AddTransient<IEventHandler<TransactionHistoryCreateEvent>, TransactionHistoryEventHandler>();

//LA CADENA DE CONEXION ESTA EN EL appsettings.json
//CON EL SIGUIENTA LINEA OBTENEMOS LA CADENA DE CONEXIONA SQL SERVER

var conPostgres = builder.Configuration.GetConnectionString("BDDPostgres")!;
builder.Services.AddDbContext<ContextDatabase>(options =>
{
    options.UseNpgsql(conPostgres);
});

builder.Services.AddScoped<IHistoryService, HistoryService>();

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

ConfigureEventBus(app);

app.Run();


void ConfigureEventBus(IApplicationBuilder app)
{
    var eventBus = app.ApplicationServices.GetRequiredService<IEventBus>();
    eventBus.Subscribe<TransactionHistoryCreateEvent, TransactionHistoryEventHandler>();
}