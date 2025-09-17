using Xunit;
using CommuteBuddy.Core.Models;

namespace CommuteBuddy.Tests.Contract;

public class ReviewSessionContractTests
{
    [Fact]
    public void ReviewSession_ShouldHaveRequiredProperties()
    {
        // Arrange & Act
        var reviewSession = new ReviewSession();

        // Assert
        Assert.NotNull(reviewSession);
        Assert.True(reviewSession.GetType().GetProperty("SessionId") != null);
        Assert.True(reviewSession.GetType().GetProperty("UserId") != null);
        Assert.True(reviewSession.GetType().GetProperty("Date") != null);
        Assert.True(reviewSession.GetType().GetProperty("StepsCompleted") != null);
        Assert.True(reviewSession.GetType().GetProperty("Notes") != null);
        Assert.True(reviewSession.GetType().GetProperty("Interruptions") != null);
    }

    [Fact]
    public void ReviewSession_ShouldAllowSettingProperties()
    {
        // Arrange
        var sessionId = Guid.NewGuid();
        var userId = Guid.NewGuid();
        var date = DateTime.Now;
        var stepsCompleted = new List<string> { "Capture", "Clarify" };
        var notes = "Test notes";
        var interruptions = 2;

        // Act
        var reviewSession = new ReviewSession
        {
            SessionId = sessionId,
            UserId = userId,
            Date = date,
            StepsCompleted = stepsCompleted,
            Notes = notes,
            Interruptions = interruptions
        };

        // Assert
        Assert.Equal(sessionId, reviewSession.SessionId);
        Assert.Equal(userId, reviewSession.UserId);
        Assert.Equal(date, reviewSession.Date);
        Assert.Equal(stepsCompleted, reviewSession.StepsCompleted);
        Assert.Equal(notes, reviewSession.Notes);
        Assert.Equal(interruptions, reviewSession.Interruptions);
    }

    [Fact]
    public void ReviewSession_ShouldValidateRequiredFields()
    {
        // Arrange
        var reviewSession = new ReviewSession();

        // Act & Assert - These should fail until validation is implemented
        Assert.Throws<ArgumentException>(() => reviewSession.Validate());
    }
}
