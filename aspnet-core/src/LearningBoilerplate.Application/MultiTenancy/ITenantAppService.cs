using Abp.Application.Services;
using LearningBoilerplate.MultiTenancy.Dto;

namespace LearningBoilerplate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

