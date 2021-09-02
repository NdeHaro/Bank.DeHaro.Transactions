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
            //typeof(ManhattanDistance).GetMethod("IDistanceMeassurement.calculate", BindingFlags.NonPublic | BindingFlags.Instance).
            //Invoke(new ManhattanDistance(), null);
            Console.WriteLine("¡Wanna kill myself!");
            var solucion = MDist.calculate();

            Console.WriteLine("la solucion  es: ");
            Console.WriteLine(solucion + "");
        }
    }

    class ManhattanDistance
    {
        private Point _p1;
        private Point _p2;

        public ManhattanDistance(Point p1, Point p2)
        {
            _p1 = p1;
            _p2 = p2;
        }
        public int getPrivatePropety(Point p, string PropName)
        {
            Type typ = typeof(Point);
            FieldInfo type = typ.GetField(PropName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var value = type.GetValue(p);

            return (int)value;
        }

        public int calculate()
        {
            int x1 = 0;
            int x2 = 0;
            int y1 = 0;
            int y2 = 0;


            x1 = getPrivatePropety(_p1, "_x");
            x2 = getPrivatePropety(_p2, "_x");
            y1 = getPrivatePropety(_p1, "_y");
            y2 = getPrivatePropety(_p2, "_y");

           /* y1 = GetPrivateProperty<int>(_p1, "_y");
            x2 = GetPrivateProperty<int>(_p2, "_x");
            y2 = GetPrivateProperty<int>(_p2, "_y");
*/
            int FinalX, FinalY;

            FinalX = x1 - x2;
            FinalX = System.Math.Abs(FinalX);
            FinalY = y1 - y2;
            FinalY = System.Math.Abs(FinalY);

            return FinalX + FinalY;
        }

    }

    class Point
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

    }
}

