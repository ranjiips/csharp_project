using SpecflowBDDAutomation.Hooks;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace SpecflowBDDAutomation.StepDefinitions.Sample
{
    [Binding]
    public class WebActionsStepDefinitions : BaseWebDriver
    {
        [Given(@"I navigate to the url (.*)")]
        public void GivenINavigateToTheUrlHttpsWww_Demoblaze_Com(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        [When(@"I see the home page loaded with title (.*)")]
        public void WhenISeeTheHomePageLoadedWithTitleSTORE(string title)
        {
            Assert.AreEqual(title.ToUpper(), Driver.Title.ToUpper());
        }

        [Then(@"I should see the (.*) logo")]
        public void ThenIShouldSeeThePRODUCTSTORELogo(string logo)
        {
            string logoText = Driver.FindElement(By.XPath("//a[@id='nava']")).Text;
            Console.WriteLine(logoText);
            Assert.AreEqual(logo.ToUpper(), logoText.Trim().ToUpper());
        }

        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser() => CloseBrowserInstance();
    }
}
