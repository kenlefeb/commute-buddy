namespace CommuteBuddy.Core.Models;

public class User
{
    public Guid UserId { get; set; }
    public string Name { get; set; } = string.Empty;
    public Dictionary<string, TimeSpan> CommuteSchedule { get; set; } = new();
    public List<Guid> ReviewHistory { get; set; } = new();

    public void Validate()
    {
        if (UserId == Guid.Empty)
            throw new ArgumentException("UserId cannot be empty");
        
        if (string.IsNullOrWhiteSpace(Name))
            throw new ArgumentException("Name cannot be empty");
    }
}
