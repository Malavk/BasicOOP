using System;

namespace BasicOOP_DZ6
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto v = new Moto();
            Console.WriteLine("Speed: {0}mph", v.Speed);    
            v.Accelerate(25);
            Console.WriteLine("Speed: {0}mph", v.Speed);    
            v.Decelerate(15);
            Console.WriteLine("Speed: {0}mph", v.Speed);
        }
    }
}
