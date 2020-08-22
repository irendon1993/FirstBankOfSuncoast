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

        // public string Balance()
        // {
        //     var transactionHistory = $"{Name} for {ChangeOfBalance}";
        //     return transactionHistory;
        // }

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

        //   public string = Transaction
        // {
        //  ; 
        // }





        static void Main(string[] args)
        {

            var checkingAccountBalance = 0;
            var savingsAccountBalance = 0;
            // Create a list to to track transfers
            var transactions = new List<Transaction>();
            // var withdraws = new List<Transaction>();


            // {
            // new Transaction
            // {
            //   Name = "Deposit",
            //   ChangeOfBalance = 10

            // },

            // new Transaction
            // {
            //   Name = "Deposit",
            //   ChangeOfBalance = 10,
            // }
            // };


            Console.WriteLine("Welcome to Wutang Financial");

            var hasQuitTheApplication = false;

            while (hasQuitTheApplication == false)
            {
                // Show them a menu of options they can do
                Console.WriteLine("Select an option from the Menu below:");
                Console.WriteLine("VIEW - View the transaction history");
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

                // Make option to DEPOSIT 
                if (choice == "DEPOSIT")
                {
                    Console.WriteLine("Please select which account to deposit into, CHECKING or SAVINGS");
                    var answer = Console.ReadLine();
                    if (answer == "CHECKING")
                    {
                        Console.WriteLine("How much would you like to deposit");
                        var depositAmount = Console.ReadLine();

                        var newTransaction = new Transaction
                        {
                            Name = "Deposit",
                            ChangeOfBalance = int.Parse(depositAmount)
                        };
                        var newCheckingAccountBalance = checkingAccountBalance + newTransaction.ChangeOfBalance;
                        checkingAccountBalance = newCheckingAccountBalance;
                        Console.WriteLine(checkingAccountBalance);
                        transactions.Add(newTransaction);
                    }
                    if (answer == "SAVINGS")
                    {
                        Console.WriteLine("How much would you like to deposit”");
                        var depositAmount = Console.ReadLine();
                        var newTransaction = new Transaction
                        {
                            Name = "Deposit",
                            ChangeOfBalance = int.Parse(depositAmount)
                        };
                        var newSavingsAccountBalance = savingsAccountBalance + newTransaction.ChangeOfBalance;
                        savingsAccountBalance = newSavingsAccountBalance;
                        Console.WriteLine(savingsAccountBalance);
                        transactions.Add(newTransaction);
                    }
                }
                if (choice == "WITHDRAW")
                {
                    Console.WriteLine("Please select which account to withdraw from, CHECKING or SAVINGS");
                    var answer = Console.ReadLine();
                    if (answer == "CHECKING")
                    {
                        Console.WriteLine("How much would you like to withdraw?");
                        var withdrawAmount = Console.ReadLine();
                        var newTransaction = new Transaction
                        {
                            Name = "Withdraw",
                            ChangeOfBalance = int.Parse(withdrawAmount)
                        };
                        //If/else statement needed
                        //If savingsAccountBalance > 0, do formula below,
                        //else “Insufficient funds available to make withdrawal”
                        var newCheckingAccountBalance = checkingAccountBalance - newTransaction.ChangeOfBalance;
                        checkingAccountBalance = newCheckingAccountBalance;
                        Console.WriteLine(checkingAccountBalance);
                        transactions.Add(newTransaction);
                    }
                    if (answer == "SAVINGS")
                    {
                        Console.WriteLine("How much would you like to withdraw?");
                        var withdrawAmount = Console.ReadLine();
                        var newTransaction = new Transaction
                        {
                            Name = "Withdraw",
                            ChangeOfBalance = int.Parse(withdrawAmount)
                        };
                        //If/else statement needed
                        //If savingsAccountBalance > 0, do formula below,
                        //else “Insufficient funds available to make withdrawal”
                        var newSavingsAccountBalance = savingsAccountBalance - newTransaction.ChangeOfBalance;
                        savingsAccountBalance = newSavingsAccountBalance;
                        Console.WriteLine(savingsAccountBalance);
                        transactions.Add(newTransaction);
                    }
                }
                if (choice == "Balance")
                {
                    Console.WriteLine("Do you want to check your Checking Account?");
                    // var answer = Console.ReadLine();
                    // if (answer == "YES")
                    // {
                    //     foreach (var deposit in deposits)
                    //     {
                    //         Console.WriteLine(deposit.TransactionHistory());
                    //         var totalAccount = deposits.Aggregate(0, currentTotal);
                    //     }
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


