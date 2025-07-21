using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TestEnvironment.Data.Models;

namespace TestEnvironment.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public virtual DbSet<Player> Players { get; set; } = null!;
		public virtual DbSet<GameSession> GameSessions { get; set; } = null!;
		public virtual DbSet<StatSubmission> StatSubmissions { get; set; } = null!;
		public virtual DbSet<Enemy> Enemies { get; set; } = null!;
		public virtual DbSet<DeathEvent> DeathEvents { get; set; } = null!;
		public virtual DbSet<GameBuild> GameBuild { get; set; } = null!;
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
