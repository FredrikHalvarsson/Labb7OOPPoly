using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OOPPoly
{
    internal class Square : Geometri
    {
        public Square()
        {
            Side = 50;
            //en kvadrat har samma höjd som bas och behöver därför endast ett värde
        }
        public int Side { get; set; }
        public override double Area()
        {
            return Side * Side;
        }
    }
}
