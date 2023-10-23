using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OOPPoly
{
    internal class Ellipse : Geometri
    {
        //Konstruktor
        public Ellipse()
        {
            RadiusA = 12;
            RadiusB = 8;
        }
        //Egenskaper
        public int RadiusA { get; set; }
        public int RadiusB { get; set; }

        //Metod för uträkning av area.
        public override double Area()
        {
            return Pi * RadiusA * RadiusB;
        }
    }
}
