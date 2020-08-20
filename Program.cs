using System;

namespace FirstBankOfSuncoast
{
    // // Create a Customer class
    // class Customer
    // {
    //     CheckingAccount()
    //     {
    //         CheckingAccountBalance =
    //     }

    //     SavingsAccount()
    //     {
    //         SavingsAccountBalance =
    //   }
    // }

    // class Transsaction 
    //     (
    //       Transactions = new List<Transsaction>
    //       {

    //       }
    //     )
    class Program
    {
        // PROBLEM
        // 
        // Create a console app that allows a user to manage savings and checking banking transactions.
        // A user will make a series of transactions.
        // You will compute balances by examining all the transactions in the history
        // The transactions will be saved in a file, using a CSV format to record the data.

        // Example
        // 
        // For instance, if a user deposits 10 to their savings, then withdraws 8 from their savings,
        // then deposits 25 to their checking, they have three transactions to consider. 
        // Compute the checking and saving balance, using the transaction list, when needed. 
        // In this case, their savings balance is 2 and their checking balance is 25.


        // DATA
        // 
        // USER   
        // CheckingAccount
        // AccountBalance
        // SavingsAccount
        // AccountBalance
        // TRANSACTION
        // MONEY
        // 
        // A
        // 
        // Make a new object with properties:
        // CheckingAccount
        // SavingsAccount 
        // Create a MENU
        // Make option to VIEW balance
        // Make option to WITHDRAW 
        // Make option to DEPOSIT
        // 
        // 

        // 
        // 
        //         

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Wutang Financial");

            // var transactions = new List<Customer>
            // {

            // }

            var hasQuitTheApplication = false;

            while (hasQuitTheApplication == false)
            {
                // Show them a menu of options they can do
                Console.WriteLine("Select an option from the Menu below:");
                Console.WriteLine("VIEW - View the dinosaurs we have in the order in which they got here!");
                Console.WriteLine("WITHDRAW - Take out money from your accounts");
                Console.WriteLine("DEPOSIT - Place money in your accounts");
                Console.WriteLine("QUIT - Quit the program!");
                Console.WriteLine();
                Console.Write("Choice: ");
                var choice = Console.ReadLine();

                if (choice == "VIEW")
                {
                    Console.WriteLine("hello");
                }
                if (choice == "WITHDRAW")
                {
                    Console.WriteLine("Do you want to withdraw from your checkings? YES or NO");
                    //   var answer = Console.ReadLine();
                    //   if(answer == "YES")
                    //   {
                    //     withdrawAmount = linq
                    //   }
                    // }
                    if (choice == "DEPOSIT")
                    {

                    }
                    if (choice == "QUIT")
                    {

                    }
                    else
                    {
                        Console.WriteLine("Goodbye");
                    }
                }
            }
        }
    }
}