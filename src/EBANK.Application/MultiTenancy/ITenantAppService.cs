using Abp.Application.Services;
using EBANK.MultiTenancy.Dto;

namespace EBANK.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

