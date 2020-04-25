namespace Visitor
{
    public interface INotification
    {
        void Execute(IOperation operation);
    }
}