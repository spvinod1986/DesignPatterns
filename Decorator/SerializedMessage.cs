namespace Decorator
{
    public class SerializeMessage : IMessage
    {
        private readonly IMessage _message;
        public SerializeMessage(IMessage message)
        {
            _message = message;
        }
        public void Send(string message)
        {
            var serializedMessage = message.ToUpper();
            System.Console.WriteLine($"Message {message} is serialized as {serializedMessage}");
            _message.Send(serializedMessage);
        }
    }
}