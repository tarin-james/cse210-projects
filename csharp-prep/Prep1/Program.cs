// Name Teller
// CSE 210
// Tarin James
// User types first and last name and the program reads it back

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        
        Console.Write($"Your name is {lastName}, {firstName} {lastName}");
    }
}