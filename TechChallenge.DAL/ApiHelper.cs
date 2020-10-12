using System.Net.Http;
using System.Net.Http.Headers;

namespace TechChallenge.DAL
{
    //API Helper Class for api default configuration
    public static class ApiHelper
    {
        #region Properties

        public static HttpClient ApiClient { get; set; } = new HttpClient();
        #endregion

        #region Method

        public static void InitialiseAPI()
        {
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        #endregion
    }
}
