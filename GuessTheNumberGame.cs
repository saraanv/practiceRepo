int Number = 4;
int ValidInput= 5;
bool Found = false;
Console.WriteLine("Guess a number between 1 to 10"); 
while (!Found)
{
    for (int i = 0; i < ValidInput; i++)
    {
        string input = Console.ReadLine();
        int userGuess =  int.Parse(input);
        if (userGuess == Number )
        {
            Console.WriteLine("Right! Congratulations!");
            Found = true;
            break;
        }
        else
        {
            Console.WriteLine("Wrong! Try again!");
        }
    }
    if ( !Found )
    {
        Console.WriteLine("You tried 5 times! The number is 4!");
        break;
    }
}
