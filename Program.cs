using System;
using System.Data.SqlClient;

namespace DBInClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings savings = new Savings("12121212", 100.03);
            Console.WriteLine("Amount in account {0}", savings.BalanceCheck());
            Deposite(savings, 10);
            Withdraw(savings, 43.57);


            Checking checking = new Checking("34343434", 700);
            Console.WriteLine("Amount in account {0}", checking.BalanceCheck());
            Deposite(checking, 20);
            Withdraw(checking, 30);

            LineOfCredit lineOfCredit = new LineOfCredit("34343434", 1000);
            Console.WriteLine("Amount in account {0}", lineOfCredit.BalanceCheck());
            Deposite(lineOfCredit, 150);
            Withdraw(lineOfCredit, 200);


            //Console.WriteLine("Balance after deposit : {0}", savings.BalanceCheck());

            //Console.WriteLine(savings.Withdraw(43.57) + " balance : {0} ", savings.BalanceCheck());


        }

        public static void Withdraw(IAccount account, double amount)
        {
            Console.WriteLine(account.Withdraw(amount) + " balance : {0} ",
               Math.Round(account.BalanceCheck(), 2));
        }

        public static void Deposite(IAccount account, double amount)
        {
            Console.WriteLine(account.Deposite(amount) + " balance : {0} ",
                Math.Round(account.BalanceCheck()));
        }
    }
}
