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

        public double Area
        {
            set { area = value; }
            get { return area; }
        }


        public double GetArea()
        {
            Console.WriteLine();
        }

        public double GetCurcumference()
        {

        }
    }
}
