﻿namespace _01_Bunnies.Model
{
    using System;
    using System.Text;

    public static class StringExtensions
    {
        public static string SplitToSeparateWordsByUppercaseLetter(this string sequence)
        {
            int probableStringMargin = 10;
            int probableStringSize = sequence.Length + probableStringMargin;

            StringBuilder builder = new StringBuilder(probableStringSize);

            char singleWhitespace = ' ';

            foreach (char letter in sequence)
            {
                if (Char.IsUpper(letter))
                {
                    builder.Append(singleWhitespace);
                }

                builder.Append(letter);
            }

            return builder.ToString().Trim();
        }
    }
}
