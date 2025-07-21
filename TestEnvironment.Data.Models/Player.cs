using Microsoft.AspNetCore.Identity;

namespace TestEnvironment.Data.Models
{
	public class Player
	{
		public int Id { get; set; }
		public string UserId { get; set; }  // FK to Identity User
		public IdentityUser? User { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
		public virtual ICollection<GameSession> GameSessions { get; set; } = new HashSet<GameSession>();
	}
}
