using Microsoft.EntityFrameworkCore;

namespace Post.Query.Infrastructure.DataAccess
{
  public class DatabaseConetextFactory
  {
    private readonly Action<DbContextOptionsBuilder> _configureDbContext;

    public DatabaseConetextFactory(Action<DbContextOptionsBuilder> configureDbContext)
    {
      _configureDbContext = configureDbContext;
    }

    public DatabaseContext CreateDbContext()
    {
      DbContextOptionsBuilder<DatabaseContext> optionsBuilder = new();
      _configureDbContext(optionsBuilder);

      return new DatabaseContext(optionsBuilder.Options);
    }
  }
}