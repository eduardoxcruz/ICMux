using Xunit;

namespace UnitTests;

public class ICControllerTest : IClassFixture<ICDatabaseFixture>
{
    public ICDatabaseFixture Fixture { get; }

    public ICControllerTest(ICDatabaseFixture fixture)
    {
        Fixture = fixture;
    }
}