using CommuteBuddy.Core.Models;

namespace CommuteBuddy.Core.Services;

public class StorageService
{
    public async Task SaveReviewSessionAsync(ReviewSession reviewSession)
    {
        // TODO: Implement review session storage
        throw new NotImplementedException("SaveReviewSessionAsync not yet implemented");
    }

    public async Task<List<ReviewSession>> GetReviewHistoryAsync(Guid userId)
    {
        // TODO: Implement review history retrieval
        throw new NotImplementedException("GetReviewHistoryAsync not yet implemented");
    }

    public async Task SaveConversationLogAsync(ConversationLog conversationLog)
    {
        // TODO: Implement conversation log storage with privacy
        throw new NotImplementedException("SaveConversationLogAsync not yet implemented");
    }

    public async Task ApplyRetentionPolicyAsync(Guid userId, TimeSpan retentionPeriod)
    {
        // TODO: Implement data retention policy
        throw new NotImplementedException("ApplyRetentionPolicyAsync not yet implemented");
    }
}
