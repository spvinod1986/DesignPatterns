using System;

namespace Mediator
{
    public abstract class Filter
    {
        public abstract event EventHandler FilterUpdated; 
    }
}