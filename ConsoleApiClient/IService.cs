namespace ConsoleApiClient
{
    using System.Threading.Tasks;

    public interface IService
    {
        Task<string> GetAsync();
    }
}