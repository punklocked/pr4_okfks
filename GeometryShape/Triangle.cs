using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Triangle : Shape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            try
            {
                if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                    throw new ArgumentException("Стороны треугольника не должны быть меньше или равны нулю");
                if (sideA + sideB < sideC
                    || sideA + sideC < sideB
                    || sideB + sideC < sideA)
                    throw new ArgumentException("Некорректные данные для треугольника");
            }
            catch
            {
                throw new ArgumentException("Некорректные входные данные");
            }
        }

        private double sideA { get; set; }
        private double sideB { get; set; }
        private double sideC { get; set; }

        public override double Area()
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        public override string ToString()
        {
            return $"Сторона A: {sideA}\nСторона B: {sideB}\nСторона C: {sideC}";
        }
    }
}
