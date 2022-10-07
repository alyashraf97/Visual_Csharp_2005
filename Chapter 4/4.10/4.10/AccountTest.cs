using System;

public class AccountTest
{
    public static void Main(string[] args)
    {
        // Create two accounts
        Account account1 = new Account( 50.00M );
        Account account2 = new Account( -7.53M );


        // BETTER BANKING PROGRAM (Pooga)

        while (true)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Current accounts are: \n1. Account1 \n2. Account2");

            Console.WriteLine("Balances are:");
            account1.DisplayBalance("Account1");
            account2.DisplayBalance("Account2");

            Console.WriteLine("Choose Account Number: ");
            int inputNumber = Convert.ToInt16( Console.ReadLine() );

            if (inputNumber==1)
            {
                Console.WriteLine("Enter an Amount to Deposit into Account1: ");

                decimal depositAmount;
                depositAmount = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Depositing {0:C} to Account1 ", depositAmount);
                account1.Credit(depositAmount);


                //account1.DisplayBalance("Account1");
                //account2.DisplayBalance("Account2");
            }

            else if (inputNumber == 2)
            {
                Console.WriteLine("Enter an Amount to Deposit into Account2:");

                decimal depositAmount;
                depositAmount = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Depositing {0:C} to Account1 ", depositAmount);
                account2.Credit(depositAmount);

                //account1.DisplayBalance("Account1");
                //account2.DisplayBalance("Account2");
            }

            else
            {
                Console.WriteLine("[-] Invalid Account Number!");
            }


        }
        //display initial balance
        /*
         * account1.DisplayBalance();
        account2.DisplayBalance();

        Console.WriteLine("Enter an Amount to Deposit into Account1: ");
        
        decimal depositAmount;
        depositAmount = Convert.ToDecimal( Console.ReadLine() );
        Console.WriteLine("Depositing {0:C} to Account1 ", depositAmount);
        account1.Credit(depositAmount);

        account1.DisplayBalance();
        account2.DisplayBalance();

        Console.WriteLine("Enter an Amount to Deposit into Account2: ");

        depositAmount = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Depositing {0:C} to Account1 ", depositAmount);
        account2.Credit(depositAmount);

        account1.DisplayBalance();
        account2.DisplayBalance();
        */
    }
}