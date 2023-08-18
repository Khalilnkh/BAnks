using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class LeoBank : Cards
    {
        public LeoBank(string name, string surname, int cardNumbers, decimal balance, int cvv) : base(name, surname, cardNumbers, balance, cvv)
        {

        }
        public override void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;

            }
            else
            {
                Console.WriteLine("Mebleg 0 dan az olmamalidir");


            }
        }
        public override void Withdraw(decimal amount)
        {
            if (amount >= Balance && amount<0)
            {
                Console.WriteLine("Balansda yeterli mebleg yoxdur ve ya daxil etdiyiniz reqem duzgun deyil");


            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Pul mexaric olundu");

            }
        }

    }
}
