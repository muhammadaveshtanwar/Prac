using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Student
{
    public string Name;
    public int Age;

    public Student()
    {
        Name = "Unknown";
        Age = 0;
    }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        Calculator c = new Calculator();

        Console.WriteLine(c.Add(10, 20));
        Console.WriteLine(c.Add(10, 20, 30));

        Student s1 = new Student();
        Student s2 = new Student("Aman", 20);

        Console.WriteLine(s1.Name + " " + s1.Age);
        Console.WriteLine(s2.Name + " " + s2.Age);
    }
}