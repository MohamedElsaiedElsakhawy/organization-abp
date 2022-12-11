using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Organizations.Pages;

public class Index_Tests : OrganizationsWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
