//-----------------------------------------------------------------------
// <copyright file="Output.cs" company="TelerikAcademy.com">
//     TelerikAcademy.com. All rights reserved.
// </copyright>
// <author>Author</author>
//-----------------------------------------------------------------------

namespace _02_PrintStatistics
{
    using System;

    /// <summary>
    /// Output static class.
    /// </summary>
    internal static class Output
    {
        /// <summary>
        /// Prints the max, min and average value of a given array with a given length.
        /// </summary>
        /// <param name="arr">Input array.</param>
        /// <param name="count">Input count.</param>
        internal static void PrintStatistics(double[] arr, int count)
        {
            if (count > arr.Length)
            {
                throw new IndexOutOfRangeException(ExceptionMessages.LARGER_COUNT);
            }

            double max = Statistics.GetMaxValue(arr, count);
            Console.WriteLine("Max = {0}", max);

            double min = Statistics.GetMinValue(arr, count);
            Console.WriteLine("Min = {0}", min);

            double average = Statistics.GetAverageValue(arr, count);
            Console.WriteLine("Average = {0}", average);
        }
    }
}
