using System;
using System.Collections.Generic;

public class Student : Person
{
    public int StudentId { get; set; }
    public List<Course> EnrolledCourses { get; set; }

    public Student(int studentId, string name, string email)
        : base(name, email)
    {
        StudentId = studentId;
        EnrolledCourses = new List<Course>();
    }

    public void Enrol(Course course)
    {
        EnrolledCourses.Add(course);
        Console.WriteLine($"{Name} has enrolled on {course.CourseName}");
    }

    public override void DisplayDetails()
    {
        Console.WriteLine("Student Details");
        Console.WriteLine("----------------");
        Console.WriteLine($"Student ID: {StudentId}");

        base.DisplayDetails();

        Console.WriteLine("Enrolled Courses:");

        if (EnrolledCourses.Count == 0)
        {
            Console.WriteLine("No courses enrolled.");
        }
        else
        {
            foreach (Course course in EnrolledCourses)
            {
                Console.WriteLine($"- {course.CourseName}");
            }
        }
    }
}
