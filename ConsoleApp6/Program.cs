using System;

namespace ConsoleApp6
{
    public class Program
    {
        static void Main(string[] args)
        {
            PashaBank acc = new PashaBank("Xelil", "Xeyrulla", 123456789, 300, 654);
            acc.Withdraw(100);
            Console.WriteLine(acc.Balance);
        }
    }
    

    
    

   
}
