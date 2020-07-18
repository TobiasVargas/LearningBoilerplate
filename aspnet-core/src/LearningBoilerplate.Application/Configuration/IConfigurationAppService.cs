using System.Threading.Tasks;
using LearningBoilerplate.Configuration.Dto;

namespace LearningBoilerplate.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
