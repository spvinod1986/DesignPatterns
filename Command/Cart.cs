namespace Command
{
    public class Cart
    {
        private readonly ICommand _command;

        public Cart(ICommand command)
        {
            _command = command;
        }

        public void OneClickBuy()
        {
            _command.Execute();
        }
    }
}