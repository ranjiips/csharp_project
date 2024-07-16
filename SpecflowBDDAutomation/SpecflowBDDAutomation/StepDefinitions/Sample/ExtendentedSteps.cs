using FluentAssertions.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowBDDAutomation.StepDefinitions.Sample
{
    [Binding]
    public class ExtendentedSteps
    {
        private readonly ScenarioContext scenarioContext;

        public ExtendentedSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Then(@"I get the random user data")]
        public void ThenIGetTheRandomUserData()
        {
            var person = scenarioContext.Get<User>();
            Console.WriteLine($"The user name is {person.Name}");
            Console.WriteLine($"The user email is {person.Email}");
            Console.WriteLine($"The user address is {person.Address}");
            Console.WriteLine($"The user phone number is {person.Phone}");
        }

    }
}
