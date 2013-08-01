using System;

/* Write a method that counts how many times given number 
 * appears in given array. Write a test program to check 
 * if the method is working correctly. */

class CountNumbersInArray
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

            // Enter the searched number
            Console.Write("\nNow enter the number you want to check how many times appears in the array:\n=> ");
            int searchedNumber = int.Parse(Console.ReadLine());

            // Output
            CountNumbers(array, searchedNumber);
            int counter = CountNumbers(array, searchedNumber);
            Console.WriteLine("The number {0} appears {1} times in the array.", searchedNumber, counter);
        }
    }

    // Count the same number
    private static int CountNumbers(int[] array, int searchedNumber)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == searchedNumber)
            {
                counter++;
            }
        }

        return counter;
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
}