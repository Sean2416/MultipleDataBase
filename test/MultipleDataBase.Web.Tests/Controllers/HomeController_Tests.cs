using System.Threading.Tasks;
using MultipleDataBase.Web.Controllers;
using Shouldly;
using Xunit;

namespace MultipleDataBase.Web.Tests.Controllers
{
    public class HomeController_Tests: MultipleDataBaseWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
