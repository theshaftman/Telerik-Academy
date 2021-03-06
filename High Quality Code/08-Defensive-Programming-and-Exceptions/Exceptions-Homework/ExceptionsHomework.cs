﻿using System;
using System.Collections.Generic;
using System.Text;

public class ExceptionsHomework
{
    /// <exception cref="ArgumentException">Arr cannot be null or empty</exception>
    /// <exception cref="ArgumentOutOfRangeException">StartIndex must be in the range [0, arr.Length - 1]</exception>
    /// <exception cref="ArgumentException">Count cannot be negative</exception>
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentException("Arr cannot be null or empty");    
        }

        if (startIndex < 0 || arr.Length <= startIndex)
        {
            throw new ArgumentOutOfRangeException("StartIndex must be in the range [0, arr.Length - 1]");
        }

        if (count < 0)
        {
            throw new ArgumentException("Count cannot be negative");
        }

        List<T> result = new List<T>();

        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    /// <exception cref="ArgumentException">String cannot be null or empty</exception>
    /// <exception cref="ArgumentOutOfRangeException">Count cannot be greater than the string length</exception>
    public static string ExtractEnding(string str, int count)
    {
        if (string.IsNullOrEmpty(str))
        {
            throw new ArgumentException("String cannot be null or empty");
        }

        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("Count cannot be greater than the string length");
        }

        StringBuilder result = new StringBuilder();

        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static string CheckPrime(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return number + " is not prime.";
            }
        }

        return number + " is prime.";
    }

    private static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(string.Join(" ", subarr));

        var allarr = Subsequence(new[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(string.Join(" ", allarr));

        var emptyarr = Subsequence(new[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(string.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));

        // This will throw an exception:
        //// Console.WriteLine(ExtractEnding("Hi", 100));

        CheckPrime(23);
        CheckPrime(33);

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
