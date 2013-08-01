using System;

/* Write a method that return the maximal element in a portion of array 
 * of integers starting at given index. Using it write another method 
 * that sorts an array in ascending / descending order. */

class ElementInAPortionOfInts
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

            // Start checking from the entered index
            Console.Write("\nNow enter the index, where you want to start the check:\n=> ");
            int index = int.Parse(Console.ReadLine());
            if (index >= array.Length - 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\aError! Please try again.\n");
                Console.ResetColor();
                Main();
            }
            else
            {
                int maximalNumber = GetMax(array, index);
                Console.WriteLine("After the {0} index of the array, the biggest number is {1}", index, maximalNumber);
            }

            // Output
            Console.WriteLine();
            AscendingSort(array);
            Console.WriteLine("The sorted array in ascending order:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0, 2} ", array[i]);
            }

            DescendingSort(array);
            Console.WriteLine("\nThe sorted array in descending order:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0, 2} ", array[i]);
            }

            Console.WriteLine();
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

    // Find the greatest element in the array
    private static int GetMax(int[] array, int index)
    {
        int max = int.MinValue;
        for (int i = index; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }

    // Sort the array in ascending order
    private static void AscendingSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int smallestNumber = array[i];
            int changedNumber = -1;
            int temp = 0;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < smallestNumber)
                {
                    smallestNumber = array[j];
                    changedNumber = j;
                }
            }

            if (changedNumber > -1)
            {
                temp = array[i];
                array[i] = array[changedNumber];
                array[changedNumber] = temp;
            }
        }
    }

    // Sort the array in descending order
    private static void DescendingSort(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            int tmp = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = tmp;
        }
    }
}