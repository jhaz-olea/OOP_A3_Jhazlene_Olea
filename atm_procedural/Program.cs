using System;

class Program
{
    static decimal balance = 1000.00m; // Initial balance

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("ATM Simulation");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CheckBalance();
                    break;
                case "2":
                    DepositMoney();
                    break;
                case "3":
                    WithdrawMoney();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    static void CheckBalance()
    {
        Console.WriteLine($"Your current balance is: {balance:C}");
    }

    static void DepositMoney()
    {
        Console.Write("Enter the amount to deposit: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            balance += amount;
            Console.WriteLine($"You have successfully deposited {amount:C}. Your new balance is {balance:C}.");
        }
        else
        {
            Console.WriteLine("Invalid amount. Please try again.");
        }
    }

    static void WithdrawMoney()
    {
        Console.Write("Enter the amount to withdraw: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"You have successfully withdrawn {amount:C}. Your new balance is {balance:C}.");
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
}
