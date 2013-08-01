using System;
using System.Globalization;
using System.Threading;

/* Write a method that reverses the digits of given decimal number. Example: 256  652 */

class ReverseDigitsOfNumber
{
    static void Main()
    {
        // Convert the comma in decimal to period
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        // Input data
        Console.Write("Enter a number to reverse it, it can be positive or negative:\n=> ");
        string inputNumber = Console.ReadLine();
        
        // Convert the input string number into decimal 
        decimal parsedNumber = Convert.ToDecimal(inputNumber.Replace(",", "."));

        // Reverse the input number
        decimal reversedNumber = ReverseDecimal(parsedNumber);
        
        // Output
        Console.WriteLine("The entered number is: {0}", inputNumber);
        Console.WriteLine("The reversed number looks like: {0}", reversedNumber);
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
}
