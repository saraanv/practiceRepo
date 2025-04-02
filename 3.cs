//string input = "";
//do
//{
//    Console.WriteLine("Give a number: ");
//    input = Console.ReadLine();  
//    Console.WriteLine(input);
//} while ( input != "0");


string input = "";
int sum = 0;
int count = 0;
do
{
    Console.WriteLine("Give a number: ");
    input = Console.ReadLine();
    sum += int.Parse(input);
    if (input != "0")
    {
        count++;
    }
} while (input != "0");
Console.WriteLine($"avg is {sum / count}");

