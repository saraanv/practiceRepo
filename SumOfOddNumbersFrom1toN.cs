int n;
int sum = 0;
bool valid = false;
Console.WriteLine("Give a number > 1: ");
string input = Console.ReadLine();
n = int.Parse(input);
while (!valid)
{
    if (n < 1)
    {
        Console.WriteLine("The number should be >1");
        string input2 = Console.ReadLine();
        n = int.Parse(input2);
    }
    else
        valid = true;
}
for  (int i = 0; i < n; i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine($"odd numbers before: {i}");
        sum = sum + i;
    }

}
    Console.WriteLine($"The sum of off numbers before n is = {sum}");