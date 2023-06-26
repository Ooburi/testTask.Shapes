using testTask.Shapes;
using Xunit;

namespace Tests
{
    public class CircleTest
    {
        /// <summary>
        /// вычисление площади круга
        /// </summary>
        [Fact]
        public void CircleSquare()
        {
            // Arrange
            Shape circle = new Circle(5);

            // Act
            double result = circle.Square;

            // Assert
            Assert.True((78.539816 - result) < 0.001);
        }
        /// <summary>
        /// вычисление площади треугольника
        /// </summary>
        [Fact]
        public void TriangleSquare()
        {
            // Arrange
            Shape triangle = new Triangle(3, 4, 5);

            // Act
            double result = triangle.Square;

            // Assert
            Assert.Equal(6d, result);
        }
        /// <summary>
        /// Проверка прямоугольности треугольника
        /// </summary>
        [Fact]
        public void TriangleRightness()
        {
            // Arrange
            Shape triangle = new Triangle(3, 4, 5);
            Shape secondTriangle = new Triangle(3, 4, 6);

            // Act
            bool result = (triangle as Triangle).isRight();
            bool secondResult = (secondTriangle as Triangle).isRight();

            // Assert
            Assert.True(result);
            Assert.False(secondResult);
        }
    }
}
