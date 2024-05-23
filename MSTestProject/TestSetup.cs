using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSTestProject.Hooks;
using MSTestProject.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject
{
    [TestClass]
    public class TestSetup : BaseWebPage
    {
        [TestInitialize]
        public static void BeforeScenario()
        {
            GlobalPage.Driver = new DriverFactory().GetWebDriver();
            ((IJavaScriptExecutor)GlobalPage.Driver).ExecuteScript("window.focus();");
            Console.WriteLine("\t\tCreate new WebDriver");
            Page.LoginPage.LoginUser();
        }

        [TestMethod]
        public void VerifyHomePage()
        {
            Assert.AreEqual("home",Page.HomePage.GetHomePageLabel());
        }
    }
}
