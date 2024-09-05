using FluentAssertions;
using ShapeCalculatingProject.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculatingProject.Test.Models
{
    public class CircleTests
    {
        [Fact]
        public void Circle_CreateCircle_ReturnsDouble()
        {
            //Arrange
            var circle = ShapeFactory.CreateCircle(5);
            double expectedArea = Math.PI * 25;

            //Act
            var result = circle.CalculateArea();

            //Assert
            result.Should().BeGreaterThan(0);
            result.Should().BePositive();
            result.Should().Be(expectedArea);
        }

        [Fact]
        public void Circle_InvalidCircle_ReturnsThrowsException()
        {
            //Assert
            Assert.Throws<ArgumentException>(() => ShapeFactory.CreateCircle(-5));
        }

    }
}
