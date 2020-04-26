using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var messenger1 = new MessengerService(new MsmqMessage());
            messenger1.SendMessage("Hello MSMQ");

            var messenger2 = new MessengerService(new RabbitmqMessage());
            messenger2.SendMessage("Hello RabbitMQ");

            var messenger3 = new MessengerService(new EncryptedMessage(new MsmqMessage()));
            messenger3.SendMessage("Hello encrypted message");

            var messenger4 = new MessengerService(new SerializeMessage(new RabbitmqMessage()));
            messenger4.SendMessage("Hello serialized message");
        }
    }
}
