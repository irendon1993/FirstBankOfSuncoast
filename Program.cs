using System;
using System.Collections.Generic;
using System.Linq;

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
    // 
    // 
    // 
    // Compute balances by examining all the transactions in the history
    class Transaction
    {
        public string Name { get; set; }
        public int ChangeOfBalance { get; set; }

        public string TransactionHistory()
        {
            var transactionHistory = $"{Name} for {ChangeOfBalance}";
            return transactionHistory;
        }

    }
    class Program
    {
        // PROBLEM
        // 
        // Create a console app that allows a user to manage savings and checking banking transactions.
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
        // Make option to DEPOSIT
        // 
        // 

        // 
        // 
        //         

        static void Main(string[] args)
        {

            // Create a list to to track transfers
            var deposits = new List<Transaction>()
            {
              new Transaction
              {
                Name = "Deposit",
                ChangeOfBalance = 10

              },

              new Transaction
              {
                Name = "Deposit",
                ChangeOfBalance = 10,
              }

            };


            Console.WriteLine("Welcome to Wutang Financial");

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

                // if (choice == "VIEW")
                // {
                //     foreach (var transaction in transactions)
                //     {
                //         Console.WriteLine(transaction.Balance());
                //     }
                // }
                // Make option to WITHDRAW 
                if (choice == "DEPOSIT")
                {
                    Console.WriteLine("Do you want to deposit from your checkings? YES or NO");
                    var answer = Console.ReadLine();
                    if (answer == "YES")
                    {
                        Console.WriteLine("How much would you like to deposit");
                        var withdrawAmount = Console.ReadLine();

                        var newTransaction = new Transaction
                        {
                            Name = "Withdraw",
                            ChangeOfBalance = int.Parse(withdrawAmount)
                        };
                        deposits.Add(newTransaction);
                    }
                }
                if (choice == "Balance")
                {
                    Console.WriteLine("Do you want to check your Checking Account?");
                    var answer = Console.ReadLine();
                    if (answer == "YES")
                    {
                        foreach (var deposit in deposits)
                        {
                            Console.WriteLine(deposit.TransactionHistory());
                        }
                    }
                }




            }
        }


        // if (choice == "BALAnce")
        // {

        // }
        // else
        // {
        //     Console.WriteLine("Goodbye");
        // }
    }
}

