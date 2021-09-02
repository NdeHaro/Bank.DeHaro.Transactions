using System;
using System.Reflection;

namespace DeHaro.CabbieGeometry.Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(5, 5);
            var p2 = new Point(2, 3);
            var MDist = new ManhattanDistance(p1, p2);
            // TO ACCESS A PRIVATE METHOD
            //typeof(ManhattanDistance).GetMethod("IDistanceMeassurement.calculate", BindingFlags.NonPublic | BindingFlags.Instance).
            //Invoke(new ManhattanDistance(), null);
            Console.WriteLine("¡Wanna kill myself!");
            var solucion = MDist.calculate();

            Console.WriteLine("la solucion  es: ");
            Console.WriteLine(solucion + "");
        }
    }

   
}

