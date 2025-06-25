using RabbitMQDemo.Application.Interfaces;
using RabbitMQDemo.Domain.Interfaces;

namespace RabbitMQDemo.Application.Services
{
    public class RabbitMQSendApplicationService : IRabbitMQSendApplicationService
    {
        private readonly IRabbitMQSenderService _senderService;

        public RabbitMQSendApplicationService(IRabbitMQSenderService senderService)
        {
            this._senderService = senderService;
        }

        public async Task SendMessageAsync(string content)
        {
            await this._senderService.SendMessageAsync(content);
        }
    }
}
