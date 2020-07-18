using System.Threading.Tasks;
using Abp.Application.Services;
using LearningBoilerplate.Sessions.Dto;

namespace LearningBoilerplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
