SavingsAccount account = new SavingsAccount();

try
{
    account.Deposit(100000);
    Console.WriteLine($"Current balance: ${account.Balance:N0}");

    account.Withdraw(30000);
    Console.WriteLine($"Balance after withdrawal: ${account.Balance:N0}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.WriteLine("Program continues running.");