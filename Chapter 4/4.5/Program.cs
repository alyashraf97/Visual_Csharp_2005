using System;

public class GradeBookTest
{
    public static void Main(string[] args)
    {
        GradeBook gradeBook = new GradeBook();
        Console.WriteLine("The initual value of CourseName is: '{0}'", gradeBook.CourseName);
        Console.WriteLine();

        Console.WriteLine("Enter the name of the Course: ");
        string userInput = Console.ReadLine();
        gradeBook.CourseName = userInput;
        Console.WriteLine();

        gradeBook.display_message();
        Console.WriteLine();

        Console.WriteLine("The value of CourseName is: '{0}'", gradeBook.CourseName);


    }
}