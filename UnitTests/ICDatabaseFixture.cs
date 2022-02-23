using Microsoft.EntityFrameworkCore;
using Mux;

namespace UnitTests;

public class ICDatabaseFixture
{
    private const string ConnectionString = "Server=192.168.0.254;Database=Testing;User Id=sa;Password=Tlacua015;";
    private static readonly object Lock = new();
    private static bool DatabaseInitialized;

    public ICDatabaseFixture()
    {
        lock (Lock)
        {
            if (!DatabaseInitialized)
            {
                using var context = CreateContext();

                context.Database.EnsureCreated();
                DatabaseInitialized = true;
            }
        }
    }
    
    public ICContext CreateContext()
    {
        return new ICContext(new DbContextOptionsBuilder<ICContext>()
            .UseSqlServer(ConnectionString)
            .EnableDetailedErrors()
            .EnableSensitiveDataLogging()
            .Options);
    }
}