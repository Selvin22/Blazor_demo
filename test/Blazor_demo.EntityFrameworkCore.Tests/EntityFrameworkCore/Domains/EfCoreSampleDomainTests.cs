using Blazor_demo.Samples;
using Xunit;

namespace Blazor_demo.EntityFrameworkCore.Domains;

[Collection(Blazor_demoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<Blazor_demoEntityFrameworkCoreTestModule>
{

}
