namespace ConsoleApp5.Models;

internal class Group
{
    public int No { get; set; }
    public int Limit { get; set; }
    private Student[] Students { get; set; } = new Student[0];

    public Group(int limit)
    {
        Limit = limit;
    }
    public void AddStudent(Student student)
    {
        if (Students.Length < Limit)
        {
            Student[] List = new Student[Students.Length + 1];
            for (int i = 0; i < Students.Length; i++)
            {
                List[i] = Students[i];
            }
            List[Students.Length] = student;
            Students = List;
        }
        else
        {
            Console.WriteLine("Group is full.");
        }
    }
    public string GetStudents()
    {
        string result = "Telebeler: ";
        foreach (var student in Students)
        {
            result += $"{student.Name} {student.Surname}";
        }
        return result;
    }
}




