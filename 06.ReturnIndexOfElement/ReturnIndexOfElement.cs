using System;

/* Write a method that returns the index of the first element in array 
 * that is bigger than its neighbors, or -1, if there’s no such element. */

class ReturnIndexOfElement
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

            // Comparison output
            int result = Comparison(array);
            if (Comparison(array) > 0)
            {
                Console.WriteLine("\nThe first number bigger than its neighbours is {0}", array[result]);
                Console.WriteLine("Comparison: {0} < {1} > {2}", array[result - 1], array[result], array[result + 1]);
            }
            else
            {
                Console.WriteLine("There isn't any number bigger than its neighbours.", result);
            }
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

    // Compare the neighbour numbers
    private static int Comparison(int[] array)
    {
        int index = 0;
        for (int currentIndex = 1; currentIndex < array.Length - 1; currentIndex++)
        {
            if ((array[currentIndex] > array[currentIndex + 1]) && (array[currentIndex] > array[currentIndex - 1]))
            {
                index = currentIndex;
                break;
            }
            else
            {
                index = 0;
            }
        }

        return index;
    }
}