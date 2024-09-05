using FluentAssertions;
using ShapeCalculatingProject.Factory;
using ShapeCalculatingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculatingProject.Test.Models
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_CalculateArea_ReturnsDoubleArea()
        {
            //Arrange
            var triangle = ShapeFactory.CreateTriangle(3, 4, 5);
            double expectedArea = 6;

            //Act
            var result = triangle.CalculateArea();

            //Assert
            result.Should().BeGreaterThan(0);
            result.Should().BePositive();
            result.Should().Be(expectedArea);
        }

        [Fact]
        public void Triangle_IsRightAngled_ReturnsTrue()
        {
            //Arrange
            var triangle = ShapeFactory.CreateTriangle(3, 4, 5);

            //Act
            var result = ((Triangle)triangle).IsRightAngled();

            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Triangle_IsRightAngled_ReturnsFalse()
        {
            //Arrange
            var triangle = ShapeFactory.CreateTriangle(3, 4, 6);
            
            //Act
            var result = ((Triangle)triangle).IsRightAngled();

            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Triangle_CreateTriangle_ReturnsException()
        {
            //Assert
            Assert.Throws<ArgumentException>(() => ShapeFactory.CreateTriangle(1, 2, 3));
        }
    }
}
