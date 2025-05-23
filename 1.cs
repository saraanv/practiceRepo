int sum = 0;
int count = 0;
for (int i = 0; i<=10; i++)
{
    Console.WriteLine($"your score at {i} lesson (-1 is exit)");
    string input = Console.ReadLine();
    int number = int.Parse( input );
    if (number == -1)
    {
        break;
    }
    sum += number;
    count++;
}
   int avg;
    avg = sum / count;
    Console.WriteLine($"your avg is {avg}");