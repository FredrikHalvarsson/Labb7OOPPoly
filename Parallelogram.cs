using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OOPPoly
{
    internal class Parallelogram : Geometri
    {
        public Parallelogram()
        {
            Base = 22;
            Height = 17;
        }
        public int Base { get; set; }
        public int Height { get; set; }
        public override double Area()
        {
            return Base * Height;
            //Uträkningen för arean på ett parallellogram är detsamma som den för en rektangel och denna klass är därför egentligen överflödig.
        }
    }
}
