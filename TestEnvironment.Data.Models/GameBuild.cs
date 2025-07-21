public class GameBuild
{
	public int Id { get; set; }

	public string Version { get; set; } = default!;
	public string Description { get; set; } = default!;

	public string FilePath { get; set; } = default!;
	public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

	public bool IsPublic { get; set; } = true;
}