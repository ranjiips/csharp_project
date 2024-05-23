using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using MSTestProject;

namespace MSTestProject.Hooks
{
    public class BaseWebPage
    {
        public string PageURL { get; set; }
        public IWebDriver Driver = GlobalPage.Driver;
        public int waitTime = GlobalPage.SeleniumLongTimeOut;

        public BaseWebPage()
        {
        PageURL = GlobalPage.GetGlobal().BaseURL;
        }

        public void GoTo()
        {
            PageURL = GlobalPage.GetGlobal().BaseURL;

            if (!string.IsNullOrEmpty(PageURL))
            {
                Driver.Navigate().GoToUrl(PageURL);
            }
        }

        public void WaitForElementPresent(By element)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(waitTime));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
        }

        public void SendText(By element, string text)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(waitTime));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            Driver.FindElement(element).SendKeys(text);
        }

        public void ClickElement(By element)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(waitTime));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            Driver.FindElement(element).Click();
        }

        public string GetElementText(By element)
        {
            try
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(waitTime));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(element));
                return Driver.FindElement(element).Text.Trim();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return null;
        }

        public void ScrillToElement(By element)
        {
            IWebElement ele = Driver.FindElement(element);
            Actions act = new Actions(Driver);
            act.MoveToElement(ele).Perform();
        }
    }
}
