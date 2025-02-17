using MassTransit;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MicroserviceB.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMassTransit(x =>
{
    x.AddConsumer<HelloMessageConsumer>();

    x.UsingRabbitMq((context, config) =>
    {
        config.Host("localhost", "/", h =>
        {
            h.Username("guest");
            h.Password("guest");
        });
        config.ReceiveEndpoint("microservice-b-queue", e =>
        {
            e.ConfigureConsumer<HelloMessageConsumer>(context);
        });
    });
});

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", () => "MicroserviceB is running...");

app.Run();

// Consumer references HelloMessage in MicroserviceB.Contracts
public class HelloMessageConsumer : IConsumer<HelloMessage>
{
    public Task Consume(ConsumeContext<HelloMessage> context)
    {
        Console.WriteLine($"Received: {context.Message.Text}");
        return Task.CompletedTask;
    }
}