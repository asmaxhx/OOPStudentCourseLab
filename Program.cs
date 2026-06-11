using System;
using System.Collections.Generic;

class Program
{
    static List<Course> courses = new List<Course>();
    static List<Student> students = new List<Student>();

    static void Main()
    {
        SeedData();

        Console.WriteLine("======================================");
        Console.WriteLine("   STUDENT COURSE MANAGEMENT SYSTEM   ");
        Console.WriteLine("======================================");
        Console.WriteLine("Welcome! Manage students and courses easily.\n");

        while (true)
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Show Courses");
            Console.WriteLine("2. Show Students");
            Console.WriteLine("3. Search Student by ID");
            Console.WriteLine("4. Remove Student from Course");
            Console.WriteLine("5. Exit");
            Console.Write("Enter option: ");

            string input = Console.ReadLine();

            Console.WriteLine();

            switch (input)
            {
                case "1":
                    ShowCourses();
                    break;

                case "2":
                    ShowStudents();
                    break;

                case "3":
                    SearchStudent();
                    break;

                case "4":
                    RemoveStudentFromCourse();
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please enter 1-5.");
                    break;
            }
        }
    }

    // ---------------- SEED DATA ----------------
    static void SeedData()
    {
        var instructor = new Instructor(1, "Sarah Johnson", "sarah@test.com", "Software Testing");

        var course1 = new Course(101, "C# Basics", instructor, 6, "Beginner", "Programming");
        var course2 = new Course(102, "Advanced Testing", instructor, 8, "Advanced", "QA");

        courses.Add(course1);
        courses.Add(course2);

        var s1 = new FullTimeStudent(1, "Michael Brown", "michael@test.com");
        var s2 = new PartTimeStudent(2, "Emma White", "emma@test.com", 15);
        var s3 = new FullTimeStudent(3, "John Green", "john@test.com");

        students.Add(s1);
        students.Add(s2);
        students.Add(s3);

        course1.EnrolStudent(s1);
        course1.EnrolStudent(s2);
        course2.EnrolStudent(s3);
    }

    // ---------------- SHOW COURSES ----------------
    static void ShowCourses()
    {
        foreach (var c in courses)
        {
            Console.WriteLine($"{c.CourseId} - {c.CourseName}");
        }
    }

    // ---------------- SHOW STUDENTS ----------------
    static void ShowStudents()
    {
        foreach (var s in students)
        {
            Console.WriteLine($"{s.StudentId} - {s.Name}");
        }
    }

    // ---------------- SEARCH STUDENT ----------------
    static void SearchStudent()
    {
        try
        {
            Console.Write("Enter Student ID to search: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int id))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            var student = students.Find(s => s.StudentId == id);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.WriteLine("\n--- STUDENT FOUND ---");
            student.DisplayDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error searching student: " + ex.Message);
        }
    }

    // ---------------- REMOVE STUDENT ----------------
    static void RemoveStudentFromCourse()
    {
        try
        {
            Console.Write("Enter Course ID: ");
            if (!int.TryParse(Console.ReadLine(), out int courseId))
            {
                Console.WriteLine("Invalid Course ID.");
                return;
            }

            Console.Write("Enter Student ID: ");
            if (!int.TryParse(Console.ReadLine(), out int studentId))
            {
                Console.WriteLine("Invalid Student ID.");
                return;
            }

            var course = courses.Find(c => c.CourseId == courseId);

            if (course == null)
            {
                Console.WriteLine("Course not found.");
                return;
            }

            course.RemoveStudent(studentId);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error removing student: " + ex.Message);
        }
    }
}