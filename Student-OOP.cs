class Student
{
    //fields
    private string name;
    private int age;

    //proprtis
    public string Name { get { return name; } set { name = value; } }
    public int Age { get {return age; } set { age = value; } }

    //constructor
    public Student()
    {
        Console.WriteLine("Name:");
        string input1 = Console.ReadLine();
        name = input1;
        Console.WriteLine("Age:");
        string input2 = Console.ReadLine();
        age = int.Parse(input2);
    }

     //method
    public void Introduce()
    {
        Console.WriteLine($"Hello , my name is {name} and I am {age} years old.");
    }

}

//Main
class Program
{
    static void Main()
    {
        Student student = new Student();
        student.Introduce();
    }
}
