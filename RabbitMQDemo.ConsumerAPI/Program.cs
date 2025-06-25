using RabbitMQDemo.Application.Interfaces;
using RabbitMQDemo.Application.Services;
using RabbitMQDemo.Domain.Interfaces;
using RabbitMQDemo.Domain.Services.Implementations;
using RabbitMQDemo.Domain.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRabbitMQConsumerApplicationService, RabbitMQConsumerApplicationService>();
builder.Services.AddScoped<IRabbitMQConsumerService, RabbitMQConsumerService>();
builder.Services.AddScoped<IMessageHandler, MessageHandler>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
