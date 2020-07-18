using System.Threading.Tasks;
using LearningBoilerplate.Models.TokenAuth;
using LearningBoilerplate.Web.Controllers;
using Shouldly;
using Xunit;

namespace LearningBoilerplate.Web.Tests.Controllers
{
    public class HomeController_Tests: LearningBoilerplateWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}