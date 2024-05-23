using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SpecFlowProject1.Hooks;
using SpecFlowProject1.Pages;

namespace SpecFlowProject1
{
    [Binding]
    public class TestSetup : BaseWebPage
    {
        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {
            GlobalPage.Driver = new DriverFactory().GetWebDriver();
            ((IJavaScriptExecutor)GlobalPage.Driver).ExecuteScript("window.focus();");
            Console.WriteLine("\t\tCreate new WebDriver");
            Page.LoginPage.LoginUser();
        }
    }
}
