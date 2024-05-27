using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class HalfPlane : HalfSmth
    {
        public HalfPlane() : this(0, 0, 0)
        { }
        public HalfPlane(double a1, double a2, double b)
        {
            coefficients = new double[] { a1, a2, b };
        }

        public override void SetCoefficients(double[] coeficients)
        {
            this.coefficients[0] = coeficients[0];
            this.coefficients[1] = coeficients[1];
            this.coefficients[2] = coeficients[2];
        }
        public override void GetCoeficientFromConsole()
        {
            Console.WriteLine("Write coeficients a1, a2, b:");
            List<double> input = Console.ReadLine().Split(' ').Select(c => double.Parse(c)).ToList();
            while (input.Count < 3)
            {
                input.Add(0);
            }
            coefficients[0] = input[0];
            coefficients[1] = input[1];
            coefficients[2] = input[2];
        }

        public override void DisplayCoefficients()
        {
            Console.WriteLine($"Coefficients: {coefficients[0]}, {coefficients[1]}, {coefficients[2]}");
        }

        public override bool IsPointInside()
        {
            Console.WriteLine("Enter point coordinates x,y:");
            double[] x = Console.ReadLine().Split(' ').Select(cor => double.Parse(cor)).ToArray();
            return x[0] * coefficients[0] + x[1] * coefficients[1] < coefficients[2];
        }
    }
}
