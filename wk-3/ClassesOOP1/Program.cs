using System;
using System.Collections.Generic;
using System.IO;

namespace ClassesOOP1
{
    class Program
    {
        static void Main()
        {
            // The program starts here...
            Square squareOne = new Square();

            Console.WriteLine("Square number of sides = " + squareOne.numberOfSides);
            Console.WriteLine("Square perimeter = " + squareOne.getPerimeter());

            try 
            {
                Triangle newTriangle = new Triangle( 40.2, 40, 1);
                Console.WriteLine("Perimeter of the triangle = " + newTriangle.Perimeter());
            }
            catch( Exception e)
            {
                Console.WriteLine("Triangle was not able to be created, invalid sides.");
            }
            
            Console.WriteLine("The program continues after the Try-Catch");

        }
    }
}