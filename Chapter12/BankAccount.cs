using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    class BankAccount
    {
        #region variables
        private double checkingAmount;
        private double savingsAmount;
        private int accountNumber;
        private const int routingNum = 8675309;
        private const int bankNum = 6345789;
        private string eMsg;
        private string accountOwner;
        #endregion
        #region properties
        public double CheckingAmount { get => checkingAmount; }
        public double SavingsAmount { get => savingsAmount; }
        public int AccountNumber { get => accountNumber; }
        public static int RoutingNum => routingNum;
        public static int BankNum => bankNum;
        public string EMsg { get => eMsg; set => eMsg = value; }
        public string AccountOwner { get => accountOwner; set => accountOwner = value; }
        #endregion
        #region constructors
        public BankAccount(double chkStartAmt, double savingsStartAmt, int accountNum, string accountOwner)
        {
            try
            {
                if(chkStartAmt < 0 || SavingsAmount < 0)
                {
                    throw new NegativeException("init");
                }
                this.checkingAmount = chkStartAmt;
                this.savingsAmount = savingsStartAmt;
            }
            catch(NegativeException e)
            {
                this.eMsg = e.Message;
                this.checkingAmount = 0;
                this.savingsAmount = 0;
            }
            finally
            {
                this.accountNumber = accountNum;
                this.accountOwner = accountOwner;
            }
        }
        #endregion
        #region methods
        public KeyValuePair<string, bool> withdrawChecking(double withdrawAmt)
        {
            double tempVal = this.CheckingAmount;
            try
            {
                if (withdrawAmt < 0)
                {
                    throw new NegativeException("negi");
                }
                if ((tempVal - withdrawAmt) < 0)
                {
                    throw new NegativeException("with");
                }
                else
                {
                    this.checkingAmount -= withdrawAmt;
                    return new KeyValuePair<string, bool>("Transaction Successful", true);
                }
            }
            catch(NegativeException e)
            {
                return new KeyValuePair<string, bool>(e.Message, false);
            }
        }
        public KeyValuePair<string, bool> withdrawSavings(double withdrawAmt)
        {
            double tempVal = this.SavingsAmount;
            try
            {
                if(withdrawAmt < 0)
                {
                    throw new NegativeException("negi");
                }
                if ((tempVal - withdrawAmt) < 0)
                {
                    throw new NegativeException("with");
                }
                else
                {
                    this.savingsAmount -= withdrawAmt;
                    return new KeyValuePair<string, bool>("Transaction Successful", true);
                }
            }
            catch (NegativeException e)
            {
                return new KeyValuePair<string, bool>(e.Message, false);
            }
        }
        public KeyValuePair<string, bool> depositChecking(double depositAmt)
        {
            try
            {
                if (depositAmt < 0)
                {
                    throw new NegativeException("depo");
                }
                else
                {
                    this.checkingAmount += depositAmt;
                    return new KeyValuePair<string, bool>("Transaction Successful", true);
                }
            }
            catch (NegativeException e)
            {
                return new KeyValuePair<string, bool>(e.Message, false);
            }
        }
        public KeyValuePair<string, bool> depositSavings(double depositAmt)
        {
            try
            {
                if (depositAmt < 0)
                {
                    throw new NegativeException("depo");
                }
                else
                {
                    this.savingsAmount += depositAmt;
                    return new KeyValuePair<string, bool>("Transaction Successful", true);
                }
            }
            catch (NegativeException e)
            {
                return new KeyValuePair<string, bool>(e.Message, false);
            }
        }
        #endregion
    }
    #region internalClasses
    internal class NegativeException : ApplicationException
    {
        private string action;
        public NegativeException(string action)
        {
            this.action = action;
        }
        public override string Message
        {
            get
            {
                switch (this.action.ToUpper())
                {
                    case "NEGI": return "You can not withdraw a negative value!";
                    case "INIT": return "You can not start an account with a negative balance!";
                    case "WITH": return "Failure to withdraw, account will become negative!";
                    case "DEPO": return "Failure to deposit, you can not deposit a negative value!";
                    default: return "An error occured when accessing the account!";
                }
            }
        }
    }
    #endregion
}
