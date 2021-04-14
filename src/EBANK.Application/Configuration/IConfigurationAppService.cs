using System.Threading.Tasks;
using EBANK.Configuration.Dto;

namespace EBANK.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
