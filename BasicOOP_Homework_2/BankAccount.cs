using System;

namespace BasicOOP_Homework_2
{
    class BankAccount
    {
        public static int numberAccount;

        public void RandomNumber()      //Метод для генерации рандомного ключа
        {
            Random someNumbers = new Random();
            numberAccount = someNumbers.Next(400000, int.MaxValue);
            Console.WriteLine($"Случайный номер счета: {numberAccount} ");
        }
    }
}
