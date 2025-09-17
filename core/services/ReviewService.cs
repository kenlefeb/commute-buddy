using CommuteBuddy.Core.Models;

namespace CommuteBuddy.Core.Services;

public class ReviewService
{
    public async Task<ReviewSession> StartDailyReviewAsync(User user)
    {
        // TODO: Implement daily review startup logic
        throw new NotImplementedException("StartDailyReviewAsync not yet implemented");
    }

    public async Task GuideUserThroughStepsAsync(User user, List<string> steps)
    {
        // TODO: Implement GTD step guidance logic
        throw new NotImplementedException("GuideUserThroughStepsAsync not yet implemented");
    }

    public async Task<ReviewSession> CreateSessionRecordAsync(User user)
    {
        // TODO: Implement session record creation
        throw new NotImplementedException("CreateSessionRecordAsync not yet implemented");
    }
}
