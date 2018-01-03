namespace ConsoleApiClient
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("GetAsync to an API: ");
                GetAsync().Wait();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static async Task<string> GetAsync()
        {
            HttpResponseMessage response = await GetHttpResponseMessage();
            string stringResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine(stringResponse);

            return stringResponse;
        }

        private static async Task<HttpResponseMessage> GetHttpResponseMessage()
        {
            using (HttpClient client = new HttpClient())
            {
                return await client.GetAsync("https://dog.ceo/api/breeds/list/all");
            }
        }
    }
}