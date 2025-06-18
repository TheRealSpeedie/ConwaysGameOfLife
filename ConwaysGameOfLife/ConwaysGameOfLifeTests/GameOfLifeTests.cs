using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife.Tests
{
    [TestClass()]
    public class GameOfLifeTests
    {
        [TestMethod()]
        public void OverpopulationTest()
        {
            var game = new GameOfLife();
            game.SetAlive(10, 10);
            game.SetAlive(10, 11);
            game.SetAlive(10, 9);
            game.SetAlive(9, 10);
            game.SetAlive(9, 11);

            game.NextGeneration();

            Assert.IsFalse(game.IsAlive(10, 10));
        }
        [TestMethod()]
        public void UnderpopulationTest()
        {
            var game = new GameOfLife();
            game.SetAlive(10, 10);
            game.SetAlive(10, 11);

            game.NextGeneration();

            Assert.IsFalse(game.IsAlive(10, 10));
        }
        [TestMethod()]
        public void StablepopulationTest()
        {
            var game = new GameOfLife();
            game.SetAlive(10, 10);
            game.SetAlive(10, 11);
            game.SetAlive(10, 9);
            game.SetAlive(9, 11);

            game.NextGeneration();

            Assert.IsTrue(game.IsAlive(10, 10));
        }
        [TestMethod()]
        public void ReviveTest()
        {
            var game = new GameOfLife();
            game.SetAlive(10, 11);
            game.SetAlive(10, 9);
            game.SetAlive(9, 10);

            game.NextGeneration();

            Assert.IsTrue(game.IsAlive(10, 10));
        }
        [TestMethod()]
        public void NeighbourCountTest()
        {
            var game = new GameOfLife();
            game.SetAlive(10, 11);
            game.SetAlive(10, 10);
            game.SetAlive(10, 9);
            game.SetAlive(9, 10);

            var count = game.CountAliveNeighbours(10, 10);

            Assert.AreEqual(3, count);
        }
        [TestMethod()]
        public void NewGenerationTest()
        {
            var game = new GameOfLife();
            game.SetAlive(20, 20);
            game.SetAlive(21, 20);
            game.SetAlive(19, 20);

            game.NextGeneration();

            Assert.IsTrue(game.IsAlive(20, 20) && game.IsAlive(20, 19) && game.IsAlive(20, 21));
        }
    }
}