using System;
using System.Collections.Generic;
using System.IO;

namespace ClassesOOP1
{
    class Square
    {
        public int numberOfSides;
        private double perimeter;
        double sideLength; // { get; set; } "Shorthand" way to write simple getter and setter methods for a field.
        double area;

        public Square()
        {
            this.numberOfSides = 4;
            this.sideLength = 1.5;
            setCalcPerimeter(this.numberOfSides, this.sideLength);
            setCalcArea(this.sideLength);
        }

        void setCalcPerimeter(int NumberSides, double Length)
        {
            this.perimeter = ( NumberSides * Length );
        }

        void setCalcArea(double length)
        {
            this.area = ( length * length );
        }

        // Getter - is a method that returns the value of a private (or otherwise) member
        public double getPerimeter()
        {
            return this.perimeter;
        }
        
        // Setter - is a metod that sets the value of a private (or otherwise) member
        public void setPerimeter( double Perimeter)
        {
            this.perimeter = Perimeter;
        }

    }
}