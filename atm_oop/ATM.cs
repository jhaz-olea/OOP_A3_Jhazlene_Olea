public class ATM
{
    private Account account;

    public ATM()
    {
        account = new Account(1000.00m); // Initial balance
    }

    public void Start()
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
                    account.CheckBalance();
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

    private void DepositMoney()
    {
        Console.Write("Enter the amount to deposit: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            account.Deposit(amount);
        }
        else
        {
            Console.WriteLine("Invalid amount. Please try again.");
        }
    }

    private void WithdrawMoney()
    {
        Console.Write("Enter the amount to withdraw: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            account.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Invalid amount. Please try again.");
        }
    }
}
