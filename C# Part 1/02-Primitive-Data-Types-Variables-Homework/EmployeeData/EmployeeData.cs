using System;

class EmployeeData
{
    static void Main()
    {
        Random randomGenerator = new Random();

        string firstName = "Mariyan";
        string lastName = "Vasilev";
        byte age = 23;
        bool isMale = true;
        long personalID = (long)((randomGenerator.NextDouble() * 2.0 - 1.0) * 9999999999);
        string uniqueEmployee = randomGenerator.Next(27560000, 27569999).ToString();

        Console.WriteLine("First name: {0}\n" + "Last name: {1}\n" + "Age: {2}\n" +
            "Male: {3}\n" + "Personal ID: {4}\n" + "Unique employee number: {5}", 
            firstName, lastName, age, isMale, personalID, uniqueEmployee);
    }
}
