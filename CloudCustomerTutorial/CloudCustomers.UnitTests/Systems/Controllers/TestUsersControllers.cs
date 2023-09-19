using CloudCustomers.API.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace CloudCustomers.UnitTests.Systems.Controllers;

public class TestUsersControllers
{
    [Fact]
    public async Task Get_OnSuccess_ReturnsStatusCode200()
    {
        // Arrange
        var sut = new UsersController();
       
       // Act
       var result = (OkObjectResult)await sut.Get();

        // Assert
        result.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task Get_OnSuccess_InvokesUserService()
    {
        // Arrange
        var mockUserService = new Mock<IUsersService>();
        var sut = new UsersController(mockUserService.Object);

        // Act
        var result = (OkObjectResult)await sut.Get();

        // Assert
    }
}