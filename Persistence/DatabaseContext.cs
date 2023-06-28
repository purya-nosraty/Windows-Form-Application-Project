using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DatabaseContext :
	Microsoft.EntityFrameworkCore.DbContext
{
#pragma warning disable CS8618
	public DatabaseContext() : base()
#pragma warning restore CS8618
	{
		// **************************************************
		Database.EnsureCreated();
		// **************************************************
	}

	public Microsoft.EntityFrameworkCore.DbSet<Domain.User> Users { get; set; }

	protected override void OnConfiguring
		(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
	{
		var connectionString =
			"Server=.;Database=USER_MANAGEMENT;MultipleActiveResultSets=true;Trusted_Connection=True;TrustServerCertificate=True;";

		// using Microsoft.EntityFrameworkCore;
		optionsBuilder.UseSqlServer
			(connectionString: connectionString);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly
			(assembly: typeof(DatabaseContext).Assembly);
	}
}
