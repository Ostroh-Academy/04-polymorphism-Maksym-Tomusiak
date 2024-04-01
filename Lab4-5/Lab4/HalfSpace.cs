using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class HalfSpace : HalfPlane
    {
        public HalfSpace() : this(0, 0, 0, 0)
        { }
        public HalfSpace(double a1, double a2, double a3, double b)
        {
            coefficients = new double[] { a1, a2, a3, b };
        }

        public void SetCoefficients(double a1, double a2, double a3, double b)
        {
            coefficients[0] = a1;
            coefficients[1] = a2;
            coefficients[2] = a3;
            coefficients[3] = b;
        }
        public override void GetCoeficientFromConsole()
        {
            Console.WriteLine("Write coeficients a1, a2, a3, b:");
            List<double> input = Console.ReadLine().Split(' ').Select(c => double.Parse(c)).ToList();
            while (input.Count < 4)
            {
                input.Add(0);
            }
            coefficients[0] = input[0];
            coefficients[1] = input[1];
            coefficients[2] = input[2];
            coefficients[3] = input[3];
        }

        public override void DisplayCoefficients()
        {
            Console.WriteLine($"Coefficients: {coefficients[0]}, {coefficients[1]}, {coefficients[2]}, {coefficients[3]}");
        }

        public override bool IsPointInside()
        {
            Console.WriteLine("Enter point coordinates x ,y ,z:");
            double[] x = Console.ReadLine().Split(' ').Select(cor => double.Parse(cor)).ToArray();
            return x[0] * coefficients[0] + x[1] * coefficients[1] + x[2] * coefficients[2] <= coefficients[3];
        }
    }
}
