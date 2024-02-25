using System.Net.Http;
using MyCV_Frontend_Blazor.Data;
using static System.Net.WebRequestMethods;

namespace MyCV_Frontend_Blazor.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;       
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
                // Assign the UserModelId to the new skill before sending to the API
                //newSkill.SkillId = userId;

                var response = await _httpClient.PutAsJsonAsync($"{baseUrl}{"/users"}", user);
                return await response.Content.ReadFromJsonAsync<UserModel>();
            }
            catch (Exception ex)
            {
                // Handle exceptions or return null
                Console.WriteLine($"Error adding skill: {ex.Message}");
                return null;
            }
        }

        public async Task<Skill> AddSkill(Skill skill)
        {
            try
            {
                // Assign the UserModelId to the new skill before sending to the API
                //newSkill.SkillId = userId;

                var response = await _httpClient.PutAsJsonAsync($"{baseUrl}{"/addskill"}", skill);
                return await response.Content.ReadFromJsonAsync<Skill>();
            }
            catch (Exception ex)
            {
                // Handle exceptions or return null
                Console.WriteLine($"Error adding skill: {ex.Message}");
                return null;
            }
        }

        public async Task<Skill> UpdateSkill(Skill skill)
        {
            try
            {
                // Assign the UserModelId to the new skill before sending to the API
                //newSkill.SkillId = userId;

                var response = await _httpClient.PutAsJsonAsync($"{baseUrl}{"/updateskill"}", skill);
                return await response.Content.ReadFromJsonAsync<Skill>();
            }
            catch (Exception ex)
            {
                // Handle exceptions or return null
                Console.WriteLine($"Error adding skill: {ex.Message}");
                return null;
            }
        }

        public async Task DeleteSkill(int skillId)
        {
            try
            {
                // Assign the UserModelId to the new skill before sending to the API
                //newSkill.SkillId = userId;

                string finalUrl = $"{baseUrl}{"/users/"}{skillId}";
                var response = await _httpClient.DeleteAsync(finalUrl);                
            }
            catch (Exception ex)
            {
                // Handle exceptions or return null
                Console.WriteLine($"Error adding skill: {ex.Message}");                
            }
        }

    }
}
