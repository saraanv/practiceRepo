class BankAccount
{
    //Field
    private int Balance;

    //Constructor
    public BankAccount(int InitialSet)
        {
        Balance = InitialSet;
        }


    //Method Withdraw
    public void Withdraw(int amount)
    {

        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"New balance with withdraw is {Balance}");
        }
        else
        {
            Console.WriteLine("Not Enough");
        }
    }

    //Method Deposit
    public void Deposit(int amount)
    {
        Balance += amount;
        Console.WriteLine($"New balance with deposit is {Balance}");
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Balance: {Balance}");
    }

}
//Program Class
class Program
{
    //Main
    static void Main()
    {
        BankAccount account = new BankAccount(1000);
        account.ShowBalance();
        account.Deposit(300);
        account.Withdraw(250);
        account.Withdraw(1500);
        account.ShowBalance();
    }
}
