using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Net.Mail;
using System.Threading;
using System.IO;


namespace ExploreCSharp.SeleniumWeb
{
    public abstract class SeleniumBaseWebInteractions: Hooks
    {
        public int elementTimeout = 60;
        By MainPageHeaderLocator = By.CssSelector("div#content h2");        

        public void NavigateToURL(string url)
        {
            //Driver = GetWebDriver();
            Driver.Navigate().GoToUrl(url);
        }

        public void LoadPageByText(string linkText)
        {
            ClickLinkByText(linkText);
        }

        public void VerifyPageTitle(string pagetitle, By locator)
        {
            WaitTillElementVisible(locator);
            //string title = Driver.Title;
            SaveScreenshot();
            string title = GetText(locator);
            if (title.Equals(pagetitle))
                Console.WriteLine($"Web page loaded successfully, the title of the page is : {title}");
            else
                Console.WriteLine($"Failed to load the page: {pagetitle}");
        }

        public void BackToMainPage()
        {
            while (true)
            {
                Driver.Navigate().Back();
                Thread.Sleep(TimeSpan.FromSeconds(2));                
                if (IsElementVisible(MainPageHeaderLocator))
                {
                    string header = GetText(MainPageHeaderLocator);
                    if (header.Equals("Available Examples"))
                        break;
                }
            }
            SaveScreenshot();
        }

        public void ClickLinkByText(string linkText)
        {
            WaitTillElementVisible(By.LinkText(linkText));
            WaitTillElementClickable(By.LinkText(linkText));
            IWebElement element = Driver.FindElement(By.LinkText(linkText));
            element.Click();
        }

        public void EnterText(By locator, string inputText)
        {
            WaitTillElementVisible(locator);
            WaitTillElementClickable(locator);
            IWebElement element = Driver.FindElement(locator);
            element.Clear();
            element.SendKeys(inputText);
        }

        public void ClickElement(By locator)
        {
            WaitTillElementVisible(locator);
            WaitTillElementClickable(locator);
            IWebElement element = Driver.FindElement(locator);
            element.Click();
        }

        public void WaitTillElementVisible(By locator)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(elementTimeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public void WaitTillElementClickable(By locator)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(elementTimeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }

        public void WaitTillElementDisplay(By locator)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(elementTimeout));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
        }

        public string GetText(By locator)
        {
            WaitTillElementDisplay(locator);
            SaveScreenshot();
            IWebElement element = Driver.FindElement(locator);
            return element.Text;
        }
        public IAlert SwitchToAlert()
        {
            IAlert alert = Driver.SwitchTo().Alert();
            return alert;
        }

        public string GetPopupContent(IAlert alert)
        {
            SaveScreenshot();
            return alert.Text;
        }

        public void EnterTextInJavaScriptInput(IAlert alert, string input)
        {
            alert.SendKeys(input);
        }

        public void AcceptJavaScriptAlert(IAlert alert)
        {
            alert.Accept();
        }

        public void CancelJavaScriptAlert(IAlert alert)
        {
            alert.Dismiss();
        }

        public bool IsCheckBoxSelected(IWebElement element)
        {
            //IWebElement element = Driver.FindElement(locator);
            if(element.Selected == true)
                return true;
            else
                return false;
        }

        public bool IsElementVisible(By locator)
        {
            try
            {
                IWebElement element = Driver.FindElement(locator);
                if (element.Displayed)
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }

        public void DragAndDrop(IWebElement fromLocator, IWebElement toLocator)
        {
            Actions actions = new Actions(Driver);
            actions.DragAndDrop(fromLocator, toLocator).Build().Perform();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            SaveScreenshot();
        }

        public void SaveScreenshot()
        {
            var screenshotFolderLocation = Environment.CurrentDirectory + @"\Screenshots";
            Directory.CreateDirectory(screenshotFolderLocation);

            var fileNamePath = screenshotFolderLocation + @"\Screenshot_" + DateTime.Now.ToString(" MM_dd hh-mm-ss") + ".png";
            var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
            screenshot.SaveAsFile(fileNamePath);
        }

        public void SwitchToFrame(IWebElement element)
        {
            Driver.SwitchTo().Frame(element);
        }

        public void SwitchToDefaultWindow()
        {
            Driver.SwitchTo().DefaultContent();
        }

        public void SwitchToWindows(string title)
        {
            var getAllWindows = Driver.WindowHandles;
            var currentWindow = Driver.CurrentWindowHandle;

            foreach (var windowHandle in getAllWindows)
            {
                if(currentWindow!=windowHandle)
                {
                    Driver.SwitchTo().Window(windowHandle);
                    if(Driver.Title==title)
                    {
                        Console.WriteLine($"Child window: {title} loaded sucessfully");
                        Thread.Sleep(TimeSpan.FromSeconds(2));
                        SaveScreenshot();
                        break;
                    }
                }
            }            
            Driver.SwitchTo().Window(currentWindow);
            Console.WriteLine($"Back to main window");
        }
    }
}
