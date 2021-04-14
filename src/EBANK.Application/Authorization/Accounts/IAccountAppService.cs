using System.Threading.Tasks;
using Abp.Application.Services;
using EBANK.Authorization.Accounts.Dto;

namespace EBANK.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
