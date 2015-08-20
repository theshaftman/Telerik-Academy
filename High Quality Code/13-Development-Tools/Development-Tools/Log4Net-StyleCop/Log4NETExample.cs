// <copyright file="Log4NetExample.cs" company="Me">
// Copyright (c) 2015
// </copyright>

namespace Log4Net
{
    using System;
    using log4net;
    using log4net.Config;

    /// <summary>
    /// This class checks if a string can be converted to a number
    /// </summary>
    public class Log4NetExample
    {
        /// <summary>
        /// This is a static ILog constant
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(typeof(Log4NetExample));

        /// <summary>
        /// This is the main program method
        /// </summary>
        /// <param name="args">string[] args</param>
        public static void Main(string[] args)
        {
            XmlConfigurator.Configure();

            string stringCheck = "NaN";
            IsStringOfTypeInt(stringCheck);
            
            stringCheck = "1.13";
            IsStringOfTypeInt(stringCheck);

            stringCheck = "0";
            IsStringOfTypeInt(stringCheck);

            Console.WriteLine(" Press any key to continue . . .");
            Console.ReadKey();
        }

        /// <summary>
        /// This method checks the given string if it is of type INT
        /// Warns if it is a floating number
        /// Errors if it is NOT a number
        /// </summary>
        /// <param name="stringCheck">string stringCheck</param>
        private static void IsStringOfTypeInt(string stringCheck)
        {
            int intCheck;
            double doubleCheck;

            if (int.TryParse(stringCheck, out intCheck))
            {
                Log.Info("The variable is of type INT.");
            }
            else if (double.TryParse(stringCheck, out doubleCheck) && stringCheck != "NaN")
            {
                Log.Warn("The variable is NOT of type INT but it is a floating number.");
            }
            else
            {
                Log.Error("The variable can NOT be converted to type INT and it is NOT a number.");
            }
        }
    }
}
