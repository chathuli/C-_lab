using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public abstract class BankAccount
        {
            public int AccountNumber { get; private set; }
            public double Balance { get; protected set; }

            public BankAccount(int accountNumber)
            {
                AccountNumber = accountNumber;
                Balance = 0;
            }

            public abstract void Deposit(double amount);
            public abstract void Withdraw(double amount);
        }

        public class SavingsAccount : BankAccount
        {
            public double InterestRate { get; private set; }

            public SavingsAccount(int accountNumber, double interestRate) : base(accountNumber)
            {
                InterestRate = interestRate;
            }

            public override void Deposit(double amount)
            {
                Balance += amount;
            }

            public override void Withdraw(double amount)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                }
                else
                {
                    Console.WriteLine("Insufficient funds for withdrawal.");
                }
            }
        }

        public class CurrentAccount : BankAccount
        {
            public double OverdraftLimit { get; private set; }

            public CurrentAccount(int accountNumber, double overdraftLimit) : base(accountNumber)
            {
                OverdraftLimit = overdraftLimit;
            }

            public override void Deposit(double amount)
            {
                Balance += amount;
            }

            public override void Withdraw(double amount)
            {
                if (amount <= Balance + OverdraftLimit)
                {
                    Balance -= amount;
                }
                else
                {
                    Console.WriteLine("Withdrawal exceeds account balance and overdraft limit.");
                }
            }
        }

        public class program
        {
            public static void Main(string[] args)
            {
                SavingsAccount savingsAccount = new SavingsAccount(12345, 0.02);
                savingsAccount.Deposit(1000);
                savingsAccount.Withdraw(500);
                Console.WriteLine($"Savings Account Balance: {savingsAccount.Balance}");

                CurrentAccount currentAccount = new CurrentAccount(54321, 1000);
                currentAccount.Deposit(2000);
                currentAccount.Withdraw(1500);
                Console.WriteLine($"Current Account Balance: {currentAccount.Balance}");
            }
        } 
    }
}
