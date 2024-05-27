using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.factories
{
    class ConcreteCreatorPlane : Creator
    {
        public override HalfSmth FactoryMethod()
        {
            return new HalfPlane();
        }
    }

    class ConcreteCreatorSpace : Creator
    {
        public override HalfSmth FactoryMethod()
        {
            return new HalfSpace();
        }
    }
}
