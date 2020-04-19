using System.Collections.Generic;

namespace Command
{
    public class CompositeCommand : ICommand
    {
        private readonly List<ICommand> _commands;
        public CompositeCommand()
        {
            _commands = new List<ICommand>();
        }

        public void Add(ICommand command)
        {
            _commands.Add(command);
        }
        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}