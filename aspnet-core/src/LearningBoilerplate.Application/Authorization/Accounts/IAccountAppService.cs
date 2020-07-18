using System.Threading.Tasks;
using Abp.Application.Services;
using LearningBoilerplate.Authorization.Accounts.Dto;

namespace LearningBoilerplate.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
