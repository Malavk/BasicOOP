using System;

namespace BasicOOP_Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(123000, AccountType.Savings);
            myAccount.GetAccountInfo();
        }
    }
}