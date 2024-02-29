using Blazor_demo.Samples;
using Xunit;

namespace Blazor_demo.EntityFrameworkCore.Applications;

[Collection(Blazor_demoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<Blazor_demoEntityFrameworkCoreTestModule>
{

}
