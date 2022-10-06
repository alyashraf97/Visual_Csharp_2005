// Class with constructor
using System;

public class GradeBookTest
{
    public static void Main(string[] args)
    {
        GradeBook myGradeBook1 = new GradeBook("CS101 Introduction to C# Programming");
        GradeBook myGradeBook2 = new GradeBook("CS102 Data Structures in C#");

        Console.WriteLine("gradeBook1 Course name is {0}\n", myGradeBook1.CourseName);
        Console.WriteLine("gradeBook2 Course name is {0}", myGradeBook2.CourseName);
        

        //Console.WriteLine();
        //myGradeBook.display_message()

    }
}