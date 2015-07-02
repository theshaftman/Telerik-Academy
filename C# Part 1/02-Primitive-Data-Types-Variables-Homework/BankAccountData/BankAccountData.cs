using System;

class BankAccountData
{
    static void Main()
    {
        Random randomGenerator = new Random();

        string holderName = "Ivan Todorov Petkov";
        string[] names = holderName.Split(' ');
        string firstName = "";
        string secondName = "";
        string lastName = "";
        decimal ammount = 5250M;
        string bankName = "Bulgarian National Bank";
        string iban = "BG80 BNBG ";
        long[] creditCards = new long[3];

        for (int i = 0; i < names.Length; i++)
        {
            switch (i)
            {
                case 0: firstName = names[i];
                    break;
                case 1: secondName = names[i];
                    break;
                case 2: lastName = names[i];
                    break;
            }
        }

        int k = 0;
        string numStr = "";
        while (k < 4)
        {
            int num = 0;

            for (int m = 0; m < 3; m++)
            {
                num = randomGenerator.Next(1000, 9999);
            }

            if (k == 3)
            {
                num = randomGenerator.Next(10, 99);
            }

            numStr += num.ToString() + " ";
            k++;
        }

        iban = iban + numStr;

        Console.WriteLine("Holder name: {0} {1} {2}\nAmmount: {3}lv\nBank name: {4}\nIBAN: {5}\n",
            firstName, secondName, lastName, ammount, bankName, iban);

        Console.WriteLine("Credit card numbers:");
        for (int j = 0; j < creditCards.Length; j++)
        {
            long num = (long)((randomGenerator.NextDouble() * 2.0 - 1.0) * 9999999999999999);

            if (num < 0)
            {
                string str = num.ToString();
                str = str.Remove(0, 1);

                num = Convert.ToInt64(str);
            }

            creditCards[j] = num;
            Console.WriteLine("\t{0}", creditCards[j]);
        }
    }
}
