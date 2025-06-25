namespace RabbitMQDemo.Domain.Interfaces
{
    public interface IRabbitMQConsumerService
    {
        Task StartConsumerAsync();
    }
}
