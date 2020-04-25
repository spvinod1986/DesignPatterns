namespace Visitor
{
    public class EmailNotification : INotification
    {
        public string EmailAddress { get; private set; }
        public EmailNotification(string emailAddress)
        {
            EmailAddress = emailAddress;
        }
        public void Execute(IOperation operation)
        {
            operation.apply(this);
        }
    }
}