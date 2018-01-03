namespace ConsoleApiClient
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GetAll: ");
            GetAsync().Wait();
            Console.ReadLine();
        }

        private static async Task<string> GetAsync()
        {
            string stringResponse = string.Empty;

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://dog.ceo/api/breeds/list/all");
                stringResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine(stringResponse);
            }

            return stringResponse;
        }
    }
}