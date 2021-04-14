using System.Threading.Tasks;
using EBANK.Models.TokenAuth;
using EBANK.Web.Controllers;
using Shouldly;
using Xunit;

namespace EBANK.Web.Tests.Controllers
{
    public class HomeController_Tests: EBANKWebTestBase
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