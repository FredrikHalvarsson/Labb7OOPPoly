using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OOPPoly
{
    internal class Rectangle : Geometri
    {
        public Rectangle()
        {
            Base = 8;
            Height = 5;
            //konstruktor med fasta värden
        }
        public int Base { get; set; }
        public int Height { get; set; }
        //Formens värden som egenskaper.
        public override double Area()
        {
            return Base * Height;
            //Uträkning för area
        }
    }
}
