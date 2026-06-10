using System;

public class Person
{
    private string name;
    private string email;

    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                name = value;
            }
        }
    }

    public string Email
    {
        get { return email; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                email = value;
            }
        }
    }

    public Person(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
    }
}