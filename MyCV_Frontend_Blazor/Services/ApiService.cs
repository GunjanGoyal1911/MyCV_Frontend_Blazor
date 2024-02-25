using MyCV_Frontend_Blazor.Data;

namespace MyCV_Frontend_Blazor.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;
        //private string baseUrl = "https://gunjancvapi.azurewebsites.net";
        // Pointing to local API
        private string baseUrl = "https://localhost:7280";

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserModel> CreateCV(UserModel user)
        {        
            var response = await _httpClient.PostAsJsonAsync($"{ baseUrl }{"/users"}", user);
            return await response.Content.ReadFromJsonAsync<UserModel>();
        }

        public async Task<UserModel> GetUserData(string userName)
        {
            string finalUrl = $"{baseUrl}{"/users/"}{userName}";
            var response = await _httpClient.GetAsync(finalUrl);
            return await response.Content.ReadFromJsonAsync<UserModel>();
        }

        public async Task<UserModel> UpdateUserData(UserModel user)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{baseUrl}{"/users"}", user);
                return await response.Content.ReadFromJsonAsync<UserModel>();
            }
            catch (Exception ex)
            {            
                Console.WriteLine($"Error adding skill: {ex.Message}");
                return null;
            }
        }

        public async Task<Skill> AddSkill(Skill skill)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{baseUrl}{"/addskill"}", skill);
                return await response.Content.ReadFromJsonAsync<Skill>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding skill: {ex.Message}");
                return null;
            }
        }
        public async Task<Project> AddProject(Project project)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{baseUrl}{"/addproject"}", project);
                return await response.Content.ReadFromJsonAsync<Project>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding skill: {ex.Message}");
                return null;
            }
        }

        public async Task<Skill> UpdateSkill(Skill skill)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{baseUrl}{"/updateskill"}", skill);
                return await response.Content.ReadFromJsonAsync<Skill>();
            }
            catch (Exception ex)
            {
                // Handle exceptions or return null
                Console.WriteLine($"Error updating skill: {ex.Message}");
                return null;
            }
        }

        public async Task<Project> UpdateProject(Project project)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{baseUrl}{"/updateproject"}", project);
                return await response.Content.ReadFromJsonAsync<Project>();
            }
            catch (Exception ex)
            {
                // Handle exceptions or return null
                Console.WriteLine($"Error updating skill: {ex.Message}");
                return null;
            }
        }

        public async Task DeleteSkill(int skillId)
        {
            try
            {
                string finalUrl = $"{baseUrl}{"/skills/"}{skillId}";
                var response = await _httpClient.DeleteAsync(finalUrl);                
            }
            catch (Exception ex)
            {
                // Handle exceptions or return null
                Console.WriteLine($"Error delete skill: {ex.Message}");                
            }
        }

        public async Task DeleteProject(int projectId)
        {
            try
            {
                string finalUrl = $"{baseUrl}{"/projects/"}{projectId}";
                var response = await _httpClient.DeleteAsync(finalUrl);
            }
            catch (Exception ex)
            {
                // Handle exceptions or return null
                Console.WriteLine($"Error delete skill: {ex.Message}");
            }
        }
    }
}
