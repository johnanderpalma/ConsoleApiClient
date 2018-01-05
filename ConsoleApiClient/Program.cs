namespace ConsoleApiClient
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("GetAsync to an API: ");
                IService service = new Service();
                service.GetAsync();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}