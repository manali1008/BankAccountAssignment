using System;
using System.Collections.Generic;
using System.Text;

namespace DBInClassPractice
{
    interface IAccount
    {
        //double Balance { get; set; }
        string AccountCode { get; }
        string Withdraw(double amount);
        string Deposite(double amount);
        double BalanceCheck();
    }
}
