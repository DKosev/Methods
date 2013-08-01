using System;
using System.Globalization;
using System.Threading;

/* Write a program that can solve these tasks:
 * Reverses the digits of a number
 * Calculates the average of a sequence of integers
 * Solves a linear equation a * x + b = 0 */

class MultiTaskProgram
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Hello {0}!", Environment.UserName);
        Console.WriteLine("Choose what you're going to do in the next step.");
       
        // Options list
        Console.WriteLine("\nOptions:");
        Console.WriteLine("1. Enter 1 if you want to reverse the digits of a number");
        Console.WriteLine("2. Enter 2 if you want to calculate the average of a sequence of integers");
        Console.WriteLine("3. Enter 3 if you want to solve a linear equation a * x + b = 0");

        // User choice
        Console.Write("Your choice:\n=> ");
        int userChoice = int.Parse(Console.ReadLine());
        ChoiceOption(userChoice);
    }

    // Options to choose
    private static void ChoiceOption(int input)
    {
        switch (input)
        {
            case 1:
                ReverseDigitsMenu();
                break;
            case 2:
                CalculateAverageMenu();
                break;
            case 3:
                SolveLinearEquation();
                break;
            default:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\aError! You have to choose from the three options.\n");
                Console.ResetColor();
                Main();
                break;
        }
    }

    private static void ReverseDigitsMenu()
    {
        // Input data
        Console.Write("Enter a number to reverse it, it have to be positive:\n=> ");
        string inputNumber = Console.ReadLine();
        if (decimal.Parse(inputNumber) > 0)
        {
            // Convert the input string number into decimal 
            decimal parsedNumber = Convert.ToDecimal(inputNumber.Replace(",", "."));

            // Reverse the input number
            decimal reversedNumber = ReverseDecimal(parsedNumber);

            // Output
            Console.WriteLine("The entered number is: {0}", inputNumber);
            Console.WriteLine("The reversed number looks like: {0}", reversedNumber);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\aError! Enter a positive number.");
            Console.ResetColor();
            ReverseDigitsMenu();
        }
    }

    // Reverse the number
    private static decimal ReverseDecimal(decimal inputNumber)
    {
        string parsedNumber = inputNumber.ToString();
        string[] arrayList = new string[parsedNumber.Length];
        for (int i = 0; i < parsedNumber.Length; i++)
        {
            arrayList[i] = parsedNumber[i].ToString();
        }

        Array.Reverse(arrayList);
        parsedNumber = string.Join(string.Empty, arrayList);
        return inputNumber = decimal.Parse(parsedNumber);
    }

    // Calculate average menu
    private static void CalculateAverageMenu()
    {
        Console.Write("Enter how many numbers you will add to calculate their average:\n=> ");
        int arrayLength = int.Parse(Console.ReadLine());
        if (arrayLength <= 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\aError! There have to be some numbers in the array.");
            Console.ResetColor();
            CalculateAverageMenu();
        }
        else
        {
            decimal[] userArray = new decimal[arrayLength];

            // Fill the array
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.Write("Enter the {0} number: => ", i + 1);
                userArray[i] = decimal.Parse(Console.ReadLine().Replace(",", "."));
            }

            // Print the array
            Console.WriteLine("Your array of numbers looks like:");
            PrintArray(userArray);

            // Show the average of the entered numbers
            Console.WriteLine("\nThe average of these numbers is:");
            Console.WriteLine("{0:F3}", GetAverage(userArray));
        }
    }

    // Print the array
    private static void PrintArray(decimal[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    // Get the average from the array
    private static decimal GetAverage(decimal[] array)
    {
        decimal sumElements = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sumElements += array[i];
        }

        decimal average = sumElements / array.Length;
        return average;
    }

    // Solve linear equation
    private static void SolveLinearEquation()
    {
        Console.WriteLine("Linear equation: a * x + b = 0");
        Console.Write("Enter value for 'a' parameter:\n=> ");
        decimal valueA = decimal.Parse(Console.ReadLine());
        if (valueA == 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\aError! The 'a' parameter should not be equal to 0.");
            Console.ResetColor();
            SolveLinearEquation();
        }
        else
        {
            Console.Write("Enter value for 'b' parameter:\n=> ");
            decimal valueB = decimal.Parse(Console.ReadLine());

            // Linear equation solution
            Console.WriteLine("\nSolution:");
            GetTheSignOfANumber(valueA, valueB);
        }
    }

    // Get the sign of a number
    private static void GetTheSignOfANumber(decimal firstParam, decimal secondParam)
    {
        if ((firstParam < 0 && secondParam < 0) || (firstParam > 0 && secondParam < 0))
        {
            Console.WriteLine("{0} * x + ({1}) = 0", firstParam, secondParam);
            Console.WriteLine("{0} * x = 0 - ({1})", firstParam, secondParam);
            Console.WriteLine("{0} * x = {1}", firstParam, 0 - secondParam);
            Console.WriteLine("x = {0} / {1}", secondParam, firstParam);
            Console.WriteLine("x = {0}", secondParam / firstParam);
        }
        else if ((firstParam > 0 && secondParam > 0) || (firstParam < 0 && secondParam > 0))
        {
            Console.WriteLine("{0} * x + {1} = 0", firstParam, secondParam);
            Console.WriteLine("{0} * x = 0 - {1}", firstParam, secondParam);
            Console.WriteLine("{0} * x = {1}", firstParam, 0 - secondParam);
            Console.WriteLine("x = {0} / {1}", secondParam, firstParam);
            Console.WriteLine("x = {0}", secondParam / firstParam);
        }
    }
}