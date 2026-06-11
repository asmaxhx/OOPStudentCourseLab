using System;
using System.Collections.Generic;
using System.Linq;

public class Student : Person
{
    public int StudentId { get; set; }

    public Student(int id, string name, string email)
        : base(name, email)
    {
        StudentId = id;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Student ID: {StudentId}");
        base.DisplayDetails();
    }
}