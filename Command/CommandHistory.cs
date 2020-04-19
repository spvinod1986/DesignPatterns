using System.Collections.Generic;

namespace Command
{
    public class CommandHistory
    {
        private readonly Stack<IUndoableCommand> _commands;

        public CommandHistory()
        {
            _commands = new Stack<IUndoableCommand>();
        }

        public void Push(IUndoableCommand command)
        {
            _commands.Push(command);
        }

        public IUndoableCommand Pop()
        {
            return _commands.Pop();
        }

        public int Size()
        {
            return _commands.Count;
        }
    }
}