using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes {
    public class Rectangle : Quadrilateral {

        public Rectangle(int l1, int l2) : base(l1, l2, l1, l2) {

        }

        public void Area(int l1, int l2) {
            var area = l1 * l2;
            Console.WriteLine($"The area is {area}");
        }

    }
}
