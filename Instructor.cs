using System;

public class Instructor : Person
{
    public int InstructorId { get; set; }
    public string Specialism { get; set; }

    public Instructor(int instructorId, string name, string email, string specialism)
        : base(name, email)
    {
        InstructorId = instructorId;
        Specialism = specialism;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine("Instructor Details");
        Console.WriteLine("------------------");
        Console.WriteLine($"Instructor ID: {InstructorId}");

        base.DisplayDetails();

        Console.WriteLine($"Specialism: {Specialism}");
    }
}