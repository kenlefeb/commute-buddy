using Xunit;
using CommuteBuddy.Core.Services;
using CommuteBuddy.Core.Models;

namespace CommuteBuddy.Tests.Integration;

public class DailyReviewFlowIntegrationTests
{
    [Fact]
    public async Task DailyReview_ShouldCompleteFullFlow()
    {
        // Arrange
        var reviewService = new ReviewService();
        var user = new User { UserId = Guid.NewGuid(), Name = "Test User" };

        // Act & Assert - This should fail until ReviewService is implemented
        var exception = await Assert.ThrowsAsync<NotImplementedException>(() => 
            reviewService.StartDailyReviewAsync(user));
    }

    [Fact]
    public async Task DailyReview_ShouldGuideUserThroughGTDSteps()
    {
        // Arrange
        var reviewService = new ReviewService();
        var user = new User { UserId = Guid.NewGuid(), Name = "Test User" };

        // Act & Assert - This should fail until implementation
        var exception = await Assert.ThrowsAsync<NotImplementedException>(() => 
            reviewService.GuideUserThroughStepsAsync(user, new List<string> { "Capture", "Clarify", "Organize", "Reflect", "Engage" }));
    }

    [Fact]
    public async Task DailyReview_ShouldCreateSessionRecord()
    {
        // Arrange
        var reviewService = new ReviewService();
        var storageService = new StorageService();
        var user = new User { UserId = Guid.NewGuid(), Name = "Test User" };

        // Act & Assert - This should fail until services are implemented
        var exception = await Assert.ThrowsAsync<NotImplementedException>(() => 
            reviewService.CreateSessionRecordAsync(user));
    }
}
