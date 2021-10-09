using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Destination.Controller;
using Destination.Dtos;
using Destination.Entities;
using Destination.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Destination.UnitTests
{
    public class DestControllerTests
    {

        private readonly Mock<InterfaceInMemDestRepository> repositoryStub = new();
        // Unit Test naming convention (UnitofWork_StateUnderTest_ExpectedBehavior)

        [Fact]
        public void GetDestTest_WithUnexistingDestination_ReturnsNotFound()
        {
            // Arrange
            repositoryStub.Setup(repo => repo.GetDest("InvalidDestination"))
                .Returns((Dest)null);

            var controller = new DestController(repositoryStub.Object);

            // Act
            var result = controller.GetDest("InvalidDestination");

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public void GetDestTest_WithExistingDestination_ReturnsExpectedItem()
        {
            // Arrange
            var expectedDest = CreateRandomDest();
            repositoryStub.Setup(repo => repo.GetDest("AUS"))
                .Returns(expectedDest);

            var controller = new DestController(repositoryStub.Object);

            // Act
            var result = controller.GetDest("AUS");

            // Assert
            Assert.IsType<DestDto>(result.Value);
            var dto = (result as ActionResult<DestDto>).Value;
            Assert.Equal(expectedDest.Destination, dto.Destination);
            Assert.Equal(expectedDest.List, dto.List);
        }
        [Fact]
        public void GetDestsTest_WithExistingDestination_ReturnsAllDest()
        {
            // Arrange
            var expectedDests = new[]{ CreateRandomDest(), CreateRandomDest(), CreateRandomDest() };
            repositoryStub.Setup(repo => repo.GetDests())
                .Returns(expectedDests);

            var controller = new DestController(repositoryStub.Object);

            // Act
            var result = controller.GetDests();

            // Assert
            Assert.IsType<DestDto>(result.Value.ElementAt(0));
            for(int i = 0; i < result.Value.Count(); i++){
                Assert.Equal(expectedDests[i].Destination, result.Value.ElementAt(i).Destination);
                Assert.Equal(expectedDests[i].List, result.Value.ElementAt(i).List);
            }
        }

        [Fact]
        public void GetDestsTest_NoDests_NoContent()
        {
            // Arrange
            var expectedDests = new Dest[]{ };
            repositoryStub.Setup(repo => repo.GetDests())
                .Returns(expectedDests);

            var controller = new DestController(repositoryStub.Object);

            // Act
            var result = controller.GetDests();

            // Assert
            Assert.IsType<NoContentResult>(result.Result);
        }

        // Generates a Dest object to be used in API repository for testing purposes
        private Dest CreateRandomDest()
        {
            return new Dest()
            {
                Destination = "AUS",
                List = new List<string> {"USA", "CAN", "MEX"}
            };
        }
    }
}
