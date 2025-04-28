class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void GetDetails()
    {
        //Console.WriteLine("Enter your name: ");
        //string input = Console.ReadLine();
        //Console.WriteLine("Enter your age");
        //string input2 = Console.ReadLine();
        //age = int.Parse(input2);
        Console.WriteLine($"Name is {Name} and age is {Age}");
    }
}

class Student : Person
{
    public int StudentID { get; set; }
    public string Major {  get; set; }

    public void GetDetails()
    {
        Console.WriteLine($"Student => Name: {Name}, Age: {Age}, StudentID: {StudentID}, Major: {Major}");
    }
}

class Professor : Person
{
    public int ProfessorID { get; set; }
    public string Subject { get; set; }

    public void GetDetails()
    {
        Console.WriteLine($"Professor => Name: {Name}, Age: {Age}, ProfessorID: {ProfessorID}, Subject: {Subject}");
    }
}

class Program
{
    public static void Main(string[] args)
    {

        List<Student> students = new List<Student>
        {
        new Student { Name = "Sara Alinezhad", Age = 21, StudentID = 1234, Major = "Computer Enginering" },
        new Student { Name = "Ali Alavi", Age = 20, StudentID = 234, Major = "Computer Science" },
        };


        List<Professor> professors = new List<Professor>
        {
        new Professor { Name = "Unknown 1", Age = 56, ProfessorID = 1234, Subject = "AI" },
        new Professor { Name = "Unknown 2", Age = 55, ProfessorID = 234, Subject = "Network" },
        };

        foreach (Student student in students)
        {
            student.GetDetails();
        }

        foreach (Professor professor in professors)
        {
            professor.GetDetails(); 
        }
    }
}
