using book.AIImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    public class Actor
    {
        public BookGame BookGame { get; }

        public Actor(BookGame game) { BookGame = game; }

        private AI ai;
        public AI AI
        {
            get { return ai; }
            set
            {
                ai = value;
                ai.Actor = this;
            }
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
