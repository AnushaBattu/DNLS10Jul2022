using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("what is your name? ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}
