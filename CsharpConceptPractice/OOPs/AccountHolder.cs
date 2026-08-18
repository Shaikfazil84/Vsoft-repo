using System;
public class BankAccount
{
   
    public string accountHolder;
    public int accountNumber;
    public double balance;

    public BankAccount(string holder, int number, double initialBalance)
    {
        accountHolder = holder;
        accountNumber = number;
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance = balance + amount;
            Console.WriteLine(amount + " deposited.");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public bool Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid withdrawal amount.");
            return false;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance.");
            return false;
        }

        balance = balance - amount;

        Console.WriteLine(amount + " withdrawn.");

        return true;
    }

    public double GetBalance()
    {
        return balance;
    }

    public string GetAccountType()
    {
        if (balance >= 100000)
        {
            return "Premium Account";
        }
        else if (balance >= 50000)
        {
            return "Gold Account";
        }
        else
        {
            return "Regular Account";
        }
    }

    public void DisplayAccount()
    {
        Console.WriteLine();
        Console.WriteLine("==============================");
        Console.WriteLine("       ACCOUNT DETAILS");
        Console.WriteLine("==============================");

        Console.WriteLine("Account Holder : " + accountHolder);
        Console.WriteLine("Account Number : " + accountNumber);
        Console.WriteLine("Balance        : " + balance);
        Console.WriteLine("Account Type   : " + GetAccountType());

        Console.WriteLine("==============================");
    }
}

public class AccountDetails
{
    public void RunBank()
    {
        // Object 1
        BankAccount account1 =
            new BankAccount("Rahul", 101, 50000);

        // Object 2
        BankAccount account2 =
            new BankAccount("Harish", 102, 75000);

        // Object 3
        BankAccount account3 =
            new BankAccount("Vinayak", 103, 120000);



        account1.DisplayAccount();

        account2.DisplayAccount();

        account3.DisplayAccount();



        Console.WriteLine();
        Console.WriteLine("===== ACCOUNT 1 DEPOSIT =====");

        account1.Deposit(25000);

        Console.WriteLine(
            "New Balance: " + account1.GetBalance());

        Console.WriteLine();
        Console.WriteLine("===== ACCOUNT 2 WITHDRAW =====");

        account2.Withdraw(20000);

        Console.WriteLine(
            "New Balance: " + account2.GetBalance());



        Console.WriteLine();
        Console.WriteLine("===== INVALID WITHDRAW =====");

        account1.Withdraw(100000);

        Console.WriteLine();
        Console.WriteLine("===== UPDATED ACCOUNTS =====");

        account1.DisplayAccount();

        account2.DisplayAccount();

        Console.WriteLine();
        Console.WriteLine("===== COMPARING ACCOUNTS =====");

        double balance1 = account1.GetBalance();
        double balance2 = account2.GetBalance();

        if (balance1 > balance2)
        {
            Console.WriteLine(
                account1.accountHolder +
                " has more money.");
        }
        else if (balance2 > balance1)
        {
            Console.WriteLine(
                account2.accountHolder +
                " has more money.");
        }
        else
        {
            Console.WriteLine(
                "Both accounts have the same balance.");
        }

        Console.WriteLine();
        Console.WriteLine("===== MODIFY OBJECT =====");

        Console.WriteLine(
            "Old account holder: " +
            account3.accountHolder);

        account3.accountHolder = "Vinayak Kumar";

        Console.WriteLine(
            "New account holder: " +
            account3.accountHolder);

        Console.WriteLine();
        Console.WriteLine("===== FINAL ACCOUNT =====");

        account3.DisplayAccount();

        Console.WriteLine();
        Console.WriteLine("Program completed.");
    }
}