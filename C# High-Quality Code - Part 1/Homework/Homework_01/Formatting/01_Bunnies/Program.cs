namespace _01_Bunnies
{
    using System.Collections.Generic;
    using System.IO;
    using Enums;
    using Model;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Bunny> bunnies = new List<Bunny>
            {
                new Bunny("Leonid", 1, FurType.NotFluffy),
                new Bunny("Rasputin", 2, FurType.ALittleFluffy),
                new Bunny("Tiberii", 3, FurType.ALittleFluffy),
                new Bunny("Neron", 1, FurType.ALittleFluffy),
                new Bunny("Klavdii", 3,  FurType.Fluffy),
                new Bunny("Vespasian", 3, FurType.Fluffy),
                new Bunny("Domician", 4, FurType.FluffyToTheLimit),
                new Bunny("Tit", 2, FurType.FluffyToTheLimit)
            };

            // Introduce all bunnies
            ConsoleWriter consoleWriter = new ConsoleWriter();

            foreach (Bunny bunny in bunnies)
            {
                bunny.Introduce(consoleWriter);
            }

            // Create bunnies text file
            string bunniesFilePath = @"..\..\bunnies.txt";
            FileStream fileStream = File.Create(bunniesFilePath);

            fileStream.Close();

            // Save bunnies to a text file
            using (StreamWriter streamWriter = new StreamWriter(bunniesFilePath))
            {
                foreach (Bunny bunny in bunnies)
                {
                    streamWriter.WriteLine(bunny.ToString());
                }
            }
        }
    }
}
