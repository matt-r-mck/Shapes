using System;

namespace Shapes {
    class Program {
        static void Main(string[] args) {

            var quad1 = new Quadrilateral(27, 13, 42, 22);
            quad1.FindPerimeter();

            var rect1 = new Rectangle(27, 13);
            rect1.FindPerimeter();
            rect1.FindArea();

            var sq1 = new Square(27);
            sq1.FindPerimeter();
            sq1.FindArea();

        }
    }
}
