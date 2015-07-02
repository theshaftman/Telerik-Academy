using System;

class ZeroSubset
{
    static void Main()
    {
        Console.Write("\nEnter five integer numbers (devided by space): ");
        string str = Console.ReadLine();
        string[] numberStr = str.Split(' ');
        int numbers;

        if (numberStr.Length == 5)
        {
            if (int.TryParse(numberStr[0], out numbers) &&
            int.TryParse(numberStr[1], out numbers) &&
            int.TryParse(numberStr[2], out numbers) &&
            int.TryParse(numberStr[3], out numbers) &&
            int.TryParse(numberStr[4], out numbers))
            {
                int numA = int.Parse(numberStr[0]);
                int numB = int.Parse(numberStr[1]);
                int numC = int.Parse(numberStr[2]);
                int numD = int.Parse(numberStr[3]);
                int numE = int.Parse(numberStr[4]);

                if (numA + numB == 0)
                    Console.WriteLine("{0} + {1} = 0", numA, numB);
                if (numA + numC == 0)
                    Console.WriteLine("{0} + {1} = 0", numA, numC);
                if (numA + numD == 0)
                    Console.WriteLine("{0} + {1} = 0", numA, numD);
                if (numA + numE == 0)
                    Console.WriteLine("{0} + {1} = 0", numA, numE);
                if (numB + numC == 0)
                    Console.WriteLine("{0} + {1} = 0", numB, numC);
                if (numB + numD == 0)
                    Console.WriteLine("{0} + {1} = 0", numB, numD);
                if (numB + numE == 0)
                    Console.WriteLine("{0} + {1} = 0", numB, numE);
                if (numC + numD == 0)
                    Console.WriteLine("{0} + {1} = 0", numC, numD);
                if (numC + numE == 0)
                    Console.WriteLine("{0} + {1} = 0", numC, numE);
                if (numD + numE == 0)
                    Console.WriteLine("{0} + {1} = 0", numD, numE);
                if (numA + numB + numC == 0)
                    Console.WriteLine("{0} + {1} + {2} = 0", numA, numB, numC);
                if (numA + numB + numD == 0)
                    Console.WriteLine("{0} + {1} + {2} = 0", numA, numB, numD);
                if (numA + numB + numE == 0)
                    Console.WriteLine("{0} + {1} + {2} = 0", numA, numB, numE);
                if (numA + numC + numD == 0)
                    Console.WriteLine("{0} + {1} + {2} = 0", numA, numC, numD);
                if (numA + numC + numE == 0)
                    Console.WriteLine("{0} + {1} + {2} = 0", numA, numC, numE);
                if (numA + numD + numE == 0)
                    Console.WriteLine("{0} + {1} + {2} = 0", numA, numD, numE);
                if (numB + numC == 0)
                    Console.WriteLine("{0} + {1} = 0", numB, numC);
                if (numB + numD == 0)
                    Console.WriteLine("{0} + {1} = 0", numB, numD);
                if (numB + numE == 0)
                    Console.WriteLine("{0} + {1} = 0", numB, numE);
                if (numB + numC + numD == 0)
                    Console.WriteLine("{0} + {1} + {2} = 0", numB, numC, numD);
                if (numB + numC + numE == 0)
                    Console.WriteLine("{0} + {1} + {2} = 0", numB, numC, numE);
                if (numB + numD + numE == 0)
                    Console.WriteLine("{0} + {1} + {2} = 0", numB, numD, numE);
                if (numC + numD == 0)
                    Console.WriteLine("{0} + {1} = 0", numC, numD);
                if (numC + numE == 0)
                    Console.WriteLine("{0} + {1} = 0", numC, numE);
                if (numC + numD + numE == 0)
                    Console.WriteLine("{0} + {1} + {2} = 0", numC, numD, numE);
                if (numD + numE == 0)
                    Console.WriteLine("{0} + {1} = 0", numD, numE);
                if (numA + numB + numC + numD == 0)
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", numA, numB, numC, numD);
                if (numA + numB + numC + numE == 0)
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", numA, numB, numC, numE);
                if (numA + numB + numD + numE == 0)
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", numA, numB, numD, numE);
                if (numA + numC + numD + numE == 0)
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", numA, numC, numD, numE);
                if (numB + numC + numD + numE == 0)
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", numB, numC, numD, numE);
                if (numA + numB + numC + numD + numE == 0)
                    Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numA, numB, numC, numD, numE);
                else
                    Console.WriteLine("no zero subset");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
        else
        {
            Console.WriteLine("Error!");
        }
        Main();
    }
}
