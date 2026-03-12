using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            try
            {
                if (height <= 0 || width <= 0)
                    throw new ArgumentException("Некорректные значения сторон");
                if (height == width)
                    throw new ArgumentException("У прямоугольника не может быть одинаковая высота и ширина");
            }
            catch
            {
                throw new ArgumentException("Некорректные входные данные");
            }

        }

        private double width { get; set; }
        private double height { get; set; }

        public override double Area()
        {
            return width * height;
        }

        public override double Perimeter()
        {
            return (height * 2) + (width * 2);
        }

        public override string ToString()
        {
            return $"Ширина прямоугольника - {width}\nВысота прямоугольника - {height}";
        }
    }
}
