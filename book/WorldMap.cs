using book.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    public class WorldMap
    {
        public WorldMap(Size size) { Size = size; }

        public Size Size { get; }

        public void UpdateActorPosition(Direction direction)
        {
            throw new NotImplementedException();
        }
    }
}
