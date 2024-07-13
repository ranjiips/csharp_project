namespace SpecflowBDDAutomation.Transformer
{
    [Binding]
    public class EmailTransformer
    {
        [StepArgumentTransformation(@"(.*) email")]
        public string GenerateDynamicEmailAddress(string emailAddress) => emailAddress.Split("@")[0]+"@"+GetRandomDomain();        

        private string GetRandomDomain() => new Fixture().Create<MailAddress>().Host;        
    }

}
