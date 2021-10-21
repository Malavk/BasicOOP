using System;
using System.IO.Compression;
using System.Linq;

namespace BasicOOP_Homework_2
{
    enum AccountType        // виды банковский счетов
    {
        Current,       //текущмй счет
        Savings,       //сберегательный счет
        Checking       //расчетный счет
    }
    class BankAccount
    {
        private int numberAccount;
        private decimal balance;
        private AccountType type;

        /// <summary>
        /// Конструкторы
        /// </summary>
        public BankAccount()
        {
            RandomNumber();
        }

        public BankAccount(decimal Balance)
        {
            this.balance = Balance;
            RandomNumber();
        }
        public BankAccount(AccountType Type)
        {
            this.type = Type;
            RandomNumber();
        }
        public BankAccount(decimal Balance, AccountType Type)
        {
            this.balance = Balance;
            this.type = Type;
            RandomNumber();
        }

        /// <summary>
        /// Свойства
        /// </summary>
        public int NumberAccount
        {
            get { return this.numberAccount = RandomNumber(); }
            set { this.numberAccount = value; }
        }
        public decimal Balance
        {
            get { return this.balance = Balance; }
            set { this.balance = value; }
        }
        public AccountType Type
        {
            get { return this.type = Type; }
            set { this.type = value; }
        }
        /// <summary>
        /// Метод для генерации рандомного ключа
        /// </summary>
        public int RandomNumber()
        {
            Random someNumbers = new Random();
            this.numberAccount = someNumbers.Next(400000, int.MaxValue);
            return numberAccount;
        }
       
        //Метод перевода денег 
        public void Transfer(BankAccount bank, int moneyCount)
        {
            this.balance -= moneyCount;
            bank.balance += moneyCount;
        }

        //Метод счета симовлов задом на перёд
        public string Reverse(string text)
        {
            char[] textArr = text.ToCharArray();
            Array.Reverse(textArr);
            return new string(textArr);
        }

        public void GetAccountInfo()
        {
            Console.WriteLine($"Ваш номер счета:{numberAccount} , баланс:{balance} рублей" +
                              $" и тип банковского счета: {type}");
        }
    }
}
