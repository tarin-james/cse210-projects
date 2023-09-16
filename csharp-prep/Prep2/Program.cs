using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int number = int.Parse(userGrade);

        string letter;

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number < 90 && number >= 80)
        {
            letter = "B";
        }
        else if (number < 80 && number >= 70)
        {
            letter = "C";
        }
        else if (number < 70 && number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your Grade is a {letter}");
        
        if (letter == "D"|| letter == "F")
        {
            Console.WriteLine("You did not pass the class, study harder");
        }
        else
        {
            Console.WriteLine("Congrats! You passed the class");
        }

    }
}