using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using SpecFlowProject1.Hooks;
using SpecFlowProject1.Pages;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;

namespace SpecFlowProject1
{
	[Binding]
    public class TestSetup : BaseWebPage
    {
        private static ScenarioContext _scenarioContext;
        private static ExtentReports _extentReports;
        private static  ExtentHtmlReporter _extentHTMLReporter;
        private static  ExtentTest _featureTest;
        private static ExtentTest _scenarioTest;
        private static string reportPath = "/repo/TestResults";

        [BeforeTestRun]
        public static void InitializeReport()
		{
            _extentHTMLReporter = new ExtentHtmlReporter(reportPath);
            _extentHTMLReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            _extentHTMLReporter.Config.DocumentTitle = "Test Framework";
            _extentHTMLReporter.Config.ReportName = "RanjiReport";
            _extentHTMLReporter.Config.Encoding = "utf-8";
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(_extentHTMLReporter);

        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            if (featureContext != null)
            {
                _featureTest = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title, featureContext.FeatureInfo.Description);
            }
        }

        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {
            GlobalPage.Driver = new DriverFactory().GetWebDriver();
            ((IJavaScriptExecutor)GlobalPage.Driver).ExecuteScript("window.focus();");
            Console.WriteLine("\t\tCreate new WebDriver");
            Page.LoginPage.LoginUser();
        }

        [AfterScenario]
        public static void AfterScenario(ScenarioContext scenarioContext)
        {
            GlobalPage.Driver.Close();
        }
    }
}
