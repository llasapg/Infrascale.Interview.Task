using Infrascale.Interview.Task;
using NUnit.Framework;

namespace Infrascale.Interview.Test
{
    [TestFixture]
    public class KnightsOnABoardTests
    {
        [Test]
        public void CheckThatKnigthCantCaptureAnother_ValidCase()
        {
            // Arrange
            var chessPlateOne = new int[,] {
              { 0, 0, 0, 1, 0, 0, 0, 0 },
              { 0, 0, 0, 0, 0, 0, 0, 0 },
              { 0, 1, 0, 0, 0, 1, 0, 0 },
              { 0, 0, 0, 0, 1, 0, 1, 0 },
              { 0, 1, 0, 0, 0, 1, 0, 0 },
              { 0, 0, 0, 0, 0, 0, 0, 0 },
              { 0, 1, 0, 0, 0, 0, 0, 1 },
              { 0, 0, 0, 0, 1, 0, 0, 0 }
            };
            var chessPlateTwo = new int[,] {
              { 0, 0, 0, 1, 0, 0, 0, 0 },
              { 0, 0, 0, 0, 0, 0, 0, 1 },
              { 0, 1, 0, 0, 0, 1, 0, 0 },
              { 1, 0, 0, 0, 1, 0, 1, 0 },
              { 0, 1, 0, 0, 0, 1, 0, 0 },
              { 0, 0, 0, 0, 1, 0, 0, 0 },
              { 0, 1, 0, 0, 0, 0, 0, 1 },
              { 0, 0, 0, 0, 1, 0, 0, 0 }
            };
            var sut = new KnightsOnABoard();

            // Act
            var resultOne = sut.CheckThatKnigthCantCaptureAnother(chessPlateOne);
            var resultTwo = sut.CheckThatKnigthCantCaptureAnother(chessPlateTwo);

            // Assert
            Assert.That(resultOne == true);
            Assert.That(resultTwo == true);
        }

        [Test]
        public void CheckThatKnigthCantCaptureAnother_WrongCase()
        {
            // Arrange
            var chessPlateOne = new int[,] {
              {1, 0, 1, 0, 1, 0, 1, 0},
              {0, 1, 0, 1, 0, 1, 0, 1},
              {1, 0, 1, 0, 1, 0, 1, 0},
              {0, 0, 0, 1, 0, 1, 0, 1},
              {1, 0, 0, 0, 1, 0, 1, 0},
              {0, 0, 0, 0, 0, 1, 0, 1},
              {1, 0, 1, 0, 1, 0, 1, 0},
              {1, 0, 0, 1, 0, 0, 0, 1}
            };
            var chessPlateTwo = new int[,] {
              {1, 0, 1, 0, 1, 0, 1, 0},
              {0, 1, 0, 1, 0, 1, 0, 1},
              {1, 0, 1, 0, 1, 0, 1, 0},
              {0, 0, 0, 1, 0, 1, 0, 1},
              {1, 0, 1, 0, 1, 0, 1, 0},
              {0, 0, 0, 0, 0, 1, 0, 1},
              {0, 0, 1, 0, 1, 0, 1, 0},
              {1, 0, 0, 1, 1, 0, 0, 1}
            };
            var sut = new KnightsOnABoard();

            // Act
            var firstResult = sut.CheckThatKnigthCantCaptureAnother(chessPlateOne);
            var secondResult = sut.CheckThatKnigthCantCaptureAnother(chessPlateTwo);

            // Assert
            Assert.That(firstResult == false);
            Assert.That(secondResult == false);
        }
    }
}