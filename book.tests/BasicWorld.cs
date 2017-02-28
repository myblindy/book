using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using book;
using book.Types;
using book.AIImplementation;

namespace book.tests
{
    [TestClass]
    public class BasicWorld
    {
        [TestMethod]
        public void InitializeGame()
        {
            var game = new BookGame(new WorldMap(new Size(50, 50)));
        }

        [TestMethod]
        public void PlayerActor()
        {
            var game = new BookGame(new WorldMap(new Size(50, 50)));

            var actor = new Actor(game) { X = 25, Y = 20 };
            actor.AI = game.PlayerAI;
            game.Actors.Add(actor);

            actor.AI.TurnAction = Direction.NE;
            game.ProcessTurn();
            Assert.IsTrue(actor.X == 24 && actor.Y == 21);

            actor.AI.TurnAction = Direction.N;
            game.ProcessTurn();
            Assert.IsTrue(actor.X == 23 && actor.Y == 21);

            actor.AI.TurnAction = Direction.C;
            game.ProcessTurn();
            Assert.IsTrue(actor.X == 23 && actor.Y == 21);
        }
    }
}
