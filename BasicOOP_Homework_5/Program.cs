using System;

namespace BasicOOP_DZ_5
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumbers rationalNumbers1 = new RationalNumbers(1,4);
            RationalNumbers rationalNumbers2 = new RationalNumbers(7,15);

            Console.WriteLine(rationalNumbers1+rationalNumbers2);
            Console.WriteLine(rationalNumbers1 % rationalNumbers2);
        }
    }
}
