using System;

/* Write a method that checks if the element at given position in given
 * array of integers is bigger than its two neighbors (when such exist). */

class IsBiggerPreviousAndNext
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

            // Enter the index for checking
            Console.Write("\nNow enter an index to check if the number is bigger than its neighbours:\n=> ");
            int indexOfNumber = int.Parse(Console.ReadLine());
            if (indexOfNumber <= 0 || indexOfNumber >= array.Length - 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\aError! The index have to be within the array.\n");
                Console.ResetColor();
                Main();
            }

            // Comparison output
            Comparison(array, indexOfNumber);
            if (Comparison(array, indexOfNumber))
            {
                Console.WriteLine("The number at index {0} is {1}", indexOfNumber, array[indexOfNumber]);
                Console.WriteLine("Comparison: {0} < {1} > {2}", array[indexOfNumber - 1], array[indexOfNumber], array[indexOfNumber + 1]);
            }
            else
            {
                Console.WriteLine("The number at index {0} isn't bigger than its neighbours.", indexOfNumber);
            }
        }
    }

    // Compare the neighbour numbers
    private static bool Comparison(int[] array, int indexOfNumber)
    {
        if ((array[indexOfNumber] > array[indexOfNumber + 1]) && (array[indexOfNumber] > array[indexOfNumber - 1]))
        {
            return true;
        }
        else
        {
            return false;
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
}
