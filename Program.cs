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
        public string TransactionType { get; set; }
        public string AccountType { get; set; }
        public int ChangeOfBalance { get; set; }

        public string TransactionHistory()
        {
            var transactionHistory = $"{TransactionType} for {ChangeOfBalance}";
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

        //   public string = Transaction
        // {
        //  ; 
        // }





        static void Main(string[] args)
        {

            var checkingAccountBalance = 0;
            var savingsAccountBalance = 0;
            // Create a list to to track transfers
            var checkingTransactions = new List<Transaction>();
            var savingsTransactions = new List<Transaction>();


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
                Console.WriteLine("BALANCE- View the balance of your accounts");
                Console.WriteLine("QUIT - Quit the program!");
                Console.WriteLine();
                Console.Write("Choice: ");
                var choice = Console.ReadLine();

                if (choice == "VIEW")
                {
                    Console.WriteLine("Please select which account you would like to view the transcation history of, CHECKING or SAVINGS");
                    var answer = Console.ReadLine();
                    if (answer == "CHECKING")
                    {
                        foreach (var transaction in checkingTransactions)
                        {
                            Console.WriteLine(transaction.TransactionHistory());

                        }
                    }
                    if (answer == "SAVINGS")
                    {
                        foreach (var transaction in savingsTransactions)
                        {
                            Console.WriteLine(transaction.TransactionHistory());

                        }
                    }
                }

                // Make option to DEPOSIT 
                if (choice == "DEPOSIT")
                {
                    Console.WriteLine("Please select which account to deposit into, CHECKING or SAVINGS");
                    var answer = Console.ReadLine();
                    if (answer == "CHECKING")
                    {
                        Console.WriteLine("How much would you like to deposit");
                        var depositAmount = int.Parse(Console.ReadLine());

                        var newTransaction = new Transaction
                        {
                            TransactionType = "Deposit",
                            ChangeOfBalance = depositAmount,
                            AccountType = "Checking"
                        };
                        var newCheckingAccountBalance = checkingAccountBalance + newTransaction.ChangeOfBalance;
                        checkingAccountBalance = newCheckingAccountBalance;
                        Console.WriteLine(checkingAccountBalance);
                        checkingTransactions.Add(newTransaction);
                    }
                    if (answer == "SAVINGS")
                    {
                        Console.WriteLine("How much would you like to deposit”");
                        var depositAmount = int.Parse(Console.ReadLine());
                        var newTransaction = new Transaction
                        {
                            TransactionType = "Deposit",
                            ChangeOfBalance = depositAmount,
                            AccountType = "Savings"
                        };
                        var newSavingsAccountBalance = savingsAccountBalance + newTransaction.ChangeOfBalance;
                        savingsAccountBalance = newSavingsAccountBalance;
                        Console.WriteLine(savingsAccountBalance);
                        savingsTransactions.Add(newTransaction);
                    }
                }
                if (choice == "WITHDRAW")
                {
                    Console.WriteLine("Please select which account to withdraw from, CHECKING or SAVINGS");
                    var answer = Console.ReadLine();
                    if (answer == "CHECKING")
                    {
                        Console.WriteLine("How much would you like to withdraw?");
                        var withdrawAmount = int.Parse(Console.ReadLine());
                        var newTransaction = new Transaction
                        {
                            TransactionType = "Withdraw",
                            ChangeOfBalance = withdrawAmount,
                            AccountType = "Checking"
                        };
                        //If/else statement needed
                        //If savingsAccountBalance > 0, do formula below,
                        //else “Insufficient funds available to make withdrawal”
                        if (withdrawAmount < savingsAccountBalance)
                        {
                            var newCheckingAccountBalance = checkingAccountBalance - newTransaction.ChangeOfBalance;
                            checkingAccountBalance = newCheckingAccountBalance;
                            Console.WriteLine(checkingAccountBalance);
                            checkingTransactions.Add(newTransaction);
                        }
                        else
                        {
                            Console.WriteLine("You broke bitch");
                        }
                    }
                    if (answer == "SAVINGS")
                    {
                        Console.WriteLine("How much would you like to withdraw?");
                        var withdrawAmount = int.Parse(Console.ReadLine());
                        var newTransaction = new Transaction
                        {
                            TransactionType = "Withdraw",
                            ChangeOfBalance = withdrawAmount,
                            AccountType = "Savings"
                        };
                        //If/else statement needed
                        //If savingsAccountBalance > 0, do formula below,
                        //else “Insufficient funds available to make withdrawal”
                        if (withdrawAmount < savingsAccountBalance)
                        {
                            var newSavingsAccountBalance = savingsAccountBalance - newTransaction.ChangeOfBalance;
                            savingsAccountBalance = newSavingsAccountBalance;
                            Console.WriteLine(savingsAccountBalance);
                            savingsTransactions.Add(newTransaction);
                        }
                    }
                }

                if (choice == "Balance")
                {
                    Console.WriteLine($"The balance of your checking account is {checkingAccountBalance} and your savings account balance is {savingsAccountBalance}");
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


