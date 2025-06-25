namespace RabbitMQDemo.Domain.Interfaces
{
    public interface IRabbitMQConsumerService
    {
        Task StartConsumerAsync();

        Task ConsumeSingleMessageAsync();
    }
}
