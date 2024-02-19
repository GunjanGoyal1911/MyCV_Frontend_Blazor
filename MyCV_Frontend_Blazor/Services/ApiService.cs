using MyCV_Frontend_Blazor.Data;

namespace MyCV_Frontend_Blazor.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<UserModel> CreateCV(UserModel user)
        {        
            var response = await _httpClient.PostAsJsonAsync("https://localhost:7280/users", user);
            return await response.Content.ReadFromJsonAsync<UserModel>();
        }
    }
}
