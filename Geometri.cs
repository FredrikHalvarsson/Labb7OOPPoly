using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7OOPPoly
{
    //Abstrakt klass eftersom den endast ska ärvas
    internal abstract class Geometri
    {
        public Geometri()
        {
            Pi = 3.141f;
        }
        public float Pi { get; }
        //Pi är alltid Pi, därför lägger jag Egenskapen och konstruktorn för på i basklassen
        //Man kan heller inte ändra på Pi därav ingen "set" i prop.
        public abstract double Area();
        //Abstrakt metod som överskrids av ärvande klasser
    }
}
