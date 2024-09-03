using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pr4
{
    public class Point
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public void Deconstruct(out float x, out float y)
        {
            x = X;
            y = Y;
        }
    }
}
