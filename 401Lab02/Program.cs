using System;

namespace Lab02
{
    public class Program
    {
        public static decimal Balance = 0;

        public static void Main()
        {
            UserInterface();
        }

        public static void UserInterface()
        {
            string choice;
            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Current Balance: {ViewBalance()}");
                        break;
                    case "2":
                        Console.WriteLine("Enter the amount to withdraw:");
                        decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                        Console.WriteLine($"Remaining Balance: {Withdraw(withdrawAmount)}");
                        break;
                    case "3":
                        Console.WriteLine("Enter the amount to deposit:");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        Console.WriteLine($"Updated Balance: {Deposit(depositAmount)}");
                        break;
                    case "4":
                        Console.WriteLine("Exiting application...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                Console.WriteLine();
            } while (choice != "4");
        }

        public static decimal ViewBalance()
        {
            return Balance;
        }

        public static decimal Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalid withdrawal amount.");
                return Balance;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
                return Balance;
            }

            Balance -= amount;
            return Balance;
        }

        public static decimal Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalid deposit amount.");
                return Balance;
            }

            Balance += amount;
            return Balance;
        }
    }
}
