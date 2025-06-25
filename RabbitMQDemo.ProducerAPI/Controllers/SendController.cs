using Microsoft.AspNetCore.Mvc;
using RabbitMQDemo.Domain.Interfaces;

namespace RabbitMQDemo.ProducerAPI.Controllers
{
    [ApiController]
    [Route("Api/")]
    public class SendController : ControllerBase
    {
        private readonly IRabbitMQSenderService _sender;

        public SendController(IRabbitMQSenderService sender)
        {
            _sender = sender;
        }

        [HttpPost("Send")]
        public async Task<IActionResult> SendMessage([FromBody] string message)
        {
            await _sender.SendMessageAsync(message);
            return Ok("Mensagem enviada com sucesso.");
        }
    }
}
