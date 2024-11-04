using System;

namespace OOPs_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank bankAccount = new Bank();

            // Deposit money
            bankAccount.Deposit(5000);

            // Withdraw money
            bankAccount.Withdraw(3000);

            // Display the balance
            Console.WriteLine(bankAccount.Display());

            // Keep the console open until a key is pressed
            Console.ReadKey();
        }
    }

    public class Bank
    {
        double balance;

        public Bank()
        {
            balance = 25000;
        }

        public void Deposit(int amt)
        {
            balance += amt;
            Console.WriteLine("Deposit amount = " + amt);
            Console.WriteLine("Total balance = " + balance);
        }

        public void Withdraw(int amt)
        {
            if (amt <= balance)
            {
                balance -= amt;
                Console.WriteLine("Withdraw amount = " + amt);
                Console.WriteLine("Total balance = " + balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }

        public string Display()
        {
            return $"Balance is {balance}";
        }
    }
}
