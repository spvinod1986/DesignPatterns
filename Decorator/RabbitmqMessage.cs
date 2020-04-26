namespace Decorator
{
    public class RabbitmqMessage : IMessage
    {
        public void Send(string message)
        {
            System.Console.WriteLine($"Message {message} send by RabbitMQ service");
        }
    }
}