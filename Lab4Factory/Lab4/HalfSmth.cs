using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public abstract class HalfSmth
    {
        public double[] coefficients;
        public HalfSmth()
        { }

        public virtual void SetCoefficients(double[] coeficients)
        { }
        public virtual void GetCoeficientFromConsole()
        { }

        public virtual void DisplayCoefficients()
        { }

        public virtual bool IsPointInside()
        {
            return false;
        }
    }
}
