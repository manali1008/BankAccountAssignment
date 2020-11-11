using System;
using System.Collections.Generic;
using System.Text;

namespace DBInClassPractice
{
    public class Checking : IAccount
    {
        public Checking(string accountCode, double balance)
        {
            Balance = balance;
            if (!string.IsNullOrEmpty(accountCode) && accountCode.Length == 8)
                AccountCode = accountCode;

        }
        public string AccountCode { get; }
        private double Balance { get; set; }

        public double BalanceCheck()
        {
            return Balance;
        }

        public string Deposite(double amount)
        {
            string message = "";

            if (amount > 0)
            {
                Balance = Balance + amount;
                message = "Amount deposited successfully";
            }

            return message;
        }

        public string Withdraw(double amount)
        {
            string message;
            if (Balance > 500)
            {
                double temp = Balance - amount;
                if (temp > 500)
                {
                    Balance = temp;
                    message = "Withdrwal successful";
                }
                else
                    message = "Minimum overdraft of 500";
            }
            else
                message = "Insufficient balance in checking account";

            return message;
        }
    }
}

