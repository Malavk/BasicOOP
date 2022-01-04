using System;

namespace BasicOOP_DZ6
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount firstBA = new BankAccount(100000, AccountType.Current);
            BankAccount secondBA = new BankAccount(1000000, AccountType.Current);
            Console.WriteLine($"{firstBA.ToString()}, {secondBA.ToString()}");
            Console.WriteLine($"{firstBA.Equals(secondBA)}");
            Console.WriteLine($"{firstBA.GetHashCode()} , {secondBA.GetHashCode()}");



            //Console.WriteLine(firstBA == secondBA);
            //Console.WriteLine(firstBA != secondBA);



        }
    }
}
