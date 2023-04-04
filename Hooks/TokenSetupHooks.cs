using ApiTests.ApiExtensions.ApiCalls;
using ApiTests.Model.AccessToken;
using ApiTests.Model.Token;
using ApiTests.Utilities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ApiTests.Hooks
{
    [Binding]
    public sealed class TokenSetupHooks
    {
        private readonly ScenarioContextHelper _scenarioHelper;
        private static Dictionary<string, string> _accessCreds;

        public TokenSetupHooks(ScenarioContextHelper scenarioHelper)
        {
            _scenarioHelper = scenarioHelper;
        }

        [BeforeTestRun]
        public static async Task SetTokensConfig()
        {
            _accessCreds = new();
            var credentials = DataStoreLoader.Read<List<Credential>>("PartnersCreds");
            foreach (var credential in credentials)
            {
                var response = await GenerateTokens(credential.ClientId, credential.ClientSecret, credential.Url);
                _accessCreds.Add(credential.PartnerId, response.AccessToken);
            }
        }

        [BeforeScenario("GenericLiberisAPI")]
        public void SetLiberisApiCredentials()
        {
            string token = _accessCreds.GetValueOrDefault("LiberisAPI");
            _scenarioHelper.AddToken(token);
        }

        public static async Task<TokenResponse> GenerateTokens(string clientId, string clientSecret, string url)
        {
            HttpPost httpPost = new();
            var tokenRequest = new TokenRequest(clientId, clientSecret);
            string body = JsonConvert.SerializeObject(tokenRequest);
            var bodyResponse = await httpPost.PostApiAsyncNoToken<TokenResponse>(url, body);
            return bodyResponse;

        }
    }
}