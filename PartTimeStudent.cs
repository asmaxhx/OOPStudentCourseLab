using System;

public class PartTimeStudent : Student
{
    public int HoursPerWeek { get; set; }

    public PartTimeStudent(int id, string name, string email, int hours)
        : base(id, name, email)
    {
        HoursPerWeek = hours;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine("Part-Time Student");
        base.DisplayDetails();
        Console.WriteLine($"Hours per week: {HoursPerWeek}");
    }
}