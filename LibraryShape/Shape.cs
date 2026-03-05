using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryShape
{
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
        public override abstract string ToString();
    }
}
