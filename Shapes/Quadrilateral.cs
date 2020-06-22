using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes {
    public class Quadrilateral {

        //public int Leg1 { get; set; }
        //public int Leg2 { get; set; }
        //public int Leg3 { get; set; }
        //public int Leg4 { get; set; }
        public int Perimeter { get; set; }

        public Quadrilateral() {

        }

        public int FindPerimeter(int Leg1, int Leg2, int Leg3, int Leg4) {
            Perimeter = (Leg1 + Leg2 + Leg3 + Leg4);
            return Perimeter;
        }

    }
}
