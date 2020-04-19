namespace Command
{
    public class UndoCommand : ICommand
    {
        private readonly CommandHistory _commandHistory;
        public UndoCommand(CommandHistory commandHistory)
        {
            _commandHistory = commandHistory;
        }
        public void Execute()
        {
            if (_commandHistory.Size() == 0)
                return;

            System.Console.WriteLine("Undo is done");
            _commandHistory.Pop().UnExecute();
        }
    }
}