public static class InputHelper
{
    public static decimal ReadAmount(string message)
    {
        while (true)
        {
            Console.Write(message);

            string? input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal amount))
            {
                return amount;
            }

            Console.WriteLine("Please enter a valid numeric value.");
        }
    }
}