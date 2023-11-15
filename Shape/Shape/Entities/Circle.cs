using Shape.Entities.Enum;
using System.Globalization;
using System;

namespace Shape.Entities
{
    internal class Circle: Shapee
    {


        public double Radius { get; set; }

        public Circle(double radius, Color color): base(color) {
        
            Radius = radius;
        
        }



        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);


        }



    }
}
