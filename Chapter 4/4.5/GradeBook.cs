using System;

public class GradeBook
{
    private string courseName;

    public string CourseName
    {
        get
        {
            return courseName;
        }
        set
        {
            courseName = value;
        }
    }

    public void display_message()
    {
        Console.WriteLine("Welcome to the grade book for {0}", CourseName);
    }
}