namespace DesignPatterns.Creational.Mediator
{
    public class TextBox : Component
    {
        public string Text { get; set; }
        public bool HasText
        {
            get
            {
                return !(Text == null || Text.Equals(string.Empty));
            }
        }
        public TextBox(IMediator Mediator) : base(Mediator)
        {
        }

        public override void SendKeys(string keys)
        {
            Text = keys;
            Mediator.Notify(this, Events.SentKeys);
        }
    }
}
