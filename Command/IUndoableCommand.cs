namespace Command
{
    public interface IUndoableCommand : ICommand
    {
        void UnExecute();
    }
}