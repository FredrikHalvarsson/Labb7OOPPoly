using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OOPPoly
{
    internal class Circle: Geometri
    {
        public Circle()
        {
            Radius = 5;
            //Cirkelns radie, värdet på Pi hittar vi i basklassen Geometri
        }
        public int Radius { get; set; }

        public override double Area()
        {
            return Radius * Radius * Pi;
        }
    }
}