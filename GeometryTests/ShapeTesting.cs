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
    }
}