namespace RabbitMQDemo.Application.Interfaces
{
    public interface IRabbitMQConsumerApplicationService
    {
        Task StartConsumerAsync();

        Task ConsumeSingleMessageAsync();
    }
}
