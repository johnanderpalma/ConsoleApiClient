namespace ConsoleApiClient
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class Service : IService
    {
        private const string url = "https://dog.ceo/api/breeds/list/all";

        private HttpClient HttpClient { get; set; }

        private HttpResponseMessage HttpResponseMessage { get; set; }

        public Service()
        {
            HttpClient = new HttpClient();
        }

        private async Task<HttpResponseMessage> GetHttpResponseMessage()
        {
            return await this.HttpClient.GetAsync(url);
        }

        public async Task<string> GetAsync()
        {
            this.HttpResponseMessage = await GetHttpResponseMessage();
            string stringResponse = await this.HttpResponseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(stringResponse);

            return stringResponse;
        }
    }
}