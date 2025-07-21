using TestEnvironment.Data.Models;

public class GameSession
{
	public int Id { get; set; }
	public int PlayerId { get; set; }
	public Player? Player { get; set; }

	public int Level { get; set; }
	public TimeSpan PlayTime { get; set; }
	public DateTime DateSubmitted { get; set; } = DateTime.UtcNow;

	public virtual ICollection<DeathEvent> DeathEvents { get; set; } = new HashSet<DeathEvent>();
	public StatSubmission? StatSubmission { get; set; }
}