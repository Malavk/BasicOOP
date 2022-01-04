using System;

namespace BasicOOP_DZ7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("class ACipher");
            ACoder r = new ACoder() { Str = "БВГ" };
            Console.WriteLine(r.Encode());
            ACoder r2 = new ACoder() { Str = r.Encode() };
            Console.WriteLine(r2.Decode());


            Console.WriteLine("class BCipher");
            BCoder t = new BCoder() { Str = "ABC" };
            Console.WriteLine(t.Encode());
            BCoder c = new BCoder() { Str = t.Encode() }; 
            Console.WriteLine(c.Decode());
        }
    }
}
