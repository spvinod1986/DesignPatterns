namespace Decorator
{
    public class MessengerService
    {
        private readonly IMessage _message;
        public MessengerService(IMessage message)
        {
            _message = message;
        }
        public void SendMessage(string messageContent)
        {
            _message.Send(messageContent);
        }
    }
}