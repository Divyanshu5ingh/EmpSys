using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.EmpSys.Pages;

public class Index_Tests : EmpSysWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
