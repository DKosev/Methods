using System;

/* Extend the program to support also subtraction 
 * and multiplication of polynomials. */

class SubstractMultiplicatePolynom
{
    private static readonly Random randomNumber = new Random();

    static void Main()
    {
        // Input
        Console.Write("Enter the length of the arrays:\n=> ");
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
            // Fill and print the first array
            Console.WriteLine("The first array:");
            int[] firstArray = new int[arrayLength];
            FillArray(firstArray);
            PrintArray(firstArray);

            // Fill and print the second array
            Console.WriteLine("\nThe second array:");
            int[] secondArray = new int[arrayLength];
            FillArray(secondArray);
            PrintArray(secondArray);

            // Output add polynomials
            int[] result = AddPolynomial(firstArray, secondArray, arrayLength);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Add polynomial:");
            PrintPolynomials(result);

            // Output substract polynomials
            result = SubstractPolynomial(firstArray, secondArray, arrayLength);
            Console.WriteLine();
            Console.WriteLine("Substract polynomial:");
            PrintPolynomials(result);

            // Output substract polynomials
            result = MultiplicatePolynomial(firstArray, secondArray, arrayLength);
            Console.WriteLine();
            Console.WriteLine("Multiplicate polynomial:");
            PrintPolynomials(result);
        }
    }

    // Fill the both arrays with random numbers
    private static void FillArray(int[] array)
    {
        int min = 0;
        int max = 10;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randomNumber.Next(min, max);
        }
    }

    // Print the array
    private static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    // Add polynomials
    private static int[] AddPolynomial(int[] firstArray, int[] secondArray, int length)
    {
        int[] resultArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            resultArray[i] = firstArray[i] + secondArray[i];
        }

        return resultArray;
    }

    // Substract polynomials
    private static int[] SubstractPolynomial(int[] firstArray, int[] secondArray, int length)
    {
        int[] resultArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            resultArray[i] = firstArray[i] - secondArray[i];
        }

        return resultArray;
    }

    // Multiplicate polynomials
    private static int[] MultiplicatePolynomial(int[] firstArray, int[] secondArray, int length)
    {
        int[] resultArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            resultArray[i] = firstArray[i] * secondArray[i];
        }

        return resultArray;
    }

    // Print output
    private static void PrintPolynomials(int[] result)
    {
        for (int i = result.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                Console.WriteLine(result[i]);
                break;
            }
            else if (i == 1)
            {
                Console.Write(result[i] + "x" + " + ");
            }
            else
            {
                Console.Write(result[i] + "x" + i + " + ");
            }
        }
    }
}
