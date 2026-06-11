using System;
using System.Collections.Generic;

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public Instructor CourseInstructor { get; set; }

    // Exercise features
    public int DurationInWeeks { get; set; }
    public string Level { get; set; }       // Beginner / Intermediate / Advanced
    public string Category { get; set; }    // e.g. Programming, QA

    public bool IsCompleted { get; set; }

    // Students enrolled in this course
    public List<Student> EnrolledStudents { get; set; }

    // Student grades (StudentId -> Grade)
    public Dictionary<int, string> StudentGrades { get; set; }

    public Course(int courseId, string courseName, Instructor instructor,
                  int durationInWeeks, string level, string category)
    {
        CourseId = courseId;
        CourseName = courseName;
        CourseInstructor = instructor;

        DurationInWeeks = durationInWeeks;
        Level = level;
        Category = category;

        IsCompleted = false;

        EnrolledStudents = new List<Student>();
        StudentGrades = new Dictionary<int, string>();
    }

    // ---------------- ENROL STUDENT (with duplicate check) ----------------
    public void EnrolStudent(Student student)
    {
        if (student == null)
        {
            Console.WriteLine("Cannot enrol null student.");
            return;
        }

        bool exists = EnrolledStudents.Exists(s => s.StudentId == student.StudentId);

        if (exists)
        {
            Console.WriteLine($"{student.Name} is already enrolled in {CourseName}.");
            return;
        }

        EnrolledStudents.Add(student);
        Console.WriteLine($"{student.Name} enrolled in {CourseName}");
    }

    // ---------------- REMOVE STUDENT ----------------
    public void RemoveStudent(int studentId)
    {
        var student = EnrolledStudents.Find(s => s.StudentId == studentId);

        if (student == null)
        {
            Console.WriteLine("Student not found in this course.");
            return;
        }

        EnrolledStudents.Remove(student);
        Console.WriteLine($"{student.Name} removed from {CourseName}");
    }

    // ---------------- ASSIGN GRADE ----------------
    public void AssignGrade(int studentId, string grade)
    {
        if (!StudentGrades.ContainsKey(studentId))
        {
            StudentGrades.Add(studentId, grade);
        }
        else
        {
            StudentGrades[studentId] = grade;
        }

        Console.WriteLine($"Grade {grade} assigned to student ID {studentId}");
    }

    // ---------------- DISPLAY COURSE DETAILS ----------------
    public void DisplayCourseDetails()
    {
        Console.WriteLine("\n=== COURSE DETAILS ===");
        Console.WriteLine($"Course ID: {CourseId}");
        Console.WriteLine($"Course Name: {CourseName}");
        Console.WriteLine($"Instructor: {CourseInstructor.Name}");
        Console.WriteLine($"Duration: {DurationInWeeks} weeks");
        Console.WriteLine($"Level: {Level}");
        Console.WriteLine($"Category: {Category}");
        Console.WriteLine($"Completed: {IsCompleted}");

        Console.WriteLine("\nEnrolled Students:");

        if (EnrolledStudents.Count == 0)
        {
            Console.WriteLine("No students enrolled.");
        }
        else
        {
            foreach (var student in EnrolledStudents)
            {
                Console.WriteLine($"- {student.StudentId}: {student.Name}");
            }
        }

        Console.WriteLine("\nGrades:");

        if (StudentGrades.Count == 0)
        {
            Console.WriteLine("No grades assigned.");
        }
        else
        {
            foreach (var g in StudentGrades)
            {
                Console.WriteLine($"Student ID {g.Key}: {g.Value}");
            }
        }
    }
}