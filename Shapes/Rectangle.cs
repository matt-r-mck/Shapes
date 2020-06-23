using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes {
    public class Rectangle : Quadrilateral { //inherits quad


        public void FindArea() { 
            Console.WriteLine($"The area is {Leg1 * Leg2}");
        }

        public Rectangle(int l1, int l2) : base(l1, l2, l1, l2) {

        }
    }
}
