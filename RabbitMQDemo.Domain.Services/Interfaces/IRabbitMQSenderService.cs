namespace RabbitMQDemo.Domain.Interfaces
{
    public interface IRabbitMQSenderService
    {
        Task SendMessageAsync(string content);
    }
}
