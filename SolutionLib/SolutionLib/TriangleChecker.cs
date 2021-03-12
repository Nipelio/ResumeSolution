using System;

namespace SolutionLib
{
    public static class TriangleChecker
    {
        /// <summary>
        /// True if triangle is rectangular
        /// </summary>
        /// <param name="firstSide"></param>
        /// <param name="secondSide"></param>
        /// <param name="thirdSide"></param>
        /// <returns></returns>
        public static bool IsTriangleRectangular(double firstSide, double secondSide, double thirdSide)
        {
            //Determining hypotenuse and cathets 
            double hypotenuse = Math.Max(firstSide, Math.Max(secondSide, thirdSide));
            double cathet1;
            double cathet2;
            if (Math.Abs(hypotenuse - firstSide) < double.Epsilon)
            {
                cathet1 = secondSide;
                cathet2 = thirdSide;
            } else if (Math.Abs(hypotenuse - secondSide) < double.Epsilon)
            {
                cathet1 = thirdSide;
                cathet2 = firstSide;
            } else
            {
                cathet1 = secondSide;
                cathet2 = firstSide;
            }
            //Checking rectangular condition
            return Math.Abs(cathet1 * cathet1 + cathet2 * cathet2 - hypotenuse * hypotenuse) < double.Epsilon;
        }
        
        /// <summary>
        /// True if triangle is correct
        /// </summary>
        /// <param name="firstSide"></param>
        /// <param name="secondSide"></param>
        /// <param name="thirdSide"></param>
        /// <returns></returns>
        public static bool IsTriangleCorrect(double firstSide, double secondSide, double thirdSide)
        {
            double halfPerimeter = (firstSide + secondSide + thirdSide) / 2.0;
            if ((firstSide >= halfPerimeter) || (secondSide >= halfPerimeter) || (thirdSide >= halfPerimeter))
            {
                return false;
            }

            return true;
        }
    }
}