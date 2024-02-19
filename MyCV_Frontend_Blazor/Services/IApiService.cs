using MyCV_Frontend_Blazor.Data;

namespace MyCV_Frontend_Blazor.Services
{
    public interface IApiService
    {
        Task<UserModel> CreateCV(UserModel user);
    }
}
