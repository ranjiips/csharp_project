using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UnitTestProject.Hooks;
using UnitTestProject.Pages;

namespace UnitTestProject
{
    [TestClass]
    public class TestSetup
    {
        [TestInitialize]
        public void TestInitialize1()
        {
            Console.WriteLine("Test Initiallize");
            //Driver = new ChromeDriver();
            GlobalPage.Driver = new DriverFactory().GetWebDriver();
            ((IJavaScriptExecutor)GlobalPage.Driver).ExecuteScript("window.focus();");
            Console.WriteLine("\t\tCreate new WebDriver");
            Page.LoginPage.LoginUser();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("home",Page.HomePage.GetHomePageLabel().ToLower());
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Test Method-2");
        }
    }
}
