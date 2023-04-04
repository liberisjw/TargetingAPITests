using ApiTests.Utilities;
using Microsoft.Extensions.Configuration;
using TechTalk.SpecFlow;

namespace ApiTests.Hooks
{
    [Binding]
    public sealed class UriSetupHooks
    {
        private readonly ScenarioContextHelper _scenarioHelper;

        public UriSetupHooks(ScenarioContextHelper scenarioHelper)
        {
            _scenarioHelper = scenarioHelper;
        }
        
        [BeforeScenario("MX-API")]
        public void SetBaseUrl()
        {
            _scenarioHelper.AddBaseUrl("https://dev-backend-api.liberis.co.uk/mx-api");
        }
        [BeforeScenario("LiberisAPI")]
        public void SetBaseLiberisAPIUrl()
        {
            _scenarioHelper.AddBaseUrl("https://api-dev.liberis.com");
        }
    }
}
