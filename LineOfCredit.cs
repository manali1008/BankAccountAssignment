using System;
using System.Collections.Generic;
using System.Text;

namespace DBInClassPractice
{
    public class LineOfCredit : IAccount
    {
        public LineOfCredit(string accountCode, double balance)
        {
            if (balance > 0)
            {
                Balance = balance;
                if (!string.IsNullOrEmpty(accountCode) && accountCode.Length == 8)
                    AccountCode = accountCode;
            }
            else
                Console.WriteLine("Available credit can't be zero");

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
            if (Balance > 0)
            {
                double temp = Balance - amount;
                if (temp > 0)
                {
                    Balance = temp;
                    message = "Withdrwal successful";
                }
                else
                    message = "Negative balance not allowed";
            }
            else
                message = "Insufficient balance in savings account";

            return message;
        }
    }
}

