using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Types
{
    public static class Constants
    {
        public static readonly Dictionary<Direction, Tuple<int, int>> DirectionToOffsets = new Dictionary<Direction, Tuple<int, int>>
        {
            { Direction.NW, Tuple.Create(-1, -1) },
            { Direction.N, Tuple.Create(-1, 0) },
            { Direction.NE, Tuple.Create(-1, 1) },
            { Direction.W, Tuple.Create(-0, -1) },
            { Direction.C, Tuple.Create(0, 0) },
            { Direction.E, Tuple.Create(0, 1) },
            { Direction.SW, Tuple.Create(1, -1) },
            { Direction.S, Tuple.Create(1, 0) },
            { Direction.SE, Tuple.Create(1, 1) },
        };
    }
}
