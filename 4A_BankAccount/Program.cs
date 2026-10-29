using System;

class BankAccount
{
    public string AccountNumber { get; set; }

    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
        set
        {
            if (value < 0)
                throw new ArgumentException(
                    "Balance cannot be negative.");

            balance = value;
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.AccountNumber = "123456";
        account.Balance = 5000;

        Console.WriteLine("Account Number: " +
            account.AccountNumber);
        Console.WriteLine("Balance: " + account.Balance);

        try
        {
            account.Balance = -100;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}