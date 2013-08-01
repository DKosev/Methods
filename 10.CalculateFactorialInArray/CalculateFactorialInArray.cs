using System;
using System.Numerics;

/* Write a program to calculate n! for each n in the range [1..100]. 
 * Hint: Implement first a method that multiplies a number represented 
 * as array of digits by given integer number. */

class CalculateFactorialInArray
{
    static void Main()
    {
        // Input
        Console.Write("Enter the length of the array:\n=> ");
        int arrayLength = int.Parse(Console.ReadLine());
        if (arrayLength <= 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\aError! The array length have to be greater than 0.\n");
            Console.ResetColor();
            Main();
        }
        else
        {
            // Fill and print the array
            int[] array = new int[arrayLength];
            FillArray(array);
            PrintArray(array);

            // Output
            Console.WriteLine(Environment.NewLine);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Factorial of {0, 2} is {1}", array[i], CalculatesFactorial(array[i]));
            }
        }
    }

    // Fill the array with random numbers
    private static void FillArray(int[] array)
    {
        Random randomNumber = new Random();
        int min = 1;
        int max = 20; // 100
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randomNumber.Next(min, max);
        }
    }

    // Print the array
    private static void PrintArray(int[] array)
    {
        Console.WriteLine("The array with random numbers is:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    // Calculate the factorial of each number in the array
    private static BigInteger CalculatesFactorial(int arrayNumbers)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= arrayNumbers; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}