using SpecflowBDDAutomation.Pages.ProductStore;
using System;
using TechTalk.SpecFlow;
using SpecflowBDDAutomation.Pages;
using TechTalk.SpecFlow.Assist;

namespace SpecflowBDDAutomation.StepDefinitions.WebApplications
{
    [Binding]
    public class ProductStoreStepDefinitions
    {
        [When(@"I select the (.*) option from the Navigation Bar")]
        public void WhenISelectTheSignUpOptionFromTheNavigationBar(string option)
        {
            Pages.Pages.PS_Signup.SelectHeaderOption(option);
        }

        [Then(@"I should see the (.*) popup appear")]
        public void ThenIShouldSeeTheSignUpPopupAppear(string header)
        {
            Assert.AreEqual(header.ToLower(),Pages.Pages.PS_Signup.GetPopupHeader().ToLower());
        }

        [When(@"I fill the new username and password and click the (.*) button")]
        public void WhenIFillTheNewUsernameAndPasswordAndClickTheLogInButton(Table table, string buttonName)
        {
            dynamic data = table.CreateDynamicSet();
            foreach (dynamic item in data)
            {
                Pages.Pages.PS_Signup.EnterCredentails(item.Username, item.Password);
                Pages.Pages.PS_Signup.ClickTheFooterButton(buttonName);
            }
        }


        [Then(@"I should see the (.*) popup message")]
        public void ThenIShouldSeeTheSignUpSuccessfulPopupMessage(string message)
        {
            string value = Pages.Pages.PS_Signup.VerifyPopupMessage();
            Assert.AreEqual(message.ToUpper(), value.ToUpper());
        }

        [Then(@"I should see the home page with user name (.*)")]
        public void ThenIShouldSeeTheHomePageWithUserNameRanji_Ips(string userName)
        {
            Assert.IsTrue(Pages.Pages.PS_Signup.GetLoggedInUserName(userName));
        }

        [Then(@"I should the user signed out successfully")]
        public void ThenIShouldTheUserSignedOutSuccessfully()
        {
            Pages.Pages.PS_Signup.VeirfySignout();
        }

        [When(@"I enter the credentials (.*) and (.*)")]
        public void WhenIEnterTheCredentials(string username, string password)
        {
            Pages.Pages.PS_Signup.EnterCredentails(username, password);            
        }

        [When(@"I click the (.*) button")]
        public void WhenIClickTheLogInButton(string buttonName)
        {
            Pages.Pages.PS_Signup.ClickTheFooterButton(buttonName);
        }



    }
}
