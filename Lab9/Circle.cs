using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Circle
    {
        
        public double radius;
        public double area;

        public double Radius
        {
            set { radius = value; }

            get { return radius; }

        }



        public static void GetArea()
        {

           return (Math.PI*(double.Radius*Radius);
            //Console.WriteLine(GetArea);
        }

        public static void GetCircumference()
        {
            return (2 * (Math.PI * Radius));
            //Console.WriteLine(GetCircumference);
        }
    }
}

