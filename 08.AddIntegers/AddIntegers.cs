using System;
using System.Numerics;

/* Write a method that adds two positive integer numbers represented 
 * as arrays of digits (each array element arr[i] contains a digit; 
 * the last digit is kept in arr[0]). Each of the numbers that will 
 * be added could have up to 10 000 digits. */

class AddIntegers
{
    private static readonly Random randomNumber = new Random();
    
    static void Main()
    {
        Console.Write("Enter the width for the two arrays:\n=> ");
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
            // Fill and print the arrays
            BigInteger[] firstArr = new BigInteger[arrayLength];
            FillArray(firstArr);
            Console.WriteLine("First array:");
            PrintArray(firstArr);

            BigInteger[] secondArr = new BigInteger[arrayLength];
            FillArray(secondArr);
            Console.WriteLine("\nSecond array");
            PrintArray(secondArr);

            // Sum output
            BigInteger result = SumArrays(firstArr, secondArr);
            Console.WriteLine("\nThe sum of the both arrays is: {0}", result);
        }
    }

    // Fill the arrays with random numbers
    private static BigInteger[] FillArray(BigInteger[] array)
    {
        int min = 1;
        int max = 10;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randomNumber.Next(min, max);
        }

        return array;
    }

    // Print the filled arrays
    private static void PrintArray(BigInteger[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    // Sum the numbers in the both arrays
    private static BigInteger SumArrays(BigInteger[] arr1, BigInteger[] arr2)
    {
        BigInteger sum = 0;
        string num1 = string.Empty;
        string num2 = string.Empty;
        for (int i = 0; i < arr1.Length; i++)
        {
            num1 += arr1[i].ToString();
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            num2 += arr2[i].ToString();
        }

        BigInteger first = BigInteger.Parse(num1);
        BigInteger second = BigInteger.Parse(num2);
        sum = first + second;
        return sum;
    }
}