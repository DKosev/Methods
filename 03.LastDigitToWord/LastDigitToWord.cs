using System;

/* Write a method that returns the last digit of given 
 * integer as an English word. Examples: 
 * 512  "two", 1024  "four", 12309  "nine". */

class LastDigitToWord
{
    static void Main()
    {
        Console.Write("Enter a number to find out what is the name of its last number:\n=> ");
        int inputNumber = int.Parse(Console.ReadLine());
        if (inputNumber < 0)
        {
            inputNumber = inputNumber * -1;
            Console.Write("The last digit of -{0} is ", inputNumber);
        }
        else
        {
            Console.Write("The last digit of {0} is ", inputNumber);
        }

        PrintLastDigit(inputNumber);
    }

    // Find the name of the last digit
    private static void PrintLastDigit(int enteredNumber)
    {
        string[] numbers = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", };
        if (enteredNumber % 10 == 0)
        {
            Console.WriteLine(numbers[0]);
        }
        else if (enteredNumber % 10 == 1)
        {
            Console.WriteLine(numbers[1]);
        }
        else if (enteredNumber % 10 == 2)
        {
            Console.WriteLine(numbers[2]);
        }
        else if (enteredNumber % 10 == 3)
        {
            Console.WriteLine(numbers[3]);
        }
        else if (enteredNumber % 10 == 4)
        {
            Console.WriteLine(numbers[4]);
        }
        else if (enteredNumber % 10 == 5)
        {
            Console.WriteLine(numbers[5]);
        }
        else if (enteredNumber % 10 == 6)
        {
            Console.WriteLine(numbers[6]);
        }
        else if (enteredNumber % 10 == 7)
        {
            Console.WriteLine(numbers[7]);
        }
        else if (enteredNumber % 10 == 8)
        {
            Console.WriteLine(numbers[8]);
        }
        else if (enteredNumber % 10 == 9)
        {
            Console.WriteLine(numbers[9]);
        }
    }
}