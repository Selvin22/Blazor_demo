using Xunit;

namespace Blazor_demo.EntityFrameworkCore;

[CollectionDefinition(Blazor_demoTestConsts.CollectionDefinitionName)]
public class Blazor_demoEntityFrameworkCoreCollection : ICollectionFixture<Blazor_demoEntityFrameworkCoreFixture>
{

}
