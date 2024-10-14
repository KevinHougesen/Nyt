using System.Net.Http;
using System.Threading.Tasks;

namespace Nyt.Shared.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Methods for GET, POST, etc.
    }
}
