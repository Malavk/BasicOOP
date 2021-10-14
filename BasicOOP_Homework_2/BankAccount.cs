using System;

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

        public BankAccount(int NumberAccount, decimal Balance, AccountType Type)
        {
            this.numberAccount = NumberAccount;
            this.balance = Balance;
            this.type = Type;
        }

        public int NumberAccount
        {
            get { return this.numberAccount = NumberAccount; }
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

        public void GetAccountInfo()
        {
            Console.WriteLine($"Ваш номер счета:{numberAccount} , баланс:{balance}рублей" +
                              $" и тип банковского счета: {type}");
        }
    }
}
