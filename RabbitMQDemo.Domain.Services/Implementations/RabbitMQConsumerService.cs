using RabbitMQDemo.Domain.Interfaces;
using RabbitMQDemo.Domain.Services.Interfaces;
using RabbitMQDemo.Infrastructure.CrossCutting.Messaging;

namespace RabbitMQDemo.Domain.Services.Implementations
{
    public class RabbitMQConsumerService : IRabbitMQConsumerService
    {
        private readonly RabbitMQConsumer _consumer;
        private readonly IMessageHandler _handler;

        public RabbitMQConsumerService(IMessageHandler handler)
        {
            _handler = handler;
            _consumer = new RabbitMQConsumer();
        }

        public async Task StartConsumerAsync()
        {
            await _consumer.StartAsync(async message =>
            {
                _handler.Handle(message);
                await Task.CompletedTask;
            });
        }
    }
}
