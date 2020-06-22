using System;

namespace Shapes {
    class Program {
        static void Main(string[] args) {

            var quad1 = new Quadrilateral();
            quad1.FindPerimeter(10, 10, 10, 10);
            Console.WriteLine($"{quad1.Perimeter}");

        }
    }
}
