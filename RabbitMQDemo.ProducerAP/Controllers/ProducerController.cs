using Microsoft.AspNetCore.Mvc;

namespace RabbitMQDemo.ProducerAP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProducerController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ProducerController> _logger;

        public ProducerController(ILogger<ProducerController> logger)
        {
            _logger = logger;
        }

    }
}
