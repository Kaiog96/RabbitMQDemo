using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace RabbitMQDemo.Infrastructure.CrossCutting.Messaging
{
    public class RabbitMQConsumer
    {
        public async Task StartAsync(Func<string, Task> handler)
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

            var consumer = new AsyncEventingBasicConsumer(channel);
            consumer.ReceivedAsync += async (_, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                await handler(message);
            };

            await channel.BasicConsumeAsync(
                queue: "demo-queue",
                autoAck: true,
                consumer: consumer
            );

            Console.WriteLine("RabbitMQ consumer started. Waiting for messages...");
            await Task.Delay(-1);
        }
    }
}
