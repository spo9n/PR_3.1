using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3._1_Surgai_ZVD2
{
    class Triangle
    {
        private double x1, y1;
        private double x2, y2;
        private double x3, y3;
        private double a;
        private double b;
        private double c;
        private double perimeter;
        private double square;

        public Triangle () { }

        public Triangle(double _x1, double _y1, double _x2, double _y2, double _x3, double _y3)
        {
            x1 = _x1;
            y1 = _y1;

            x2 = _x2;
            y2 = _y2;

            x3 = _x3;
            y3 = _y3;

            a = CalculateLengthOfSide(_x1, _y1, _x2, _y2);
            b = CalculateLengthOfSide(_x2, _y2, _x3, _y3);
            c = CalculateLengthOfSide(_x3, _y3, _x1, _y1);

            perimeter = CalculatePerimeter();
            square = CalculateSquare();
        }

        public Triangle(double _a, double _b, double _c)
        {
            a = _a;
            b = _b;
            c = _c;

            perimeter = CalculatePerimeter();
            square = CalculateSquare();
        }

        public double CalculatePerimeter()
        {
            return a + b + c;
        }

        public double CalculateSquare()
        {
            return Math.Sqrt(perimeter / 2 * (perimeter / 2 - a) * (perimeter / 2 - b) * (perimeter / 2 - c));
        }

        public double CalculateLengthOfSide(double _x1, double _y1, double _x2, double _y2)
        {
            return Math.Sqrt((_x1 - _x2) * (_x1 - _x2) + (_y1 - _y2) * (_y1 - _y2));
        }
    }
}
