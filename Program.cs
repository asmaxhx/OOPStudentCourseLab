using System;

Console.WriteLine("Student Course Management System");
Console.WriteLine("================================");

// Create instructor
Instructor instructor = new Instructor(
    1,
    "Sarah Johnson",
    "sarah.johnson@example.com",
    "Software Testing"
);

// Create courses
Course course1 = new Course(
    101,
    "Object-Oriented Programming with C#",
    instructor
);

Course course2 = new Course(
    102,
    "Introduction to Test Automation",
    instructor
);

// Create student
Student student = new Student(
    1001,
    "Michael Brown",
    "michael.brown@example.com"
);

// Enrol student
student.Enrol(course1);
student.Enrol(course2);

Console.WriteLine();
student.DisplayDetails();

Console.WriteLine();
course1.DisplayCourseDetails();

Console.WriteLine();
instructor.DisplayDetails();
