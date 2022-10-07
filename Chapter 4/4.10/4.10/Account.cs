// Fig 4.15: Account.cs
//Account class with a constructor to initialize instance variable balance

public class Account
{
    private decimal balance; //instance variable that stores the balance

    // Getter Setter
    public decimal Balance
    {
        get
        {return balance;}
        set
        {
            if (value >=0) 
            {balance = value;}
        }
    }

    // Constructor
    public Account( decimal initialBalance )
    {
        Balance = initialBalance; // set initial account balance
    }

    public void Credit( decimal amount )
    {
        Balance += amount; //adds amount to balance
    }

    public void DisplayBalance( string accountName )
    {
        Console.WriteLine("The Account Balance for {0} is: {1:C}", accountName, Balance);
    }
    
}   