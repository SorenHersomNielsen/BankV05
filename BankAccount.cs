namespace BankV05
{
    /// <summary>
    /// This class represents a very simple bank account.
    /// Only the amount of money on the account is represented.
    /// </summary>
    public class BankAccount
    {
        private double _balance;
        private string _accountHolderName;

        public BankAccount(string accountHolderName)
        {
            _balance = 0.0;
            _accountHolderName = accountHolderName;
        }

        public double Balance
        {
            get { return _balance;}
            
        }
      
          public string accountHolderName
        {
          get {return _accountHolderName;}
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }
/// <summary>
/// Withdraws some money 
/// </summary>
/// <param name="amount"></param>
        public void Withdraw(double amount)
        {
            _balance = _balance - amount;
        }
    }
}