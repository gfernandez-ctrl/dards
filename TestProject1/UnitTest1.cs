using System;
using Xunit;

namespace TestDards
{
    public class TestDardsGame
    {
        [Fact]
        public void TestPlayerTurn()
        {
            // Arrange
            Random rnd = new Random();
            var dards = new DardsTestHelper();
            int[,] diana = dards.InitializeDiana();
            int currentScore = 0;
            int playerNumber = 1;

            
            int simulatedX = 3;
            int simulatedY = 3;
            int expectedPoints = diana[simulatedX, simulatedY];

            // Act
            int newScore = dards.SimulatePlayerTurn(diana, currentScore, playerNumber, simulatedX, simulatedY);

            // Assert
            Assert.Equal(currentScore + expectedPoints, newScore);
        }
    }

    public class DardsTestHelper
    {
        public int[,] InitializeDiana()
        {
            return new int[,]
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 1, 1, 1, 1, 1, 1, 0 },
                { 0, 1, 2, 2, 2, 2, 2, 1, 0 },
                { 0, 1, 2, 5, 5, 5, 2, 1, 0 },
                { 0, 1, 2, 5, 10, 5, 2, 1, 0 },
                { 0, 1, 2, 5, 5, 5, 2, 1, 0 },
                { 0, 1, 2, 2, 2, 2, 2, 1, 0 },
                { 0, 1, 1, 1, 1, 1, 1, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            };
        }

        public int SimulatePlayerTurn(int[,] diana, int currentScore, int playerNumber, int x, int y)
        {
            int points = diana[x, y];
            return currentScore + points;
        }
    }
}