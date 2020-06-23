using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes {
    public class Quadrilateral {

        protected int Leg1 { get; set; } //protected means that only available to class that calls it
        protected int Leg2 { get; set; }
        protected int Leg3 { get; set; }
        protected int Leg4 { get; set; }

        public Quadrilateral(int l1, int l2, int l3, int l4) { //default constructor takes 4 parameters
            Leg1 = l1;
            Leg2 = l2;
            Leg3 = l3;
            Leg4 = l4;
        }

        public void FindPerimeter() {
            Console.WriteLine($"Perimeter is {Leg1 + Leg2 + Leg3 + Leg4}");
            
        }

    }
}
