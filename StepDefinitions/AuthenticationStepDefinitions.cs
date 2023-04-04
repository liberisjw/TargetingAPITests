using ApiTests.Model.Authentication;
using ApiTests.Utilities;
using FluentAssertions;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TemplatePOC.StepDefinitions
{
    [Binding]
    public class AuthenticationStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public AuthenticationStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"Login request")]
        public void GivenLoginRequest()
        {
            var userCredentials = DataStoreLoader.Read<LoginRequest>("Auth0Login");
            var loginRequest = new LoginRequest
            {
                Locale = userCredentials.Locale,
                Email = userCredentials.Email,
                Password = userCredentials.Password,
            };
            string body = JsonConvert.SerializeObject(loginRequest);
            _scenarioContext.Add("postBody", body);
        }
    }
}
