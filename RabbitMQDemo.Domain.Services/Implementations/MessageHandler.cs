using RabbitMQDemo.Domain.Services.Interfaces;

namespace RabbitMQDemo.Domain.Services.Implementations
{
    public class MessageHandler : IMessageHandler
    {
        public void Handle(string message)
        {
            Console.WriteLine($"[Domain] Mensagem recebida: {message}");
        }
    }
}
