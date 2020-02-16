using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Mediator
{

    public interface IMediator
    {
        /// <summary>
        /// This method is intended to mediate between different components in a concrete implementation of a mediator
        /// </summary>
        /// <param name="component"></param>
        /// <param name="eventId"></param>
        void Notify(Component component, Events eventId);
    }
    public class Dialog : IMediator
    {
        public Button SignInButton { get; set; }
        public TextBox EmailTextBox { get; set; }
        public TextBox PasswordTextBox { get; set; }

        public Dialog()
        {
            SignInButton = new Button(this)
            {
                IsEnabled = false
            };
            EmailTextBox = new TextBox(this);
            PasswordTextBox = new TextBox(this);
        }


        public void Notify(Component component, Events eventId)
        {
            var isTextBox = (component == EmailTextBox || component == PasswordTextBox);
            var bothTextBoxHaveText = (EmailTextBox.HasText && PasswordTextBox.HasText);
            var isSentKeys = eventId == Events.SentKeys;

            if (isTextBox && bothTextBoxHaveText && isSentKeys)
                SignInButton.IsEnabled = true;
        }
    }
}
