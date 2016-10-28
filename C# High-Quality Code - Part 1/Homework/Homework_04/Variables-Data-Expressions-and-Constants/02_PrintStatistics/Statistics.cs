//-----------------------------------------------------------------------
// <copyright file="Statistics.cs" company="TelerikAcademy.com">
//     TelerikAcademy.com. All rights reserved.
// </copyright>
// <author>Author</author>
//-----------------------------------------------------------------------

namespace _02_PrintStatistics
{
    using System;

    /// <summary>
    /// Statistics class.
    /// </summary>
    internal static class Statistics
    {
        /// <summary>
        /// Gets the maximum value of a given array with a given length.
        /// </summary>
        /// <param name="arr">Input array.</param>
        /// <param name="count">Input count.</param>
        /// <returns>Returns the maximum value.</returns>
        internal static double GetMaxValue(double[] arr, int count)
        {
            if (count > arr.Length)
            {
                throw new IndexOutOfRangeException(ExceptionMessages.LARGER_COUNT);
            }

            double max = double.MinValue;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Gets the minimal value of a given array with a given length.
        /// </summary>
        /// <param name="arr">Input array.</param>
        /// <param name="count">Input count.</param>
        /// <returns>Returns the minimal value.</returns>
        internal static double GetMinValue(double[] arr, int count)
        {
            if (count > arr.Length)
            {
                throw new IndexOutOfRangeException(ExceptionMessages.LARGER_COUNT);
            }

            double min = double.MaxValue;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        /// <summary>
        /// Gets the average value of a given array with a given length.
        /// </summary>
        /// <param name="arr">Input array.</param>
        /// <param name="count">Input count.</param>
        /// <returns>Returns the average value.</returns>
        internal static double GetAverageValue(double[] arr, int count)
        {
            if (count > arr.Length)
            {
                throw new IndexOutOfRangeException(ExceptionMessages.LARGER_COUNT);
            }

            double sum = 0.0;

            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }

            double average = sum / count;

            return average;
        }
    }
}
