using Microsoft.Win32.SafeHandles;
using System.Runtime.CompilerServices;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("Enter what to create(half-plane, half-space):");
                choice = Console.ReadLine();
            } while (choice != "half-plane" && choice != "half-space");
            HalfPlane curFigure = null;
            switch (choice)
            {
                case "half-plane":
                    curFigure = new HalfPlane();
                    break;
                case "half-space":
                    curFigure = new HalfSpace();
                    break;
            }
            curFigure.GetCoeficientFromConsole();
            if (curFigure.IsPointInside())
            {
                Console.WriteLine("Your point is inside");
            }
            else
            {
                Console.WriteLine("Your point is not inside");
            }
        }
    }
}
