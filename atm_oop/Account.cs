public class Account
{
    public decimal Balance { get; private set; }

    public Account(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"You have successfully deposited {amount:C}. Your new balance is {Balance:C}.");
        }
        else
        {
            Console.WriteLine("Invalid amount. Please try again.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"You have successfully withdrawn {amount:C}. Your new balance is {Balance:C}.");
            }
            else
            {
                Console.WriteLine("Insufficient funds. Please try again.");
            }
        }
        else
        {
            Console.WriteLine("Invalid amount. Please try again.");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Your current balance is: {Balance:C}");
    }
}
