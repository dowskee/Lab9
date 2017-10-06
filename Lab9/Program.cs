using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int Count = 0;

             bool Continue = true;
             while (Continue == true)

            {
                

                Circle RadiusInput = new Circle();
                Count++;

                Console.WriteLine("Please enter the Radius");
                RadiusInput.Radius = double.Parse(Console.ReadLine());

               
                Console.WriteLine($"The area is: { RadiusInput.GetArea() }");
                Circle.GetCircumference();
                Console.WriteLine($"The circumference is: {RadiusInput.GetCircumference()}");
            }
            string UserInput = Console.ReadLine().ToLower();
            if (UserInput == "N" || UserInput == "No")
            {
                Console.WriteLine("Goodbye!");
                Continue = false;
            }
        }
    }
}
