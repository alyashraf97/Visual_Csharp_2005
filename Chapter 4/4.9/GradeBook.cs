using System;

public class GradeBook
{
    private string courseName;

    public GradeBook(string name)
    {
        CourseName = name;
    }

    public string CourseName
    {
        get { return courseName; }
        set { courseName = value; }
    }

    public void display_message()
    {
        Console.WriteLine("Welcome to the gradebook for {0}", CourseName);
    }
}