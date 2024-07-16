namespace SpecflowBDDAutomation.StepDefinitions.Sample
{
    [Binding]
    public class UserStepDefinitions
    {
        public User person;
        private readonly ScenarioContext scenarioContext;

        public UserStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [Given(@"I enter random user data")]
        public void GivenIEnterRandomUserData()
        {
            person = new Fixture().Create<User>();
            Console.WriteLine($"The user name is {person.Name}");
            Console.WriteLine($"The user email is {person.Email}");
            Console.WriteLine($"The user address is {person.Address}");
            Console.WriteLine($"The user phone number is {person.Phone}");
        }

        [When(@"I enter random user data with static email")]
        public void WhenIEnterRandomUserDataWithStaticEmail()
        {
            person = new Fixture().Build<User>().With(x => x.Email, "Test@gmail.com").Create();

            scenarioContext.Set(person);

            Console.WriteLine($"The user name is {person.Name}");
            Console.WriteLine($"The user email is {person.Email}");
            Console.WriteLine($"The user address is {person.Address}");
            Console.WriteLine($"The user phone number is {person.Phone}");
        }

        [When(@"I input dynamic domain for (.* email)")]
        public void WhenIInputDynamicDomainForTestGmail_ComEmail(string email) => Console.WriteLine($"The random email address is {email}");


    }

    public record User
    {
        public string Name { get; init; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }
}
