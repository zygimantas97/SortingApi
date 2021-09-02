using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using SortingApi.Contracts.V1.Requests;
using SortingApi.Contracts.V1.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortingApi.Tests.Controllers.V1
{
    [TestFixture]
    public class SortingController
    {
        [Test]
        public void SortSequence_WithCorrectFormatOfSequence_ReturnsSortedSequence()
        {
            // Arrange
            var sortingRequest = new SortingRequest
            {
                Sequence = "3 5 1 4 2",
                Algorithm = AlgorithmType.BubbleSort
            };
            var expectedSortedSequence = "1 2 3 4 5";
            var sortingController = new SortingApi.Controllers.V1.SortingController();

            // Act
            var actionResult = sortingController.SortSequence(sortingRequest);
            var objectResult = actionResult as ObjectResult;
            sortingController.DeleteLastSortedSequence();

            // Assert
            Assert.NotNull(objectResult);
            Assert.AreEqual(201, objectResult.StatusCode);
            Assert.IsInstanceOf<SortingResponse>(objectResult.Value);
            Assert.AreEqual(expectedSortedSequence, (objectResult.Value as SortingResponse).SortedSequence);
        }

        [Test]
        public void SortSequence_WithIncorrectFormatOfSequence_ReturnsBadRequest()
        {
            // Arrange
            var sortingRequest = new SortingRequest
            {
                Sequence = "three five one four two",
                Algorithm = AlgorithmType.BubbleSort
            };
            var sortingController = new SortingApi.Controllers.V1.SortingController();

            // Act
            var actionResult = sortingController.SortSequence(sortingRequest);
            var objectResult = actionResult as ObjectResult;

            // Assert
            Assert.NotNull(objectResult);
            Assert.AreEqual(400, objectResult.StatusCode);
        }

        [Test]
        public void GetLastSortedSequence_WithExistingSortedSequence_ReturnsSortedSequence()
        {
            // Arrange
            var sortingRequest = new SortingRequest
            {
                Sequence = "3 5 1 4 2",
                Algorithm = AlgorithmType.BubbleSort
            };
            var expectedSortedSequence = "1 2 3 4 5";
            var sortingController = new SortingApi.Controllers.V1.SortingController();

            // Act
            sortingController.SortSequence(sortingRequest);
            var actionResult = sortingController.GetLastSortedSequence();
            var objectResult = actionResult as ObjectResult;
            sortingController.DeleteLastSortedSequence();

            // Assert
            Assert.NotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);
            Assert.IsInstanceOf<SortingResponse>(objectResult.Value);
            Assert.AreEqual(expectedSortedSequence, (objectResult.Value as SortingResponse).SortedSequence);
        }

        [Test]
        public void GetLastSortedSequence_WithNotExistingSortedSequence_ReturnsNotFound()
        {
            // Arrange
            var sortingController = new SortingApi.Controllers.V1.SortingController();

            // Act
            var actionResult = sortingController.GetLastSortedSequence();
            var objectResult = actionResult as ObjectResult;

            // Assert
            Assert.NotNull(objectResult);
            Assert.AreEqual(404, objectResult.StatusCode);
        }

        [Test]
        public void DeleteLastSortedSequence_WithExistingSortedSequence_ReturnsSortedSequence()
        {
            // Arrange
            var sortingRequest = new SortingRequest
            {
                Sequence = "3 5 1 4 2",
                Algorithm = AlgorithmType.BubbleSort
            };
            var expectedSortedSequence = "1 2 3 4 5";
            var sortingController = new SortingApi.Controllers.V1.SortingController();

            // Act
            sortingController.SortSequence(sortingRequest);
            var actionResult = sortingController.DeleteLastSortedSequence();
            var objectResult = actionResult as ObjectResult;

            // Assert
            Assert.NotNull(objectResult);
            Assert.AreEqual(200, objectResult.StatusCode);
            Assert.IsInstanceOf<SortingResponse>(objectResult.Value);
            Assert.AreEqual(expectedSortedSequence, (objectResult.Value as SortingResponse).SortedSequence);
        }

        [Test]
        public void DeleteLastSortedSequence_WithNotExistingSortedSequence_ReturnsNotFound()
        {
            // Arrange
            var sortingController = new SortingApi.Controllers.V1.SortingController();

            // Act
            var actionResult = sortingController.DeleteLastSortedSequence();
            var objectResult = actionResult as ObjectResult;

            // Assert
            Assert.NotNull(objectResult);
            Assert.AreEqual(404, objectResult.StatusCode);
        }
    }
}
