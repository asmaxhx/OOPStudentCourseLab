using System;

public class FullTimeStudent : Student
{
    public string StudyMode { get; set; }

    public FullTimeStudent(int id, string name, string email)
        : base(id, name, email)
    {
        StudyMode = "Full-Time";
    }

    public override void DisplayDetails()
    {
        Console.WriteLine("Full-Time Student");
        base.DisplayDetails();
        Console.WriteLine($"Mode: {StudyMode}");
    }
}