using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;

namespace SpecFlowProject1
{
    public class DriverFactory
    {
        public IWebDriver Driver;

        public IWebDriver GetWebDriver()
        {
            var browser = GlobalPage.GetGlobal().Browser;

            if(!string.IsNullOrEmpty(browser))
            {
                switch(browser.ToLower())
                {
                    case "chrome":
                        var options = new ChromeOptions();
                        options.AddArguments("--disable-extensions");
                        options.AddArguments("disable-infobars");
                        options.AddUserProfilePreference("credentials_enable_service", false);
                        options.AddUserProfilePreference("profile.password_manager_enabled", false);
                        options.AddUserProfilePreference("profile.default_content_setting_values.clipboard", 1);
                        Driver = new ChromeDriver(options);
                        break;
                    default:
                        Debug.WriteLine("App.config key error");
                        Debug.WriteLine("Defaulting to Chrome");
                        Driver = new ChromeDriver();
                        break;
                }
            }
            Driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(0));
            Driver.Manage().Timeouts().PageLoad = (TimeSpan.FromSeconds(GlobalPage.SeleniumPageLoadTimeOut));
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Manage().Window.Maximize();
            return Driver;
        }
    }
}
