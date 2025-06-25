using Microsoft.AspNetCore.Mvc;
using RabbitMQDemo.Application.Interfaces;

namespace RabbitMQDemo.ProducerAPI.Controllers
{
    [ApiController]
    [Route("Api/")]
    public class SendController : ControllerBase
    {
        private readonly IRabbitMQSendApplicationService _rabbitMQSendApplicationService;

        public SendController(IRabbitMQSendApplicationService rabbitMQSendApplicationService)
        {
            this._rabbitMQSendApplicationService = rabbitMQSendApplicationService;
        }

        [HttpPost("Send")]
        public async Task<IActionResult> SendMessage([FromBody] string message)
        {
            await _rabbitMQSendApplicationService.SendMessageAsync(message);
            return Ok("Mensagem enviada com sucesso.");
        }
    }
}
