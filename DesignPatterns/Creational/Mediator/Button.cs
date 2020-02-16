namespace DesignPatterns.Creational.Mediator
{
    public class Button : Component
    {
        public bool IsEnabled { get; set; }
        public Button(IMediator Mediator) : base(Mediator)
        {
        }

        public override void Click()
        {
            if (IsEnabled)
            {
                base.Click();
            }                
        }
    }
}
