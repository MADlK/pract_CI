using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrShapeCI
{
    public class Triangle : Shape
    {
        private double _sideA;
        public double SideA
        {
            get;
        }


        private double _sideB;
        public double SideB
        {
            get;
        }


        private double _sideC;
        public double SideC
        {
            get;
        }
        public Triangle(double a, double b, double c)
        {
            if (!IsTriangle(a, b, c))
            {
                throw new ArgumentException("Данные стороны не образуют треугольник");

            }
            if (a < 0.001 || b < 0.001 || c < 0.001)
            { throw new ArgumentException("Ни одна из сторон треугольника не может быть меньше 0.001"); }
            _sideA = a;
            _sideB = b;
            _sideC = c;
        }


        private bool IsTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && c + b > a)
                return true;
            return false;
        }
        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }
        public override double Perimeter()
        {
            return _sideA + _sideB + -_sideC;
        }

        public override string ToString()
        {
            return $"Площадь: {Area()}, периметер: {Perimeter()}";
        }
    }
}
