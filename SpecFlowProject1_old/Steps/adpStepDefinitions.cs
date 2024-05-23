using System;
using TechTalk.SpecFlow;
using SpecFlowProject1.Hooks;
using SpecFlowProject1.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class PK_ADPPortalSteps : BaseWebPage
    {
        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            Assert.AreEqual("home", Page.HomePage.GetHomePageLabel().ToLower());
        }
        
        [Given(@"View the current month pay slip")]
        public void GivenViewTheCurrentMonthPaySlip()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"View the tax statement")]
        public void GivenViewTheTaxStatement()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
