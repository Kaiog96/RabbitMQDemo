using Microsoft.AspNetCore.Mvc;
using RabbitMQDemo.Application.Interfaces;

namespace RabbitMQDemo.ConsumerAPI.Controllers
{
    [ApiController]
    [Route("Api/")]
    public class ConsumerController : ControllerBase
    {
        private readonly IRabbitMQConsumerApplicationService _rabbitMQConsumerApplicationService;

        public ConsumerController(IRabbitMQConsumerApplicationService rabbitMQConsumerApplicationService)
        {
            this._rabbitMQConsumerApplicationService = rabbitMQConsumerApplicationService;
        }

        [HttpPost("Start")]
        public async Task<IActionResult> Start()
        {
            _ = Task.Run(() => _rabbitMQConsumerApplicationService.StartConsumerAsync()); 
            return Ok("RabbitMQ consumer started.");
        }
    }
}

