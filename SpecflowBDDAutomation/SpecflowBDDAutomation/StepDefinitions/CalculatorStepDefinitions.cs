using NUnit.Framework;
using TechTalk.SpecFlow.Assist;

namespace SpecflowBDDAutomation.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        public int number1 { get; set; }
        public int number2 { get; set; }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            number1 = number;
            Console.WriteLine($"{nameof(GivenTheFirstNumberIs)} is {number1}");
        }


        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            number2 = number;
            Console.WriteLine($"{nameof(GivenTheSecondNumberIs)} is {number2}");
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded() => Console.WriteLine("Adding the numbers");

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result) => Assert.AreEqual(number1 + number2, result);

        [Then(@"the test case is ""([^""]*)""")]
        public void ThenTheTestCaseIs(string pASSED) => Console.WriteLine(pASSED);

        [Given(@"I input the following the numbers in the calculator")]
        public void GivenIInputTheFollowingTheNumbersInTheCalculator(Table table)
        {
            var datas = table.CreateSet<Calculation>();
            foreach (var item in datas)
            {
                Console.WriteLine(item.Numbers);
            }

            dynamic dataa = table.CreateDynamicSet();
            foreach (var item in dataa)
            {
                Console.WriteLine($"The numbers are {item.Numbers}"); //Numbers from feature file table header
            }
        }

        [Then(@"I should see the below details")]
        public void ThenIShouldSeeTheBelowDetails(Table table)
        {
            dynamic datas = table.CreateDynamicInstance();
            Console.WriteLine($"Result value is {datas.Results} and the operator is {datas.Operator}");
        }

    }

    public record Calculation
    {
        public int Numbers { get; set; }
    }
}
