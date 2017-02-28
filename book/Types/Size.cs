using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Types
{
    public class Size
    {
        public Size() { }
        public Size(int w, int h) { Width = w; Height = h; }

        int Width { get; set; }
        int Height { get; set; }
    }
}
