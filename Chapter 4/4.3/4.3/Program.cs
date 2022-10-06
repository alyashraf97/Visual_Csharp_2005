// Class example
using System;
/*public class GradeBookTest
{
    public void display_message()
    {
        Console.WriteLine("Welcome to the Grade Book!");
    }
}*/
public class GradeBookTest
{
    static void Main(string[] args)
    {
        GradeBook gradeBook = new GradeBook();
        Console.WriteLine("Please enter the course name: ");
        
        string courseName = Console.ReadLine();
        Console.WriteLine();
        
        gradeBook.display_messages( courseName );
    }
}