using System.Threading.Tasks;
using Abp.Application.Services;
using EBANK.Sessions.Dto;

namespace EBANK.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
