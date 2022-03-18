using System;

namespace AbstractAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts =
            {
                new CurrentAccount(123456, 12345678, "Current Account 1", 0),
                new CurrentAccount(123456, 87654321, "Current Account 2", 2000),
                new SavingsAccount(123456, 54637281, "Savings Account 1", 0.75),
                new SavingsAccount(123456, 81726354, "Savings Account 2", 1.25)
            };

            foreach (Account ac in accounts)
            {
                Console.WriteLine("\n" + ac);
            }
        }
    }
}
