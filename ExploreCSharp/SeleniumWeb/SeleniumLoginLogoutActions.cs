using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp.SeleniumWeb
{
    public class SeleniumLoginLogoutActions:SeleniumBaseWebInteractions
    {
        public By loginpageHeaderLocator = By.CssSelector("div#content h2"); 
        By userNameLocator = By.CssSelector("input#username");
        By passwordLocator = By.CssSelector("input#password");
        By submitLocator = By.XPath("//button[@type='submit']/i");
        By flashMessageLocator = By.CssSelector("div#flash-messages div");
        By welcomeMessageLocator = By.XPath("//div[@id='content']//h4");
        By logoutButtonLocator = By.XPath("//a[contains(@class,'button')]/i[contains(text(),'Logout')]");
        

        public void LoginWithValidCredentials(string username, string password)
        {
            EnterText(userNameLocator, username);
            EnterText(passwordLocator, password);
            ClickElement(submitLocator);
        }

        public void VerifyMessage(string message)
        {
            string text = GetText(flashMessageLocator);
            if (text.ToLower().Contains(message.ToLower()))
                Console.WriteLine($"Message: {text}");
            else Console.WriteLine($"Failed to load the page, error message: {text}");
            Console.WriteLine($"Message: {GetText(welcomeMessageLocator)}");
        }

        public void LogoutAction()
        {
            ClickElement(logoutButtonLocator);
        }

        public void VerifyLogoutMessage(string message)
        {
            string text = GetText(flashMessageLocator);
            if (text.ToLower().Contains(message.ToLower()))
                Console.WriteLine($"Paged loggedout successfully with the message: {text}");
            else Console.WriteLine($"Failed to logout the page, error message: {text}");
        }

    }
}
