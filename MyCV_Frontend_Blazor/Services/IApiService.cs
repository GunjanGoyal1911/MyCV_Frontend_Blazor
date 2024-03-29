﻿using MyCV_Frontend_Blazor.Data;

namespace MyCV_Frontend_Blazor.Services
{
    public interface IApiService
    {
        Task<UserModel> CreateCV(UserModel user);
        Task<UserModel> GetUserData(string userName);
        Task<UserModel> UpdateUserData(UserModel user);
        Task<Skill>AddSkill(Skill skill);
        Task<Skill> UpdateSkill(Skill skill);
        Task DeleteSkill(int skillId);
        Task<Project> AddProject(Project project);
        Task<Project> UpdateProject(Project project);
        Task DeleteProject(int projectId);

        Task<string> GetRandomJoke();
    }
}
