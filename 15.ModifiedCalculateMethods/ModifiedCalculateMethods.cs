using System;

/* * Modify your last program and try to make it work for any 
 * number type, not just integer (e.g. decimal, float, byte, etc.). 
 * Use generic method (read in Internet about generic methods in C#). */

class ModifiedCalculateMethods
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
    private static void FillTheArray<T>(params T[] array)
    {
        dynamic min = -10;
        dynamic max = 10;
        Random randNum = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randNum.Next(min, max);
        }
    }

    // Print the filled array
    private static void PrintTheArray<T>(params T[] array)
    {
        for (dynamic j = 0; j < array.Length; j++)
        {
            Console.Write("{0, 2} ", array[j]);
        }
    }

    // Find the min number in the array
    private static T FindMinNumber<T>(params T[] array)
    {
        dynamic min = int.MaxValue;
        foreach (dynamic number in array)
        {
            if (number < min)
            {
                min = number;
            }
        }

        return min;
    }

    // Find the max number in the array
    private static T FindMaxNumber<T>(params T[] array)
    {
        dynamic min = int.MinValue;
        foreach (dynamic number in array)
        {
            if (number > min)
            {
                min = number;
            }
        }

        return min;
    }

    // Calculate the average of the array items
    private static T CalculateAverage<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        dynamic average = sum / array.Length;
        return average;
    }

    // Calculate sum of the array items
    private static T CalculateSum<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    // Calculate product of the array items
    private static T CalculateProduct<T>(params T[] array)
    {
        dynamic product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }

        return product;
    }
}
