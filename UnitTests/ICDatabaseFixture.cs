using Mux;

namespace UnitTests;

public class ICDatabaseFixture
{
    private const string ConnectionString = "Server=192.168.0.254;Database=Testing;User Id=sa;Password=Tlacua015;";
    private static readonly object Lock = new();
    private static bool _databaseInitialized;

    public ICDatabaseFixture()
    {
        lock (Lock)
        {
            if (!_databaseInitialized)
            {
                using var context = CreateContext();

                context.Database.EnsureCreated();
                _databaseInitialized = true;
            }
        }
    }
    
    public ICContext CreateContext()
    {
        return new ICContext();
    }
}