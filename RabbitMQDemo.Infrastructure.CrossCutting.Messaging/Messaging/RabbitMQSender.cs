using System.Text;
using RabbitMQ.Client;
namespace RabbitMQDemo.Infrastructure.CrossCutting.Messaging;

public class RabbitMQSender
{
    public async Task SendAsync(string content)
    {
        var factory = new ConnectionFactory
        {
            HostName = "localhost"
        };

        var connection = await factory.CreateConnectionAsync();
        var channel = await connection.CreateChannelAsync();

        await channel.QueueDeclareAsync(
            queue: "demo-queue",
            durable: false,
            exclusive: false,
            autoDelete: false,
            arguments: null
        );

        var body = Encoding.UTF8.GetBytes(content);

        await channel.BasicPublishAsync(
            exchange: "",
            routingKey: "demo-queue",
            body: body
        );

        Console.WriteLine($"Message sent to queue: {content}");

        await channel.CloseAsync();
        await connection.CloseAsync();
    }
}

