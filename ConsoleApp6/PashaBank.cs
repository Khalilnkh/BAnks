using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class PashaBank : Cards
    {
        public PashaBank(string name, string surname, int cardNumbers, decimal balance, int cvv) : base(name, surname, cardNumbers, balance, cvv)
        {

        }
        public override void Deposit(decimal amount)
        {

            if (amount > 0)
            {
                amount = amount * (100 - 0.6m) / 100;
                Balance += amount;

            }
            else
            {
                Console.WriteLine("Mebleg 0 dan az olmamalidir");


            }
        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                amount = (amount * (100 + 1.1m) / 100);
                Balance -= amount;



            }
            else
            {
                Console.WriteLine("Balansda yeterli mebleg yoxdur ve ya daxil etdiyiniz reqem duzgun deyil");

            }
        }
    }
}
