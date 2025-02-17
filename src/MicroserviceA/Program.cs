using MassTransit;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MicroserviceA.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMassTransit(cfg =>
{
    cfg.UsingRabbitMq((context, config) =>
    {
        config.Host("localhost", "/", h =>
        {
            h.Username("guest");
            h.Password("guest");
        });
    });
});

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Simple GET endpoint to publish our HelloMessage
app.MapGet("/", async (IPublishEndpoint publishEndpoint) =>
{
    await publishEndpoint.Publish(new HelloMessage { Text = "Hello from MicroserviceA!" });
    return "Published HelloMessage!";
});

app.Run();
