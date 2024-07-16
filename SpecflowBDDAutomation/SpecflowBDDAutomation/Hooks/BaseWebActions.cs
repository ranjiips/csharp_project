using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowBDDAutomation.Hooks
{
    public class BaseWebActions : BaseWebDriver
    {

        private int _elementtimeout = 10;
        public void ClickWebElement(By locator)
        {
            WaitUntilElementVisible(locator);
            WaitUntilElementIsClickable(locator);
            var element = Driver.FindElement(locator);
            if (element != null && element.Enabled)
                element.Click();
            else
                throw new Exception("Unable to click the element");
        }

        public void EnterText(By locator, string input)
        {
            WaitUntilElementVisible(locator);
            if (IsElementEnabled(locator))
                Driver.FindElement(locator).SendKeys(input);
            else
                throw new Exception("Unable to enter the given text");
        }

        public string GetText(By locator)
        {
            WaitUntilElementVisible(locator);
            return Driver.FindElement(locator).Text;
        }

        public bool IsElementEnabled(By locator)
        {
            if(Driver.FindElement(locator).Enabled)
                return true;
            else
                return false;
        }

        public void WaitUntilElementVisible(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(_elementtimeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public void WaitUntilElementIsClickable(By locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver,TimeSpan.FromSeconds(_elementtimeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }

        public string GetAlertText(IAlert alert)
        {
            return alert.Text;
        }

        public IAlert SwitchToAlert()
        {
            //return Driver.SwitchTo().Alert();
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            //wait.Until(driver => Driver!=null);
            return wait.Until(driver => IsAlertShown(Driver));
        }

        public void AcceptAlert(IAlert alert)
        {
            alert.Accept();
        }

        public void DissmissAlert(IAlert alert)
        {
            alert.Dismiss();
        }

        public IAlert IsAlertShown(IWebDriver driver)
        {
            IAlert alert = null;
            try
            {
                alert = driver.SwitchTo().Alert();
            }
            catch (NoAlertPresentException e)
            {
                return alert;
            }
            return alert;
        }
    }
}
