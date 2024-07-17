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
        
        public void LoginPageUsingFormAuthentication(string pageName)
        {
            LoadPageByText(pageName);
            Pages.SeleniumLoginLogoutActions.VerifyPageTitle("Login Page", Pages.SeleniumLoginLogoutActions.loginpageHeaderLocator);
            Pages.SeleniumLoginLogoutActions.LoginWithValidCredentials("tomsmith", "SuperSecretPassword!");
            Pages.SeleniumLoginLogoutActions.VerifyMessage("You logged into a secure area");
            Pages.SeleniumLoginLogoutActions.LogoutAction();
            Pages.SeleniumLoginLogoutActions.VerifyMessage("You logged out of the secure area");
            Pages.SeleniumLoginLogoutActions.BackToMainPage();
        }

        public void HandleCheckBoxes(string pageName)
        {
            LoadPageByText(pageName);
            Pages.SeleniumFormActions.VerifyPageTitle("Checkboxes", Pages.SeleniumFormActions.checkboxPageHeaderLocator);
            Pages.SeleniumFormActions.UnselectAndSelectCheckbox();
            Pages.SeleniumFormActions.BackToMainPage();
        }

        public void EnterBasicAuthinJSPopup()
        {
            Pages.SeleniumJavaScriptActions.ClickLinkByText("Basic Auth");
            Pages.SeleniumJavaScriptActions.EnterCredentialsInJSPopup();
            Pages.SeleniumJavaScriptActions.VerifyJavaScriptLoginMessage();
            Pages.SeleniumJavaScriptActions.BackToMainPage();
        }

        public void HandleDragDrop(string pageName)
        {
            LoadPageByText(pageName);
            Pages.SeleniumMouseActions.VerifyPageTitle("Drag and Drop", Pages.SeleniumFormActions.checkboxPageHeaderLocator);
            Pages.SeleniumMouseActions.DragAndDropAction();
            Pages.SeleniumFormActions.BackToMainPage();
        }

        public void HandleFrames(string pageName)
        {
            Pages.SeleniumFrames.LoadPageByText(pageName);
            Pages.SeleniumFrames.VerifyPageTitle("Frames", Pages.SeleniumFormActions.checkboxPageHeaderLocator);
            Pages.SeleniumFrames.LoadPageByText("Nested Frames");
            Pages.SeleniumFrames.SwitchToFrameAction();
            Pages.SeleniumFormActions.BackToMainPage();
        }

        public void HandleMultipleWindows(string pageName)
        {
            Pages.SeleniumFrames.LoadPageByText(pageName);
            Pages.SeleniumFrames.VerifyPageTitle("Opening a new window", Pages.SeleniumFormActions.checkboxPageHeaderLocator);
            Pages.SeleniumMulitpleWindows.OpenChildWindow("New Window");
            Pages.SeleniumFormActions.BackToMainPage();
        }

        public void LoginWithValidCredentials(string username, string password)
        {
            //Enter username using the relative locators - selenium 4 feature
            //EnterText(userNameLocator, username);
            IWebElement usernameLabel = Driver.FindElement(By.XPath("//label[text()='Username']"));
            IWebElement element = Driver.FindElement(RelativeBy.WithLocator(By.TagName("input")).Below(usernameLabel));
            element.SendKeys(username);

            //Enter password
            EnterText(passwordLocator, password);

            //Click Login button
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
