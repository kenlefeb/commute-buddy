namespace CommuteBuddy.Core.Models;

public class ReviewSession
{
    public Guid SessionId { get; set; }
    public Guid UserId { get; set; }
    public DateTime Date { get; set; }
    public List<string> StepsCompleted { get; set; } = new();
    public string Notes { get; set; } = string.Empty;
    public int Interruptions { get; set; }

    public void Validate()
    {
        if (SessionId == Guid.Empty)
            throw new ArgumentException("SessionId cannot be empty");
        
        if (UserId == Guid.Empty)
            throw new ArgumentException("UserId cannot be empty");
        
        if (Date == default)
            throw new ArgumentException("Date cannot be default");
    }
}
