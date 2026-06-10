using System;

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public Instructor CourseInstructor { get; set; }

    public Course(int courseId, string courseName, Instructor instructor)
    {
        CourseId = courseId;
        CourseName = courseName;
        CourseInstructor = instructor;
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine("Course Details");
        Console.WriteLine("--------------");
        Console.WriteLine($"Course ID: {CourseId}");
        Console.WriteLine($"Course Name: {CourseName}");
        Console.WriteLine($"Instructor: {CourseInstructor.Name}");
    }
}