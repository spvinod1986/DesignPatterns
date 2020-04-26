namespace Decorator
{
    public class EncryptedMessage : IMessage
    {
        private readonly IMessage _message;
        public EncryptedMessage(IMessage message)
        {
            _message = message;
        }
        public void Send(string message)
        {
            var encryptedMessage = message.Length + "$#%^";
            System.Console.WriteLine($"Message {message} is encrypted as {encryptedMessage}");
            _message.Send(encryptedMessage);
        }
    }
}