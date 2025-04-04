string text = "CSharp";
int attempts = 0;
bool found= false;
Console.WriteLine("Guess a text: ");
while (!found)
{
    string guess = Console.ReadLine();
    if (guess == text)
    {
        attempts++;
        Console.WriteLine($"You are right! Congratulations! You won after {attempts} attempts.");
        break;
    }
    else
    {
        attempts++;
        Console.WriteLine($"Try again!You had {attempts} attempts");
    }
}