using RabbitMQDemo.Domain.Interfaces;
using RabbitMQDemo.Infrastructure.CrossCutting.Messaging;

namespace RabbitMQDemo.Domain.Services.Implementations
{
    public class RabbitMQSenderService : IRabbitMQSenderService
    {
        private readonly RabbitMQSender _sender;

        public RabbitMQSenderService()
        {
            _sender = new RabbitMQSender();
        }

        public async Task SendMessageAsync(string content)
        {
            await _sender.SendAsync(content);
        }
    }
}
