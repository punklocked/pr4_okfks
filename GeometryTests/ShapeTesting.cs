using System;
using GeometryShape;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTests
{
    public class ShapeTesting
    {
        [Fact]
        public void RectangleAreaCalculationTest()
        {
            double width = 10;
            double height = 5;

            double expected = width * height;

            GeometryShape.Rectangle rectangle = new GeometryShape.Rectangle(width, height);

            Assert.Equal(expected, rectangle.Area());
        }

        [Fact]
        public void RectanglePerimeterCalculationTest()
        {
            double width = 10;
            double height = 5;

            double expected = (width * 2) + (height * 2);

            GeometryShape.Rectangle rectangle = new GeometryShape.Rectangle(width, height);

            Assert.Equal(expected, rectangle.Perimeter());
        }

        [Fact]
        public void TriangleAreaCalculationTestFail()
        {
            double sideA = 6;
            double sideB = 8;
            double sideC = 0;

            double p = (sideA + sideB + sideC) / 2;
            double expected = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

            GeometryShape.Triangle triangle = new GeometryShape.Triangle(sideA, sideB, sideC);

            Assert.Equal(expected, triangle.Area());
        }

        [Fact]
        public void TrianglePerimeterCalculationTest()
        {
            double sideA = 6;
            double sideB = 8;
            double sideC = 10;

            double expected = sideA + sideB + sideC;

            GeometryShape.Triangle triangle = new GeometryShape.Triangle(sideA, sideB, sideC);

            Assert.Equal(expected, triangle.Perimeter());
        }

        [Fact]
        public void TriangleWrongArguments()
        {
            double sideA = 6;
            double sideB = 8;
            double sideC = 0;

            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void RectangleWrongArguments()
        {
            double width = 10;
            double height = 0;

            Assert.Throws<ArgumentException>(() => new GeometryShape.Rectangle(width, height));
        }
    }
}