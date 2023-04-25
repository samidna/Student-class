using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp5.Models;

internal class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Student(string name, string surname)
    {
        Name = name;
        Surname = surname;
    
    }
    public void Fullname()
    {
        Console.WriteLine("Name:"+Name+"  "+"Surname:"+Surname);
    }
}
