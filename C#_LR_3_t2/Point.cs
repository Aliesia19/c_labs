using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LR_3_t2
{
    internal class Point
    {
            public int X { get; }
            public int Y { get; }
            public string Label { get; }

        public Point(int x, int y, string label)
        {
            X = x;
            Y = y;
            Label = label;
        }
        
    }
}
