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



        public static double GetArea()
        {

            return (Math.PI * (Radius * Radius));
            //Console.WriteLine(GetArea);
        }

        public static double GetCircumference()
        {
            return (2 * (Math.PI * Radius));
            //Console.WriteLine(GetCircumference);
        }
    }
}

