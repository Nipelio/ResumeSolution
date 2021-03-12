using System;
using SolutionLib;
using NUnit.Framework;

namespace SolutionLibTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CorrectTriangle()
        {
            double firstSide = 3.0;
            double secondSide = 4.0;
            double thirdSide = 3.0;
            bool result = TriangleChecker.IsTriangleCorrect(firstSide, secondSide, thirdSide);
            Assert.True(result);
        }
        
        [Test]
        public void CorrectTriangleArea()
        {
            double firstSide = 3.0;
            double secondSide = 4.0;
            double thirdSide = 5.0;
            double result = AreaCalculator.TriangleArea(firstSide, secondSide, thirdSide);
            Assert.True(Math.Abs(result - firstSide * secondSide / 2.0) <= double.Epsilon);
        }
        
        [Test]
        public void IncorrectTriangle()
        {
            double firstSide = 1.0;
            double secondSide = 1.0;
            double thirdSide = 3.0;
            bool result = TriangleChecker.IsTriangleCorrect(firstSide, secondSide, thirdSide);
            Assert.False(result);
        }
        
        [Test]
        public void IncorrectTriangleArea()
        {
            double firstSide = 1.0;
            double secondSide = 1.0;
            double thirdSide = 3.0;
            double result = AreaCalculator.TriangleArea(firstSide, secondSide, thirdSide);
            Assert.True(result < double.Epsilon);
        }
        
        [Test]
        public void CircleArea()
        {
            double radius = 1.0;
            double result = AreaCalculator.CircleArea(radius);
            Assert.True(Math.Abs(result - Math.PI) < double.Epsilon);
        }
        
        [Test]
        public void Rectangular()
        {
            double firstSide = 3.0;
            double secondSide = 4.0;
            double thirdSide = 5.0;
            bool result = TriangleChecker.IsTriangleRectangular(firstSide, secondSide, thirdSide);
            Assert.True(result);
        }
        
        [Test]
        public void NotRectangular()
        {
            double firstSide = 3.0;
            double secondSide = 4.0;
            double thirdSide = 6.0;
            bool result = TriangleChecker.IsTriangleRectangular(firstSide, secondSide, thirdSide);
            Assert.False(result);
        }
    }
}