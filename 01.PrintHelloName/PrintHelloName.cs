using System;

/* Write a method that asks the user for his name and prints 
 * “Hello, <name>” (for example, “Hello, Peter!”). 
 * Write a program to test this method. */

class PrintHelloName
{
    static void Main()
    {
        Console.Write("Please enter your name:\n=> ");
        string userName = Console.ReadLine();

        Greeting(userName);
    }

    private static void Greeting(string userName)
    {
        Console.WriteLine("Hello, {0}", userName);
    }
}