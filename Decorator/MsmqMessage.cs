namespace Decorator
{
    public class MsmqMessage : IMessage
    {
        public void Send(string message)
        {
            System.Console.WriteLine($"Message {message} send by MSMQ service");
        }
    }
}