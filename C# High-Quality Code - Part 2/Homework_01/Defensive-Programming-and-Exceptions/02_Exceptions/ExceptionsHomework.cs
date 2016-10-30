namespace _02_Exceptions
{
    using System;
    using System.Collections.Generic;
    using Model;

    public class ExceptionsHomework
    {
        public static void Main()
        {
            string message = "Hello!";

            char[] substring = Operations.Subsequence(message.ToCharArray(), 2, 3);
            Console.WriteLine(substring);

            int[] array = new int[] { -1, 3, 2, 1 };

            int[] subArray = Operations.Subsequence(array, 0, 2);
            Console.WriteLine(string.Join(" ", subArray));

            int[] fullArray = Operations.Subsequence(array, 0, 4);
            Console.WriteLine(string.Join(" ", fullArray));

            int[] emptyArray = Operations.Subsequence(array, 0, 0);
            Console.WriteLine(string.Join(" ", emptyArray));

            Console.WriteLine(Operations.ExtractEnding("I love C#", 2));
            Console.WriteLine(Operations.ExtractEnding("Nakov", 4));
            Console.WriteLine(Operations.ExtractEnding("beer", 4));
            // Console.WriteLine(Operations.ExtractEnding("Hi", 100));
            
            Console.WriteLine(Operations.CheckPrime(23));
            Console.WriteLine(Operations.CheckPrime(33));
            
            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };

            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();

            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}
