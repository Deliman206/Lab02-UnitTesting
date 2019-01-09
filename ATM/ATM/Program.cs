using System;


namespace ATM
{
    public class Program
    {
        static void Main(string[] args)
        {
            int accountBalance = 0;
            Console.WriteLine("Welcome to ATM");
            Menu(accountBalance);
        }

        static int Menu(int accountBalance)
        {
            Console.WriteLine("What kind of transaction would you like to make?/n");
            Console.WriteLine("1. View Balance\n2. Withdraw\n3. Deposit\n4. Exit");
            string transactionType = Console.ReadLine();

            switch (transactionType)
            {
                case "View Balance":
                    return ViewBalance(accountBalance);
                case "1":
                    return ViewBalance(accountBalance);

                case "Withdraw":
                    return Withdraw(accountBalance);
                case "2":
                    return Withdraw(accountBalance);

                case "Deposit":
                    return Deposit(accountBalance);
                case "3":
                    return Deposit(accountBalance);

                case "Exit":
                    return Exit(accountBalance);
                case "4":
                    return Exit(accountBalance);

                default:
                    return Menu(accountBalance);
            }
        }

        public static int _ViewBalance(int balance)
        {
            Console.WriteLine($"Your balance is {balance}");
            return balance;
        }
        static int ViewBalance(int accountBalance)
        {
            Menu(_ViewBalance(accountBalance));
            return accountBalance;
        }

        public static int _Withdraw(int accountBalance, int withdrawAmount)
        {
            if (accountBalance >= withdrawAmount)
            {
                accountBalance -= withdrawAmount;
                return accountBalance;
            }
            Console.WriteLine("insufficient funds");
            return accountBalance;
        }

        static int Withdraw(int accountBalance)
        {
            Console.WriteLine("How much would you like to withdraw?");
            string amount = Console.ReadLine();
            Int32.TryParse(amount, out int withdrawAmount);
            return Menu(_Withdraw(accountBalance, withdrawAmount));
        }

        public static int _Deposit(int accountBalance, int depositAmount)
        {
            accountBalance += depositAmount;
            return accountBalance;
        }

        static int Deposit(int accountBalance)
        {
            Console.WriteLine("How much would you like to deposit?");
            string amount = Console.ReadLine();
            Int32.TryParse(amount, out int depositAmount);
            return Menu(_Deposit(accountBalance, depositAmount));
        }

        static int Exit(int accountBalance)
        {
            Environment.Exit(1);
            return accountBalance;
        }
    }
}
