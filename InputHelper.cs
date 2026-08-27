public static class InputHelper
{
    public static decimal ReadAmount(string message)
    {
        while (true)
        {
            Console.Write(message);

            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Amount cannot be empty.");
                continue;
            }

            if (input.Contains(",") || input.Contains("."))
            {
                Console.WriteLine("Please enter the amount without commas or periods. Example: 5500.");
                continue;
            }

            if (decimal.TryParse(input, out decimal amount))
            {
                return amount;
            }

            Console.WriteLine("Please enter a valid numeric value.");
        }
    }
}