using System;

namespace DesignPatterns.Creational.Mediator
{
    public class Component
    {
        public IMediator Mediator { get; set; }

        public Component(IMediator Mediator)
        {
            this.Mediator = Mediator;

        }

        public virtual void Click()
        {
            throw new NotImplementedException();

        }
        public virtual void SendKeys(string keys)
        {
            throw new NotImplementedException();
        }
    }
}
