using Microsoft.EntityFrameworkCore;
using SixMinimalApi.Models;

namespace SixMinimalApi.Data
{
	public class AppDbContext: DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

		public DbSet<Command> commands => Set<Command>();
	}
}

