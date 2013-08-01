using System;
using System.Numerics;

/* Write methods to calculate minimum, maximum, average, 
 * sum and product of given set of integer numbers. 
 * Use variable number of arguments. */

class CalculateMethods
{
    static void Main()
    {
        Console.Write("Enter the width of the array and it will be filled with random numbers:\n=> ");
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
            FillTheArray(array);
            PrintTheArray(array);

            // Print the min number in the array
            Console.WriteLine("\nThe min number in the array is: => {0}", FindMinNumber(array));

            // Print the max number in the array
            Console.WriteLine("\nThe max number in the array is: => {0}", FindMaxNumber(array));

            // Print the average of the array numbers
            Console.WriteLine("\nThe average of all numbers in the array is: => {0}", CalculateAverage(array));

            // Print the sum of the array numbers
            Console.WriteLine("\nThe sum of all numbers in the array is: => {0}", CalculateSum(array));

            // Print the product of the array numbers
            Console.WriteLine("\nThe product of all numbers in the array is: => {0}", CalculateProduct(array));
        }
    }

    // Fill the array with random numbers
    private static void FillTheArray(int[] array)
    {
        int min = -10;
        int max = 10;
        Random randNum = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randNum.Next(min, max);
        }
    }

    // Print the filled array
    private static void PrintTheArray(int[] array)
    {
        for (int j = 0; j < array.Length; j++)
        {
            Console.Write("{0, 2} ", array[j]);
        }
    }

    // Find the min number in the array
    private static int FindMinNumber(params int[] array)
    {
        int min = int.MaxValue;
        foreach (int number in array)
        {
            if (number < min)
            {
                min = number;
            }
        }

        return min;
    }

    // Find the max number in the array
    private static int FindMaxNumber(params int[] array)
    {
        int min = int.MinValue;
        foreach (int number in array)
        {
            if (number > min)
            {
                min = number;
            }
        }

        return min;
    }

    // Calculate the average of the array items
    private static int CalculateAverage(params int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        int average = sum / array.Length;
        return average;
    }

    // Calculate sum of the array items
    private static int CalculateSum(params int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    // Calculate product of the array items
    private static BigInteger CalculateProduct(params int[] array)
    {
        BigInteger product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }

        return product;
    }
}
