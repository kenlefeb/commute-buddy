namespace CommuteBuddy.Core.Models;

public class ConversationLog
{
    public Guid LogId { get; set; }
    public Guid SessionId { get; set; }
    public string Transcript { get; set; } = string.Empty;
    public List<DateTime> Timestamps { get; set; } = new();
    public string PrivacyStatus { get; set; } = string.Empty;

    public void Validate()
    {
        if (LogId == Guid.Empty)
            throw new ArgumentException("LogId cannot be empty");
        
        if (SessionId == Guid.Empty)
            throw new ArgumentException("SessionId cannot be empty");
        
        if (string.IsNullOrWhiteSpace(PrivacyStatus))
            throw new ArgumentException("PrivacyStatus cannot be empty");
    }
}
