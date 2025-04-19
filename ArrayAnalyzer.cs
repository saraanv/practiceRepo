class ArrayAnalyzer
{
   public void AnalyzeArray(int[] array, ref int max, out double average )
    {
        if (array.Length == 0)
        {
            max = 0;
            average = 0.0 ;
            return ;
        }

        int sum = 0;
        max = array[0];

        foreach (var num in array)
        {
            sum += num;

            if (sum > max)
            {
                max = num;
            }
        }

        average = sum / array.Length;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter size of array: ");
        string input = Console.ReadLine();
        int size = int.Parse(input);

        int[] array= new int[size];

        Console.WriteLine("Enter elements of array: ");
        for (int i=0; i<size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        ArrayAnalyzer arrayAnalyzer = new ArrayAnalyzer();
        int max = 0;
        double average;
        arrayAnalyzer.AnalyzeArray(array, ref max,out  average );
        Console.WriteLine($"max is : {max} ");
        Console.WriteLine($"average is : {average:F1}");
    }
}

