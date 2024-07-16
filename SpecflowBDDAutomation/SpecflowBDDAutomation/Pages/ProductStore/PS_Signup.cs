using SpecflowBDDAutomation.Hooks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowBDDAutomation.Pages.ProductStore
{
    public class PS_Signup:BaseWebActions
    {
        private string _optionLocator = "//li/a[text()='OPTION_VALUE']";
        private string _footerBtn = "//div[@class='modal-footer']/button[text()='BUTTON_NAME']";
        //private By _singupPopup = By.XPath("//div[@id='signInModal' and contains(@style,'block')]");
        private By _popupHeaderlocator = By.XPath("//div[contains(@id,'InModal') and contains(@style,'block')]//h5");
        //private By _singupusernameInput = By.XPath("//div[@id='signInModal']//label[contains(text(),'Username')]");
        private By _usernameInput = By.XPath("//div[contains(@id,'InModal') and contains(@style,'block')]//label[contains(text(),'Username')]");
        private By _passwordInput = By.XPath("//div[contains(@id,'InModal') and contains(@style,'block')]//label[contains(text(),'Password')]");
        //private By _signupPasswordInput = By.CssSelector("input#sign-password");
        private By _loginusernameLocator = By.CssSelector("a#nameofuser");

        public void SelectHeaderOption(string option)
        {
            ClickWebElement(GetDynamicLocator("OPTION_VALUE", option));
        }

        private By GetDynamicLocator(string replaceValue, string optionName)
        {
            string locator = GetLocatorByValue(replaceValue);
            string value = locator.Replace(replaceValue, optionName);
            return By.XPath(value);
        }

        private string GetLocatorByValue(string option)
        {
            if (option.ToUpper() == "OPTION_VALUE")
                return _optionLocator;
            else if (option.ToUpper() == "BUTTON_NAME")
                return _footerBtn;
            else
                return String.Empty;
        }
        
        public string GetPopupHeader()
        {
            return GetText(_popupHeaderlocator);
        }

        public void EnterCredentails(string username, string password)
        {
            var userNameLocator = Driver.FindElement(RelativeBy.WithLocator(By.TagName("input")).Below(_usernameInput));
            userNameLocator.SendKeys(username);

            var passwordLocator = Driver.FindElement(RelativeBy.WithLocator(By.TagName("input")).Below(_passwordInput));
            passwordLocator.SendKeys(password);

            //EnterText(_signupPasswordInput, password);
        }

        public void ClickTheFooterButton(string name)
        {
            ClickWebElement(GetDynamicLocator("BUTTON_NAME", name));
        }

        public string VerifyPopupMessage()
        {
            var alert = SwitchToAlert();
            string message = GetAlertText(alert);
            AcceptAlert(alert);
            return message;
        }

        public bool GetLoggedInUserName(string username)
        {
            string name= GetText(_loginusernameLocator);
            return name.Trim().ToLower().Contains(username.Trim().ToLower());
        }

        public void VeirfySignout()
        {
            WaitUntilElementVisible(GetDynamicLocator("OPTION_VALUE", "Log in"));
            WaitUntilElementVisible(GetDynamicLocator("OPTION_VALUE", "Sign up"));
        }

    }
}
