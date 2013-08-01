using System;

/* Write a method GetMax() with two parameters that returns the bigger
 * of two integers. Write a program that reads 3 integers from the 
 * console and prints the biggest of them using the method GetMax(). */

class GetMaxParameter
{
    static void Main()
    {
        Console.Write("Enter the first number:\n=> ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number:\n=> ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number:\n=> ");
        int thirdNumber = int.Parse(Console.ReadLine());
        int biggestNumber = GetMax(firstNumber, secondNumber);
        
        // Get and print the greatest number
        biggestNumber = GetMax(biggestNumber, thirdNumber);
        Console.WriteLine("The biggest number from {0}, {1} and {2} is {3}", firstNumber, secondNumber, thirdNumber, biggestNumber);
    }

    // Find the greatest number
    private static int GetMax(int first, int second)
    {
        if (first > second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }
}
