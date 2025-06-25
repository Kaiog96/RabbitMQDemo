namespace RabbitMQDemo.Application.Interfaces
{
    public interface IRabbitMQSendApplicationService
    {
        Task SendMessageAsync(string content);
    }
}
