using Xunit;
using AspNetCoreWebService.Controllers;

namespace AspNetCoreWebServiceTest.Controllers
{
    public class HelloControllerTest
    {
        [Fact]
        public void NoInputParamPostResponseTest()
        {
            HelloController controller = new HelloController();
            var response = controller.Get().Value as Response;
            Assert.Equal("Hello World!!!", response.output);
        }
    }
}
