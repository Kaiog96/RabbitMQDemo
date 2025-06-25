namespace RabbitMQDemo.Domain.Services.Interfaces
{
    public interface IMessageHandler
    {
        void Handle(string message);
    }
}
