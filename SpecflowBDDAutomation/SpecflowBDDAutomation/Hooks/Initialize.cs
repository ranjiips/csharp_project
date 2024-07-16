namespace SpecflowBDDAutomation.Hooks
{
    [Binding]
    public sealed class Initialize
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeTestRun]
        public static void InitializeTest() => Console.WriteLine("Execute before each test case");

        [BeforeFeature]
        public static void BeforeFeatureTest() => Console.WriteLine("This is from Before Feature");

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("Before Scenario with Tag");
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario() => Console.WriteLine("After Scenario execution");

        [AfterFeature]
        public static void AfterFeatureTest() => Pages.Pages.BaseWebDriver.CloseBrowserInstance();


    }
}