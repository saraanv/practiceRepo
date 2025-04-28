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
        Student student = new Student();
        student.Name = "Sara Alinezhad";
        student.Age = 21;
        student.StudentID = 401463156;
        student.Major = "Computer Enginering";
        student.GetDetails();

        Professor professor = new Professor();
        professor.Name = "Dr.Professor Unknown";
        professor.Age = 56;
        professor.ProfessorID = 123456;
        professor.Subject = "Artificial Intelligence";
        professor.GetDetails();
    }
}