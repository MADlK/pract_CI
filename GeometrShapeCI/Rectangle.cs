using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrShapeCI
{
    public class Rectangle : Shape
    {
        private double _width;
        public double Width
        {
            get => _width;
            set
            {
                if (value < 0.001)
                    throw new ArgumentException("Ширина не может быть меньше 0,001");

                _width = value;
            }
        }


        private double _height;
        public double Height
        {
            get => _height;
            set
            {
                if (value < 0.001)
                    throw new ArgumentException("Высота не может быть меньше 0,001");

                _height = value;
            }
        }


        public override double Area()
        {
            return _width * _height;
        }
        public override double Perimeter()
        {
            return _height + _width;
        }

        public override string ToString()
        {
            return $"Ширина: {_width}, высота: {_height}, Площадь: {Area()}, Периметер: {Perimeter()}";
        }
    }
}
