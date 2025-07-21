public class StatSubmission
{
	public int Id { get; set; }
	public int GameSessionId { get; set; }
	public GameSession? GameSession { get; set; }

	public int PlayerLevel { get; set; }
	public int EnemiesDefeated { get; set; }
	public int DeathCount { get; set; }

	public string? RawJson { get; set; }
}