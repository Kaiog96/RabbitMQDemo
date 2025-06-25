using Microsoft.AspNetCore.Mvc;
using RabbitMQDemo.Application.Interfaces;

namespace RabbitMQDemo.ConsumerAPI.Controllers
{
    [ApiController]
    [Route("Api/")]
    public class ConsumerController : ControllerBase
    {
        private readonly IRabbitMQConsumerApplicationService _rabbitMQAppService;

        public ConsumerController(IRabbitMQConsumerApplicationService rabbitMQAppService)
        {
            _rabbitMQAppService = rabbitMQAppService;
        }

        [HttpPost("Start")]
        public async Task<IActionResult> Start()
        {
            _ = Task.Run(() => _rabbitMQAppService.StartConsumerAsync()); // executa em background
            return Ok("RabbitMQ consumer started.");
        }

        [HttpPost("Consume-one")]
        public async Task<IActionResult> ConsumeOne()
        {
            await _rabbitMQAppService.ConsumeSingleMessageAsync();
            return Ok("Single message consumed (if available).");
        }
    }
}

