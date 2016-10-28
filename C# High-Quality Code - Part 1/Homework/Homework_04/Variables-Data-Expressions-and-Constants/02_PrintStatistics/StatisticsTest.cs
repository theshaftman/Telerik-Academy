//-----------------------------------------------------------------------
// <copyright file="StatisticsTest.cs" company="TelerikAcademy.com">
//     TelerikAcademy.com. All rights reserved.
// </copyright>
// <author>Author</author>
//-----------------------------------------------------------------------

namespace _02_PrintStatistics
{
    /// <summary>
    /// Statistics test class.
    /// </summary>
    public class StatisticsTest
    {
        /// <summary>
        /// Input console application main method.
        /// </summary>
        /// <param name="args">Input arguments string array values.</param>
        public static void Main(string[] args)
        {
            double[] arr = new double[] { 1.5, 0.8, 0.7 };
            int count = arr.Length;

            Output.PrintStatistics(arr, count);
        }
    }
}
