//-----------------------------------------------------------------------
// <copyright file="SizeTest.cs" company="TelerikAcademy.com">
//     TelerikAcademy.com. All rights reserved.
// </copyright>
// <author>Author</author>
//-----------------------------------------------------------------------

namespace _01_Size
{
    /// <summary>
    /// Size test class.
    /// </summary>
    public class SizeTest
    {
        /// <summary>
        /// Console application main method.
        /// </summary>
        /// <param name="args">Input arguments string array values.</param>
        public static void Main(string[] args)
        {
            Size size = new Size(12.5, 12.5);
            Size rotated = Size.GetRotatedSize(size, 12);
        }
    }    
}
