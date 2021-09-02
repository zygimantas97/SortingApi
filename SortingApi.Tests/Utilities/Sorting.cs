using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortingApi.Tests.Utilities
{
    [TestFixture]
    public class Sorting
    {
        [Test]
        public void BubbleSort_WithSortedSequence_ReturnsSortedSequence()
        {
            // Arrange
            var sequence = new List<int>
            {
                1, 2, 3, 4, 5
            };
            var expectedSortedSequence = new List<int>()
            {
                1, 2, 3, 4, 5
            };

            // Act
            var actualSortedSequence = SortingApi.Utilities.Sorting.BubbleSort(sequence);

            // Assert
            CollectionAssert.AreEqual(expectedSortedSequence, actualSortedSequence);
        }

        [Test]
        public void BubbleSort_WithReversedSequence_ReturnsSortedSequence()
        {
            // Arrange
            var sequence = new List<int>
            {
                5, 4, 3, 2, 1
            };
            var expectedSortedSequence = new List<int>()
            {
                1, 2, 3, 4, 5
            };

            // Act
            var actualSortedSequence = SortingApi.Utilities.Sorting.BubbleSort(sequence);

            // Assert
            CollectionAssert.AreEqual(expectedSortedSequence, actualSortedSequence);
        }

        [Test]
        public void BubbleSort_WithRandomSequence_ReturnsSortedSequence()
        {
            // Arrange
            var sequence = new List<int>
            {
                3, 5, 1, 4, 2
            };
            var expectedSortedSequence = new List<int>()
            {
                1, 2, 3, 4, 5
            };

            // Act
            var actualSortedSequence = SortingApi.Utilities.Sorting.BubbleSort(sequence);

            // Assert
            CollectionAssert.AreEqual(expectedSortedSequence, actualSortedSequence);
        }

        [Test]
        public void BubbleSort_WithSequenceOfOneElement_ReturnsSequenceOfOneElement()
        {
            // Arrange
            var sequence = new List<int>
            {
                1
            };
            var expectedSortedSequence = new List<int>()
            {
                1
            };

            // Act
            var actualSortedSequence = SortingApi.Utilities.Sorting.BubbleSort(sequence);

            // Assert
            CollectionAssert.AreEqual(expectedSortedSequence, actualSortedSequence);
        }

        [Test]
        public void BubbleSort_WithEmptySequence_ReturnsEmptySequence()
        {
            // Arrange
            var sequence = new List<int>();
            var expectedSortedSequence = new List<int>();

            // Act
            var actualSortedSequence = SortingApi.Utilities.Sorting.BubbleSort(sequence);

            // Assert
            CollectionAssert.AreEqual(expectedSortedSequence, actualSortedSequence);
        }

        [Test]
        public void MergeSort_WithSortedSequence_ReturnsSortedSequence()
        {
            // Arrange
            var sequence = new List<int>
            {
                1, 2, 3, 4, 5
            };
            var expectedSortedSequence = new List<int>()
            {
                1, 2, 3, 4, 5
            };

            // Act
            var actualSortedSequence = SortingApi.Utilities.Sorting.MergeSort(sequence);

            // Assert
            CollectionAssert.AreEqual(expectedSortedSequence, actualSortedSequence);
        }

        [Test]
        public void MergeSort_WithReversedSequence_ReturnsSortedSequence()
        {
            // Arrange
            var sequence = new List<int>
            {
                5, 4, 3, 2, 1
            };
            var expectedSortedSequence = new List<int>()
            {
                1, 2, 3, 4, 5
            };

            // Act
            var actualSortedSequence = SortingApi.Utilities.Sorting.MergeSort(sequence);

            // Assert
            CollectionAssert.AreEqual(expectedSortedSequence, actualSortedSequence);
        }

        [Test]
        public void MergeSort_WithRandomSequence_ReturnsSortedSequence()
        {
            // Arrange
            var sequence = new List<int>
            {
                3, 5, 1, 4, 2
            };
            var expectedSortedSequence = new List<int>()
            {
                1, 2, 3, 4, 5
            };

            // Act
            var actualSortedSequence = SortingApi.Utilities.Sorting.MergeSort(sequence);

            // Assert
            CollectionAssert.AreEqual(expectedSortedSequence, actualSortedSequence);
        }

        [Test]
        public void MergeSort_WithSequenceOfOneElement_ReturnsSequenceOfOneElement()
        {
            // Arrange
            var sequence = new List<int>
            {
                1
            };
            var expectedSortedSequence = new List<int>()
            {
                1
            };

            // Act
            var actualSortedSequence = SortingApi.Utilities.Sorting.MergeSort(sequence);

            // Assert
            CollectionAssert.AreEqual(expectedSortedSequence, actualSortedSequence);
        }

        [Test]
        public void MergeSort_WithEmptySequence_ReturnsEmptySequence()
        {
            // Arrange
            var sequence = new List<int>();
            var expectedSortedSequence = new List<int>();

            // Act
            var actualSortedSequence = SortingApi.Utilities.Sorting.MergeSort(sequence);

            // Assert
            CollectionAssert.AreEqual(expectedSortedSequence, actualSortedSequence);
        }
    }
}
