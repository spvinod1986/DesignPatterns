using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var filter = new FilterMediator();
            filter.ChangeFilter();
        }
    }
}
