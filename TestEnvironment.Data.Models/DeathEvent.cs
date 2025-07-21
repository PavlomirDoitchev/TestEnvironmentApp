public class DeathEvent
{
	public int Id { get; set; }
	public int GameSessionId { get; set; }
	public GameSession? GameSession { get; set; }

	public int EnemyId { get; set; }
	public Enemy? Enemy { get; set; }

	public string Mechanic { get; set; } = default!;
	public TimeSpan TimeOfDeath { get; set; }
}