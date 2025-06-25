using RabbitMQDemo.Application.Interfaces;
using RabbitMQDemo.Domain.Interfaces;

namespace RabbitMQDemo.Application.Services
{
    public class RabbitMQConsumerApplicationService : IRabbitMQConsumerApplicationService
    {
        private readonly IRabbitMQConsumerService _consumerService;

        public RabbitMQConsumerApplicationService(IRabbitMQConsumerService consumerService)
        {
            _consumerService = consumerService;
        }

        public async Task StartConsumerAsync()
        {
            await _consumerService.StartConsumerAsync();
        }

        public async Task ConsumeSingleMessageAsync()
        {
            await _consumerService.ConsumeSingleMessageAsync();
        }
    }
}
