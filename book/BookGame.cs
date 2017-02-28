using book.AIImplementation;
using book.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    public class BookGame
    {
        public BookGame(WorldMap worldmap) { WorldMap = worldmap; }

        public WorldMap WorldMap { get; }
        public List<Actor> Actors { get; } = new List<Actor>();
        public AI PlayerAI { get; } = new AI();

        public void ProcessTurn()
        {
            foreach (var actor in Actors)
            {
                if (actor.AI != PlayerAI)
                    actor.AI.DetermineTurnAction();

                // furfil turn action
                var offset = Constants.DirectionToOffsets[actor.AI.TurnAction];
                actor.X += offset.Item1;
                actor.Y += offset.Item2;
            }
        }
    }
}
