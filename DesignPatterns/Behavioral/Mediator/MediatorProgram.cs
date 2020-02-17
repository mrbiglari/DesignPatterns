namespace DesignPatterns.Creational.Mediator
{
    public class MediatorProgram
    {
        public static void MediatorMain(string [] args )
        {
            var dialog = new Dialog();

            dialog.EmailTextBox.SendKeys("test@test.com");
            dialog.PasswordTextBox.SendKeys("testPassword");

            dialog.SignInButton.Click();
        }
    }
}
