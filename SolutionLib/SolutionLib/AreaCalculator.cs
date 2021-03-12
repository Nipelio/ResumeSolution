using System;

namespace SolutionLib
{
    public static class AreaCalculator
    {
        /// <summary>
        /// Returns area of triangle, 0 if triangle is incorrect
        /// </summary>
        /// <param name="firstSide"></param>
        /// <param name="secondSide"></param>
        /// <param name="thirdSide"></param>
        /// <returns></returns>
        public static double TriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            if (!TriangleChecker.IsTriangleCorrect(firstSide, secondSide, thirdSide))
            {
                return 0.0;
            }
            double halfPerimeter = (firstSide + secondSide + thirdSide) / 2.0;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide)
                                           * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));
        }

        /// <summary>
        /// Returns area of circle
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}