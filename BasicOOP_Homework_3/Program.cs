using System;

namespace BasicOOP_Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Перевод денег с одного счета в другой
            BankAccount firstBank = new BankAccount(200000, AccountType.Current);
            BankAccount secondBank = new BankAccount(100000, AccountType.Current);
            firstBank.Transfer(secondBank, 20000); 
            firstBank.GetAccountInfo();
            secondBank.GetAccountInfo();

            //Переворачиваем строку
            BankAccount reverseTesting = new BankAccount(123000, AccountType.Savings);
            String someString = reverseTesting.Reverse("любая строка перевернется");
            Console.WriteLine(someString);
        }
    }
}