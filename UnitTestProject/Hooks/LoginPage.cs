using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject.Pages;
using System.Configuration;
using OpenQA.Selenium;

namespace UnitTestProject.Hooks
{
    public class LoginPage : BaseWebPage
    {
        By _loginPageLabel = By.CssSelector("h1.vdl-login__title");
        By _clientID = By.CssSelector("input[placeholder='Client ID']");
        By _userID = By.CssSelector("input[placeholder='Employee ID']");
        By _password = By.CssSelector("input[placeholder='Password']");
        By _signinButton = By.CssSelector("button[type='submit']");

        public void LoginUser()
        {
            LoginAs(GlobalPage.GetGlobal().LoginUserName, GlobalPage.GetGlobal().LoginPassword);
        }

        public void LoginAs(string username, string password)
        {
            string browser = GlobalPage.GetGlobal().Browser;
            GoTo();
            WaitForElementPresent(_loginPageLabel);
            SendText(_clientID, GlobalPage.GetGlobal().Company);
            SendText(_userID, username);
            SendText(_password, password);
            ClickElement(_signinButton);
        }

    }
}
