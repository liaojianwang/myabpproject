using System.Threading.Tasks;
using MyAbpProject.Configuration.Dto;

namespace MyAbpProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
