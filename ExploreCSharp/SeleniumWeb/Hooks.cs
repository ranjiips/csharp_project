﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExploreCSharp.SeleniumWeb
{
    public class Hooks
    {
        public static IWebDriver Driver = null;
        public Hooks()
        {
            if (Driver == null)
                Driver = GetWebDriver();
        }

        public IWebDriver GetWebDriver()
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-extensions");
            options.AddArguments("disable-infobars");
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddUserProfilePreference("profile.default_content_setting_values.clipboard", 1);
            Driver = new ChromeDriver(options);
            Driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(0));
            Driver.Manage().Timeouts().PageLoad = (TimeSpan.FromSeconds(120));
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Manage().Window.Maximize();
            return Driver;
        }

        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}
