public class User 
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public long? Weight { get; set; }
}