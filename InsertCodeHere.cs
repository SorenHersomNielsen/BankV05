using System;

namespace BankV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            BankAccount myAccount = new BankAccount("Søren");
            BankAccount myAccount2 = new BankAccount("Chris");
            BankAccount myAccount3 = new BankAccount("Line");

            myAccount.Deposit(2000);
            Console.WriteLine($"Account holder {myAccount.accountHolderName} and balance is : {myAccount.Balance}");
           
            myAccount.Withdraw(1500);
            Console.WriteLine($"Account holder {myAccount.accountHolderName} and balance is : {myAccount.Balance}");

            myAccount2.Deposit(5000);
            Console.WriteLine($"Account holder {myAccount2.accountHolderName} and balance is : {myAccount2.Balance}");
           
            myAccount2.Withdraw(1500);
            Console.WriteLine($"Account holder {myAccount2.accountHolderName} and balance is : {myAccount2.Balance}");

            myAccount3.Deposit(10000);
            Console.WriteLine($"Account holder {myAccount3.accountHolderName} and balance is : {myAccount3.Balance}");
           
            myAccount3.Withdraw(3000);
            Console.WriteLine($"Account holder {myAccount3.accountHolderName} and balance is : {myAccount3.Balance}");

            // The LAST line of code should be ABOVE this line
        }
    }
}