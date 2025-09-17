using Xunit;
using CommuteBuddy.Core.Models;

namespace CommuteBuddy.Tests.Contract;

public class UserContractTests
{
    [Fact]
    public void User_ShouldHaveRequiredProperties()
    {
        // Arrange & Act
        var user = new User();

        // Assert
        Assert.NotNull(user);
        Assert.True(user.GetType().GetProperty("UserId") != null);
        Assert.True(user.GetType().GetProperty("Name") != null);
        Assert.True(user.GetType().GetProperty("CommuteSchedule") != null);
        Assert.True(user.GetType().GetProperty("ReviewHistory") != null);
    }

    [Fact]
    public void User_ShouldAllowSettingProperties()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var name = "Test User";
        var commuteSchedule = new Dictionary<string, TimeSpan>
        {
            { "MorningStart", TimeSpan.FromHours(8) },
            { "EveningStart", TimeSpan.FromHours(17) }
        };
        var reviewHistory = new List<Guid> { Guid.NewGuid() };

        // Act
        var user = new User
        {
            UserId = userId,
            Name = name,
            CommuteSchedule = commuteSchedule,
            ReviewHistory = reviewHistory
        };

        // Assert
        Assert.Equal(userId, user.UserId);
        Assert.Equal(name, user.Name);
        Assert.Equal(commuteSchedule, user.CommuteSchedule);
        Assert.Equal(reviewHistory, user.ReviewHistory);
    }

    [Fact]
    public void User_ShouldValidateRequiredFields()
    {
        // Arrange
        var user = new User();

        // Act & Assert - These should fail until validation is implemented
        Assert.Throws<ArgumentException>(() => user.Validate());
    }
}
