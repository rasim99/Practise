using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            User us = new User();
            Console.WriteLine(us.PasswordChechker("Rtt78ttgjj9"));
            Console.WriteLine(us.ShowInfo());
        }
    }
}
