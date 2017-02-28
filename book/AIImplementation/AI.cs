using book.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.AIImplementation
{
    public class AI
    {
        public Actor Actor { get; internal set; }

        public Direction TurnAction { get; set; }

        internal void DetermineTurnAction() => TurnAction = Direction.C;
    }
}
