using Lab4.factories;
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
            HalfSmth curFigure = null;
            Creator creator = null;
            switch (choice)
            {
                case "half-plane":
                    creator = new ConcreteCreatorPlane();
                    break;
                case "half-space":
                    creator = new ConcreteCreatorSpace();
                    break;
            }
            curFigure = creator.FactoryMethod();
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
