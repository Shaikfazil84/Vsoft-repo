using System;
using System.Collections.Generic;

class BankAccount
{
    // Private fields
    private string accountNumber;
    private double balance;
    private string ownerName;
    private List<string> transactions = new List<string>();

    // Read-only properties
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public double Balance
    {
        get { return balance; }
    }

    // Read/Write property
    public string OwnerName
    {
        get { return ownerName; }
        set { ownerName = value; }
    }

    // Constructor
    public BankAccount(string ownerName, double initialBalance = 0)
    {
        this.ownerName = ownerName;
        balance = initialBalance;

        accountNumber = Guid.NewGuid().ToString().Substring(0, 8);

        transactions.Add("Account Created. Balance: " + balance);
    }

    // Deposit
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount.");
            return;
        }

        balance += amount;
        transactions.Add("Deposited: " + amount);
    }

    // Withdraw
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance.");
            return;
        }

        balance -= amount;
        transactions.Add("Withdrawn: " + amount);
    }

    // Transfer
    public void Transfer(double amount, BankAccount targetAccount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance.");
            return;
        }

        balance -= amount;
        targetAccount.balance += amount;

        transactions.Add("Transferred " + amount + " to " + targetAccount.OwnerName);
        targetAccount.transactions.Add("Received " + amount + " from " + OwnerName);
    }

    // Transaction History
    public List<string> GetTransactionHistory()
    {
        return new List<string>(transactions);
    }
}

class BankAccountTest
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount("Fazil", 5000);
        BankAccount acc2 = new BankAccount("Rahul", 2000);

        acc1.Deposit(1000);
        acc1.Withdraw(1500);
        acc1.Transfer(2000, acc2);

        Console.WriteLine("Account 1");
        Console.WriteLine("Owner: " + acc1.OwnerName);
        Console.WriteLine("Account No: " + acc1.AccountNumber);
        Console.WriteLine("Balance: " + acc1.Balance);

        Console.WriteLine("\nTransaction History:");
        foreach (string t in acc1.GetTransactionHistory())
        {
            Console.WriteLine(t);
        }

        Console.WriteLine("\n-------------------------");

        Console.WriteLine("Account 2");
        Console.WriteLine("Owner: " + acc2.OwnerName);
        Console.WriteLine("Account No: " + acc2.AccountNumber);
        Console.WriteLine("Balance: " + acc2.Balance);

        Console.WriteLine("\nTransaction History:");
        foreach (string t in acc2.GetTransactionHistory())
        {
            Console.WriteLine(t);
        }
    }
}