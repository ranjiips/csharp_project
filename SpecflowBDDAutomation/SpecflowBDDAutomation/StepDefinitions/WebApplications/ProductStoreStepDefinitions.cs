using System;
using TechTalk.SpecFlow;

namespace SpecflowBDDAutomation.StepDefinitions.WebApplications
{
    [Binding]
    public class ProductStoreStepDefinitions
    {
        [When(@"I select the Sign up option from the Navigation Bar")]
        public void WhenISelectTheSignUpOptionFromTheNavigationBar()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see the Sign up popup appear")]
        public void ThenIShouldSeeTheSignUpPopupAppear()
        {
            throw new PendingStepException();
        }

        [When(@"I fill the new username and password")]
        public void WhenIFillTheNewUsernameAndPassword(Table table)
        {
            throw new PendingStepException();
        }

        [When(@"I click the Signup button")]
        public void WhenIClickTheSignupButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see the Sign up successful popup message")]
        public void ThenIShouldSeeTheSignUpSuccessfulPopupMessage()
        {
            throw new PendingStepException();
        }
    }
}
