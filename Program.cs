SavingsAccount account = new SavingsAccount();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("=== SAVINGS ACCOUNT ===");
    Console.WriteLine("1. Deposit money");
    Console.WriteLine("2. Withdraw money");
    Console.WriteLine("3. Check balance");
    Console.WriteLine("4. Exit");

    Console.Write("Enter an option: ");
    string? option = Console.ReadLine();

   if (option == "1")
{
    decimal amount = InputHelper.ReadAmount("Enter deposit amount: ");

    try
    {
        account.Deposit(amount);
        Console.WriteLine($"Deposit successful. Current balance: ${account.Balance:N0}");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
    else if (option == "2")
{
    decimal amount = InputHelper.ReadAmount("Enter withdrawal amount: ");

    try
    {
        account.Withdraw(amount);
        Console.WriteLine($"Withdrawal successful. Current balance: ${account.Balance:N0}");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
    else if (option == "3")
    {
        Console.WriteLine($"Current balance: ${account.Balance:N0}");
    }
    else if (option == "4")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
    else
    {
        Console.WriteLine("Invalid option.");
    }
}