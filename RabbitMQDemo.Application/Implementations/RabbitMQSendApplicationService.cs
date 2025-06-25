using RabbitMQDemo.Application.Interfaces;
using RabbitMQDemo.Domain.Interfaces;

namespace RabbitMQDemo.Application.Services
{
    public class RabbitMQSendApplicationService : IRabbitMQSendApplicationService
    {
        private readonly IRabbitMQSenderService _senderService;

        public RabbitMQSendApplicationService(IRabbitMQSenderService senderService)
        {
            _senderService = senderService;
        }

        public async Task SendMessageAsync(string content)
        {
            await _senderService.SendMessageAsync(content);
        }
    }
}
