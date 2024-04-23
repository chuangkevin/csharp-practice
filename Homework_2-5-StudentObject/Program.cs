using Microsoft.VisualBasic;
using System;

public class Class
{
    public string Name { get; set; }
    public int Point { get; set; }

    public override string ToString()
    {
        return $"\t{Name}，{Point}學分";
    }
}

public class Student
{
    public string Number { get; set; }
    public string Name { get; set; }
    public IEnumerable<Class> Classes { get; set; }

    public override string ToString()
    {
        return $"學號:{Number}"
            + Environment.NewLine
            + $"姓名:{Name}"
            + Environment.NewLine
            + $"選課:{Environment.NewLine}{string.Join(Environment.NewLine, Classes)}"
            + Environment.NewLine
            + $"總共:{Classes.Sum(y => y.Point)}學分";
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> studentList = new List<Student>();
        Student student1 = new Student()
        {
            Number = "S11001",
            Name = "Dann",
            Classes = new List<Class>()
            {
                new Class()
                {
                    Name = "微積分",
                    Point = 4
                },
                new Class()
                {
                    Name = "線性代數",
                    Point = 3
                },
                new Class()
                {
                    Name = "普通物理",
                    Point = 3
                },
                new Class()
                {
                    Name= "物理實驗",
                    Point = 1
                }
            }
        };

        Student student2 = new Student()
        {
            Number = "S11002",
            Name = "Bill",
            Classes = new List<Class>()
            {
                new Class()
                {
                    Name = "視唱",
                    Point = 3
                },
                new Class()
                {
                    Name = "和弦",
                    Point = 4
                }
            }
        };

        studentList.Add(student1);
        studentList.Add(student2);
        foreach (var student in studentList)
        {
            Console.WriteLine(student.ToString());
            Console.WriteLine("------------------------");
        }
        Console.ReadLine();
    }
}