class Statistics
{
    public void AnalyzeNumbers (int a, ref int b , out int c)
    {
        c = a + b;
        b *= b;
    }
}

class Program
{
    static void Main()
    {
       Statistics stats = new Statistics();

       Console.Write("number a=");
       string input1 = Console.ReadLine();
       int a = int.Parse(input1);
        Console.Write("number b=");
        string input2 = Console.ReadLine();
        int b = int.Parse(input2);
        Console.Write("number c=");
        string input3 = Console.ReadLine();
        int c = int.Parse(input3);

        Console.WriteLine($"a={a}");
        Console.WriteLine($"b={b}");
        Console.WriteLine($"c={c}");

        stats.AnalyzeNumbers(a, ref b , out c);
        Console.WriteLine($"new a= {a}");
        Console.WriteLine($"new b= {b}");
        Console.WriteLine($"new c= {c}");

    }
}