using System;

namespace BasicOOP_Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(40817810, 354000, AccountType.Current);
            myAccount.GetAccountInfo();
        }
    }
}
