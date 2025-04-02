//Calculate the average score of a student

// approach 1 :

//int sum = 0;
//int count= 0;
//bool userReq = true;
//while (userReq)
//{
//    Console.Write("Your score(-1 is exit): ");
//    string input = Console.ReadLine();
//    int number = int.Parse(input);  
//    if (number == -1)
//    {
//        userReq = false;
//    }
//    else
//    {
//        sum += number;
//        count++;

//    }
//}
//Console.WriteLine($"your avg is {sum/count}");

// approach 2 :

int sum = 0;
int count = 0;
int number = 0;
while (number != -1)
{
    Console.Write("Your score(-1 is exit): ");
    string input = Console.ReadLine();
    number = int.Parse(input);
    if (number != -1)
    {
        sum += number;
        count++;

    }
}
Console.WriteLine($"your avg is {sum / count}");