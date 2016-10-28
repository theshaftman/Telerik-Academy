//-----------------------------------------------------------------------
// <copyright file="Size.cs" company="TelerikAcademy.com">
//     TelerikAcademy.com. All rights reserved.
// </copyright>
// <author>Author</author>
//-----------------------------------------------------------------------

namespace _01_Size
{
    using System;

    /// <summary>
    /// Creates a size object.
    /// </summary>
    internal class Size
    {
        /// <summary>
        /// Private width field.
        /// </summary>
        private double width;

        /// <summary>
        /// Private height field.
        /// </summary>
        private double height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Size"/> class.
        /// </summary>
        /// <param name="width">Input width parameter.</param>
        /// <param name="height">Input height parameter.</param>
        internal Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets the size object width property.
        /// </summary>
        internal double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        /// <summary>
        /// Gets or sets the size object height property.
        /// </summary>
        internal double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;
            }
        }

        /// <summary>
        /// Gets rotated size with given size object and a given rotation angle.
        /// </summary>
        /// <param name="size">Input size object.</param>
        /// <param name="rotationAngle">Input rotation angle.</param>
        /// <returns>Returns the rotated size object.</returns>
        internal static Size GetRotatedSize(Size size, double rotationAngle)
        {
            double width = GetAbsoluteCos(rotationAngle, size.Width) +
                GetAbsoluteSin(rotationAngle, size.Height);
            double height = GetAbsoluteSin(rotationAngle, size.Width) +
                GetAbsoluteCos(rotationAngle, size.Height);

            Size rotatedSize = new Size(width, height);

            return rotatedSize;
        }

        /// <summary>
        /// Gets the absolute multiplied value between the sinus angle of the input rotation angle and the input multiplied value.
        /// </summary>
        /// <param name="rotationAngle">Input rotation angle.</param>
        /// <param name="multipliedValue">Input multiplied value.</param>
        /// <returns>Returns the multiplied value.</returns>
        private static double GetAbsoluteSin(double rotationAngle, double multipliedValue)
        {
            double value = Math.Abs(Math.Sin(rotationAngle)) * multipliedValue;

            return value;
        }

        /// <summary>
        /// Gets the absolute multiplied value between the cosine angle of the input rotation angle and the input multiplied value.
        /// </summary>
        /// <param name="rotationAngle">Input rotation angle.</param>
        /// <param name="multipliedValue">Input multiplied value.</param>
        /// <returns>Returns the multiplied value.</returns>
        private static double GetAbsoluteCos(double rotationAngle, double multipliedValue)
        {
            double value = Math.Abs(Math.Cos(rotationAngle)) * multipliedValue;

            return value;
        }
    }
}
