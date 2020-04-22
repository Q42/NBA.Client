using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestEase;
using System;

namespace NBA.Client
{
    public class NBAClient
    {
        private const string apiBaseUrl = "https://api.biodiversitydata.nl/v2/";

        public static INBApi GetClient(string baseUrl = apiBaseUrl)
        {
            var nbApi = new RestClient(baseUrl)
            {

                JsonSerializerSettings = new JsonSerializerSettings()
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                }
            }.For<INBApi>();
            return nbApi;
        }
    }
}
